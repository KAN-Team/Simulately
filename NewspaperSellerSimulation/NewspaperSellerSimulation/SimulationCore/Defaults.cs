namespace NewspaperSellerSimulation.SimulationCore
{
    class Defaults
    {
        // Number of Newspapers to Simulate on.
        public static readonly int NUMBER_OF_NEWSPAPERS = 70;

        // Number of Days to Simulate.
        public static readonly int NUMBER_OF_RECORDS = 20;

        // The Price by which the Newspaper Seller buys.
        public static readonly decimal PurchasePrice = (decimal)0.33;

        // The Price of Newspapers that are not Sold at the end of the day.
        public static readonly decimal ScrapPrice = (decimal)0.05;

        // The Price by which the Newspapers Seller sells.
        public static readonly decimal SellingPrice = (decimal)0.5;
    }
}
