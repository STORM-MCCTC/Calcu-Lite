using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcu_Lite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("Input First Number: ");
                string StrNum1 = Console.ReadLine();
                if (StrNum1 == ""){ break; }
                Console.WriteLine("Input Second Number: ");
                string StrNum2 = Console.ReadLine();
                if (StrNum2 == "") { break; }
                Console.WriteLine("Input Operation | + | - | * | / |: ");
                string op = Console.ReadLine();
                if (op == ""){ break; }

                int IntNum1 = int.Parse(StrNum1);
                int IntNum2 = int.Parse(StrNum2);

                if (op == "+") { add(IntNum1, IntNum2); }
                else if (op == "-") { subtract(IntNum1, IntNum2); }
                else if (op == "*") { multiply(IntNum1, IntNum2); }
                else if (op == "/") { divide(IntNum1, IntNum2); }
                else { Console.WriteLine("Invaild Operation"); }
            }

        }
        static void add(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("Sum: " + result);
        }

        static void subtract(int num1, int num2)
        {
            int result = num1 - num2;
            Console.WriteLine("Difference: " + result);
        }

        static void multiply(int num1, int num2)
        {
            int result = num1 * num2;
            Console.WriteLine("Product: " + result);
        }

        static void divide(int num1, int num2)
        {
            if (num2 != 0)
            {
                double result = (double)num1 / num2; // Cast to double for decimals
                Console.WriteLine("Quotient: " + result);
            }
            else
            {
                Console.WriteLine("Error: Divided by Zero");
            }
        }
    }
}
