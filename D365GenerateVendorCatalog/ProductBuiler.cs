using System;
using D365GenerateVendorCatalog.Entities;

namespace D365GenerateVendorCatalog
{
    public class ProductBuilder
    {

        private string _productNumber = Guid.NewGuid().ToString();//new Random().Next(1, Int32.MaxValue).ToString();

        public static implicit operator CatVendorProductCandidateEntity(ProductBuilder instance)
        {
            return instance.Build();
        }

        public CatVendorProductCandidateEntity Build()
        {
            return new CatVendorProductCandidateEntity
            {
                ProductCategoryHierarchyName = "Procurement - Office Supplies",
                ActionType = "Add",
                ProductCategoryName = "OFFICE MACHINES",
                ProductNumber = _productNumber,
                SearchName = "SearchName",
                ProductSubtype = "Product",
                Barcode = _productNumber,
                ProductColorId = string.Empty,
                ProductConfigurationId = string.Empty,
                ProductSizeId = string.Empty,
                ProductStyleId = string.Empty,
                CatVendorProductCandidateDefaultOrderSettingsEntity = new CatVendorProductCandidateDefaultOrderSettingsEntity
                {
                    LeadTime = 15,
                    MaximumOrderQuantity = 100,
                    MinimumOrderQuantity = 1,
                    OrderQuantityMultiples = 10,
                    StandardOrderQuantity = 10,
                    UnitSymbol = "ea"
                },
                CatVendorProductCandidatePurchasePriceEntity = new CatVendorProductCandidatePurchasePriceEntity
                {
                    UnitSymbol = "ea",
                    CurrencyCode = "USD",
                    Price = 100M
                },
                CatVendorProductCandidateSalesPriceEntity = new CatVendorProductCandidateSalesPriceEntity
                {
                    UnitSymbol = "ea",
                    CurrencyCode = "USD",
                    Price = 200M,
                    SuggestedPrice = 220M
                },
                CatVendorProductCandidateTranslationEntity = new CatVendorProductCandidateTranslationEntity
                {
                    Description = "Product description",
                    LanguageId = "en-au",
                    ProductName = $"Product Name ({_productNumber})"
                }
            };
        }


        public ProductBuilder WithProductNumber(string productNumber)
        {
            _productNumber = productNumber;
            return this;
        }
    
    }
}
