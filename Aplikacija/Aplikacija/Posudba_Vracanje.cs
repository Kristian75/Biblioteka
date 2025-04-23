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
    public partial class Posudba_Vracanje : Form
    {
        public Posudba_Vracanje()
        {
            InitializeComponent();
        }

        private void OsvjeziComboBoxeve()
        {
            cmbKorisnici.DataSource = null;
            cmbKorisnici.DataSource = BibliotekaData.Korisnici;
            cmbKnjige.DataSource = null;
            cmbKnjige.DataSource = BibliotekaData.Knjige;
        }

        private void btnPosudi_Click(object sender, EventArgs e)
        {
            var korisnik = cmbKorisnici.SelectedItem as Korisnik;
            var knjiga = cmbKnjige.SelectedItem as Knjiga_Klasa;

            if (korisnik == null || knjiga == null)
            {
                MessageBox.Show("Odaberite korisnika i knjigu.");
                return;
            }

            if (knjiga.BrojPrimjeraka - knjiga.Posudeno <= 0)
            {
                MessageBox.Show("Nema dostupnih primjeraka ove knjige.");
                return;
            }

            korisnik.PosudeneKnjige.Add(knjiga);
            knjiga.Posudeno++;

            BibliotekaData.Posudbe.Add(new Posudba
            {
                Korisnik = korisnik,
                Knjiga = knjiga,
                Datum = DateTime.Now
            });

            MessageBox.Show("Knjiga posuđena!");

        }

        private void btnVrati_Click(object sender, EventArgs e)
        {
            var korisnik = cmbKorisnici.SelectedItem as Korisnik;
            var knjiga = cmbKnjige.SelectedItem as Knjiga;

            if (korisnik == null || knjiga == null)
            {
                MessageBox.Show("Odaberite korisnika i knjigu.");
                return;
            }

            if (!korisnik.PosudeneKnjige.Contains(knjiga))
            {
                MessageBox.Show("Ovaj korisnik nema ovu knjigu.");
                return;
            }

            korisnik.PosudeneKnjige.Remove(knjiga);
            knjiga.Posudeno--;

            MessageBox.Show("Knjiga vraćena!");
        }
    }
}
