using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oktobar2015;

namespace Konzolna
{
    public class Student:Osoba
    {
        string brojIndeksa;//smer_godina_broj
        List<Ispit> spisakIspita = new List<Ispit>();

        public Student(string brojIndeksa, List<Ispit> spisakIspita,string ime, int jmbg) : base(ime, jmbg)
        {
            this.brojIndeksa = brojIndeksa;
            this.spisakIspita = spisakIspita;
        }

        public string BrojIndeksa
        {
            get
            {
                return brojIndeksa;
            }

            set
            {
                brojIndeksa = value;
            }
        }

        public List<Ispit> SpisakIspita
        {
            get
            {
                return spisakIspita;
            }

            set
            {
                spisakIspita = value;
            }
        }

        public string prvaMetoda(int god)
        {
            string pom = "";

            string[] niz = brojIndeksa.Split('_');
            if (int.Parse(niz[1]) == god)
            {
                pom = "JESTE";
            }
            else
            {
                pom = "NIJE";
            }
            return pom;

        }

        public int drugaMetoda() //najveca ocena nekog studenta u trecoj godini
        {
            int najveca = 5;

            foreach (Ispit i in spisakIspita)
            {
                if(i.Predmet.Godina == 3)
                {
                    if (i.Ocena > najveca)
                    {
                        najveca = i.Ocena;
                    }
                }
            }


            return najveca;

        }

        public string trecaMetoda(Predmet p)
        {
            string pom = "";
            foreach (Ispit i in spisakIspita)
            {
                if (i.Predmet.Equals(p)&& i.Ocena>5)
                {
                    pom = "jeste";
                }
                else
                {
                    pom = "nije";
                }
            }
            return pom;
        }

        public int cetvrtaMetoda(string prof)
        {
            int br = 0;
            foreach (Ispit i in spisakIspita)
            {
                if (i.Predmet.Profesor.Equals(prof))
                {
                    br++;
                }
            }
            return br;
        }

        public string petaMetoda()
        {
            List<string> spisakProfesora = new List<string>();
            foreach (Ispit i in spisakIspita)
            {
                if (!spisakProfesora.Contains(i.Predmet.Profesor))
                {
                    spisakProfesora.Add(i.Predmet.Profesor);
                }
            }

            string pom = "";

            foreach (string  s in spisakProfesora)
            {
                pom +=s;
            }

            return pom;
        }

        public List<DateTime> sestaMetoda()
        {
            List<DateTime> datumi = new List<DateTime>();

            foreach (Ispit i in spisakIspita)
            {
                datumi.Add(i.Datum);
            }
            return datumi;
        }

        public List<Predmet> sedmaMetoda()
        {
            List<Predmet> predmeti = new List<Predmet>();
            foreach (Ispit i in spisakIspita)
            {
                if (!predmeti.Contains(i.Predmet))
                {
                    predmeti.Add(i.Predmet);
                }
            }
            return predmeti;
        }
        static void Main(string[] args)
        {
        }
    }
}
