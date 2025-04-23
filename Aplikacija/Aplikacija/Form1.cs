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
    public partial class Novi_korisnik : Form
    {
        public Novi_korisnik()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDodajKorisnika_Click(object sender, EventArgs e)
        {
            string ime = txtIme.Text.Trim();
            string email = txtEmail.Text.Trim();
            string clanskiID = txtClanskiID.Text.Trim();

            if (ime == "" || email == "" || clanskiID == "")
            {
                MessageBox.Show("Sva polja su obavezna!");
                return;
            }

            var korisnik = new Korisnik
            {
                Ime = ime,
                Email = email,
                ClanskiID = clanskiID
            };

            BibliotekaData.Korisnici.Add(korisnik);
            MessageBox.Show("Korisnik dodan!");
            txtIme.Clear();
            txtEmail.Clear();
            txtClanskiID.Clear();
        }

        private void btnNovaKnjiga_Click(object sender, EventArgs e)
        {
            var forma = new Nova_Knjiga();
            forma.ShowDialog();
        }

        private void btnPosudba_Click(object sender, EventArgs e)
        {
            var forma = new Posudba_Vracanje();
            forma.ShowDialog();
        }

        private void btnKorisnici_Click(object sender, EventArgs e)
        {
            var forma = new Korisnici();
            forma.ShowDialog();
        }

        private void btnKnjige_Click(object sender, EventArgs e)
        {
            var forma = new Knjiga();
            forma.ShowDialog();
        }

        private void btnPosudbe_Click(object sender, EventArgs e)
        {
            var forma = new Posudbe();
            forma.ShowDialog();
        }
    }
}
