using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie
{
    public partial class Form1 : Form
    {
        private Liczby dane = new Liczby();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            double liczba;

            if (double.TryParse(txtLiczba.Text, out liczba))
            {
                dane.Dodaj(liczba);
                lstLiczby.Items.Add(liczba);
                txtLiczba.Clear();

            }
            else
            {
                MessageBox.Show("Błędna dana!");
            }
        }

        private void btnOblicz_Click(object sender, EventArgs e)
        {
            if (dane.Ilosc() == 0)
            {
                MessageBox.Show("Najpierw dodaj przynajmniej jedną liczbę!");
                return;

            }

            lblMax.Text = "Max: " + dane.Maksimum();
            lblMin.Text = "Min: " + dane.Minimum();
            lblSuma.Text = "Suma: " + dane.Suma();
            lblSrednia.Text = "Średnia: " + dane.Srednia();
        }
        private void txtLiczba_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
