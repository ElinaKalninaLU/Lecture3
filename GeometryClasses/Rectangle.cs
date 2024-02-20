using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryClasses
{
    public class Rectangle: Figure
    {
		private int height;

		public int Height
		{
			get { return height; }
			set { 
				if (value>=0) {  height = value; }
			
			}
		}

        private int width;

        public int Width
        {
            get { return width; }
            set
            {
                if (value >= 0) { width = value; }

            }
        }

        public Rectangle()
        { }

        public Rectangle(int h, int w)
        {
            Height = h;
            Width = w;
        }

        public override int Perimeter()
        {
            return 2*Height+2*Width;
        }

        public override int Area => Height*Width;
    }
}
