namespace StartMain
{
    using System;
    using System.Linq;

    class Display
    {
        // size and number of colors
        readonly public double size;
        readonly public long numberOfColors;

        public Display(double size, long numberOfColors)
        {
            this.size = size;
            this.numberOfColors = numberOfColors;
        }
    }
}
