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
        for(int i = 1;i <= 5; i++){
            Console.Write(i);
        }

        int[] nums = {1,2,3,4,5};
        for(int i = 0;i < nums.Length;i++){
            Console.WriteLine(nums[i]);
        }
    }
  }
}