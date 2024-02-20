using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryClasses
{
    public class Polygon
    {
        public Polygon() { 
		 _pointList = new List<Point>();
		}

		private List<Point> _pointList;

		public List<Point> Points
		{
			get { return _pointList; }
			set { _pointList = value; }
		}

		public void AddPoint(Point point) { _pointList.Add(point); }

	}
}
