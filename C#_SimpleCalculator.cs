using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            int v1 = new Int32();
            int v2 = new Int32();
            
            string op;
            string strVar1;
            string strVar2;

            Console.Write("Enter Value 1: ");
            strVar1 = Console.ReadLine();
            if (Int32.TryParse(strVar1, out v1))
            {
                Console.Write("Enter Value 2: ");
                strVar2 = Console.ReadLine();

                if(Int32.TryParse(strVar2, out v2))
                {
                    Console.Write("(A)dd, (S)ubtract, (D)ivide, (M)ultiply: ");
                    op = Console.ReadLine();

                    switch (op)
                    {
                        case "A":
                            {
                                AddValues(v1, v2);
                                break;
                            }
                        case "S":
                            {
                                SubtractValues(v1, v2);
                                break;
                            }
                        case "D":
                            {
                                DivideValues(v1, v2);
                                break;
                            }
                        case "M":
                            {
                                MultiplyValues(v1, v2);
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Invalid operation");
                                break;
                            }
                    }
                }

                else
                {
                    Console.WriteLine("Parsing failed!");
                }

            }
            else
            {
                Console.WriteLine("Parsing failed!");
            }


        }

        static void AddValues(int v1, int v2)
        {
            Console.WriteLine("Result: " + (v1+v2));
        }

        static void SubtractValues(int v1, int v2)
        {
            Console.WriteLine("Result: " + (v1 - v2));
        }

        static void DivideValues(int v1, int v2)
        {
            Console.WriteLine("Result: " + (v1 / v2));
        }

        static void MultiplyValues(int v1, int v2)
        {
            Console.WriteLine("Result: " + (v1 * v2));
        }


    }
}
