using System.Data.Common;
using System.Xml.Serialization;

namespace GeometryClasses
{
    [XmlInclude(typeof(Square))]
    [XmlInclude(typeof(Rectangle))]
    [XmlInclude(typeof(Polygon))]
    public abstract class Figure
    {
        public string Name { get; set; } = "";

        public override string? ToString()
        {
            return "Perimeter: " + Perimeter().ToString() + " Area: " + Area.ToString();
        }

        public virtual int Perimeter()
        {
            return 0;
        }

        public virtual int Area { get; }

        public Colour figureColour { get; set; } = Colour.Black;

        public Point location { get; set; } = new Point() { x=0, y=0};
    }
}
