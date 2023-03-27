using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bassa_InfoTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public class ListaCandidati
        {
            private List<bassa_Candidato> candidati;
            public ListaCandidati()
            {
                candidati = new List<bassa_Candidato>();
            }

            public void AggiungiCandidato(bassa_Candidato candidato)
            {
                bassa_Candidato.Add(candidato);
            }
            public void eliminaCandidato(bassa_Candidato candidato)
            {
                bassa_Candidato.Remove(candidato);
            }
        }

        
    }
