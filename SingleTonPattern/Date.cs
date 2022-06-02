using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonPattern
{
    [Serializable]
    public class Date
    {
        public int Year { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }

        public Date Clone()
        {
            return new Date() { Year = Year, Day = Day, Month = Month };
        }
    }
}
