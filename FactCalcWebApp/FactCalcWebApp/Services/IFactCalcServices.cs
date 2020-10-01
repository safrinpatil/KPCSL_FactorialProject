using FactCalcWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactCalcWebApp.Services
{
    public interface IFactCalcServices
    {
        FactCalcModel CalculateFactorial(FactCalcModel factNumModel);
    }
}
