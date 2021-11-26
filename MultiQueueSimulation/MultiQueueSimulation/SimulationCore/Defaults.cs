namespace MultiQueueSimulation.OOP
{
    class Defaults
    {
        // 1 -> HighestPriority
        // 2 -> Random
        // 3 -> LeastUtilization
        public static readonly int SELECTION_METHOD = 1;

        // 1 -> NumberOfCustomers
        // 2 -> SimulationEndTime
        public static readonly int STOPPING_CRITERIA = 1;

        // Least Number of Servers Could be Exist.
        public static readonly int NUMBER_Of_SERVERS = 2;

        // Simulation Ends after simulating this number of iterations.
        public static readonly int STOPPING_NUMBER = 2;

        // Maximum Chart Y axis Value
        public static readonly int MAX_Y_VALUE = 2;
    }
}
