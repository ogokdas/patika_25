using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patika_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calisan S = new calisan("memo");
            calisan2 C = new calisan2();

            Console.WriteLine(S);
            Console.WriteLine(C);
            Console.ReadLine();
        }
    }

    internal struct calisan
    {
        public string ad;

        public calisan(string isim)
        {
            ad = isim;
        }

        public override string ToString() {
            return ad;
        }


    }

    internal class calisan2
    {
        public string ad = "miyem";
        public override string ToString()
        {
            return ad;
        }


    }


}
