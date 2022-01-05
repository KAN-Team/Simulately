using InventoryModels;
using System;
using System.Collections.Generic;

namespace InventorySimulation.SimulationCore
{
    class InventorySimulator
    {
        private SimulationSystem System;
        private readonly Random random;
        private List<int> DaysUntilOrderArrives = new List<int>();
        private SimulationCase SimulationCasesTemp;

        private int DayCounter = 0;
        private int OrderQuantity = 0;
        private int ShortQuantity = 0;
        private int EndingQuantity = 0;
        private int DayWithinCycle = 1;

        public InventorySimulator()
        {
            random = new Random();
            System = Program.mSystem;

            DaysUntilOrderArrives.Add(System.StartLeadDays - 1);

            while (DayCounter < System.NumberOfDays)
            {
                // Initial Static Values Assignment  
                SimulationCasesTemp = new SimulationCase();
                SimulationCasesTemp.Day = DayCounter + 1;
                SimulationCasesTemp.Cycle = GetCycle(SimulationCasesTemp.Day);
                SimulationCasesTemp.RandomDemand = GenerateRandom();
                SimulationCasesTemp.Demand = GetDemand(SimulationCasesTemp.RandomDemand);
                SimulationCasesTemp.LeadDays = 0;
                SimulationCasesTemp.ShortageQuantity = 0;

                // Day Within Cycle 
                workOnDayWithinCycle();

                // Beginning/Ending Inventory 
                workOnBeginningAndEndingInventory();

                // Cycle Order 
                workOnCycleOrder();

                // Lead Days 
                workOnLeadDays();

                // Counters Control
                System.SimulationCases.Add(SimulationCasesTemp);
                DayWithinCycle++;
                DayCounter++;
            }

            // Set All Negative Values To Zeros
            setAllNegativeValuesToZeroes();

            doPerformanceMeasure();

        }

        #region HELPERS
        public int GetCycle(int Day)
        {
            if (Day % System.ReviewPeriod == 0)
            {
                return (Day / System.ReviewPeriod);
            }
            return (Day / System.ReviewPeriod) + 1;
        }

        private int GenerateRandom()
        {
            return random.Next(1, 101);
        }

        private int GetDemand(int Random)
        {
            for (int i = 0; i < System.DemandDistribution.Count; i++)
            {
                if (Random >= System.DemandDistribution[i].MinRange &&
                    Random <= System.DemandDistribution[i].MaxRange)
                {
                    return System.DemandDistribution[i].Value;
                }
            }
            return -1;
        }

        private void workOnDayWithinCycle()
        {
            if (DayWithinCycle != System.ReviewPeriod)
            {
                DayWithinCycle = DayWithinCycle % System.ReviewPeriod;
            }
            SimulationCasesTemp.DayWithinCycle = DayWithinCycle;
        }

        private void workOnBeginningAndEndingInventory()
        {
            if (DayCounter == 0)
            {
                SimulationCasesTemp.BeginningInventory = System.StartInventoryQuantity;
                SimulationCasesTemp.EndingInventory = SimulationCasesTemp.BeginningInventory - SimulationCasesTemp.Demand;
            }
            else
            {
                if (DaysUntilOrderArrives[DayCounter] == -1 && DayCounter / System.ReviewPeriod == 0)
                {
                    SimulationCasesTemp.BeginningInventory =
                        System.SimulationCases[DayCounter - 1].EndingInventory
                        + System.StartOrderQuantity;
                }
                else if (DaysUntilOrderArrives[DayCounter] == -1 && DayCounter / System.ReviewPeriod != 0 && DayWithinCycle != System.ReviewPeriod)
                {
                    SimulationCasesTemp.BeginningInventory = System.SimulationCases[DayCounter - 1].EndingInventory + OrderQuantity;
                }
                else
                {
                    SimulationCasesTemp.BeginningInventory = System.SimulationCases[DayCounter - 1].EndingInventory;
                }


                SimulationCasesTemp.EndingInventory = EndingQuantity = SimulationCasesTemp.BeginningInventory -
                    (SimulationCasesTemp.Demand + System.SimulationCases[DayCounter - 1].ShortageQuantity);
            }


            if (SimulationCasesTemp.EndingInventory <= 0)
            {
                SimulationCasesTemp.ShortageQuantity = ShortQuantity = Math.Abs(SimulationCasesTemp.EndingInventory);
                SimulationCasesTemp.EndingInventory = EndingQuantity = 0;
            }
            else
            {
                ShortQuantity = 0;
            }
        }

        private void workOnCycleOrder()
        {
            if (SimulationCasesTemp.DayWithinCycle == 5)
            {
                SimulationCasesTemp.OrderQuantity = OrderQuantity = GetOrderQuantity(
                   EndingQuantity,
                   ShortQuantity);

                SimulationCasesTemp.RandomLeadDays = GenerateRandom();
                SimulationCasesTemp.LeadDays = GetLeadDays(SimulationCasesTemp.RandomLeadDays);
                DaysUntilOrderArrives[DayCounter] = SimulationCasesTemp.LeadDays;
            }
            else
            {
                SimulationCasesTemp.OrderQuantity = 0;
                SimulationCasesTemp.RandomLeadDays = 0;
            }
        }

        private int GetOrderQuantity(int EndingE, int ShortQuantity)
        {
            return OrderQuantity = System.OrderUpTo - EndingE + ShortQuantity;
        }

        private int GetLeadDays(int Random)
        {
            for (int i = 0; i < System.LeadDaysDistribution.Count; i++)
            {
                if (Random >= System.LeadDaysDistribution[i].MinRange &&
                    Random <= System.LeadDaysDistribution[i].MaxRange)
                {
                    return System.LeadDaysDistribution[i].Value;
                }
            }
            return -1;
        }

        private void workOnLeadDays()
        {
            if (DaysUntilOrderArrives[DayCounter] >= -1)
            {
                DaysUntilOrderArrives.Add(DaysUntilOrderArrives[DayCounter] - 1);
            }
            else
            {
                DaysUntilOrderArrives.Add(0);
            }
        }

        private void setAllNegativeValuesToZeroes()
        {
            for (int i = 0; i < DaysUntilOrderArrives.Count; i++)
            {
                if (DaysUntilOrderArrives[i] < 0)
                {
                    DaysUntilOrderArrives[i] = 0;
                }
            }
        }
        #endregion

        #region PERFORMANCE_MEASURES
        private void doPerformanceMeasure()
        {
            // Performance Measures 
            decimal ShortSum = 0, EndinSum = 0;
            for (int i = 0; i < System.SimulationCases.Count; i++)
            {
                ShortSum += System.SimulationCases[i].ShortageQuantity;
                EndinSum += System.SimulationCases[i].EndingInventory;
            }
            PerformanceMeasures PM = new PerformanceMeasures();
            PM.ShortageQuantityAverage = ShortSum / System.SimulationCases.Count;
            PM.EndingInventoryAverage = EndinSum / System.SimulationCases.Count;
            System.PerformanceMeasures = PM;
        }
        #endregion
    }
}