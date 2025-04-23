using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacija
{
    public partial class Posudbe : Form
    {
        public Posudbe()
        {
            InitializeComponent();
            PrikaziPosudbe();
        }

        private void PrikaziPosudbe()
        {
            lstPosudbe.Items.Clear();
            foreach (Knjiga_Klasa knjiga in BibliotekaData.Knjige)

            {
                string linija = $"{posudba.Korisnik} \t {posudba.Knjiga.Naslov} \t {posudba.Datum:dd.MM.yyyy}";
                lstPosudbe.Items.Add(linija);
            }
        }

        private void lstPosudbe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
