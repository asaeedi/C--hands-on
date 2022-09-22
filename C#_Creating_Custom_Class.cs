using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            List<object> produce = new List<object>();

            var f1 = new Fruit("Apple", "red", 10.4, 4);
            produce.Add(f1);

            var f2 = new Fruit("Orange", "orange", 14.7, 8);
            produce.Add(f2);

            produce.Add(new Vegetable("Lettuce", "green", 2.6, 14));
            produce.Add(new Vegetable());

            Console.WriteLine($"There are {produce.Count} objects in produce");

            foreach (var item in produce)
            {
                Console.WriteLine(item);
            }

        }

   internal class Fruit
    {
        public Fruit()
        {
            Name = "unknown name";
            Color = "unknown color";
            Weight = 0.0;
            Quantity = 0;
        }

        public Fruit(string name, string color, double weight, int quantity)
        {
            Name = name;
            Color = color;
            Weight = weight;
            Quantity = quantity;
        }

        private string name;
        private double weight;

        public string Name
        {
            get { return name.ToUpper(); }
            set { name = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public int Quantity { get; set; }

        public string Color { get; set; }

        public override string ToString()
        {
            return Color + " " + Name + " (" + Weight + " oz): " + Quantity;
        }
    }


    class Vegetable
    {

        public Vegetable()
        {
            Name = "unknown name";
            Color = "unknown color";
            Weight = 0.0;
            Quantity = 0;
        }

        public Vegetable(string name, string color, double weight, int quantity)
        {
            Name = name;
            Color = color;
            Weight = weight;
            Quantity = quantity;
        }

        private string name;
        private double weight;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public int Quantity { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            return Color + " " + Name + " (" + Weight + " oz): " + Quantity;
        }
    }
}
