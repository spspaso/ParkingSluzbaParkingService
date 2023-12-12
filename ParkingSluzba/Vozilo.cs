using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSluzba
{
    internal class Vozilo
    {
        public string Model { get; set; }
        private string ime;
        public string Prezime { get; set; } //interfejsni property
        public string BrTablica { get; set; }
        public Karta[] Karte { get; set; }



        public string Ime // potpun property
        {
            get { return ime; }
            set { ime = value; }
        }

        public Vozilo()
        {
            this.Model = "";
            this.BrTablica = "000000";
            this.Ime = "";
            this.Prezime = "";
            this.Karte = new Karta[5];
        }
        public Vozilo(string ime, string prezime, string mdl)  //naziv konstruktora Klijent se zove sa nazivom nase klase
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Model = mdl;          // ako se nazivi poklapaju this. je obavezeno, u suprotnom dovoljno je model = mdl;

        }
        // generisani konsturktor preko lampice 
        public Vozilo(string model, string ime, string prezime, string brtablica, Karta[] karte) : this(model, ime, prezime)
        {
            this.BrTablica = brtablica;
            this.Karte = karte;
        }

        public void Ispis()
        {
            Console.WriteLine("Vozilo u vlasnistvu ime " + this.Ime + " i prezime " + this.Prezime
                + " modela: " + this.Model + " i ima kartu " + this.Karte.Length + " karti");

            Console.WriteLine("Stanje karti : " + this.Karte[0].zona);
           


        }
    }
}
