using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bassa_InfoTest
{
    public abstract class bassa_lavoratore : bassa_Candidato
    {
        private int bassa_esperienze;

        public int bassa_Esperienze { get { return bassa_esperienze; } private set { if (bassa_esperienze <= 5) { bassa_esperienze = value; } } }

        public bassa_lavoratore()
        {
            bassa_esperienze = 0;
        }

        public bassa_lavoratore(int bassa_esperienze)
        {
            bassa_Esperienze = bassa_esperienze;
        }

        public override int punteggio()
        {
            int punti = bassa_Esperienze * 20;
            return punti;
            
        }

        public override bool islisldoneo()
        {
            if(punteggio()>=60)
            {
                return true;
            }
            else
                return false;
        }

        public override string ToString()
        {
            string a = bassa_Esperienze + ",";
            return a;

        }

        public bool Equals(bassa_lavoratore a)
        {
            if (a == null)
                return false;

            if (this == a)
                return true;

            if (this.bassa_Esperienze == a.bassa_Esperienze)
                return true;

            else
                return false;
        }

        public override int HashCode()
        {
             return bassa_Esperienze.GetHashCode();

        }

    }
}
