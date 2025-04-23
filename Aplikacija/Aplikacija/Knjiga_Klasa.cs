using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija
{
    public class Knjiga_Klasa
    {
            public string Naslov { get; set; }
            public string InventarniBroj { get; set; }
            public int BrojPrimjeraka { get; set; } = 1;
            public int Posudeno { get; set; } = 0;

            public override string ToString() => Naslov;
    }
}
