using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApresLiskov
{
    internal class Animal
    {
        public virtual void Comer()
        {
            Console.WriteLine("Animal esta comendo");
        }
    }
}
