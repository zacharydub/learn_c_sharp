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
        bool isMale = true;
        bool isTall = true;

        if(isMale && isTall)
        {
            Console.WriteLine("You are male and tall");
        } else if(isMale && !isTall){
            Console.WriteLine("You are a short male");
        }else if(!isMale && isTall){
            Console.WriteLine("You are not male and tall");
        }else
        {
            Console.WriteLine("You are either not male or not tall or both");
        }

        Console.WriteLine(GetMax(2,10,40));
    }
    static int GetMax(int num1, int num2, int num3)
    {
        int result;

        if(num1 > num2 && num1 > num3){
            result = num1;
        }else if(num2 > num1 && num2 > num3){
            result = num2;
        } else{
            result = num3;
        }

        return result;
    }
  }
}