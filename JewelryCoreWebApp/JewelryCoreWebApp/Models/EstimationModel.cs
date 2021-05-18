using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JewelryCoreWebApp.Models
{
    public class EstimationModel
    {
        public int GoldPrice { get; set; }
        public int Weight { get; set; }
        public int TotalPrice { get; set; }

        public int Discount { get; set; }
    }
}
