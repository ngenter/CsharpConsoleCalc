using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpConsoleCalculator;

namespace CsharpConsoleCalculator
{
    class Calculator
    {
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


            Program.Menu();
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

            Program.Menu();

        }

        public static void Multiplication()
        {
            List<int> intList = new List<int>();
            Console.WriteLine("\nWelcome to the multiplication section\n");
            Console.WriteLine("Enter the first number you want to multiply");
            var input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number you want to multiply");
            var input2 = Convert.ToInt32(Console.ReadLine());
            var total = (input * input2);
            Console.WriteLine("{0} X {1} = {2}\n", input, input2, total);

            Program.Menu();
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

            Program.Menu();
        }

        public static void Modulus()
        {
            Console.WriteLine("\nthis is the modulus section\n");
            Console.WriteLine("Enter the first number");
            var input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter the second number");
            var input2 = Convert.ToInt32(Console.ReadLine());
            var modulus = (input1 % input2);
            Console.WriteLine("Remainder is {0}\n", modulus);

            Program.Menu();
        }
    }
}
