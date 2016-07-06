using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oktobar2015;

namespace Konzolna
{
    public class Osoba
    {
        protected string ime;
        protected int jmbg;

        public virtual Osoba(string ime, int jmbg)
        {
            this.ime = ime;
            this.jmbg = jmbg;
        }

        public string Ime
        {
            get
            {
                return ime;
            }

            set
            {
                ime = value;
            }
        }

        public int Jmbg
        {
            get
            {
                return jmbg;
            }

            set
            {
                jmbg = value;
            }
        }
    }
}
