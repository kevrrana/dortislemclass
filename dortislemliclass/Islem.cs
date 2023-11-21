using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dortislemliclass
{
    internal class Isleme
    {
        public double sayi1;
        public double sayi2;

        public double Topla()
        {
            return sayi1 + sayi2;
        }
        public double Cikarma()
        {
            return sayi2 - sayi1;
        }
        public double Carpma()
        {
            return sayi2 * sayi1;
        }
        public double Bolme()
        {
            return sayi2 / sayi1;
        }
    }
}
