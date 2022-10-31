
namespace ИС_завода
{
    partial class Form10_dop
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.иДДоставкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерЗаказаДоставкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресДоставкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаОформленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cотрудники = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._ИС_завода_для_с_DataSet = new ИС_завода._ИС_завода_для_с_DataSet();
            this.Номер_заказа_продажи = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.продажаНапиткаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Cтатус_доставки = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.статусДоставкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.доставкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.доставкаTableAdapter = new ИС_завода._ИС_завода_для_с_DataSetTableAdapters.ДоставкаTableAdapter();
            this.статус_доставкиTableAdapter = new ИС_завода._ИС_завода_для_с_DataSetTableAdapters.Статус_доставкиTableAdapter();
            this.сотрудникиTableAdapter = new ИС_завода._ИС_завода_для_с_DataSetTableAdapters.СотрудникиTableAdapter();
            this.продажа_напиткаTableAdapter = new ИС_завода._ИС_завода_для_с_DataSetTableAdapters.Продажа_напиткаTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ИС_завода_для_с_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продажаНапиткаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.статусДоставкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.доставкаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.иДДоставкаDataGridViewTextBoxColumn,
            this.номерЗаказаДоставкиDataGridViewTextBoxColumn,
            this.адресДоставкиDataGridViewTextBoxColumn,
            this.датаОформленияDataGridViewTextBoxColumn,
            this.Cотрудники,
            this.Номер_заказа_продажи,
            this.Cтатус_доставки});
            this.dataGridView1.DataSource = this.доставкаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1273, 287);
            this.dataGridView1.TabIndex = 0;
            // 
            // иДДоставкаDataGridViewTextBoxColumn
            // 
            this.иДДоставкаDataGridViewTextBoxColumn.DataPropertyName = "ИД доставка";
            this.иДДоставкаDataGridViewTextBoxColumn.HeaderText = "ИД доставка";
            this.иДДоставкаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.иДДоставкаDataGridViewTextBoxColumn.Name = "иДДоставкаDataGridViewTextBoxColumn";
            this.иДДоставкаDataGridViewTextBoxColumn.Width = 125;
            // 
            // номерЗаказаДоставкиDataGridViewTextBoxColumn
            // 
            this.номерЗаказаДоставкиDataGridViewTextBoxColumn.DataPropertyName = "Номер заказа доставки";
            this.номерЗаказаДоставкиDataGridViewTextBoxColumn.HeaderText = "Номер заказа доставки";
            this.номерЗаказаДоставкиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерЗаказаДоставкиDataGridViewTextBoxColumn.Name = "номерЗаказаДоставкиDataGridViewTextBoxColumn";
            this.номерЗаказаДоставкиDataGridViewTextBoxColumn.Width = 125;
            // 
            // адресДоставкиDataGridViewTextBoxColumn
            // 
            this.адресДоставкиDataGridViewTextBoxColumn.DataPropertyName = "Адрес доставки";
            this.адресДоставкиDataGridViewTextBoxColumn.HeaderText = "Адрес доставки";
            this.адресДоставкиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.адресДоставкиDataGridViewTextBoxColumn.Name = "адресДоставкиDataGridViewTextBoxColumn";
            this.адресДоставкиDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаОформленияDataGridViewTextBoxColumn
            // 
            this.датаОформленияDataGridViewTextBoxColumn.DataPropertyName = "Дата оформления";
            this.датаОформленияDataGridViewTextBoxColumn.HeaderText = "Дата оформления";
            this.датаОформленияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаОформленияDataGridViewTextBoxColumn.Name = "датаОформленияDataGridViewTextBoxColumn";
            this.датаОформленияDataGridViewTextBoxColumn.Width = 125;
            // 
            // Cотрудники
            // 
            this.Cотрудники.DataPropertyName = "ИД сотрудники";
            this.Cотрудники.DataSource = this.сотрудникиBindingSource;
            this.Cотрудники.DisplayMember = "Фамилия_сотрудника";
            this.Cотрудники.HeaderText = "Cотрудники";
            this.Cотрудники.MinimumWidth = 6;
            this.Cотрудники.Name = "Cотрудники";
            this.Cотрудники.ValueMember = "ИД сотрудники";
            this.Cотрудники.Width = 125;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this._ИС_завода_для_с_DataSet;
            // 
            // _ИС_завода_для_с_DataSet
            // 
            this._ИС_завода_для_с_DataSet.DataSetName = "_ИС_завода_для_с_DataSet";
            this._ИС_завода_для_с_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Номер_заказа_продажи
            // 
            this.Номер_заказа_продажи.DataPropertyName = "ИД продажа";
            this.Номер_заказа_продажи.DataSource = this.продажаНапиткаBindingSource;
            this.Номер_заказа_продажи.DisplayMember = "Номер заказа";
            this.Номер_заказа_продажи.HeaderText = "Номер_заказа_продажи";
            this.Номер_заказа_продажи.MinimumWidth = 6;
            this.Номер_заказа_продажи.Name = "Номер_заказа_продажи";
            this.Номер_заказа_продажи.ValueMember = "ИД продажа";
            this.Номер_заказа_продажи.Width = 125;
            // 
            // продажаНапиткаBindingSource
            // 
            this.продажаНапиткаBindingSource.DataMember = "Продажа напитка";
            this.продажаНапиткаBindingSource.DataSource = this._ИС_завода_для_с_DataSet;
            // 
            // Cтатус_доставки
            // 
            this.Cтатус_доставки.DataPropertyName = "ИД статус доставки";
            this.Cтатус_доставки.DataSource = this.статусДоставкиBindingSource;
            this.Cтатус_доставки.DisplayMember = "Наименование статуса";
            this.Cтатус_доставки.HeaderText = "Cтатус_доставки";
            this.Cтатус_доставки.MinimumWidth = 6;
            this.Cтатус_доставки.Name = "Cтатус_доставки";
            this.Cтатус_доставки.ValueMember = "ИД статус доставки";
            this.Cтатус_доставки.Width = 125;
            // 
            // статусДоставкиBindingSource
            // 
            this.статусДоставкиBindingSource.DataMember = "Статус доставки";
            this.статусДоставкиBindingSource.DataSource = this._ИС_завода_для_с_DataSet;
            // 
            // доставкаBindingSource
            // 
            this.доставкаBindingSource.DataMember = "Доставка";
            this.доставкаBindingSource.DataSource = this._ИС_завода_для_с_DataSet;
            // 
            // доставкаTableAdapter
            // 
            this.доставкаTableAdapter.ClearBeforeFill = true;
            // 
            // статус_доставкиTableAdapter
            // 
            this.статус_доставкиTableAdapter.ClearBeforeFill = true;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // продажа_напиткаTableAdapter
            // 
            this.продажа_напиткаTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(403, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Доставка";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(961, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить данные";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1177, 413);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "Поиск данных";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(816, 413);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 33);
            this.button3.TabIndex = 4;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form10_dop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 458);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form10_dop";
            this.Text = "Form10_dop";
            this.Load += new System.EventHandler(this.Form10_dop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ИС_завода_для_с_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продажаНапиткаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.статусДоставкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.доставкаBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public _ИС_завода_для_с_DataSet _ИС_завода_для_с_DataSet;
        public System.Windows.Forms.BindingSource доставкаBindingSource;
        public _ИС_завода_для_с_DataSetTableAdapters.ДоставкаTableAdapter доставкаTableAdapter;
        private System.Windows.Forms.BindingSource статусДоставкиBindingSource;
        private _ИС_завода_для_с_DataSetTableAdapters.Статус_доставкиTableAdapter статус_доставкиTableAdapter;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private _ИС_завода_для_с_DataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.BindingSource продажаНапиткаBindingSource;
        private _ИС_завода_для_с_DataSetTableAdapters.Продажа_напиткаTableAdapter продажа_напиткаTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn иДДоставкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерЗаказаДоставкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресДоставкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаОформленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Cотрудники;
        private System.Windows.Forms.DataGridViewComboBoxColumn Номер_заказа_продажи;
        private System.Windows.Forms.DataGridViewComboBoxColumn Cтатус_доставки;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
    }
}