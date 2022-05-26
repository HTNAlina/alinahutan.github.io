using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Carte
    {
        private const string SEPARATOR_AFISARE = " ";
        private const char SEPARATOR_PRINCIPAL_FISIER = ',';
        private const char SEPARATOR_SECUNDAR_FISIER = ' ';

        public int IDcarte { get; set; }
        public static int ID;
        public string Nume { get; set; }
        public string Autor { get; set; }
        public string Editura { get; set; }
        public int AnAparitie { get; set; }
        public GENCARTE GenCarte;
        public int NrExemplare { get; set; }
        

        public DateTime DataActualizare { get; set; }

        public bool Disponibil;

        //Constructor fara parametrii
        public Carte()
        {
            Nume = string.Empty;
            Autor = string.Empty;
            Editura = string.Empty;
            GenCarte = GENCARTE.Copii;
            AnAparitie = 0;
            NrExemplare = 0;

            IDcarte = ID;
            ID = ID + 1;
            DataActualizare = DateTime.Now;
        }

        public bool disponibilitate()
        {
            if (NrExemplare == 0)
                Disponibil = false;
            else
                Disponibil = true;
            return Disponibil;
        }

        //Constructor cu 3 parametrii
        public Carte(string _nume, string _autor, string _editura)
        {
            Nume = _nume;
            Autor = _autor;
            Editura = _editura;
            DataActualizare = DateTime.Now;
        }
        //Constructor cu parametrii 2
        public Carte(string _nume, string _autor, string _editura, int _AnAparitie, int _NrExemplare, int n)
        {
            IDcarte = ID;
            ID = ID + 1;
            Nume = _nume;
            Autor = _autor;
            Editura = _editura;
            AnAparitie = _AnAparitie;
            NrExemplare = _NrExemplare;
            GenCarte = (GENCARTE)(n);
            DataActualizare = DateTime.Now;
        }

      
        public string ComparaCarte(Carte c2)
        {
            if (this.NrExemplare > c2.NrExemplare)
                return string.Format("Cartea cu numele {0} si ID-ul {1} este in mai multe exemplare ({2})", this.Nume, this.IDcarte, this.NrExemplare);
            else
            {
                if (this.NrExemplare == c2.NrExemplare)
                { return string.Format("Cele 2 carti sunt in acelasi numar de exemplare ({0})", this.NrExemplare); }
                else
                { return string.Format("Cartea cu numele {0} si ID-ul {1} este in mai multe exemplare ({2})", c2.Nume, c2.IDcarte, c2.NrExemplare); }
            }
        }

        public bool CautareGenCarte(int opt)
        {
            if (this.GenCarte == (GENCARTE)opt)
            {
                return true;
            }
            else
                return false;
        }

        public bool CautareNume(string _nume)
        {
            if (this.Nume == _nume)
                return true;
            return false;
        }

        public Carte(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);
            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ToString()
            IDcarte = Convert.ToInt32(dateFisier[0]);
            Nume = dateFisier[1];
            Autor = dateFisier[2];
            Editura = dateFisier[3];
            AnAparitie = Int32.Parse(dateFisier[4]);
            NrExemplare = Int32.Parse(dateFisier[5]);
            GenCarte = (GENCARTE)Convert.ToInt32(dateFisier[6]);
        }


        public string Info()
        {
            return string.Format("{0} {1} {2} {3} {4} exemplare ( are ID-ul : {5}).", Nume, Autor, Editura, AnAparitie, NrExemplare, IDcarte);
        }

        public string ConversieLaSir_PentruFisier()
        {
            return string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}{0}{9}", ',', IDcarte, Nume, Autor, Editura, AnAparitie, NrExemplare, Convert.ToInt32(GenCarte), DataActualizare);
        }

      
    }
}
