using System.ComponentModel.DataAnnotations;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("int");
            int num1 = 1;
            Console.WriteLine(num1);

            Console.WriteLine("float");
            float num2 = 3.5f;
            Console.WriteLine(num2);

            Console.WriteLine("decimal");
            decimal num3 = 2.65m; 
            Console.WriteLine(num3);

            Console.WriteLine("double");
            double num4 = 4.67;
            Console.WriteLine(num4);

            Console.WriteLine("Max");
            Console.WriteLine(Math.Max(1, 4));

            Console.WriteLine("Min");
            Console.WriteLine(Math.Min(1, 4));

            Console.WriteLine();

            Console.WriteLine("sum of two numbers");
            Console.WriteLine(1 + 1);
            Console.WriteLine("division of two numbers");
            Console.WriteLine(8 / 2);

        }
    }
}
