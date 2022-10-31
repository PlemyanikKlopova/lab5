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
    public partial class ADD__sale : Form
    {
        public ADD__sale()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 main = this.Owner as Form8;
            if (main != null)
            {
                DataRow nRow = main._ИС_завода_для_с_DataSet.Tables[7].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;
                nRow[2] = dateTimePicker1.Text;
                nRow[3] = textBox2.Text;
                nRow[4] = textBox3.Text;
               
                main._ИС_завода_для_с_DataSet.Tables[7].Rows.Add(nRow);
                main.продажа_напиткаTableAdapter.Update(main._ИС_завода_для_с_DataSet.Продажа_напитка);
                main._ИС_завода_для_с_DataSet.Tables[7].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                dateTimePicker1.Text = "";
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
