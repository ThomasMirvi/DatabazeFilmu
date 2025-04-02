using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabazeFilmu
{
    public class Film
    {
        public int Id { get; set; }
        public string Nazev { get; set; }
        public int Rok { get; set; }
        public string Zanr { get; set; }
        public string Reziser { get; set; }
        public double Hodnoceni { get; set; }
    }

}
