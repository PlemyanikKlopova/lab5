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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void Form6_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_завода_для_с_DataSet.Заказчик". При необходимости она может быть перемещена или удалена.
            this.заказчикTableAdapter.Fill(this._ИС_завода_для_с_DataSet.Заказчик);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ADD_zakazchik fm = new ADD_zakazchik();
            fm.Owner = this;
            fm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            search_zakazchik fm = new search_zakazchik();
            fm.Owner = this;
            fm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            заказчикBindingSource.EndEdit();
            заказчикTableAdapter.Update(_ИС_завода_для_с_DataSet);
        }
    }
}
