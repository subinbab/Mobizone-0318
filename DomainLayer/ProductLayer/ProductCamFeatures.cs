using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.ProductLayer
{
    public class ProductCamFeatures : BaseModel
    {
        public int primaryCam { get; set; }
        public int secondaryCam { get; set; }
    }
}
