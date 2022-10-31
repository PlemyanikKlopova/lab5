
namespace ИС_завода
{
    partial class Form4
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
            this.иДНапитокDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._ИС_завода_для_с_DataSet = new ИС_завода._ИС_завода_для_с_DataSet();
            this.иДНапитокDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_save_nap = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.иДНапитокDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеНапиткаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.срокГодностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаЗаШтDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Рецепт = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.рецептBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Бренд = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.брендBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Литраж = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.литражBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Тип_упаковки = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.типУпаковкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.напитокBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.напитокTableAdapter = new ИС_завода._ИС_завода_для_с_DataSetTableAdapters.НапитокTableAdapter();
            this.литражTableAdapter = new ИС_завода._ИС_завода_для_с_DataSetTableAdapters.ЛитражTableAdapter();
            this.тип_упаковкиTableAdapter = new ИС_завода._ИС_завода_для_с_DataSetTableAdapters.Тип_упаковкиTableAdapter();
            this.рецептTableAdapter = new ИС_завода._ИС_завода_для_с_DataSetTableAdapters.РецептTableAdapter();
            this.брендTableAdapter = new ИС_завода._ИС_завода_для_с_DataSetTableAdapters.БрендTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._ИС_завода_для_с_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рецептBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.брендBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.литражBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типУпаковкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.напитокBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(309, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Напитки";
            // 
            // иДНапитокDataGridViewTextBoxColumn
            // 
            this.иДНапитокDataGridViewTextBoxColumn.DataPropertyName = "ИД напиток";
            this.иДНапитокDataGridViewTextBoxColumn.HeaderText = "ИД напиток";
            this.иДНапитокDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.иДНапитокDataGridViewTextBoxColumn.Name = "иДНапитокDataGridViewTextBoxColumn";
            this.иДНапитокDataGridViewTextBoxColumn.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ИД напиток";
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // _ИС_завода_для_с_DataSet
            // 
            this._ИС_завода_для_с_DataSet.DataSetName = "_ИС_завода_для_с_DataSet";
            this._ИС_завода_для_с_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // иДНапитокDataGridViewTextBoxColumn1
            // 
            this.иДНапитокDataGridViewTextBoxColumn1.DataPropertyName = "ИД напиток";
            this.иДНапитокDataGridViewTextBoxColumn1.HeaderText = "ИД напиток";
            this.иДНапитокDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.иДНапитокDataGridViewTextBoxColumn1.Name = "иДНапитокDataGridViewTextBoxColumn1";
            this.иДНапитокDataGridViewTextBoxColumn1.Width = 125;
            // 
            // btn_save_nap
            // 
            this.btn_save_nap.Location = new System.Drawing.Point(788, 455);
            this.btn_save_nap.Name = "btn_save_nap";
            this.btn_save_nap.Size = new System.Drawing.Size(191, 30);
            this.btn_save_nap.TabIndex = 7;
            this.btn_save_nap.Text = "Добавление данных";
            this.btn_save_nap.UseVisualStyleBackColor = true;
            this.btn_save_nap.Click += new System.EventHandler(this.btn_save_nap_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.иДНапитокDataGridViewTextBoxColumn2,
            this.названиеНапиткаDataGridViewTextBoxColumn,
            this.срокГодностиDataGridViewTextBoxColumn,
            this.ценаЗаШтDataGridViewTextBoxColumn,
            this.Рецепт,
            this.Бренд,
            this.Литраж,
            this.Тип_упаковки});
            this.dataGridView1.DataSource = this.напитокBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1236, 374);
            this.dataGridView1.TabIndex = 8;
            // 
            // иДНапитокDataGridViewTextBoxColumn2
            // 
            this.иДНапитокDataGridViewTextBoxColumn2.DataPropertyName = "ИД напиток";
            this.иДНапитокDataGridViewTextBoxColumn2.HeaderText = "ИД напиток";
            this.иДНапитокDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.иДНапитокDataGridViewTextBoxColumn2.Name = "иДНапитокDataGridViewTextBoxColumn2";
            this.иДНапитокDataGridViewTextBoxColumn2.Width = 125;
            // 
            // названиеНапиткаDataGridViewTextBoxColumn
            // 
            this.названиеНапиткаDataGridViewTextBoxColumn.DataPropertyName = "Название напитка";
            this.названиеНапиткаDataGridViewTextBoxColumn.HeaderText = "Название напитка";
            this.названиеНапиткаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.названиеНапиткаDataGridViewTextBoxColumn.Name = "названиеНапиткаDataGridViewTextBoxColumn";
            this.названиеНапиткаDataGridViewTextBoxColumn.Width = 125;
            // 
            // срокГодностиDataGridViewTextBoxColumn
            // 
            this.срокГодностиDataGridViewTextBoxColumn.DataPropertyName = "Срок годности";
            this.срокГодностиDataGridViewTextBoxColumn.HeaderText = "Срок годности";
            this.срокГодностиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.срокГодностиDataGridViewTextBoxColumn.Name = "срокГодностиDataGridViewTextBoxColumn";
            this.срокГодностиDataGridViewTextBoxColumn.Width = 125;
            // 
            // ценаЗаШтDataGridViewTextBoxColumn
            // 
            this.ценаЗаШтDataGridViewTextBoxColumn.DataPropertyName = "Цена за шт";
            this.ценаЗаШтDataGridViewTextBoxColumn.HeaderText = "Цена за шт";
            this.ценаЗаШтDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ценаЗаШтDataGridViewTextBoxColumn.Name = "ценаЗаШтDataGridViewTextBoxColumn";
            this.ценаЗаШтDataGridViewTextBoxColumn.Width = 125;
            // 
            // Рецепт
            // 
            this.Рецепт.DataPropertyName = "Ид рецепт";
            this.Рецепт.DataSource = this.рецептBindingSource;
            this.Рецепт.DisplayMember = "Состав";
            this.Рецепт.HeaderText = "Рецепт";
            this.Рецепт.MinimumWidth = 6;
            this.Рецепт.Name = "Рецепт";
            this.Рецепт.ValueMember = "ИД рецепт";
            this.Рецепт.Width = 125;
            // 
            // рецептBindingSource
            // 
            this.рецептBindingSource.DataMember = "Рецепт";
            this.рецептBindingSource.DataSource = this._ИС_завода_для_с_DataSet;
            // 
            // Бренд
            // 
            this.Бренд.DataPropertyName = "ИД бренд";
            this.Бренд.DataSource = this.брендBindingSource;
            this.Бренд.DisplayMember = "Наименование бренда";
            this.Бренд.HeaderText = "Бренд";
            this.Бренд.MinimumWidth = 6;
            this.Бренд.Name = "Бренд";
            this.Бренд.ValueMember = "ИД бренд";
            this.Бренд.Width = 125;
            // 
            // брендBindingSource
            // 
            this.брендBindingSource.DataMember = "Бренд";
            this.брендBindingSource.DataSource = this._ИС_завода_для_с_DataSet;
            // 
            // Литраж
            // 
            this.Литраж.DataPropertyName = "ИД литраж";
            this.Литраж.DataSource = this.литражBindingSource;
            this.Литраж.DisplayMember = "Объем";
            this.Литраж.HeaderText = "Литраж";
            this.Литраж.MinimumWidth = 6;
            this.Литраж.Name = "Литраж";
            this.Литраж.ValueMember = "ИД литраж";
            this.Литраж.Width = 125;
            // 
            // литражBindingSource
            // 
            this.литражBindingSource.DataMember = "Литраж";
            this.литражBindingSource.DataSource = this._ИС_завода_для_с_DataSet;
            // 
            // Тип_упаковки
            // 
            this.Тип_упаковки.DataPropertyName = "ИД тип упаковки";
            this.Тип_упаковки.DataSource = this.типУпаковкиBindingSource;
            this.Тип_упаковки.DisplayMember = "Наименование типа";
            this.Тип_упаковки.HeaderText = "Тип_упаковки";
            this.Тип_упаковки.MinimumWidth = 6;
            this.Тип_упаковки.Name = "Тип_упаковки";
            this.Тип_упаковки.ValueMember = "ИД тип упаковки";
            this.Тип_упаковки.Width = 125;
            // 
            // типУпаковкиBindingSource
            // 
            this.типУпаковкиBindingSource.DataMember = "Тип упаковки";
            this.типУпаковкиBindingSource.DataSource = this._ИС_завода_для_с_DataSet;
            // 
            // напитокBindingSource
            // 
            this.напитокBindingSource.DataMember = "Напиток";
            this.напитокBindingSource.DataSource = this._ИС_завода_для_с_DataSet;
            // 
            // напитокTableAdapter
            // 
            this.напитокTableAdapter.ClearBeforeFill = true;
            // 
            // литражTableAdapter
            // 
            this.литражTableAdapter.ClearBeforeFill = true;
            // 
            // тип_упаковкиTableAdapter
            // 
            this.тип_упаковкиTableAdapter.ClearBeforeFill = true;
            // 
            // рецептTableAdapter
            // 
            this.рецептTableAdapter.ClearBeforeFill = true;
            // 
            // брендTableAdapter
            // 
            this.брендTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(589, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Поиск данных";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1000, 455);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 30);
            this.button2.TabIndex = 10;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 523);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_save_nap);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this._ИС_завода_для_с_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рецептBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.брендBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.литражBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типУпаковкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.напитокBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn иДНапитокDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        public _ИС_завода_для_с_DataSet _ИС_завода_для_с_DataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn иДНапитокDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btn_save_nap;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.BindingSource напитокBindingSource;
        public _ИС_завода_для_с_DataSetTableAdapters.НапитокTableAdapter напитокTableAdapter;
        private System.Windows.Forms.BindingSource литражBindingSource;
        private _ИС_завода_для_с_DataSetTableAdapters.ЛитражTableAdapter литражTableAdapter;
        private System.Windows.Forms.BindingSource типУпаковкиBindingSource;
        private _ИС_завода_для_с_DataSetTableAdapters.Тип_упаковкиTableAdapter тип_упаковкиTableAdapter;
        private System.Windows.Forms.BindingSource рецептBindingSource;
        private _ИС_завода_для_с_DataSetTableAdapters.РецептTableAdapter рецептTableAdapter;
        private System.Windows.Forms.BindingSource брендBindingSource;
        private _ИС_завода_для_с_DataSetTableAdapters.БрендTableAdapter брендTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn иДНапитокDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеНапиткаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn срокГодностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаЗаШтDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Рецепт;
        private System.Windows.Forms.DataGridViewComboBoxColumn Бренд;
        private System.Windows.Forms.DataGridViewComboBoxColumn Литраж;
        private System.Windows.Forms.DataGridViewComboBoxColumn Тип_упаковки;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}