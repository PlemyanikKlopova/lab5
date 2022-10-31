
namespace ИС_завода
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Sotr = new System.Windows.Forms.Button();
            this.btn_Napit = new System.Windows.Forms.Button();
            this.btn_Klien = new System.Windows.Forms.Button();
            this.btn_sale = new System.Windows.Forms.Button();
            this.btn_dos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(734, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Завод производства напитков";
            // 
            // btn_Sotr
            // 
            this.btn_Sotr.BackColor = System.Drawing.Color.DimGray;
            this.btn_Sotr.ForeColor = System.Drawing.Color.White;
            this.btn_Sotr.Location = new System.Drawing.Point(602, 434);
            this.btn_Sotr.Name = "btn_Sotr";
            this.btn_Sotr.Size = new System.Drawing.Size(168, 40);
            this.btn_Sotr.TabIndex = 1;
            this.btn_Sotr.Text = "Сотрудники";
            this.btn_Sotr.UseVisualStyleBackColor = false;
            this.btn_Sotr.Click += new System.EventHandler(this.btn_Sotr_Click);
            // 
            // btn_Napit
            // 
            this.btn_Napit.BackColor = System.Drawing.Color.DimGray;
            this.btn_Napit.ForeColor = System.Drawing.Color.White;
            this.btn_Napit.Location = new System.Drawing.Point(428, 434);
            this.btn_Napit.Name = "btn_Napit";
            this.btn_Napit.Size = new System.Drawing.Size(168, 39);
            this.btn_Napit.TabIndex = 2;
            this.btn_Napit.Text = "Напитки";
            this.btn_Napit.UseVisualStyleBackColor = false;
            this.btn_Napit.Click += new System.EventHandler(this.btn_Napit_Click);
            // 
            // btn_Klien
            // 
            this.btn_Klien.BackColor = System.Drawing.Color.DimGray;
            this.btn_Klien.ForeColor = System.Drawing.Color.White;
            this.btn_Klien.Location = new System.Drawing.Point(254, 434);
            this.btn_Klien.Name = "btn_Klien";
            this.btn_Klien.Size = new System.Drawing.Size(168, 38);
            this.btn_Klien.TabIndex = 3;
            this.btn_Klien.Text = "Клиенты";
            this.btn_Klien.UseVisualStyleBackColor = false;
            this.btn_Klien.Click += new System.EventHandler(this.btn_Klien_Click);
            // 
            // btn_sale
            // 
            this.btn_sale.BackColor = System.Drawing.Color.DimGray;
            this.btn_sale.ForeColor = System.Drawing.Color.White;
            this.btn_sale.Location = new System.Drawing.Point(602, 347);
            this.btn_sale.Name = "btn_sale";
            this.btn_sale.Size = new System.Drawing.Size(168, 37);
            this.btn_sale.TabIndex = 4;
            this.btn_sale.Text = "Продажа";
            this.btn_sale.UseVisualStyleBackColor = false;
            this.btn_sale.Click += new System.EventHandler(this.btn_sale_Click);
            // 
            // btn_dos
            // 
            this.btn_dos.BackColor = System.Drawing.Color.DimGray;
            this.btn_dos.ForeColor = System.Drawing.Color.White;
            this.btn_dos.Location = new System.Drawing.Point(602, 390);
            this.btn_dos.Name = "btn_dos";
            this.btn_dos.Size = new System.Drawing.Size(168, 38);
            this.btn_dos.TabIndex = 5;
            this.btn_dos.Text = "Доставка";
            this.btn_dos.UseVisualStyleBackColor = false;
            this.btn_dos.Click += new System.EventHandler(this.btn_dos_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(428, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Производство";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ИС_завода.Properties.Resources.Drinks_Cocktail_Lemons_439370;
            this.ClientSize = new System.Drawing.Size(802, 527);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_dos);
            this.Controls.Add(this.btn_sale);
            this.Controls.Add(this.btn_Klien);
            this.Controls.Add(this.btn_Napit);
            this.Controls.Add(this.btn_Sotr);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(820, 574);
            this.MinimumSize = new System.Drawing.Size(820, 574);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Sotr;
        private System.Windows.Forms.Button btn_Napit;
        private System.Windows.Forms.Button btn_Klien;
        private System.Windows.Forms.Button btn_sale;
        private System.Windows.Forms.Button btn_dos;
        private System.Windows.Forms.Button button1;
    }
}

