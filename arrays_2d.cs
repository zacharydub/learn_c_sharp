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
        int [,] numberGrid = {
         {1,2},
         {3,4},
         {5,6}
        };

        Console.WriteLine(numberGrid[0,0]); // 1
        Console.WriteLine(numberGrid[1,1]); // 4

        int [,] myArray = new int[2,3];//2 rows (elements) and 3 columns (each element has 3 elements inside it)
    }
  }
} 