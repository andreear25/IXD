using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XD
{
    public class Car
    {
        private string color;
        private string name;
        private int maxspeed;
        private int year;

        public string Name
        { 
            get { return name; }
            set { name = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value < 1988)
                {
                    throw new Exception ("Please find a correct value");
                }
                else
                {
                    year = value;
                }
            }
        }
        public Car(string nameName, string colorName, int yearValue, int maxspeedValue, string eng_type)
        {
           color = colorName;
           name = nameName;
           maxspeed = maxspeedValue;
           year = yearValue;
           engine_type = eng_type;
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
