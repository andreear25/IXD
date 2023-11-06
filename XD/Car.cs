using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XD
{
    public class Car
    {
        public string color;
        public string name;
        public int maxspeed;
        public int year;

        public Car(string nameName, string colorName, int yearValue, int maxspeedValue)
        {
           color = colorName;
           name = nameName;
           maxspeed = maxspeedValue;
           year = yearValue;
        }
        public Car(string nameName)
        {
            name= nameName;
        }
        public void fullThrottle()
        {
            Console.WriteLine(name + "is going at yhe speed of" + maxspeed);
        }
    }
}
