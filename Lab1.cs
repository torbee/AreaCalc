using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
            string input3 = "y";
            while (input3 == "y")
            {
                Console.WriteLine("Enter Length: ");
                string input1 = Console.ReadLine();
                float length = float.Parse(input1);

                Console.WriteLine("Enter Width: ");
                string input2 = Console.ReadLine();
                float width = float.Parse(input2);

                float area = length * width;
                Console.WriteLine("Area: " + area);

                float perimeter = (length * 2) + (width * 2);
                Console.WriteLine("Perimeter: " + perimeter);

                Console.WriteLine("Continue? Y/N:");
                input3 = Console.ReadLine();
            }
        }
    }
}
