using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FactCalcWebApp.Models;
using FactCalcWebApp.Services;
using System.IO;
using System.Diagnostics.CodeAnalysis;

namespace FactCalcWebApp.Controllers
{
    public class FactCalcController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        private readonly IFactCalcServices _services;

        public FactCalcController(IFactCalcServices services)
        {
            _services = services;
        }

        [HttpPost]
        public ActionResult<FactCalcModel> Index(FactCalcModel factNumModel)
        {

            var factorialCalculated = _services.CalculateFactorial(factNumModel);

            if (factorialCalculated == null)
            {
                return NotFound();
            }

            //Input For adding to a physical file
            string inputStreamToFile = string.Empty;
            inputStreamToFile = "Factorial of " + factNumModel.InputFactNumber.ToString() + " is " + factNumModel.OutputFactNumber.ToString();
            this.GetFile(inputStreamToFile);

            return View(factorialCalculated);
        }

        /// <summary>
        /// Adding the resultset to a file
        /// </summary>
        /// <param name="inputStreamToFile">Input to Print in a file</param>
        /// <returns></returns>
        public FileStreamResult GetFile(string inputStreamToFile)
        {
            string name = "factorialResult.txt";
            try
            {
                FileInfo info = new FileInfo(name);
                if (!info.Exists)
                {
                    using (StreamWriter writer = info.CreateText())
                    {
                        writer.WriteLine("=============" + DateTime.Now.ToString() + "=============");
                        writer.WriteLine(inputStreamToFile);
                        writer.WriteLine("=====================================");
                    }
                }
                else
                {
                    using (StreamWriter writer = info.AppendText())
                    {
                        writer.WriteLine("=============" + DateTime.Now.ToString() + "=============");
                        writer.WriteLine(inputStreamToFile);
                        writer.WriteLine("=====================================");
                    }
                }

                return File(info.OpenRead(), "text/plain");
            }
            catch (Exception ex)
            {
                
                
            }

            return null;
        }
    }
}
