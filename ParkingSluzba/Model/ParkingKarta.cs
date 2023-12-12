using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSluzba.Model
{
    internal class ParkingKarta
    {
        public string telefon;
        public string zona;
        public string pocetak;
        private static int svaParkingMesta;

        static void ParkingMesta()
        {
            // Pretpostavimo da ima 10 mesta
            int svaParkingMesta = 10;

            // Pretpostavimo da su trenutno 3 mesta zauzeta
            int zauzetaParkingMesta = 3;

            // proverava da li je bar jedno slobodno mesto

            if (svaMesta(svaParkingMesta, zauzetaParkingMesta))
            {
                Console.WriteLine("Ovde ima slobodno parking mesto. Mozete parkirati Vase vozilo.");
            }
            else
            {
                Console.WriteLine("Oprostite, sva parking mesta su zauzeta. Molim Vas da pokusate ponovo kasnije.");
            }
        }

        private static bool svaMesta(int svaParkingMesta, int zauzetaParkingMesta)
        {
            throw new NotImplementedException();
        }

        static bool ImaSlobodnihParkingMestace(int svaMesta, int zauzetaMesta)
        {
            // racuna broj slobodnih mesta
            int slobodnaMesta = svaParkingMesta - zauzetaMesta;

            // proverava da li je bar jedno slobodno mesto
            return slobodnaMesta > 0;
        }
    } 

}
