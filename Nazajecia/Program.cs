using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nazajecia
{
    class Program
    {
        static void Main(string[] args)
        {
            Mezczyzna men = new Mezczyzna("Adolf Hitler", 33, false);
            Kobieta wom = new Kobieta("Ewa Braun", 30, false);
            wom.Marriage(men);
            Console.WriteLine(men.ToString());
            Console.ReadKey();
        }
    }
}
