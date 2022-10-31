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
    public partial class Form10_dop : Form
    {
        public Form10_dop()
        {
            InitializeComponent();
        }

        private void Form10_dop_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_завода_для_с_DataSet.Продажа_напитка". При необходимости она может быть перемещена или удалена.
            this.продажа_напиткаTableAdapter.Fill(this._ИС_завода_для_с_DataSet.Продажа_напитка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_завода_для_с_DataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this._ИС_завода_для_с_DataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_завода_для_с_DataSet.Статус_доставки". При необходимости она может быть перемещена или удалена.
            this.статус_доставкиTableAdapter.Fill(this._ИС_завода_для_с_DataSet.Статус_доставки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_завода_для_с_DataSet.Доставка". При необходимости она может быть перемещена или удалена.
            this.доставкаTableAdapter.Fill(this._ИС_завода_для_с_DataSet.Доставка);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 fm9 = new Form9();
            fm9.Owner = this;
            fm9.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10_search sf = new Form10_search();
            sf.Owner = this;
            sf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            доставкаBindingSource.EndEdit();
            доставкаTableAdapter.Update(_ИС_завода_для_с_DataSet);
        }
    }
}
