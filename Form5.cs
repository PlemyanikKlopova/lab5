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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_завода_для_с_DataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this._ИС_завода_для_с_DataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_завода_для_с_DataSet.Напиток". При необходимости она может быть перемещена или удалена.
            this.напитокTableAdapter.Fill(this._ИС_завода_для_с_DataSet.Напиток);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_завода_для_с_DataSet.Производство_напитка". При необходимости она может быть перемещена или удалена.
            this.производство_напиткаTableAdapter.Fill(this._ИС_завода_для_с_DataSet.Производство_напитка);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Добавление_данных_производство qw = new Добавление_данных_производство();
            qw.Owner = this;
            qw.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            search_create fm = new search_create();
            fm.Owner = this;
            fm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            производствонапиткаBindingSource.EndEdit();
            производство_напиткаTableAdapter.Update(_ИС_завода_для_с_DataSet);
        }
    }
}
