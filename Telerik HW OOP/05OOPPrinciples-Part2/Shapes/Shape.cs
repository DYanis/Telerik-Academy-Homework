using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        protected double width;

        protected double hight;

        public Shape(double wid,double hig)
        {
            this.width = wid;
            this.hight = hig;
        }

        public  abstract double CalculateSurface();


    }
}
