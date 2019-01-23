using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.OOP
{
    class Persegipanjang : Bangun2D
    {
        private double panjang;
        private double tinggip;

        public Persegipanjang(double p, double i)
        {
            this.panjang = p;
            this.tinggip = i;
        }

        public override double HitungLuas()
        {
            return (panjang * tinggip);
        }
    }
}
