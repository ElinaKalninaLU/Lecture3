using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryClasses
{
    public interface IDataManager
    {
        public string Print();

        public bool Save(string path);

        public bool Load(string path);

        public bool CreateTestData();

        public bool Reset();

    }
}
