using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarApplication
{
    class Car
    {
        public string make { get; set; }
        public int year { get; set; }
        public int speed { get; set; }
        public string model { get; set; }
        
        public Car(string make, int year, string model)
        {
            speed = 0;
            this.make = make;
            this.year = year;
            this.speed = speed;


        }
 
    }
}
