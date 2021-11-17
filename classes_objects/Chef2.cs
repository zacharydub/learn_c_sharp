using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
   class Chef2 : Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("chef2 makes pasta");
        }
        public override void MakeSpecialDish()
        {
            Console.WriteLine("chef2 makes special dish2");
        }
    }
}
