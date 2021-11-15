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

      string characterName = "Zach";
      int characterAge;
      characterAge = 32;

      Console.WriteLine("There once was a man named " + characterName);
      Console.WriteLine("He was " + characterAge + " years old");

      characterName="Mike";
      Console.WriteLine("he really liked the name "+ characterName);
      Console.WriteLine("but didnt really like being "+ characterAge );

      string phrase = "Academy";
      char grade = 'A';
      int age = 32;
      double gpa = 3.7;
      bool isMale = true;

    Console.ReadLine(); // this will keep popup console window up until user enters text
    }
  }
}
