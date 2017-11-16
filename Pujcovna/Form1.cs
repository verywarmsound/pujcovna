using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace Pujcovna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Databaze.Inicializuj();
            skladGrid.DataSource = Databaze.Sklad;
            zakazniciGrid.DataSource = Databaze.Zakaznici;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Databaze.Sklad.Count() > 0)
            {
                int zi = zakazniciGrid.CurrentCell.RowIndex;
                int si = skladGrid.CurrentCell.RowIndex;
                Databaze.Zakaznici[zi].Vypujceno.Add(Databaze.Sklad[si]);
                Databaze.Sklad.RemoveAt(si);
            }
            else MessageBox.Show("Už není co půjčit!");
        }

        private void zakazniciGrid_SelectionChanged(object sender, EventArgs e)
        {
            int i = zakazniciGrid.CurrentCell.RowIndex;
            vypujcenoGrid.DataSource = Databaze.Zakaznici[i].Vypujceno;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int zi = zakazniciGrid.CurrentCell.RowIndex;
            if (Databaze.Zakaznici[zi].Vypujceno.Count() > 0)
            {
                int vi = vypujcenoGrid.CurrentCell.RowIndex;
                Databaze.Sklad.Add(Databaze.Zakaznici[zi].Vypujceno[vi]);
                Databaze.Zakaznici[zi].Vypujceno.RemoveAt(vi);
            }
            else MessageBox.Show("Už není co vrátit!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NovyZakaznik nz = new NovyZakaznik();
            nz.ShowDialog();
        }
    }
}
