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
       Console.WriteLine(GetDay(1));
    }
    static string GetDay(int dayNum){
        string dayName;

        switch (dayNum)
        {
            case 0:
                dayName ="Sunday";
                break;
            case 1:
                dayName ="Monday";
                break;
            case 2:
                dayName ="Tuesday";
                break;
            default:
                dayName = "Invalid day number";
                break;
        }

        return dayName;
    }
  }
}