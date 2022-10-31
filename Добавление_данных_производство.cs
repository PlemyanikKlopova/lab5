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
    public partial class Добавление_данных_производство : Form
    {
        public Добавление_данных_производство()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 main = this.Owner as Form5;
            if (main != null)
            {
                DataRow nRow = main._ИС_завода_для_с_DataSet.Tables[8].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;
                nRow[2] = dateTimePicker1.Text;
                main._ИС_завода_для_с_DataSet.Tables[8].Rows.Add(nRow);
                main.производство_напиткаTableAdapter.Update(main._ИС_завода_для_с_DataSet.Производство_напитка);
                main._ИС_завода_для_с_DataSet.Tables[8].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
                dateTimePicker1.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
