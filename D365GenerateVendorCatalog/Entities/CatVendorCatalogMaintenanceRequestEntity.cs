using System.Collections.Generic;
using System.Xml.Serialization;

namespace D365GenerateVendorCatalog.Entities
{
    public class CatVendorCatalogMaintenanceRequestEntity
    {
        [XmlElement("CatVendorProductCandidateEntity")]
        public List<CatVendorProductCandidateEntity> CatVendorProductCandidateEntity { get; set; }
        
    }
}
