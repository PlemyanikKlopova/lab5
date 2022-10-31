
namespace ИС_завода
{
    partial class Form7
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
            this.label1 = new System.Windows.Forms.Label();
            this._ИС_завода_для_с_DataSet = new ИС_завода._ИС_завода_для_с_DataSet();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиTableAdapter = new ИС_завода._ИС_завода_для_с_DataSetTableAdapters.СотрудникиTableAdapter();
            this.полBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.полTableAdapter = new ИС_завода._ИС_завода_для_с_DataSetTableAdapters.ПолTableAdapter();
            this.должностьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.должностьTableAdapter = new ИС_завода._ИС_завода_для_с_DataSetTableAdapters.ДолжностьTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.иДСотрудникиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилиясотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имясотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоСотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаРожденияСотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.серияИНомерПаспортаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Пол = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Должность = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.сотрудникиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._ИС_завода_для_с_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.полBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностьBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(427, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сотрудники";
            // 
            // _ИС_завода_для_с_DataSet
            // 
            this._ИС_завода_для_с_DataSet.DataSetName = "_ИС_завода_для_с_DataSet";
            this._ИС_завода_для_с_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this._ИС_завода_для_с_DataSet;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // полBindingSource
            // 
            this.полBindingSource.DataMember = "Пол";
            this.полBindingSource.DataSource = this._ИС_завода_для_с_DataSet;
            // 
            // полTableAdapter
            // 
            this.полTableAdapter.ClearBeforeFill = true;
            // 
            // должностьBindingSource
            // 
            this.должностьBindingSource.DataMember = "Должность";
            this.должностьBindingSource.DataSource = this._ИС_завода_для_с_DataSet;
            // 
            // должностьTableAdapter
            // 
            this.должностьTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.иДСотрудникиDataGridViewTextBoxColumn,
            this.фамилиясотрудникаDataGridViewTextBoxColumn,
            this.имясотрудникаDataGridViewTextBoxColumn,
            this.отчествоСотрудникаDataGridViewTextBoxColumn,
            this.датаРожденияСотрудникаDataGridViewTextBoxColumn,
            this.серияИНомерПаспортаDataGridViewTextBoxColumn,
            this.Пол,
            this.Должность});
            this.dataGridView1.DataSource = this.сотрудникиBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(34, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1145, 356);
            this.dataGridView1.TabIndex = 4;
            // 
            // иДСотрудникиDataGridViewTextBoxColumn
            // 
            this.иДСотрудникиDataGridViewTextBoxColumn.DataPropertyName = "ИД сотрудники";
            this.иДСотрудникиDataGridViewTextBoxColumn.HeaderText = "ИД сотрудники";
            this.иДСотрудникиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.иДСотрудникиDataGridViewTextBoxColumn.Name = "иДСотрудникиDataGridViewTextBoxColumn";
            this.иДСотрудникиDataGridViewTextBoxColumn.Width = 125;
            // 
            // фамилиясотрудникаDataGridViewTextBoxColumn
            // 
            this.фамилиясотрудникаDataGridViewTextBoxColumn.DataPropertyName = "Фамилия_сотрудника";
            this.фамилиясотрудникаDataGridViewTextBoxColumn.HeaderText = "Фамилия_сотрудника";
            this.фамилиясотрудникаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фамилиясотрудникаDataGridViewTextBoxColumn.Name = "фамилиясотрудникаDataGridViewTextBoxColumn";
            this.фамилиясотрудникаDataGridViewTextBoxColumn.Width = 125;
            // 
            // имясотрудникаDataGridViewTextBoxColumn
            // 
            this.имясотрудникаDataGridViewTextBoxColumn.DataPropertyName = "Имя_сотрудника";
            this.имясотрудникаDataGridViewTextBoxColumn.HeaderText = "Имя_сотрудника";
            this.имясотрудникаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.имясотрудникаDataGridViewTextBoxColumn.Name = "имясотрудникаDataGridViewTextBoxColumn";
            this.имясотрудникаDataGridViewTextBoxColumn.Width = 125;
            // 
            // отчествоСотрудникаDataGridViewTextBoxColumn
            // 
            this.отчествоСотрудникаDataGridViewTextBoxColumn.DataPropertyName = "Отчество сотрудника";
            this.отчествоСотрудникаDataGridViewTextBoxColumn.HeaderText = "Отчество сотрудника";
            this.отчествоСотрудникаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.отчествоСотрудникаDataGridViewTextBoxColumn.Name = "отчествоСотрудникаDataGridViewTextBoxColumn";
            this.отчествоСотрудникаDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаРожденияСотрудникаDataGridViewTextBoxColumn
            // 
            this.датаРожденияСотрудникаDataGridViewTextBoxColumn.DataPropertyName = "Дата рождения сотрудника";
            this.датаРожденияСотрудникаDataGridViewTextBoxColumn.HeaderText = "Дата рождения сотрудника";
            this.датаРожденияСотрудникаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаРожденияСотрудникаDataGridViewTextBoxColumn.Name = "датаРожденияСотрудникаDataGridViewTextBoxColumn";
            this.датаРожденияСотрудникаDataGridViewTextBoxColumn.Width = 125;
            // 
            // серияИНомерПаспортаDataGridViewTextBoxColumn
            // 
            this.серияИНомерПаспортаDataGridViewTextBoxColumn.DataPropertyName = "Серия и номер паспорта";
            this.серияИНомерПаспортаDataGridViewTextBoxColumn.HeaderText = "Серия и номер паспорта";
            this.серияИНомерПаспортаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.серияИНомерПаспортаDataGridViewTextBoxColumn.Name = "серияИНомерПаспортаDataGridViewTextBoxColumn";
            this.серияИНомерПаспортаDataGridViewTextBoxColumn.Width = 125;
            // 
            // Пол
            // 
            this.Пол.DataPropertyName = "Ид пол";
            this.Пол.DataSource = this.полBindingSource;
            this.Пол.DisplayMember = "Наименование пола";
            this.Пол.HeaderText = "Пол";
            this.Пол.MinimumWidth = 6;
            this.Пол.Name = "Пол";
            this.Пол.ValueMember = "ИД пол";
            this.Пол.Width = 125;
            // 
            // Должность
            // 
            this.Должность.DataPropertyName = "ИД должность";
            this.Должность.DataSource = this.должностьBindingSource;
            this.Должность.DisplayMember = "Наименование должности";
            this.Должность.HeaderText = "Должность";
            this.Должность.MinimumWidth = 6;
            this.Должность.Name = "Должность";
            this.Должность.ValueMember = "Ид должность";
            this.Должность.Width = 125;
            // 
            // сотрудникиBindingSource1
            // 
            this.сотрудникиBindingSource1.DataMember = "Сотрудники";
            this.сотрудникиBindingSource1.DataSource = this._ИС_завода_для_с_DataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(762, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "Добавить данные";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1014, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 26);
            this.button2.TabIndex = 6;
            this.button2.Text = "Поиск данных";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(604, 412);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 27);
            this.button3.TabIndex = 7;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this._ИС_завода_для_с_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.полBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностьBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public _ИС_завода_для_с_DataSet _ИС_завода_для_с_DataSet;
        public System.Windows.Forms.BindingSource сотрудникиBindingSource;
        public _ИС_завода_для_с_DataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.BindingSource полBindingSource;
        private _ИС_завода_для_с_DataSetTableAdapters.ПолTableAdapter полTableAdapter;
        private System.Windows.Forms.BindingSource должностьBindingSource;
        private _ИС_завода_для_с_DataSetTableAdapters.ДолжностьTableAdapter должностьTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn иДСотрудникиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилиясотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имясотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоСотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаРожденияСотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn серияИНомерПаспортаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Пол;
        private System.Windows.Forms.DataGridViewComboBoxColumn Должность;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}