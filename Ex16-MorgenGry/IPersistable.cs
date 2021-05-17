using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Ex16_MorgenGry
{
    public interface IPersistable
    {
        void Save();
        void Save(string fileName);
        void Load();
        void Load(string fileName);
    }
}
