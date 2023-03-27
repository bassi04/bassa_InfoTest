using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bassa_InfoTest
{
    public abstract class bassa_Disocupato : bassa_Candidato
    {
        private int bassa_voto;
        private bool bassa_lode;

        public int bassa_Voto { get { return bassa_voto; } private set { if (bassa_voto <= 110) { bassa_voto = value; } } }
        public bool bassa_Lode { get { return bassa_lode; } private set { bassa_lode = value; } }

        public bassa_Disocupato( ) 
        {
            bassa_Voto = 0;
            bassa_Lode = false;
        }
        public bassa_Disocupato(int bassa_voto, bool bassa_lode)
        {
            bassa_Voto=bassa_voto;
            bassa_Lode=bassa_lode;
        }

        public override int punteggio() 
        {
            int b = (bassa_Voto + 100) / 110;
            if (bassa_Lode == true)
                b += 5;
            return b;
        }

        public override bool isldoneo()
        {
            if(punteggio()>=72)
            {
                return true;
            }
        }

        public override string ToString()
        {
            string a = bassa_Voto + "," + bassa_Lode+",";
            return a;
        }

        public bool Equals(bassa_Disocupato a)
        {
            if (a == null)
                return false;

            if (this == a)
                return true;

            if (this.bassa_Voto == a.bassa_Voto || bassa_Lode == a.bassa_Lode)
                return true;

            else
                return false;
        }
        public override int HashCode()
        {
            int hash = 17;
            hash = hash * 23 + bassa_Voto.GetHashCode();
            hash = hash * 23 + bassa_Lode.GetHashCode();
            return hash;
        }
    }
}
 