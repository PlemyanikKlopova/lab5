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
    public partial class Form4 :  Form
    {
          public Form4()
          {
            InitializeComponent();
          }
    

    private void Form4_Load(object sender, EventArgs e)
    {
        this.литражTableAdapter.Fill(this._ИС_завода_для_с_DataSet.Литраж);
        this.брендTableAdapter.Fill(this._ИС_завода_для_с_DataSet.Бренд);
        this.тип_упаковкиTableAdapter.Fill(this._ИС_завода_для_с_DataSet.Тип_упаковки);
        this.рецептTableAdapter.Fill(this._ИС_завода_для_с_DataSet.Рецепт);
    }

        private void btn_save_nap_Click(object sender, EventArgs e)
        {
            Form9_dop fm9 = new Form9_dop();
            fm9.Owner = this;
            fm9.Show();
        }

        private void Form4_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_завода_для_с_DataSet.Бренд". При необходимости она может быть перемещена или удалена.
            this.брендTableAdapter.Fill(this._ИС_завода_для_с_DataSet.Бренд);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_завода_для_с_DataSet.Рецепт". При необходимости она может быть перемещена или удалена.
            this.рецептTableAdapter.Fill(this._ИС_завода_для_с_DataSet.Рецепт);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_завода_для_с_DataSet.Тип_упаковки". При необходимости она может быть перемещена или удалена.
            this.тип_упаковкиTableAdapter.Fill(this._ИС_завода_для_с_DataSet.Тип_упаковки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_завода_для_с_DataSet.Литраж". При необходимости она может быть перемещена или удалена.
            this.литражTableAdapter.Fill(this._ИС_завода_для_с_DataSet.Литраж);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИС_завода_для_с_DataSet.Напиток". При необходимости она может быть перемещена или удалена.
            this.напитокTableAdapter.Fill(this._ИС_завода_для_с_DataSet.Напиток);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10__serch_napitok fm10 = new Form10__serch_napitok();
            fm10.Owner = this;
            fm10.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            напитокBindingSource.EndEdit();
            напитокTableAdapter.Update(_ИС_завода_для_с_DataSet);  
        }

        
        
    }

}
   
       
    

