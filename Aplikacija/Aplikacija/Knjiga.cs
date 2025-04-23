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
    public partial class Knjiga : Form
    {
        public Knjiga()
        {
            InitializeComponent();
            PrikaziKnjige();
        }

        private void PrikaziKnjige()
        {
            lstKnjige.Items.Clear();
            foreach (var knjiga in BibliotekaData.Knjige)
            {
                lstKnjige.Items.Add($"{knjiga.Naslov}\t {knjiga.BrojPrimjeraka}\t {knjiga.Posudeno}");
            }
        }

        private void txtPretragaKnjiga_TextChanged(object sender, EventArgs e)
        {
            string pojam = txtPretragaKnjiga.Text.ToLower();
            lstKnjige.Items.Clear();

            foreach (Knjiga_Klasa knjiga in BibliotekaData.Knjige)
            {
                if (knjiga.Naslov.ToLower().Contains(pojam))
                {
                    lstKnjige.Items.Add($"{knjiga.Naslov}\t {knjiga.BrojPrimjeraka}\t {knjiga.Posudeno}");
                }
            }
        }
    }
}
