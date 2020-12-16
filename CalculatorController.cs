using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Calculator.Models;

namespace Calculator.Controllers
{
    
    public class CalculatorController : Controller
    {
        
        // GET: Calculator
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult total(string number1, string number2, string calc)
        {
            decimal num1 = Convert.ToDecimal(number1.ToString());
            decimal num2 = Convert.ToDecimal(number2.ToString());
            decimal res = 0.0M;
            switch (calc)
            {
                case "Add":
                    res = num1 + num2;
                    break;
                case "Subtract":
                    res = num1 - num2;
                    break;
                case "Multiply":
                    res = num1 * num2;
                    break;
                case "Divide":
                    try
                    {
                        res = num1 / num2;
                    }
                    catch (DivideByZeroException)
                    {
                        return Content("Divide by 0 is not allowed");
                    }
                    break;
                default:
                    Response.Write("Invalid input");
                    break;

            }
            return Content("Result is : " + res);
        }
    }
}

    }
}