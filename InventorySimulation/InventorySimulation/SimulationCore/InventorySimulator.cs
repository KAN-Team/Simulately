using InventoryModels;
using System;
using System.Collections.Generic;

namespace InventorySimulation.SimulationCore
{
    class InventorySimulator
    {
        private SimulationSystem System;
        private readonly Random random;

        public InventorySimulator()
        {
            random = new Random();
            System = Program.mSystem;

            calcDayTypeDist();
            calcDemandDist();
            simulateTable();
            calcPerformanceMeasures();
        }

        #region DAYTPYE_AND_DEMAND_DISTRIBUTIONS
        public void calcDayTypeDist()
        {
            
        }

        public void calcDemandDist()
        {
            
        }
        #endregion

        #region SIMULATION_TABLE
        private void simulateTable()
        {
            for (int i = 0; i < System.NumberOfDays; ++i)
            {
                System.SimulationCases.Add(new SimulationCase());
                setDayNo(i);
                genRandomNewsDayType(i);
                setNewsDayType(i);
                genRandomDemand(i);
                setDemand(i);
                setDailyCost(i);
                setSalesProfit(i);
                setLostProfit(i);
                setScrapProfit(i);
                setDailyNetProfit(i);
            }
        }

        private void setDayNo(int i)
        {
            // System.SimulationCases[i].DayNo = i + 1;
        }

        private void genRandomNewsDayType(int i)
        {
        }

        private void setNewsDayType(int i)
        {
            //for (int j = 0; j < System.DayTypeDistributions.Count; ++j)
            //{
            //    int minRange = System.DayTypeDistributions[j].MinRange;
            //    int maxRange = System.DayTypeDistributions[j].MaxRange;
            //    int RandomNewsdayType = System.SimulationTable[i].RandomNewsDayType;
            //    if (RandomNewsdayType >= minRange && RandomNewsdayType <= maxRange)
            //    {
            //        Enums.DayType dayType = System.DayTypeDistributions[j].DayType;
            //        System.SimulationTable[i].NewsDayType = dayType;
            //        break;
            //    }
            //}
        }

        private void genRandomDemand(int i)
        {
            //System.SimulationCases[i].RandomDemand = random.Next(1, 100);
        }

        private void setDemand(int i)
        {
            
        }

        private void setDailyCost(int i)
        {
          
        }

        private void setSalesProfit(int i)
        { 
            
        }

        private void setLostProfit(int i)
        {
            
        }

        private void setScrapProfit(int i)
        {
            
        }

        private void setDailyNetProfit(int i)
        {
            
        }
        #endregion

        #region PERFORMANCE_MEASURES
        private void calcPerformanceMeasures()
        {
            calcTotalSalesProfit();
            calcTotalCost();
        }

        private void calcTotalSalesProfit()
        {
        }
        private void calcTotalCost()
        {
        }
        #endregion
    }
}