using System;
using Bogus;
using D365GenerateVendorCatalog.Entities;

namespace D365GenerateVendorCatalog
{
    public class ProductBuilder
    {
        private Faker _faker = new Faker();
        
        public static implicit operator CatVendorProductCandidateEntity(ProductBuilder instance)
        {
            return instance.Build();
        }

        public CatVendorProductCandidateEntity Build()
        {

            string productName = _faker.Commerce.ProductName();
            string productBarcodEan13 = _faker.Commerce.Ean13();
            string productNumber = _faker.Random.AlphaNumeric(10);


            return new CatVendorProductCandidateEntity
            {
                ProductCategoryHierarchyName = "Procurement - Office Supplies",
                ActionType = "Add",
                ProductCategoryName = "OFFICE MACHINES",
                ProductNumber = productNumber,
                SearchName = productName.Replace(" ", string.Empty),
                ProductSubtype = "Product",
                Barcode = productBarcodEan13,
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
                    ProductName = $"{productName} ({productNumber})"
                }
            };
        }


    }
}
