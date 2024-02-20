// See https://aka.ms/new-console-template for more information
using GeometryClasses;

//Console.WriteLine("Enter height and width of rectangle");
//var rec1 = new Rectangle();
//rec1.Height = int.Parse(Console.ReadLine());
//rec1.Width = int.Parse(Console.ReadLine());
//Console.WriteLine(rec1.ToString());
//Console.WriteLine(rec1.Perimeter());
//Console.WriteLine("Enter edge of the square");
//var sq1 = new Square();
//sq1.Edge = int.Parse(Console.ReadLine());
//Console.WriteLine(sq1.ToString());
string str = "C:\\Temp\\figures.xml";
var dm = new FigureXMLDataManager();
dm.CreateTestData();
Console.WriteLine(dm.Print());
dm.Save(str);
dm.Reset();
Console.WriteLine(dm.Print());
dm.Load(str);
Console.WriteLine(dm.Print());

