using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloAngular2.Models
{
    public class Heat
    {
        public string ContractName { get; set; }
        public List<string> Temperatures { get; set; }
        public decimal Price { get; set; }
    }
}