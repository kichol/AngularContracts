using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloAngular2.Models;

namespace HelloAngular2.Controllers
{
    public class ContractsController : Controller
    {

        public ActionResult Electricity()
        {
            List<Electricity> electricityContracts = new List<Electricity>()
            {
              new Electricity {  ContractName="Electricity 1/2017",HouseType = "Flat",Price = 101M },
              new Electricity {  ContractName="Electricity 2/2017",HouseType = "Flat",Price = 102M },
              new Electricity {  ContractName="Electricity 3/2017",HouseType = "Flat",Price = 103M },
              new Electricity {  ContractName="Electricity 4/2017",HouseType = "Flat",Price = 104M },
              new Electricity {  ContractName="Electricity 5/2017",HouseType = "House",Price = 220M },
              new Electricity {  ContractName="Electricity 6/20217",HouseType = "Other",Price = 330M },
            };

            return View(electricityContracts);
        }
        public ActionResult Heat()
        {
            List<Heat> heatContracts = new List<Heat>()
            {
              new Heat {  ContractName="Heat 1/2017",
                  Temperatures=new List<string> {"10C","20C", "25C" },
                  Price = 100M },
              new Heat {  ContractName="Heat 12/2016",
                  Temperatures=new List<string> {"14C","18C", "24C" },
                  Price = 150M },
              new Heat {  ContractName="Heat 4/2017",
                  Temperatures=new List<string> {"15C","22C", "26C" },
                  Price = 200M }
            };

            return View(heatContracts);
        }
        
    }
}