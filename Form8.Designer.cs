
namespace ИС_завода
{
    partial class Form8
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._ИС_завода_для_с_DataSet = new ИС_завода._ИС_завода_для_с_DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.иДПродажаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.колвоПродНапиктаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаПродажиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Напиток = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.напитокBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Сотрудник = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Заказчик = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.заказчикBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.продажаНапиткаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.продажа_напиткаTableAdapter = new ИС_завода._ИС_завода_для_с_DataSetTableAdapters.Продажа_напиткаTableAdapter();
            this.напитокTableAdapter = new ИС_завода._ИС_завода_для_с_DataSetTableAdapters.НапитокTableAdapter();
            this.сотрудникиTableAdapter = new ИС_завода._ИС_завода_для_с_DataSetTableAdapters.СотрудникиTableAdapter();
            this.заказчикTableAdapter = new ИС_завода._ИС_завода_для_с_DataSetTableAdapters.ЗаказчикTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this._ИС_завода_для_с_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.напитокBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказчикBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продажаНапиткаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // _ИС_завода_для_с_DataSet
            // 
            this._ИС_завода_для_с_DataSet.DataSetName = "_ИС_завода_для_с_DataSet";
            this._ИС_завода_для_с_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(434, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Продажа напитков";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(741, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавление данных";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(900, 422);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "Поиск данных";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1046, 425);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 34);
            this.button3.TabIndex = 4;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.иДПродажаDataGridViewTextBoxColumn,
            this.колвоПродНапиктаDataGridViewTextBoxColumn,
            this.датаПродажиDataGridViewTextBoxColumn,
            this.суммаЗаказаDataGridViewTextBoxColumn,
            this.номерЗаказаDataGridViewTextBoxColumn,
            this.Напиток,
            this.Сотрудник,
            this.Заказчик});
            this.dataGridView1.DataSource = this.продажаНапиткаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1157, 366);
            this.dataGridView1.TabIndex = 5;
            // 
            // иДПродажаDataGridViewTextBoxColumn
            // 
            this.иДПродажаDataGridViewTextBoxColumn.DataPropertyName = "ИД продажа";
            this.иДПродажаDataGridViewTextBoxColumn.HeaderText = "ИД продажа";
            this.иДПродажаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.иДПродажаDataGridViewTextBoxColumn.Name = "иДПродажаDataGridViewTextBoxColumn";
            this.иДПродажаDataGridViewTextBoxColumn.Width = 125;
            // 
            // колвоПродНапиктаDataGridViewTextBoxColumn
            // 
            this.колвоПродНапиктаDataGridViewTextBoxColumn.DataPropertyName = "Кол-во прод напикта";
            this.колвоПродНапиктаDataGridViewTextBoxColumn.HeaderText = "Кол-во прод напикта";
            this.колвоПродНапиктаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.колвоПродНапиктаDataGridViewTextBoxColumn.Name = "колвоПродНапиктаDataGridViewTextBoxColumn";
            this.колвоПродНапиктаDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаПродажиDataGridViewTextBoxColumn
            // 
            this.датаПродажиDataGridViewTextBoxColumn.DataPropertyName = "Дата продажи";
            this.датаПродажиDataGridViewTextBoxColumn.HeaderText = "Дата продажи";
            this.датаПродажиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаПродажиDataGridViewTextBoxColumn.Name = "датаПродажиDataGridViewTextBoxColumn";
            this.датаПродажиDataGridViewTextBoxColumn.Width = 125;
            // 
            // суммаЗаказаDataGridViewTextBoxColumn
            // 
            this.суммаЗаказаDataGridViewTextBoxColumn.DataPropertyName = "Сумма заказа";
            this.суммаЗаказаDataGridViewTextBoxColumn.HeaderText = "Сумма заказа";
            this.суммаЗаказаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.суммаЗаказаDataGridViewTextBoxColumn.Name = "суммаЗаказаDataGridViewTextBoxColumn";
            this.суммаЗаказаDataGridViewTextBoxColumn.Width = 125;
            // 
            // номерЗаказаDataGridViewTextBoxColumn
            // 
            this.номерЗаказаDataGridViewTextBoxColumn.DataPropertyName = "Номер заказа";
            this.номерЗаказаDataGridViewTextBoxColumn.HeaderText = "Номер заказа";
            this.номерЗаказаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерЗаказаDataGridViewTextBoxColumn.Name = "номерЗаказаDataGridViewTextBoxColumn";
            this.номерЗаказаDataGridViewTextBoxColumn.Width = 125;
            // 
            // Напиток
            // 
            this.Напиток.DataPropertyName = "ИД напиток";
            this.Напиток.DataSource = this.напитокBindingSource;
            this.Напиток.DisplayMember = "Название напитка";
            this.Напиток.HeaderText = "Напиток";
            this.Напиток.MinimumWidth = 6;
            this.Напиток.Name = "Напиток";
            this.Напиток.ValueMember = "ИД напиток";
            this.Напиток.Width = 125;
            // 
            // напитокBindingSource
            // 
            this.напитокBindingSource.DataMember = "Напиток";
            this.напитокBindingSource.DataSource = this._ИС_завода_для_с_DataSet;
            // 
            // Сотрудник
            // 
            this.Сотрудник.DataPropertyName = "ИД сотрудник";
            this.Сотрудник.DataSource = this.сотрудникиBindingSource;
            this.Сотрудник.DisplayMember = "Фамилия_сотрудника";
            this.Сотрудник.HeaderText = "Сотрудник";
            this.Сотрудник.MinimumWidth = 6;
            this.Сотрудник.Name = "Сотрудник";
            this.Сотрудник.ValueMember = "ИД сотрудники";
            this.Сотрудник.Width = 125;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this._ИС_завода_для_с_DataSet;
            // 
            // Заказчик
            // 
            this.Заказчик.DataPropertyName = "ИД заказчик";
            this.Заказчик.DataSource = this.заказчикBindingSource;
            this.Заказчик.DisplayMember = "Фамилия заказчика";
            this.Заказчик.HeaderText = "Заказчик";
            this.Заказчик.MinimumWidth = 6;
            this.Заказчик.Name = "Заказчик";
            this.Заказчик.ValueMember = "ИД заказчик";
            this.Заказчик.Width = 125;
            // 
            // заказчикBindingSource
            // 
            this.заказчикBindingSource.DataMember = "Заказчик";
            this.заказчикBindingSource.DataSource = this._ИС_завода_для_с_DataSet;
            // 
            // продажаНапиткаBindingSource
            // 
            this.продажаНапиткаBindingSource.DataMember = "Продажа напитка";
            this.продажаНапиткаBindingSource.DataSource = this._ИС_завода_для_с_DataSet;
            // 
            // продажа_напиткаTableAdapter
            // 
            this.продажа_напиткаTableAdapter.ClearBeforeFill = true;
            // 
            // напитокTableAdapter
            // 
            this.напитокTableAdapter.ClearBeforeFill = true;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // заказчикTableAdapter
            // 
            this.заказчикTableAdapter.ClearBeforeFill = true;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 471);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this._ИС_завода_для_с_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.напитокBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказчикBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продажаНапиткаBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public _ИС_завода_для_с_DataSet _ИС_завода_для_с_DataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.BindingSource продажаНапиткаBindingSource;
        public _ИС_завода_для_с_DataSetTableAdapters.Продажа_напиткаTableAdapter продажа_напиткаTableAdapter;
        private System.Windows.Forms.BindingSource напитокBindingSource;
        private _ИС_завода_для_с_DataSetTableAdapters.НапитокTableAdapter напитокTableAdapter;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private _ИС_завода_для_с_DataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.BindingSource заказчикBindingSource;
        private _ИС_завода_для_с_DataSetTableAdapters.ЗаказчикTableAdapter заказчикTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn иДПродажаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn колвоПродНапиктаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПродажиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Напиток;
        private System.Windows.Forms.DataGridViewComboBoxColumn Сотрудник;
        private System.Windows.Forms.DataGridViewComboBoxColumn Заказчик;
    }
}