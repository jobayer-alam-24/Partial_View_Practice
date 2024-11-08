using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Partial_View_Practice.Enums;

namespace Partial_View_Practice.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; } 
        public decimal Price { get; set; }
        public string SKU { get; set; }
        public int Quantity { get; set; }
        public PublishStaus PublishStaus { get; set; }  
    }
}