using System.IO;
using System.Text;

namespace D365GenerateVendorCatalog
{
    public class StringWriterUtf8 : StringWriter
    {
        public StringWriterUtf8(StringBuilder sb) : base(sb)
        {
        }

        public override Encoding Encoding
        {
            get { return Encoding.UTF8; }
        }
    }
}