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
        int[] luckyNumbers =  {4,8,15,16,23,42};
        luckyNumbers[1] = 900;

        string[] friends = new string[5];//need to tell C# how many values it can hold
        friends[0]='Z';
        
        Console.WriteLine(luckyNumbers[0]);
    }
  }
}