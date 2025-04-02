using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabazeFilmu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Database.InitializeDatabase();
            LoadFilms();
            // Přidání filmu Forrest Gump
            //Database.AddFilm("Forrest Gump", 1994, "Drama");

        }
        private void LoadFilms()
        {
            dgv.DataSource = Database.GetFilms();
            dgv.Columns["Id"].Visible = false; // id se do tabulky vypisovat nebude
            dgv.Columns["Nazev"].HeaderText = "Název";
            dgv.Columns["Nazev"].Width = 200;
            dgv.Columns["Zanr"].HeaderText = "Žánr";
            dgv.Columns["Rezie"].HeaderText = "Režie";
            dgv.Columns["Hodnoceni"].HeaderText = "Hodnocení"; 
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                int movieId = Convert.ToInt32(dgv.SelectedRows[0].Cells["Id"].Value);

                var confirmResult = MessageBox.Show("Opravud chcete vymazat tento film z databáze?",
                                                    "Confirm Deletion",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    Database.DeleteFilm(movieId);
                    LoadFilms();
                }
            }
            else
            {
                MessageBox.Show("Vyberte prosím film, který chcete smazat.", "Je nutno vybrat film!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add addForm = new Add();
            addForm.ShowDialog();
            LoadFilms(); // Aktualizace dgv po zavření okna
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                int movieId = Convert.ToInt32(dgv.SelectedRows[0].Cells["Id"].Value);
                string nazev = dgv.SelectedRows[0].Cells["Nazev"].Value.ToString();
                int rok = Convert.ToInt32(dgv.SelectedRows[0].Cells["Rok"].Value);
                string zanr = dgv.SelectedRows[0].Cells["Zanr"].Value.ToString();
                string rezie = dgv.SelectedRows[0].Cells["Rezie"].Value.ToString();
                double hodnoceni = Convert.ToDouble(dgv.SelectedRows[0].Cells["Hodnoceni"].Value); 

                // Předání všech hodnot do formuláře Edit
                Edit editForm = new Edit(movieId, nazev, rok, zanr, rezie, hodnoceni);
                editForm.ShowDialog();
                LoadFilms(); // Aktualizace dgv po editaci
            }
            else
            {
                MessageBox.Show("Vyberte prosím film, který chcete editovat.", "Je nutno vybrat film!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
