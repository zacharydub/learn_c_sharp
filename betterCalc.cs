using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
  class Program
  {
    static void Main(string[] args)
    {
        Console.Write("Enter first number");
        double num1 = Convert.ToDouble(Console.ReadLine(""));
         Console.Write("Enter second number");
        double num2 = Convert.ToDouble(Console.ReadLine(""));

        Console.Write("Enter operator");
        string op = Console.ReadLine();

        if(op == "+")
        {
            Console.WriteLine(num1 + num2);
        } else if(op == "-"){
            Console.WriteLine(num1 - num2);
        }
        else if(op == "/"){
            Console.WriteLine(num1 / num2);
        }
        else if(op == "*"){
            Console.WriteLine(num1 * num2);
        }else{
            Console.WriteLine("invalid operator");
        }
    }
  }
}