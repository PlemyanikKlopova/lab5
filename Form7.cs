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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_завода_для_с_DataSet.Должность". При необходимости она может быть перемещена или удалена.
            this.должностьTableAdapter.Fill(this._ИС_завода_для_с_DataSet.Должность);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_завода_для_с_DataSet.Пол". При необходимости она может быть перемещена или удалена.
            this.полTableAdapter.Fill(this._ИС_завода_для_с_DataSet.Пол);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_завода_для_с_DataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this._ИС_завода_для_с_DataSet.Сотрудники);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ADD_sotr fm = new ADD_sotr();
            fm.Owner = this;
            fm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            search_sotr fm = new search_sotr();
            fm.Owner = this;
            fm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            сотрудникиBindingSource.EndEdit();
            сотрудникиTableAdapter.Update(_ИС_завода_для_с_DataSet);
        }
    }
}
