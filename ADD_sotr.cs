﻿using System;
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
    public partial class ADD_sotr : Form
    {
        public ADD_sotr()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 main = this.Owner as Form7;
            if (main != null)
            {
                DataRow nRow = main._ИС_завода_для_с_DataSet.Tables[10].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;
                nRow[2] = textBox2.Text;
                nRow[3] = textBox3.Text;
                nRow[4] = dateTimePicker1.Text;
                nRow[5] = textBox5.Text;
                main._ИС_завода_для_с_DataSet.Tables[10].Rows.Add(nRow);
                main.сотрудникиTableAdapter.Update(main._ИС_завода_для_с_DataSet.Сотрудники);
                main._ИС_завода_для_с_DataSet.Tables[10].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                dateTimePicker1.Text = "";
                textBox5.Text = "";
            }
        }
    }
}
