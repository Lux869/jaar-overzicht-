namespace data_board.Models
{
    public class ChartData
    {
        public string[] Labels { get; set; } = Array.Empty<string>();
        public int[] ItemsSold { get; set; } = Array.Empty<int>();

        // Prijzen en kosten
        public decimal SalePrice { get; set; } = 10.00m;
        public decimal PurchaseCostPerItem { get; set; } = 0.73m;
        public decimal AdministrationCostPerItem { get; set; } = 0.20m;
        public decimal DeliveryCostPerItem { get; set; } = 2.50m;

        // Vaste werknemerskosten
        public decimal EmployeeCosts { get; set; } = 50.00m;

        // Berekeningen
        public int TotalItems => ItemsSold.Sum();

        public decimal TotalRevenue =>
            TotalItems * SalePrice;

        public decimal TotalPurchaseCosts =>
            TotalItems * PurchaseCostPerItem;

        public decimal TotalAdministrationCosts =>
            TotalItems * AdministrationCostPerItem;

        public decimal TotalDeliveryCosts =>
            TotalItems * DeliveryCostPerItem;

        public decimal TotalCosts =>
            TotalPurchaseCosts
            + TotalAdministrationCosts
            + TotalDeliveryCosts
            + EmployeeCosts;

        public decimal TotalProfit =>
            TotalRevenue - TotalCosts;

        public decimal ProfitPerItemBeforeEmployees =>
            SalePrice
            - PurchaseCostPerItem
            - AdministrationCostPerItem
            - DeliveryCostPerItem;
    }
}
