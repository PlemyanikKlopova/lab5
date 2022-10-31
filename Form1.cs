using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ИС_завода
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Napit_Click(object sender, EventArgs e)
        {
            Form4 fm4 = new Form4();
            fm4.ShowDialog();
        }

        private void btn_Klien_Click(object sender, EventArgs e)
        {
            Form6 fm6 = new Form6();
            fm6.ShowDialog();
        }

        private void btn_Sotr_Click(object sender, EventArgs e)
        {
            Form7 fm7 = new Form7();
            fm7.ShowDialog();
        }

        private void btn_sale_Click(object sender, EventArgs e)
        {
            Form8 fm8 = new Form8();
            fm8.ShowDialog();
        }

        private void btn_dos_Click(object sender, EventArgs e)
        {
            Form10_dop fm10 = new Form10_dop();
            fm10.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 fm5 = new Form5();
            fm5.Show();
        }
    }
}
