using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija
{
    public class Korisnik
    {
        public string Ime { get; set; }
        public string Email { get; set; }
        public string ClanskiID { get; set; }
        public List<Knjiga_Klasa> PosudeneKnjige { get; set; } = new List<Knjiga_Klasa>();

        public override string ToString() => $"{Ime} {Email}#{ClanskiID}";
    }

}
