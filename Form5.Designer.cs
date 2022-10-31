
namespace ИС_завода
{
    partial class Form5
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
            this.иДПроизводствоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаизготовленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Напиток = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.напитокBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._ИС_завода_для_с_DataSet = new ИС_завода._ИС_завода_для_с_DataSet();
            this.Сотрудник = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.производствонапиткаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.производство_напиткаTableAdapter = new ИС_завода._ИС_завода_для_с_DataSetTableAdapters.Производство_напиткаTableAdapter();
            this.напитокTableAdapter = new ИС_завода._ИС_завода_для_с_DataSetTableAdapters.НапитокTableAdapter();
            this.сотрудникиTableAdapter = new ИС_завода._ИС_завода_для_с_DataSetTableAdapters.СотрудникиTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.напитокBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ИС_завода_для_с_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.производствонапиткаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.иДПроизводствоDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.датаизготовленияDataGridViewTextBoxColumn,
            this.Напиток,
            this.Сотрудник});
            this.dataGridView1.DataSource = this.производствонапиткаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1070, 333);
            this.dataGridView1.TabIndex = 0;
            // 
            // иДПроизводствоDataGridViewTextBoxColumn
            // 
            this.иДПроизводствоDataGridViewTextBoxColumn.DataPropertyName = "ИД производство";
            this.иДПроизводствоDataGridViewTextBoxColumn.HeaderText = "ИД производство";
            this.иДПроизводствоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.иДПроизводствоDataGridViewTextBoxColumn.Name = "иДПроизводствоDataGridViewTextBoxColumn";
            this.иДПроизводствоDataGridViewTextBoxColumn.Width = 125;
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            this.количествоDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаизготовленияDataGridViewTextBoxColumn
            // 
            this.датаизготовленияDataGridViewTextBoxColumn.DataPropertyName = "Дата_изготовления";
            this.датаизготовленияDataGridViewTextBoxColumn.HeaderText = "Дата_изготовления";
            this.датаизготовленияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаизготовленияDataGridViewTextBoxColumn.Name = "датаизготовленияDataGridViewTextBoxColumn";
            this.датаизготовленияDataGridViewTextBoxColumn.Width = 125;
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
            // _ИС_завода_для_с_DataSet
            // 
            this._ИС_завода_для_с_DataSet.DataSetName = "_ИС_завода_для_с_DataSet";
            this._ИС_завода_для_с_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Сотрудник
            // 
            this.Сотрудник.DataPropertyName = "ИД сотрудники";
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
            // производствонапиткаBindingSource
            // 
            this.производствонапиткаBindingSource.DataMember = "Производство_напитка";
            this.производствонапиткаBindingSource.DataSource = this._ИС_завода_для_с_DataSet;
            // 
            // производство_напиткаTableAdapter
            // 
            this.производство_напиткаTableAdapter.ClearBeforeFill = true;
            // 
            // напитокTableAdapter
            // 
            this.напитокTableAdapter.ClearBeforeFill = true;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(289, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Производство";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавление данных";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(458, 428);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "Поиск";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(613, 429);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 31);
            this.button3.TabIndex = 4;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 472);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.напитокBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ИС_завода_для_с_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.производствонапиткаBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public _ИС_завода_для_с_DataSet _ИС_завода_для_с_DataSet;
        public System.Windows.Forms.BindingSource производствонапиткаBindingSource;
        public _ИС_завода_для_с_DataSetTableAdapters.Производство_напиткаTableAdapter производство_напиткаTableAdapter;
        private System.Windows.Forms.BindingSource напитокBindingSource;
        private _ИС_завода_для_с_DataSetTableAdapters.НапитокTableAdapter напитокTableAdapter;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private _ИС_завода_для_с_DataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn иДПроизводствоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаизготовленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Напиток;
        private System.Windows.Forms.DataGridViewComboBoxColumn Сотрудник;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}