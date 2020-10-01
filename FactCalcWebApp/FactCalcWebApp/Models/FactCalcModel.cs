using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FactCalcWebApp.Models
{
    public class FactCalcModel
    {
        [Required]
        public int InputFactNumber { get; set; }

        public double? OutputFactNumber { get; set; }
    }
}
