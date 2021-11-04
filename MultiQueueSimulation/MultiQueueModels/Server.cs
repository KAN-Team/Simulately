using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    public class Server
    {
        public Server()
        {
            TimeDistribution = new List<TimeDistribution>();
            WorkingIntervals = new List<KeyValuePair<int, int>>();
        }

        public Server(int ID)
        {
            this.ID = ID;
            if (TimeDistribution == null)
                TimeDistribution = new List<TimeDistribution>();
            if (WorkingIntervals == null)
                WorkingIntervals = new List<KeyValuePair<int, int>>();
        }

        public int ID { get; set; }
        public decimal IdleProbability { get; set; }
        public decimal AverageServiceTime { get; set; } 
        public decimal Utilization { get; set; }

        public List<TimeDistribution> TimeDistribution;

        //optional if needed use them
        public int FinishTime { get; set; }
        public int TotalWorkingTime { get; set; }
        public List<KeyValuePair<int, int>> WorkingIntervals { get; set; }
    }
}
