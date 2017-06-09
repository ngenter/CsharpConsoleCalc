using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using CsharpConsoleCalculator;

namespace CSharpConsoleCalculator
{
    class Program
    {
        public static void Menu()
        {
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division\n");
            var input = Convert.ToInt32(Console.ReadLine());
            Choice(input);

        }

        public static void Choice(int n)
        {
            switch (n)
            {
                case 1:
                    Calculator.Addition();
                    break;
                case 2:
                    Calculator.Subtraction();
                    break;
                case 3:
                    Calculator.Multiplication();
                    break;
                case 4:
                    Calculator.Division();
                    break;
                default:
                    Console.WriteLine("Please enter a valid selection\n");
                    Menu();
                    break;
            }
        }

        

        

        

        
        public static void Intro()
        {
            Console.WriteLine("Welcome to the calculator program, enter the number that corresponds with the section you want to use\n");
        }


        static void Main(string[] args)
        {
            Intro();
            Menu();


        }
    }
}
