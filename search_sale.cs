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
    public partial class search_sale : Form
    {
        public search_sale()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 main = this.Owner as Form8;
            if (main != null)
            {
                for (int i = 0; i < main.dataGridView1.RowCount; i++)
                {
                    main.dataGridView1.Rows[i].Selected = false;
                    for (int j = 0; j < main.dataGridView1.ColumnCount; j++)
                        if (main.dataGridView1.Rows[i].Cells[j].Value != null)
                            if (main.dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(tbstr.Text))
                            {
                                main.dataGridView1.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

