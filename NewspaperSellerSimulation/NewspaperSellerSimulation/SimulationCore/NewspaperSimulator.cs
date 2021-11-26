using NewspaperSellerModels;
using System;
using System.Collections.Generic;

namespace NewspaperSellerSimulation.SimulationCore
{
    class NewspaperSimulator
    {
        private SimulationSystem System;
        private readonly Random random;

        public NewspaperSimulator()
        {
            random = new Random();
            System = Program.system;

            calcDayTypeDist();
            calcDemandDist();
            simulateTable();
            calcPerformanceMeasures();
        }

        #region DAYTPYE_AND_DEMAND_DISTRIBUTIONS
        public void calcDayTypeDist()
        {
            decimal cumulative = 0;
            int minNum = 1;
            for (int i = 0; i < System.DayTypeDistributions.Count; ++i)
            {
                cumulative += System.DayTypeDistributions[i].Probability;
                System.DayTypeDistributions[i].CummProbability = cumulative;

                System.DayTypeDistributions[i].MinRange = minNum;
                System.DayTypeDistributions[i].MaxRange = (int)(cumulative * 100);
                minNum = System.DayTypeDistributions[i].MaxRange + 1;
            }
        }

        public void calcDemandDist()
        {
            decimal cumulative_1 = 0, cumulative_2 = 0, cumulative_3 = 0;
            int minNum_1 = 1, minNum_2 = 1, minNum_3 = 1;
            for (int j = 0; j < System.DemandDistributions.Count; ++j)
            {
                List<DayTypeDistribution> dayTypeDistributions = System.DemandDistributions[j].DayTypeDistributions;
                
                cumulative_1 += dayTypeDistributions[0].Probability;
                cumulative_2 += dayTypeDistributions[1].Probability;
                cumulative_3 += dayTypeDistributions[2].Probability;
                dayTypeDistributions[0].CummProbability = cumulative_1;
                dayTypeDistributions[1].CummProbability = cumulative_2;
                dayTypeDistributions[2].CummProbability = cumulative_3;
                dayTypeDistributions[0].MinRange = minNum_1;
                dayTypeDistributions[1].MinRange = minNum_2;
                dayTypeDistributions[2].MinRange = minNum_3;
                dayTypeDistributions[0].MaxRange = (int)(cumulative_1 * 100);
                dayTypeDistributions[1].MaxRange = (int)(cumulative_2 * 100);
                dayTypeDistributions[2].MaxRange = (int)(cumulative_3 * 100);
                minNum_1 = dayTypeDistributions[0].MaxRange + 1;
                minNum_2 = dayTypeDistributions[1].MaxRange + 1;
                minNum_3 = dayTypeDistributions[2].MaxRange + 1;
            }
        }
        #endregion

        #region SIMULATION_TABLE
        private void simulateTable()
        {
            for (int i = 0; i < System.NumOfRecords; ++i)
            {
                System.SimulationTable.Add(new SimulationCase());
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
            System.SimulationTable[i].DayNo = i + 1;
        }

        private void genRandomNewsDayType(int i)
        {
            System.SimulationTable[i].RandomNewsDayType = random.Next(1, 100);
        }

        private void setNewsDayType(int i)
        {
            for (int j = 0; j < System.DayTypeDistributions.Count; ++j)
            {
                int minRange = System.DayTypeDistributions[j].MinRange;
                int maxRange = System.DayTypeDistributions[j].MaxRange;
                int RandomNewsdayType = System.SimulationTable[i].RandomNewsDayType;
                if (RandomNewsdayType >= minRange && RandomNewsdayType <= maxRange)
                {
                    Enums.DayType dayType = System.DayTypeDistributions[j].DayType;
                    System.SimulationTable[i].NewsDayType = dayType;
                    break;
                }
            }
        }

        private void genRandomDemand(int i)
        {
            System.SimulationTable[i].RandomDemand = random.Next(1, 100);
        }

        private void setDemand(int i)
        {
            int randomDigitForDemand = System.SimulationTable[i].RandomDemand;
            Enums.DayType dayType = System.SimulationTable[i].NewsDayType;
            int type;
            if (dayType == Enums.DayType.Good) type = 0;
            else if (dayType == Enums.DayType.Fair) type = 1;
            else type = 2;

            for (int j = 0; j < System.DemandDistributions.Count; ++j)
            {
                DayTypeDistribution dateType = System.DemandDistributions[j].DayTypeDistributions[type];
                if (randomDigitForDemand >= dateType.MinRange && randomDigitForDemand <= dateType.MaxRange)
                {
                    System.SimulationTable[i].Demand = System.DemandDistributions[j].Demand;
                    break;
                }
            }
        }

        private void setDailyCost(int i)
        {
           System.SimulationTable[i].DailyCost = System.NumOfNewspapers * System.PurchasePrice;
        }

        private void setSalesProfit(int i)
        { 
            if (System.SimulationTable[i].Demand <= System.NumOfNewspapers)
            {
                System.SimulationTable[i].SalesProfit = System.SimulationTable[i].Demand * System.SellingPrice;
            }
            else
            {
                System.SimulationTable[i].SalesProfit = System.NumOfNewspapers * System.SellingPrice;
            }
        }

        private void setLostProfit(int i)
        {
            if (System.SimulationTable[i].Demand > System.NumOfNewspapers)
            {
                decimal ExcessDemand = System.SimulationTable[i].Demand - System.NumOfNewspapers;
                decimal ProfitForPiece = System.SellingPrice - System.PurchasePrice;
                System.SimulationTable[i].LostProfit = ProfitForPiece*ExcessDemand;
            }
            else
            {
              System.SimulationTable[i].LostProfit = 0;
            }
        }

        private void setScrapProfit(int i)
        {
            if (System.SimulationTable[i].Demand < System.NumOfNewspapers)
            {
                decimal scrap = System.NumOfNewspapers - System.SimulationTable[i].Demand;
                System.SimulationTable[i].ScrapProfit = scrap * System.ScrapPrice;
            }
            else
            {
            System.SimulationTable[i].ScrapProfit = 0;
            }
        }

        private void setDailyNetProfit(int i)
        {
            System.SimulationTable[i].DailyNetProfit = 
                 System.SimulationTable[i].SalesProfit 
               - System.SimulationTable[i].DailyCost 
               - System.SimulationTable[i].LostProfit 
               + System.SimulationTable[i].ScrapProfit;
        }
        #endregion

        #region PERFORMANCE_MEASURES
        private void calcPerformanceMeasures()
        {
            calcTotalSalesProfit();
            calcTotalCost();
            calcTotalLostProfit();
            calcTotalScrapProfit();
            calcTotalNetProfit();
            calcDaysWithMoreDemand();
            calcDaysWithUnsoldPapers();
        }

        private void calcTotalSalesProfit()
        {
            decimal CostSum = 0;
            for (int i = 0; i < System.NumOfRecords; i++)
            {
                CostSum += System.SimulationTable[i].SalesProfit;
            }
            System.PerformanceMeasures.TotalSalesProfit = CostSum;
        }
        private void calcTotalCost()
        {
            decimal TotalCost = System.NumOfNewspapers * System.PurchasePrice * System.NumOfRecords ;
            System.PerformanceMeasures.TotalCost = TotalCost;
        }
        private void calcTotalLostProfit()
        {
            decimal LostProfitSum = 0;
            for (int i = 0; i < System.NumOfRecords; i++)
            {
                LostProfitSum += System.SimulationTable[i].LostProfit;
            }
            System.PerformanceMeasures.TotalLostProfit = LostProfitSum;
        }
        private void calcTotalScrapProfit()
        {
            decimal ScrapPrpfitSum = 0;
            for (int i = 0; i < System.NumOfRecords; i++)
            {
                ScrapPrpfitSum += System.SimulationTable[i].ScrapProfit;
            }
            System.PerformanceMeasures.TotalScrapProfit = ScrapPrpfitSum;
        }
        private void calcTotalNetProfit()
        {
            decimal NetProfit = 0;
            for (int i = 0; i < System.NumOfRecords; i++)
            {
                NetProfit += System.SimulationTable[i].DailyNetProfit;
            }
            System.PerformanceMeasures.TotalNetProfit = NetProfit;
        }
        private void calcDaysWithMoreDemand()
        {
            int ExcessDemandCount = 0;
            for (int i = 0; i < System.NumOfRecords; i++)
            {
                if (System.SimulationTable[i].LostProfit != 0)
                    ExcessDemandCount++;
            }
            System.PerformanceMeasures.DaysWithMoreDemand = ExcessDemandCount;
        }
        private void calcDaysWithUnsoldPapers()
        {
            int ScrapCount = 0;
            for (int i = 0; i < System.NumOfRecords; i++)
            {
                if (System.SimulationTable[i].ScrapProfit != 0)
                    ScrapCount++;
            }
            System.PerformanceMeasures.DaysWithUnsoldPapers = ScrapCount;
        }
        #endregion
    }
}