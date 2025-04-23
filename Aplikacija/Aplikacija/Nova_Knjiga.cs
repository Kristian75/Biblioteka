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
    public partial class Nova_Knjiga : Form
    {
        public Nova_Knjiga()
        {
            InitializeComponent();
        }

        private void btnDodajKnjigu_Click(object sender, EventArgs e)
        {
            string naslov = txtNaslov.Text.Trim();
            string inventar = txtInventarniBroj.Text.Trim();

            if (naslov == "" || inventar == "")
            {
                MessageBox.Show("Sva polja su obavezna!");
                return;
            }

            var knjiga = new Knjiga_Klasa
            {
                Naslov = naslov,
                InventarniBroj = inventar,
                BrojPrimjeraka = 3  // hardkodirano po slici
            };

            BibliotekaData.Knjige.Add(knjiga);
            MessageBox.Show("Knjiga dodana!");
            txtNaslov.Clear();
            txtInventarniBroj.Clear();
        }
    }
}
