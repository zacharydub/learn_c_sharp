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
        try{
      Console.Write("Enter num:");
      int num1 = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter num:");
      int num2 = Convert.ToInt32(Console.ReadLine());
      
      Console.WriteLine(num1 / num2);
        }
        // catch{
        //     Console.WriteLine("error");
        // }
        catch(Exception e){
            Console.WriteLine(e.Message);//attempted to divide by zero || input string not in corrcet format
        }
        catch(DivideByZeroException e){
            Console.WriteLine(e.Message);//attempted to divide by zero
        }
        catch(FormatException e){
            Console.WriteLine(e.Message);//input string not in corrcet format
        }
        finally{
            //this code always gets executed no matter what
            
        }
    }
  }
}