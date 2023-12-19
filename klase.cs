using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopKoncept
{
    class Ucenik
    {
        private string ime, prezime, razred;
        private int godinaRodjenja;

        public void setIme(string ime)
        {
            this.ime = ime;
        }
        public string getIme()
        {
            return this.ime;
        }
        public void setPrezime(string prezime)
        {
            this.prezime = prezime;
        }
        public string getPrezime()
        {
            return this.prezime;
        }
        public void setRazred(string razred)
        {
            this.razred = razred;
        }
        public string getRazred()
        {
            return this.razred;
        }
        public void setGodinaRodjenja(int godinaRodjenja)
        {
            this.godinaRodjenja = godinaRodjenja;
        }
        public int getGodinaRodjenja()
        {
            return this.godinaRodjenja;
        }
        public override string ToString()
        {
            string ispis = "Ime: " + this.ime
                + "\nPrezime: " + this.prezime
                + "\nRazred: " + this.razred
                + "\nGodina rođenja: " + this.godinaRodjenja;
            return ispis;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // instanciranje novog objekta
            Ucenik ucenik = new Ucenik();

            //korisnički unos
            Console.WriteLine("Unesi ime, prezime, razred i godinu rođenja");
            string ime = Console.ReadLine();
            string prezime = Console.ReadLine();
            string razred = Console.ReadLine();
            int godinaRodjenja = Convert.ToInt32(Console.ReadLine());

            // definiranje podataka za objekt 'ucenik'
            ucenik.setIme(ime);
            ucenik.setPrezime(prezime);
            ucenik.setRazred(razred);
            ucenik.setGodinaRodjenja(godinaRodjenja);

            // ispis podataka
            Console.WriteLine(ucenik.ToString());


            Console.ReadKey();
        }
    }
}
