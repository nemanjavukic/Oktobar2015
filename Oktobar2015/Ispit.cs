using System;


namespace Oktobar2015
{
    public enum IspitniRok{ JAN, FEB, JUN, SEPT, OKT };
    public class Ispit
    {
        Predmet predmet;
        DateTime datum;
        IspitniRok rok;
        int ocena;

        public Ispit(Predmet predmet,DateTime datum,IspitniRok rok,int ocena)
        {
            this.predmet = predmet;
            this.datum = datum;
            this.rok = rok;
            this.ocena = ocena;
        }

        public Predmet Predmet
        {
            get
            {
                return predmet;
            }

            set
            {
                predmet = value;
            }
        }

        public DateTime Datum
        {
            get
            {
                return datum;
            }

            set
            {
                datum = value;
            }
        }

        public IspitniRok Rok
        {
            get
            {
                return rok;
            }

            set
            {
                rok = value;
            }
        }

        public int Ocena
        {
            get
            {
                return ocena;
            }

            set
            {
                ocena = value;
            }
        }
    }
}
