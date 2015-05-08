using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Square : Shape
    {
        public Square(double h ):base(h,h)
        {

        }

        public override double CalculateSurface()
        {
            return this.hight * this.hight;
        }
    }
}
