namespace data_board.Models
{
    public class ChartData
    {
        public string[] Labels { get; set; } = Array.Empty<string>();
        public int[] ItemsSold { get; set; } = Array.Empty<int>();

        // Prijzen en kosten
        public decimal SalePrice { get; set; } = 34.95m;
        public decimal PurchaseCostPerItem { get; set; } = 12.80m;
        public decimal AdministrationCostPerItem { get; set; } = 2.35m;
        public decimal DeliveryCostPerItem { get; set; } = 4.10m;

        // Vaste werknemerskosten
        public decimal EmployeeCosts { get; set; } = 214500.00m;

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
