using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("chef makes chicken");
        }
        public void MakeSalad()
        {
            Console.WriteLine("chef makes salad");
        }
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("chef makes special dish");
        }
    }
}
