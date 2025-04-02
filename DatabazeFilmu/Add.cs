using System;
using System.Windows.Forms;

namespace DatabazeFilmu
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void btnAddFilm_Click(object sender, EventArgs e)
        {
            string nazev = txtFilmName.Text;
            string rokText = txtFilmYear.Text;
            string zanr = comboBoxGenre.SelectedItem.ToString();
            string rezie = txtDirector.Text;
            decimal hodnoceni = nmUpDownRating.Value;  

            if (string.IsNullOrWhiteSpace(nazev) || string.IsNullOrWhiteSpace(rokText) || string.IsNullOrWhiteSpace(rezie))
            {
                MessageBox.Show("Prosím vyplňte všechna pole.", "Neplatný vstup!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(rokText, out int rok))
            {
                MessageBox.Show("Rok musí být číslo!", "Neplatný vstup!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Přidání filmu do databáze včetně hodnocení
            Database.AddFilm(nazev, rok, zanr, rezie, (double)hodnoceni);
            MessageBox.Show("Film byl úspěšně přidán!", "Přidáno.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }


    }
}
