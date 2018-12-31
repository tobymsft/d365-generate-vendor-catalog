namespace D365GenerateVendorCatalog.Entities
{
    public class CatVendorProductCandidateEntity
    {
        public string ProductCategoryHierarchyName { get; set; }
        public string ProductCategoryName { get; set; }
        public string ActionType { get; set; }
        public string ProductNumber { get; set; }
        public string ProductSubtype { get; set; }
        public string SearchName { get; set; }
        public string Barcode { get; set; }
        public string ProductColorId { get; set; }
        public string ProductConfigurationId { get; set; }
        public string ProductSizeId { get; set; }
        public string ProductStyleId { get; set; }
        public CatVendorProductCandidatePurchasePriceEntity CatVendorProductCandidatePurchasePriceEntity { get; set; }
        public CatVendorProductCandidateSalesPriceEntity CatVendorProductCandidateSalesPriceEntity { get; set; }
        public CatVendorProductCandidateDefaultOrderSettingsEntity CatVendorProductCandidateDefaultOrderSettingsEntity { get; set; }
        public CatVendorProductCandidateTranslationEntity CatVendorProductCandidateTranslationEntity { get; set; }
    }
}