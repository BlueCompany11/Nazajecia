using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nazajecia
{
    public abstract class Osoba
    {
        protected char _sex;
        protected string _name;
        protected int _age;
        protected bool _single;

        public virtual void Marriage(Osoba person)
        {
            if((_sex=='f' && person._sex=='m') || (_sex=='m' && person._sex == 'f'))
            {
                _single = false;
                person._single = false;
                Console.WriteLine("Wszystkiego dobrego na nowej drodze zycia");
            }
            else
            {
                Console.WriteLine("Tylko pary hetero");
            }
        }
        public virtual Osoba MakeBaby(Osoba person)
        {
            Random rnd = new Random();
            int roll = rnd.Next(0, 2);
            if (roll == 0)
            {
                Kobieta wom = new Kobieta(_name, 0, true);
                Console.WriteLine("To dziewczynka!");
                return wom;
            }
            else
            {
                Mezczyzna men = new Mezczyzna(_name, 0, true);
                Console.WriteLine("To chlopiec!");
                return men;
            }
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"Nazwisko: {_name}");
            builder.AppendLine($"Wiek: {_age}");
            builder.AppendLine($"Samotny?: {_single}");
            return builder.ToString();
        }
    }
}
