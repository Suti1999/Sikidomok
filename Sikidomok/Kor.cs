using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    internal class Kor : Sikidomok
    {
        double Sugar;

        public Kor(string nev, int aoldal, int boldal, double sugar)
        {
            this.Sugar = sugar;
        }
    }
}
