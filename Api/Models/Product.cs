using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class Product : Base
    {
        public string Name { get; set; }
        public string Descripton { get; set; }
        public decimal Price { get; set; }
        public string PictureUrl { get; set; }
        public ProductType ProductType { get; set; }
        public int ProductTypeId { get; set; }
        public Brand Brand { get; set; }
        public int BrandId { get; set; }
    }
}