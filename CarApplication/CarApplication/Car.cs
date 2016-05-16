using System;

namespace CarApplication
{

    class Car
    {
        public Car(int year, string make)
        {
            int year;
            string make;
            int speed = 0;
        }
        public int setYear(int year)
        {
            this.year = year;
        }
        public void getyear()
        {
            return this.year;
        }
        public string setMake(string make)
        {
            this.make = make;
        }
        public void getMake()
        {
            return this.make;
        }
        public int setSpeed(int speed)
        {
            this.speed = speed;
        }
        public void getSpeed()
        {
            return this.speed;
        }
    }
}