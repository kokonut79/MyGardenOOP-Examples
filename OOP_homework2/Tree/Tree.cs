using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_homework2
{
    internal class Tree : IGardenItems
    {
        public double WaterRequired { get; set; }

        public Tree(double WaterRequired)
        {
            this.WaterRequired = WaterRequired;
        }

        
    }
}
