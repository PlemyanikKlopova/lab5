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
    public partial class Form9_dop : Form
    {
        public Form9_dop()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                Form4 main = this.Owner as Form4;
                if (main != null)
                {
                    DataRow nRow = main._ИС_завода_для_с_DataSet.Tables[5].NewRow();
                    int rc = main.dataGridView1.RowCount + 1;
                    nRow[0] = rc;
                    nRow[1] = textBox1.Text;
                    nRow[2] = dateTimePicker1.Text;
                    nRow[3] = textBox3.Text;
                    main._ИС_завода_для_с_DataSet.Tables[5].Rows.Add(nRow);
                    main.напитокTableAdapter.Update(main._ИС_завода_для_с_DataSet.Напиток);
                    main._ИС_завода_для_с_DataSet.Tables[5].AcceptChanges();
                    main.dataGridView1.Refresh();
                    textBox1.Text = "";
                    dateTimePicker1.Text = "";
                    textBox3.Text = "";
                }
        }

       
    }
}

