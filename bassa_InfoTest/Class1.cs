using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bassa_InfoTest
{
    public abstract class bassa_Candidato
    {
        private int bassa_matricola;
        private string bassa_nome;
        

        public int Bassa_Matricola { get { return bassa_matricola; } private set { bassa_matricola = value; } }
        public string Bassa_nome { get { return bassa_nome; } private set { bassa_nome = value; } }

        public bassa_Candidato (int bassa_matricola, string bassa_nome)
        {
            Bassa_Matricola = bassa_matricola;
            Bassa_nome = bassa_nome;
            
        }

        public bassa_Candidato() 
        {
            Bassa_Matricola=0;
            Bassa_nome = "";
        }

        public bassa_Candidato(int bassa_matricola)
        {
            Bassa_Matricola = bassa_matricola;
            

        }

        public bassa_Candidato( string bassa_nome)
        {
            
            Bassa_nome = bassa_nome;

        }

        public abstract bool isldoneo();
        


        public abstract int punteggio();

        public abstract string ToString()
        {
            string a = Bassa_nome + "," + Bassa_Matricola + ",";
            return a;
        }

        public abstract bool Equals (bassa_Candidato a)
        {
            if (a== null)
                return false;

            if(this==a)
                return true;

            if(this.Bassa_Matricola==a.Bassa_Matricola || Bassa_nome==a.Bassa_nome)
                return true;

            else
                return false;
        }

        public abstract int HashCode()
        {
            int hash = 17;
        hash = hash * 23 + Bassa_Matricola.GetHashCode();
        hash = hash * 23 + (Bassa_nome != null ? Bassa_nome.GetHashCode() : 0);
        return hash;
        }
    }
}
