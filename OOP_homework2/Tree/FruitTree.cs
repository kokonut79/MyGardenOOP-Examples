using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace OOP_homework2
{
    internal class FruitTree : Tree  , IFood
    {

        public double Energy { get; set; }
        public FruitTree(double WaterRequired , double Energy) : base(WaterRequired)
        {
            this.Energy = Energy;
        }
        
    }
}
