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
        }

        public Server(int ID)
        {
            this.ID = ID;
            if (this.TimeDistribution == null)
                TimeDistribution = new List<TimeDistribution>();
        }

        public Server(int ID, int Time, decimal Prob)
        {
            this.ID = ID;
            if (this.TimeDistribution == null)
                TimeDistribution = new List<TimeDistribution>();
            
            TimeDistribution.Add(new TimeDistribution(Time, Prob));
        }

        public int ID { get; set; }
        public decimal IdleProbability { get; set; }
        public decimal AverageServiceTime { get; set; } 
        public decimal Utilization { get; set; }

        public List<TimeDistribution> TimeDistribution;

        //optional if needed use them
        public int FinishTime { get; set; }
        public int TotalWorkingTime { get; set; }
    }
}
