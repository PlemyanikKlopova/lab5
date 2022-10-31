
namespace ИС_завода
{
    partial class Form6
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
            this.иДЗаказчикDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяЗаказчткаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияЗаказчикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоЗаказчикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаРожденияЗаказчикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонЗаказчикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.серияИНомерПаспортаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заказчикBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._ИС_завода_для_с_DataSet = new ИС_завода._ИС_завода_для_с_DataSet();
            this.заказчикTableAdapter = new ИС_завода._ИС_завода_для_с_DataSetTableAdapters.ЗаказчикTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказчикBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ИС_завода_для_с_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.иДЗаказчикDataGridViewTextBoxColumn,
            this.имяЗаказчткаDataGridViewTextBoxColumn,
            this.фамилияЗаказчикаDataGridViewTextBoxColumn,
            this.отчествоЗаказчикаDataGridViewTextBoxColumn,
            this.датаРожденияЗаказчикаDataGridViewTextBoxColumn,
            this.телефонЗаказчикаDataGridViewTextBoxColumn,
            this.серияИНомерПаспортаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.заказчикBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1102, 356);
            this.dataGridView1.TabIndex = 0;
            // 
            // иДЗаказчикDataGridViewTextBoxColumn
            // 
            this.иДЗаказчикDataGridViewTextBoxColumn.DataPropertyName = "ИД заказчик";
            this.иДЗаказчикDataGridViewTextBoxColumn.HeaderText = "ИД заказчик";
            this.иДЗаказчикDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.иДЗаказчикDataGridViewTextBoxColumn.Name = "иДЗаказчикDataGridViewTextBoxColumn";
            this.иДЗаказчикDataGridViewTextBoxColumn.Width = 125;
            // 
            // имяЗаказчткаDataGridViewTextBoxColumn
            // 
            this.имяЗаказчткаDataGridViewTextBoxColumn.DataPropertyName = "Имя заказчтка";
            this.имяЗаказчткаDataGridViewTextBoxColumn.HeaderText = "Имя заказчтка";
            this.имяЗаказчткаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.имяЗаказчткаDataGridViewTextBoxColumn.Name = "имяЗаказчткаDataGridViewTextBoxColumn";
            this.имяЗаказчткаDataGridViewTextBoxColumn.Width = 125;
            // 
            // фамилияЗаказчикаDataGridViewTextBoxColumn
            // 
            this.фамилияЗаказчикаDataGridViewTextBoxColumn.DataPropertyName = "Фамилия заказчика";
            this.фамилияЗаказчикаDataGridViewTextBoxColumn.HeaderText = "Фамилия заказчика";
            this.фамилияЗаказчикаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фамилияЗаказчикаDataGridViewTextBoxColumn.Name = "фамилияЗаказчикаDataGridViewTextBoxColumn";
            this.фамилияЗаказчикаDataGridViewTextBoxColumn.Width = 125;
            // 
            // отчествоЗаказчикаDataGridViewTextBoxColumn
            // 
            this.отчествоЗаказчикаDataGridViewTextBoxColumn.DataPropertyName = "Отчество заказчика";
            this.отчествоЗаказчикаDataGridViewTextBoxColumn.HeaderText = "Отчество заказчика";
            this.отчествоЗаказчикаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.отчествоЗаказчикаDataGridViewTextBoxColumn.Name = "отчествоЗаказчикаDataGridViewTextBoxColumn";
            this.отчествоЗаказчикаDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаРожденияЗаказчикаDataGridViewTextBoxColumn
            // 
            this.датаРожденияЗаказчикаDataGridViewTextBoxColumn.DataPropertyName = "Дата рождения заказчика";
            this.датаРожденияЗаказчикаDataGridViewTextBoxColumn.HeaderText = "Дата рождения заказчика";
            this.датаРожденияЗаказчикаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаРожденияЗаказчикаDataGridViewTextBoxColumn.Name = "датаРожденияЗаказчикаDataGridViewTextBoxColumn";
            this.датаРожденияЗаказчикаDataGridViewTextBoxColumn.Width = 125;
            // 
            // телефонЗаказчикаDataGridViewTextBoxColumn
            // 
            this.телефонЗаказчикаDataGridViewTextBoxColumn.DataPropertyName = "Телефон заказчика";
            this.телефонЗаказчикаDataGridViewTextBoxColumn.HeaderText = "Телефон заказчика";
            this.телефонЗаказчикаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.телефонЗаказчикаDataGridViewTextBoxColumn.Name = "телефонЗаказчикаDataGridViewTextBoxColumn";
            this.телефонЗаказчикаDataGridViewTextBoxColumn.Width = 125;
            // 
            // серияИНомерПаспортаDataGridViewTextBoxColumn
            // 
            this.серияИНомерПаспортаDataGridViewTextBoxColumn.DataPropertyName = "Серия и номер паспорта";
            this.серияИНомерПаспортаDataGridViewTextBoxColumn.HeaderText = "Серия и номер паспорта";
            this.серияИНомерПаспортаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.серияИНомерПаспортаDataGridViewTextBoxColumn.Name = "серияИНомерПаспортаDataGridViewTextBoxColumn";
            this.серияИНомерПаспортаDataGridViewTextBoxColumn.Width = 125;
            // 
            // заказчикBindingSource
            // 
            this.заказчикBindingSource.DataMember = "Заказчик";
            this.заказчикBindingSource.DataSource = this._ИС_завода_для_с_DataSet;
            // 
            // _ИС_завода_для_с_DataSet
            // 
            this._ИС_завода_для_с_DataSet.DataSetName = "_ИС_завода_для_с_DataSet";
            this._ИС_завода_для_с_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заказчикTableAdapter
            // 
            this.заказчикTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(424, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Заказчики";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(775, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавление данных";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(980, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 26);
            this.button2.TabIndex = 3;
            this.button2.Text = "Поиск данных";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(643, 412);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 27);
            this.button3.TabIndex = 4;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказчикBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ИС_завода_для_с_DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public _ИС_завода_для_с_DataSet _ИС_завода_для_с_DataSet;
        public System.Windows.Forms.BindingSource заказчикBindingSource;
        public _ИС_завода_для_с_DataSetTableAdapters.ЗаказчикTableAdapter заказчикTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn иДЗаказчикDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяЗаказчткаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияЗаказчикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоЗаказчикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаРожденияЗаказчикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонЗаказчикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn серияИНомерПаспортаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}