using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.OOP
{
    class Segitiga : Bangun2D
    {
        private double alas;
        private double tinggis;

        public Segitiga(double a, double t)
        {
            this.alas = a;
            this.tinggis = t;
        }

        public override double HitungLuas()
        {
            return (alas * tinggis /2);
        }
    }
}
