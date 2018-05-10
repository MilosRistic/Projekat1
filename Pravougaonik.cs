using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Termin10Primer01
{
    public class Pravougaonik
    {
        // Stranice pravougaonika
        public double x { set; get; }
        public double y { set; get; }

        // Konstruktor
        public Pravougaonik(double xArg, double yArg)
        {
            x = xArg;
            y = yArg;
        }

        // Provera da li je ovaj pravogaonik kvadrat
        public bool DaLiJeKvadrat()
        {
            if (x == y)
                return true;
            else
                return false;
        }
        // Metode koje vrse neki racun
        public double IzracunajPovrsinu()
        {
            return x * y;
        }
        public double IzracunajObim()
        {
            return x + y + z;
        }
    }
}
