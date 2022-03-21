using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.ProductLayer
{
    public class ProductOsFeatures : BaseModel
    {
        public string operatingSystem { get; set; }
        public string processor { get; set; }
        public string processorCore { get; set; }

    }
}
