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

        static void Main(string[] args)
        {
        }
    }
}
