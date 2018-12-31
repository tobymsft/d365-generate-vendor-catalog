namespace D365GenerateVendorCatalog.Entities
{
    public class CatVendorProductCandidateSalesPriceEntity
    {
        public string CurrencyCode { get; set; }
        public string UnitSymbol { get; set; }
        public decimal Price { get; set; }
        public decimal SuggestedPrice { get; set; }
    }
}