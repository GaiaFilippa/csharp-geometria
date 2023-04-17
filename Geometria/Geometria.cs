using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rettangolo
    {
        // ATTRIBUTI
        public int baseRettangolo;
        public int altezzaRettangolo;
        public int areaRettangolo;
        public int perimetroRettangolo;
     



        // STATI



        // COSTRUTTORE
        public Rettangolo(int baseRettangolo, int altezzaRettangolo)
        {
            this.baseRettangolo = baseRettangolo;
            this.altezzaRettangolo = altezzaRettangolo;
        }


        // METODI
        public int CalcolaArea()
        {
            int areaRettangolo = baseRettangolo * altezzaRettangolo;
            return areaRettangolo;
        }


        public int CalcolaPerimetro()
        {
            int perimetroRettangolo = baseRettangolo * 2 + altezzaRettangolo * 2;
            return perimetroRettangolo;
        }

    }
}
