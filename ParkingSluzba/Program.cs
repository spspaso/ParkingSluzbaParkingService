using ParkingSluzba.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSluzba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Karta karta = new Karta("BrTelefona","plava zona" );
            
            Karta karta2 = new Karta("BrTelefona", "crvena zona");




            Karta[] nizKarata = new Karta[2];
            nizKarata[0] = karta;
            nizKarata[1] = karta2;


            
        




        Vozilo vozilo1 = new Vozilo("Dunja", "Rakijic", "Ford Puma", "NS343UB", nizKarata);
            // vozilo.ime = "Dunja";
            //vozilo.prezime = "Rakijic";
            //vozilo.model = "Ford Puma";
            //vozilo.brtablica = "NS343UB";

            karta.vozilo = vozilo1; // hocu da vozilo u toj karti postane Dunja Rakijic
            Console.WriteLine("Vozilo sa vlasnikom imena " + vozilo1.Ime + " i prezime " + vozilo1.Prezime
                + " je modela: " + vozilo1.Model + " i ima trenutno karti " + vozilo1.Karte.Length + " karata");

            Console.WriteLine("Stanje na prvom nizu karata: " + vozilo1.Karte[0].zona);
            Console.WriteLine("Stanje na drugom nizu karata: " + vozilo1.Karte[1].zona);

            // primer enkapsulacije 
            karta.vozilo = vozilo1;

            vozilo1.Ispis();


            Console.ReadKey();
        }
    }
}
