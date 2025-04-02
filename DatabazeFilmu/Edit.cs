using System;
using System.Windows.Forms;

namespace DatabazeFilmu
{
    public partial class Edit : Form
    {
        private int movieId; 

        public Edit(int id, string nazev, int rok, string zanr, string rezie, double hodnoceni)
        {
            InitializeComponent();
            movieId = id;

            txtFilmName.Text = nazev;
            txtFilmYear.Text = rok.ToString();
            txtDirector.Text = rezie;
            comboBoxGenre.Text = zanr;
            nmUpDownRating.Value = (decimal)hodnoceni;  
        }


        private void btnEditFilm_Click(object sender, EventArgs e)
        {
            string nazev = txtFilmName.Text;
            string rokText = txtFilmYear.Text;
            string zanr = comboBoxGenre.SelectedItem.ToString();
            string rezie = txtDirector.Text;
            decimal hodnoceni = nmUpDownRating.Value;  

            if (string.IsNullOrWhiteSpace(nazev) || string.IsNullOrWhiteSpace(rokText) || string.IsNullOrWhiteSpace(rezie))
            {
                MessageBox.Show("Prosím vyplňte všechny pole.", "Neplatný vstup!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(rokText, out int rok))
            {
                MessageBox.Show("Rok musí být číslo.", "Neplatný vstup!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Aktualizace filmu v databázi včetně hodnocení
            Database.UpdateFilm(movieId, nazev, rok, zanr, rezie, (double)hodnoceni);
            MessageBox.Show("Film uspěšně uprave!", "Upraveno.", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }


    }
}
