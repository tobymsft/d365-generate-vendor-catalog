using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using D365GenerateVendorCatalog.Entities;

namespace D365GenerateVendorCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            string strNumVendorCatalogLines;
            int numVendorCatalogLines;
            do
            {
                Console.Write("How many vendor catalog lines do you want to generate?:  ");
                strNumVendorCatalogLines = Console.ReadLine();
            } while (!int.TryParse(strNumVendorCatalogLines, out numVendorCatalogLines));

            

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Document));

            var productNumberGroup = new Random().Next(1, int.MaxValue).ToString();
            var productsList = new List<CatVendorProductCandidateEntity>(); 
            for (int i = 0; i < numVendorCatalogLines; i++)
            {
                productsList.Add(new ProductBuilder().WithProductNumber($"{productNumberGroup}-{i+1}"));
            }

            var document = new Document
            {
                CatVendorCatalogMaintenanceRequestEntity = new CatVendorCatalogMaintenanceRequestEntity
                {
                    CatVendorProductCandidateEntity = productsList
                }
            };
            string xml;
            XmlWriterSettings xmlWriterSettings = new XmlWriterSettings
            {
                Indent = true
            };

            var sb = new StringBuilder();
            using (var stringWriter = new StringWriterUtf8(sb))
            {
                using (XmlWriter writer = XmlWriter.Create(stringWriter, xmlWriterSettings))
                {
                    
                    xmlSerializer.Serialize(writer, document);
                    xml = stringWriter.ToString();
                }
            }

            System.IO.File.WriteAllText(@"C:\temp\VendorCatalog.xml", xml);
            Console.WriteLine("Done!");
            Console.ReadKey();

            


        }


        
    }
}
