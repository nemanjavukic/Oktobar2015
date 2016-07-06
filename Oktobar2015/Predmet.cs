using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oktobar2015
{
    public class Predmet
    {
        int godina;
        string naziv;
        string profesor;

        public Predmet(int godina,string naziv,string profesor)
        {
            this.godina = godina;
            this.naziv = naziv;
            this.profesor = profesor;

        }

        public int Godina
        {
            get
            {
                return godina;
            }

            set
            {
                godina = value;
            }
        }

        public string Naziv
        {
            get
            {
                return naziv;
            }

            set
            {
                naziv = value;
            }
        }

        public string Profesor
        {
            get
            {
                return profesor;
            }

            set
            {
                profesor = value;
            }
        }
    }
}
