using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle : Shape
    {
        public Rectangle(double wid, double hig)
            : base(wid, hig)
        {

        }

        public override double CalculateSurface()
        {
            return this.hight * this.width;
        }
    }
}
