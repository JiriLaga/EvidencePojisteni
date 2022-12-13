using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    class Seznam
    {
        private List<Zaznam> zaznamy;

        public Seznam()
        {
            zaznamy = new List<Zaznam>();
        }

        public void PridejZaznam(string jmeno, string prijmeni, int vek, int telefon)
        {
            zaznamy.Add(new Zaznam(jmeno, prijmeni, vek, telefon));
        }

        public List<Zaznam> Vypis()
        {
            return zaznamy;
        }

        public List<Zaznam> NajdiOsobu(string jmeno, string prijmeni, bool dleJmenaaPrijmeni)
        {
            List<Zaznam> nalezene = new List<Zaznam>();
            foreach (Zaznam z in zaznamy)
            {
                if ((z.Jmeno == jmeno) && (z.Prijmeni == prijmeni)) 
                    
                    nalezene.Add(z);
            }
            return nalezene;
        }
    }
}
