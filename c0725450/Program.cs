using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0725450
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public void Promote()
        {
            var rating = CalculateRating();
            if (rating == 0)
            {
                Console.WriteLine("Promoted to Level1");
            }
            else
            {
                Console.WriteLine("Promoted to Level2");
            }
        }
        public int CalculateRating()
        {
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            

            //var dog_and_cat = new Car();
            //var bowling = new Car();
            //var myBook = new Book();
            //myBook.SetTitle("A Seperate Peace");
            //Console.WriteLine(myBook.GetTitle());
            //Console.WriteLine("How many cars : {0}", Vehicle.howManyCars);
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
    class BookCollection
    {

    }
    class Book: BookCollection
    {
        private String Title;
        public void SetTitle(String aTitle)
        {
            this.Title = aTitle;
        }
        public String GetTitle() { return this.Title; }
    }
}