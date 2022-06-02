using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonPattern
{
    [Serializable]
    //Одиночка
    class SingleTon
    {
        static SingleTon _singleton;
        int _count;
        private SingleTon()
        {
            _count = 0;
        }
        static public SingleTon GetObject()
        {
            if (_singleton == null)
            {
                _singleton = new SingleTon();
            }
            return _singleton;
        }
        public int GetCount()
        {
            return _count++;
        }
        public int GetCount1()
        {
            return --_count;
        }
    }
}
