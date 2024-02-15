using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryClasses
{
    public class Square: Figure
    {
		private int edge;

		public int Edge
		{
			get { return edge; }
			set {
				if (value >= 0)
				{ edge = value; }
			}
		}

        public override int Perimeter()
        {
            return 4*Edge;
        }

        public override string? ToString()
        {
            return "Square; Edge: "+ Edge + " " + base.ToString();
        }

        public override int Area => Edge*Edge;
    }
}
