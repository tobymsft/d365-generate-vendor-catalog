namespace D365GenerateVendorCatalog.Entities
{
    public class CatVendorProductCandidatePurchasePriceEntity
    {
        public string CurrencyCode { get; set; }
        public string UnitSymbol { get; set; }
        public decimal Price { get; set; }
    }
}