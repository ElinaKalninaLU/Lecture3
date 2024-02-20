using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GeometryClasses
{
    public class FigureXMLDataManager : IDataManager, IAddFigure
    {
        private List<Figure> _figureList;
        private string _path = "C:\\Test\\figures.xml";

        public FigureXMLDataManager() 
            { _figureList = new List<Figure>(); }

        public void AddFigure(Figure figure)
        {
            if (figure != null)
            { _figureList.Add(figure); }
        }

        public bool CreateTestData()
        {
            var sq = new Square() { Edge = 0 };
            AddFigure(sq);
            var rec = new Rectangle(1, 2);
            AddFigure(rec);
            return true;
        }

        public bool Load(string path)
        {

            if (File.Exists(_path))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Figure>));
                using (TextReader reader = new StreamReader(_path))
                {
                    var f = (List<Figure>)serializer.Deserialize(reader);
                    if (f != null && f is List<Figure>) { _figureList = f; }
                }
            }
            return true;
        }

        public string Print()
        {
            string str = "";
            foreach (var f in _figureList)
            {
                str += f.ToString();
                str += "\n";
            }
            if (str == "") { str = "Empty!"; }
            return str;
        }

        public bool Reset()
        {
            _figureList.Clear();
            return true;
        }

        public bool Save(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Figure>));
            using (TextWriter writer = new StreamWriter(_path))
            {
                serializer.Serialize(writer, _figureList);
            }
            return true;
        }
    }
}
