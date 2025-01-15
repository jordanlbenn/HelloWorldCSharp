using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldCSharp
{
    public class Car
    {
        public string make;
        public string model;
        public int year;
        public string VIN;
        public string exteriorColor;
        string interiorColor;
        public Car(string make, string model, int year, string vIN, string exteriorColor, string interiorColr)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            VIN = vIN;
            this.exteriorColor = exteriorColor;
            this.interiorColor = interiorColor;
        }
    }
}
