using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonPattern
{
    [Serializable]
    //Порождающий
    public class Prototype
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Home { get; set; }
        public string Work { get; set; }
        public Date Bday { get; set; }
        public string GetInfo()
        {
            return $"{Name}: {Age} лет, живет по адресу {Home}\nРаботает по адресу {Work}\n" +
                $"Дата выдачи паспорта {Bday.Day}.{Bday.Month}.{Bday.Year}";
        }
        public Prototype Clone()
        {
            Prototype result = new Prototype() { Name = Name, Age = Age, Home = Home, Work = Work, Bday=Bday.Clone() };
            return result;
        }
    }
    
}
