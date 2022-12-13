using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    class Zaznam
    {
        public string Jmeno { get; set; }

        public string Prijmeni { get; set; }

        public int Vek { get; set; }


        public int Telefon { get; set; }


        public Zaznam(string jmeno, string prijmeni, int vek, int telefon)
        {
            this.Jmeno = jmeno;
            this.Prijmeni = prijmeni;
            this.Vek = vek;
            this.Telefon = telefon;
        }

       
        public override string ToString()
        {
            return Jmeno + "\t" + Prijmeni + "\t" + Telefon + "\t" + Vek;
        }
    }
}
