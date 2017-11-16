using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pujcovna
{
    public partial class NovyZakaznik : Form
    {
        public NovyZakaznik()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Databaze.Zakaznici.Add(new Zakaznik(textBox1.Text, textBox2.Text, textBox3.Text));
        }
    }
}
