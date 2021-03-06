using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.ProductLayer
{
    public class ProductBrand : BaseModel
    {
        [Required]
        [Display(Name = "Brand Name")]
        public string name { get; set; }
    }
}
