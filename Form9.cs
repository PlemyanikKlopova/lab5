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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form10_dop main = this.Owner as Form10_dop;
            if (main != null)
            {
                DataRow nRow = main._ИС_завода_для_с_DataSet.Tables[2].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;
                nRow[3] = dateTimePicker1.Text;
                nRow[2] = textBox3.Text;
                main._ИС_завода_для_с_DataSet.Tables[2].Rows.Add(nRow);
                main.доставкаTableAdapter.Update(main._ИС_завода_для_с_DataSet.Доставка);
                main._ИС_завода_для_с_DataSet.Tables[2].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
                dateTimePicker1.Text = "";
                textBox3.Text = "";
            }
        }

        
    }
}
