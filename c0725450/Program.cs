using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0725450
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog_and_cat = new Car();
            var bowling = new Car();
            Console.WriteLine("How many cars : {0}", Vehicle.howManyCars);
        }
    }
    class Vehicle
    {
        public static int howManyCars = 0;
        public String Color = "Blue";
    }
    class Car : Vehicle
    {
        public String Color = "Red";
        public Car()
        {
            Vehicle.howManyCars++;
            Console.WriteLine("My color is " + Color);
        }
    }
}