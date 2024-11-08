using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Partial_View_Practice.Enums;
using Partial_View_Practice.Models;

namespace Partial_View_Practice.Controllers
{
    public class CustomerController : Controller
    {
        private List<Customer> customers = new List<Customer>()
        {
            new Customer() { ID = 1, Name = "Rahim", Email = "rahim@gmail.com", CompanyName = "RAHIM_ABC_COMPANY", Role = Role.Admin, ActiveStatus = ActiveStatus.Active },
            new Customer() { ID = 2, Name = "Karim", Email = "karim@gmail.com", CompanyName = "KARIM_LTD", Role = Role.Manager, ActiveStatus = ActiveStatus.Inactive },
            new Customer() { ID = 3, Name = "Jamil", Email = "jamil@gmail.com", CompanyName = "JAMIL_TECH", Role = Role.MD, ActiveStatus = ActiveStatus.Pending },
            new Customer() { ID = 4, Name = "Salim", Email = "salim@gmail.com", CompanyName = "SALIM_CORP", Role = Role.DMD, ActiveStatus = ActiveStatus.Suspended },
            new Customer() { ID = 5, Name = "Asif", Email = "asif@gmail.com", CompanyName = "ASIF_ENTERPRISE", Role = Role.Admin, ActiveStatus = ActiveStatus.Active },
            new Customer() { ID = 6, Name = "Farid", Email = "farid@gmail.com", CompanyName = "FARID_INC", Role = Role.Manager, ActiveStatus = ActiveStatus.Pending },
            new Customer() { ID = 7, Name = "Nabil", Email = "nabil@gmail.com", CompanyName = "NABIL_GROUP", Role = Role.DMD, ActiveStatus = ActiveStatus.Inactive },
        };
        private readonly ILogger<CustomerController> _logger;

        public CustomerController(ILogger<CustomerController> logger)
        {
            _logger = logger;
        }

        public IActionResult Customers()
        {
            return View(customers);
        }

        public IActionResult Details(int id)
        {
            if (id <= 0) return BadRequest();
            else
            {
                var single_customer = customers.FirstOrDefault(x => x.ID == id);
                if(single_customer != null) return View(single_customer);
                else
                {
                    return BadRequest();
                }
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}