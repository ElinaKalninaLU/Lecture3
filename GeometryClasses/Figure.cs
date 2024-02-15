namespace GeometryClasses
{
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
    }
}
