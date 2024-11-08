using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Partial_View_Practice.Enums;

namespace Partial_View_Practice.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string CompanyName { get; set; }
        public ActiveStatus ActiveStatus { get; set; }
    }
}