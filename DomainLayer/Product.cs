using System;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer
{
    public class Product
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string model { get; set; }
        public string description { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }
        public string imagePath { get; set; }
    }
}
