using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_homework2
{
    internal class DecorationTree : Tree , IBeauty
    {
        public double BeautyScore { get; set; }
        public DecorationTree(double beautyScore, double WaterRequired) 
            : base(WaterRequired)
        {
            this.BeautyScore = beautyScore;
        }
        
    }
}
