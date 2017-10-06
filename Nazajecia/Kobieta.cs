using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nazajecia
{
    public class Kobieta:Osoba
    {
        public Kobieta(string name, int age, bool single)
        {
            _name = name;
            _age = age;
            _single = single;
            _sex = 'f';
        }
    }
}
