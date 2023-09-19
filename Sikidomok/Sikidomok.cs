using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    internal class Sikidomok
    {
        string Nev;
        int Aoldal;
        int Boldal;

        public Sikidomok(string nev, int aoldal, int boldal)
        {
            this.Nev = nev;
            this.Aoldal = aoldal;
            this.Boldal = boldal;
        }

        public void Megoldas()
        {
            Console.WriteLine("A sikidomok:" + Aoldal + "" + Boldal);
        }
    }
}
