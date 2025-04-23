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
    public partial class Korisnici : Form
    {
        public Korisnici()
        {
            InitializeComponent();
            PrikaziKorisnike();
        }

        private void PrikaziKorisnike()
        {
            lstKorisnici.Items.Clear();
            foreach (var k in BibliotekaData.Korisnici)
            {
                string knjige = string.Join(", ", k.PosudeneKnjige.Select(knjiga => knjiga.Naslov));
                lstKorisnici.Items.Add($"{k} \t {knjige}");
            }
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            string pojam = txtPretraga.Text.ToLower();
            lstKorisnici.Items.Clear();

            foreach (Knjiga_Klasa knjiga in BibliotekaData.Knjige)
            {
                if (k.Ime.ToLower().Contains(pojam) || k.Email.ToLower().Contains(pojam))
                {
                    string knjige = string.Join(", ", k.PosudeneKnjige.Select(knjiga => knjiga.Naslov));
                    lstKorisnici.Items.Add($"{k} \t {knjige}");
                }
            }
        }
    }
}
