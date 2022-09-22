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
			
            /********************************************/
			/* Console Input/Output */	
			
			string input = Console.ReadLine();
            Console.WriteLine("You entered: " + input);


            /********************************************/
			/* if statement with string console input */	
            string input = Console.ReadLine();

            if (input.Equals("Hello"))
            {
                Console.WriteLine("You said hello!");
            }
            else if (input.Equals("Goodbye", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("You said goodbye!");
            }
            else
            {
                Console.WriteLine("You said something else!");
            }			

            /********************************************/
			/* if statement with numeric input */	
            string input = Console.ReadLine();

            short inputConverted = new short();

            if (short.TryParse(input, out inputConverted))
            {
                if (inputConverted > 0)
                {
                    Console.WriteLine("You entered a positive number");
                }
                else
                {
                    Console.WriteLine("You entered a negative number");
                }
            }
            else
            {
                Console.WriteLine("Parsing error");
            }

            /********************************************/
			/* switch-case statement */			
            string input = Console.ReadLine();

            switch (input)
            {
                case "January":
                case "February":
                case "March":
                    {
                        Console.WriteLine("You're in the 1st quarter");
                        break;
                    }
                case "April":
                case "May":
                case "June":
                    {
                        Console.WriteLine("You're in the 2nd quarter");
                        break;
                    }
                case "July":
                case "August":
                case "September":
                    {
                        Console.WriteLine("You're in the 3rd quarter");
                        break;
                    }

                case "October":
                case "November":
                case "December":
                    {
                        Console.WriteLine("You're in the 4th quarter");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Not a valid month name");
                        break;
                    }
            }

            /********************************************/
			/* for-loop (traditional) */	
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Number is " + i);
            }

            string[] fruits = { "Apple", "Banana", "Orange", "Coconut" };
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine("Fruit is " + fruits[i]);
            }

            Console.WriteLine("Printing fruites in a reversed order:");

            for (int i = fruits.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("Fruit is " + fruits[i]);
            }	

          /********************************************/
			/* foreach looping */	
            string[] fruits = { "Apple", "Banana", "Orange", "Coconut" };
            int[] num = { 1, 2, 3, 4, 5, 6, 7 };

            foreach (string item in fruits)
            {
                Console.WriteLine("UpperCase fruit is " + item.ToUpper());
            }

            foreach(var item in num)
            {
                Console.WriteLine("Square of " + item + " is " + Math.Pow(item, 2));
            }				

            /********************************************/
			/* do-while & while-do */	
            int num = 10;
            while (num > 0)
            {
                Console.WriteLine("while-do Number is "+num);
                num--;
            }

            int num2 = 5;
            do
            {
                Console.WriteLine("do-while Number is "+num2);
                num2++;
            } while (num2 < 12);			
			  		

			/********************************************/
			/* methods */	
			
			value1 = 12;
			value2 = 24;
			
			// call by value
            int total = Add(value1, value2);
            Console.WriteLine("Total: " + total);

			//call by reference (note the keyword 'out' in both function and function call)
            int result;
            AddToOutParam(Value1, Value2, out result);
            Console.WriteLine("The result is " + result);			
			
			
			/********************************************/
			/* keyword 'continue' */			
			enum Fruit {Apple, Fig, Orange};
            Fruit[] fruit = {Fruit.Apple, Fruit.Apple, Fruit.Orange, Fruit.Fig};

            int apples = 0;

            foreach (var item in fruit)
            {
                if (item.Equals(Fruit.Apple))
                {
                    apples++;
                    if(apples > 1)
                    {
                        continue;		// by continue, for loop skips the current iteration and jumps to the next one 
                    }
                }

                Console.WriteLine(item);
            }
			
			
			/********************************************/
			/* Exceptions */				
			 
			 string[] fruit = { "Apples", "Oranges", "Grapes" };

            try
            {
                for (int i = 0; i <= fruit.Length; i++)
                {
                    Debug.WriteLine("Value of i: " + i);
                    Console.WriteLine(fruit[i]);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
			
			
			/********************************************/
			/* Multiple-Exceptions */	
			
            string[] fruit = { "Apples", null, "Grapes"};

            try
            {
                for (int i = 0; i <= fruit.Length; i++)
                {
                    //if (fruit[i] == null)
                    //{
                    //    throw (new ArgumentNullException());
                    //}
                    Console.WriteLine(fruit[i]);
                }

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("null error!");
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("index error!");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally has been reached!");

            }			
			
						
			/********************************************/
			/* 1-D Arrays (immutable) */				

           string[] fruit = { "Apples", "Oranges", "Grapes" };

            foreach (var item in fruit)
            {
                Console.WriteLine(item);
            }

            string[] names = new string[3];

            names[0] = "Joe";
            names[1] = "Mary";
            names[2] = "Martha";

            Console.WriteLine("");

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            int[] grades = { 12, 15, 18, 19, 20, 11, 13 };

            Console.WriteLine("Minimum of the grades is " + grades.Min());
            Console.WriteLine("Maximum of the grades is " + grades.Max());
            int sum = grades.Sum();
            Console.WriteLine("The sum is " + sum);

            double avg = grades.Average();
            Console.WriteLine("The average is " + avg.ToString("0.##"));			
			
						
			/********************************************/
			/* 2-D Arrays */				
			
            int[,] table = new int[10, 10];

            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    table[i, j] = (i + 1) * (j + 1);
                    Console.Write(table[i, j] + "\t");
                }
                Console.WriteLine("");
            }			
			
			/********************************************/
			/* Lists (mutable) */				
			
            List<string> fruits = new List<string>();

            fruits.Add("Apple");
            fruits.Add("Fig");
            fruits.Add("Orange");
            fruits.Add("Banana");

            fruits.Insert(0, "Coconut");
            fruits.Insert(2, "Banana");

            foreach (var item in fruits)
            {
                Console.WriteLine(item);
            }

            int indexOfFig = fruits.IndexOf("Fig");
            Console.WriteLine("Fig is at position " + indexOfFig);

            int firstIndexOfBanana = fruits.IndexOf("Banana");
            int lastIndexOfBanana = fruits.LastIndexOf("Banana");
            Console.WriteLine("First Banana is at position " + firstIndexOfBanana);
            Console.WriteLine("Last Banana is at position " + lastIndexOfBanana);

            fruits.Reverse();

            foreach (var item in fruits)
            {
                Console.WriteLine($"{item.ToUpper()}");
            }			
				
				
			/********************************************/
			/* Fobonacci Serie using List */							
			
            var fibboSerie = new List<int> {1, 1};
            int numEl = 20;

            while(fibboSerie.Count <= numEl)
            {
                int previous = fibboSerie[fibboSerie.Count - 1];
                int previous2 = fibboSerie[fibboSerie.Count - 2];
                fibboSerie.Add(previous + previous2);

            }

            foreach (int item in fibboSerie)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("");

			/********************************************/
			/* Dictionary */				
			
            var inventory = new Dictionary<string, double>();

            inventory.Add("Apple", 24);
            inventory.Add("Orange", 40);
            inventory.Add("Banana", 35);

            foreach (var item in inventory.Keys)
            {
                Console.WriteLine(item + ": " + inventory[item]);
            }

            string[] keysArray = inventory.Keys.ToArray();

            foreach (string item in keysArray)
            {
                Console.WriteLine($"(stringArray) {item}: {inventory[item]}");
            }

            double value;

            if (inventory.TryGetValue("Fig", out value))
            {
                Console.WriteLine("Found! price = " + value);
            }
            else
            {
                Console.WriteLine("NOT found");
            }			
			
			/********************************************/
			/*  */		

			/********************************************/
			/*  */				
			
			/********************************************/
			/*  */	

			/********************************************/
			/*  */				
			
			/********************************************/
			/*  */				
        }
		
		// call by value
        static int Add(int val1, int val2)
        {
            return val1 + val2;
        }
		
		// call by reference
        static void AddToOutParam(int val1, int val2, out int result)
        {
            result = val1 + val2;
        }		
    }
}
