using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAsa_4
{
    internal class Cerchio
    {
        public int Raggio { get; set; }
        public double Area()
        {
            return Raggio * Raggio * Math.PI;
        }

        public double Circonferenza()
        { 
        return 2* Raggio * Math.PI;
        }

        public override string ToString() {
            return string.Format("Cerchio di raggio {0}", Raggio);
        }
    }
}
