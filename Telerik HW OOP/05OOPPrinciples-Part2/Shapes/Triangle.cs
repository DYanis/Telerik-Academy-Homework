using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle : Shape
    {
        public Triangle(double wid, double hig)
            : base(wid, hig)
        {

        }
        public override double CalculateSurface()
        {
            return (this.width * this.hight) / 2;
        }
    }
}
