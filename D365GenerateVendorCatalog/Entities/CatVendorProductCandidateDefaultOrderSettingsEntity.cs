namespace D365GenerateVendorCatalog.Entities
{
    public class CatVendorProductCandidateDefaultOrderSettingsEntity
    {
        public string UnitSymbol { get; set; }
        public int LeadTime { get; set; }
        public int OrderQuantityMultiples { get; set; }
        public int MaximumOrderQuantity { get; set; }
        public int MinimumOrderQuantity { get; set; }
        public int StandardOrderQuantity { get; set; }
    }
}