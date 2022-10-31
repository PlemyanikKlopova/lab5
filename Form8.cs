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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_завода_для_с_DataSet.Заказчик". При необходимости она может быть перемещена или удалена.
            this.заказчикTableAdapter.Fill(this._ИС_завода_для_с_DataSet.Заказчик);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_завода_для_с_DataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this._ИС_завода_для_с_DataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_завода_для_с_DataSet.Напиток". При необходимости она может быть перемещена или удалена.
            this.напитокTableAdapter.Fill(this._ИС_завода_для_с_DataSet.Напиток);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_завода_для_с_DataSet.Продажа_напитка". При необходимости она может быть перемещена или удалена.
            this.продажа_напиткаTableAdapter.Fill(this._ИС_завода_для_с_DataSet.Продажа_напитка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_завода_для_с_DataSet.Заказчик". При необходимости она может быть перемещена или удалена.
            this.заказчикTableAdapter.Fill(this._ИС_завода_для_с_DataSet.Заказчик);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_завода_для_с_DataSet.Напиток". При необходимости она может быть перемещена или удалена.
            this.напитокTableAdapter.Fill(this._ИС_завода_для_с_DataSet.Напиток);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_завода_для_с_DataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this._ИС_завода_для_с_DataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_завода_для_с_DataSet.Продажа_напитка". При необходимости она может быть перемещена или удалена.
            this.продажа_напиткаTableAdapter.Fill(this._ИС_завода_для_с_DataSet.Продажа_напитка);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            search_sale fm = new search_sale();
            fm.Owner = this;
            fm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ADD__sale fm = new ADD__sale();
            fm.Owner = this;
            fm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            продажаНапиткаBindingSource.EndEdit();
            продажа_напиткаTableAdapter.Update(_ИС_завода_для_с_DataSet);
        }
    }
}
