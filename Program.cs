using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

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
                    Addition();
                    break;
                case 2:
                    Subtraction();
                    break;
                case 3:
                    Multiplication();
                    break;
                case 4:
                    Division();
                    break;
                default:
                    Console.WriteLine("Please enter a valid selection\n");
                    Menu();
                    break;
            }
        }

        public static void Addition()
        {
            var sum = 0;
            Console.WriteLine("\nWelcome to the addition section\n");
            Console.WriteLine("Enter numbers seperated by a comma and I will give you the sum\n");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error");
                return;
            }

            foreach (var number in input.Split(','))
            {
                var convertedNumber = Convert.ToInt32(number);
                sum = sum += convertedNumber;


            }

            foreach (var number in input.Split(','))
            {
                Console.Write("{0} + ", number);
            }
            Console.WriteLine("\n{0}\n", sum);


            Menu();
        }

        public static void Subtraction()
        {
            Console.WriteLine("\nWelcome to the subtraction section\n");
            Console.WriteLine("Enter the number you would like to subtract from");
            var firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the amount you would like subtract");
            var secondNumber = Convert.ToInt32(Console.ReadLine());
            var total = (firstNumber - secondNumber);

            Console.WriteLine("\n{0} - {1} = {2} \n", firstNumber, secondNumber, total);

            Menu();

        }

        public static void Multiplication()
        {
            List<int> intList = new List<int>();
            var num = 1;
            Console.WriteLine("\nWelcome to the multiplication section\n");
            Console.WriteLine("Enter the first number you want to multiply");
            var input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number you want to multiply");
            var input2 = Convert.ToInt32(Console.ReadLine());
            var total = (input * input2);
            Console.WriteLine("{0} X {1} = {2}\n", input, input2, total);

            Menu();
        }

        public static void Division()
        {
            Console.WriteLine("\nWelcome to the division section\n");
            Console.WriteLine("Enter the numerator");
            var numerator = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the denominator");
            var denominator = Convert.ToInt32(Console.ReadLine());
            var product = (numerator / denominator);
            Console.WriteLine("\n{0} / {1} = {2}\n", numerator, denominator, product);

            Menu();
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
