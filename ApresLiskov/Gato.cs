using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApresLiskov
{
    internal class Gato : Animal
    {
        public override void Comer()
        {
            Console.WriteLine("Gato esta comendo");
        }
    }
}
