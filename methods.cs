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
        SayHi("Zach", 32); //only code inside Main method gets run automatically, need to call other methods
        SayHi("Jim",12);

        Console.WriteLine(cube(5));

        int cubedNumber = cube(5);
        Console.WriteLine(cubedNumber);
    }

    //when creating a new method, we need to tell C# some things- first static, then return type (void means wont return any info)
    static void SayHi(string name, int age)
    {
        Console.WriteLine("Hello "+ name + " you are "+ age);
    }

    //using return statement

    static int cube(int num)
    {
        int result = Math.Pow(2,3);
        return result;
    }

     static int[] cube(int num)
    {
        int[] result = {1,2,3};
        return result;
    }
    
  }
}