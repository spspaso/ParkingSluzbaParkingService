using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSluzba
{
    internal class Karta
    {
        public string telefon;
        public string zona;
        public Vozilo vozilo;
        private int v1;
        private int v2;

        public bool Uplata(double iznos)
        {
            throw new System.NotImplementedException();
        }

        public bool Isplata(double iznos)
        {
            throw new System.NotImplementedException();
        }
        
        public Karta(string telefon, string zona) // vazno da konsturktor definise vrednosi sa this. iz parametara ()
        {
            this.telefon = telefon;
            this.zona = zona;
        }
        public Karta(string telefon, string zona, Vozilo vozilo1)
        {
            this.telefon = telefon;
            this.zona = zona;
            this.vozilo = vozilo1;
        }

        public Karta(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}
