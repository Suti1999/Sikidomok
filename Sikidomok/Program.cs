using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Sikidomok> sikidomok=new List<Sikidomok>();
            Sikidomok kor = new Sikidomok("Kör",10,20);
            Sikidomok teglalap = new Sikidomok("Téglalap", 30,20);
            Sikidomok negyzet = new Sikidomok("Négyzet",20,10);

            kor.Megoldas();
            teglalap.Megoldas();
            negyzet.Megoldas();
        }
    }
}
