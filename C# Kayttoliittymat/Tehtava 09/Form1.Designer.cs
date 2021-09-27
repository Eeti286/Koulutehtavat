
namespace Tehtava_09
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.luo_lista_button = new System.Windows.Forms.Button();
            this.lisaa_button1 = new System.Windows.Forms.Button();
            this.hae_button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(39, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Luodaan -string tyyppinen muuttuja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(86, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lisätään listan merkkijono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(103, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Haetaan listan sisältö";
            // 
            // luo_lista_button
            // 
            this.luo_lista_button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.luo_lista_button.Location = new System.Drawing.Point(138, 110);
            this.luo_lista_button.Name = "luo_lista_button";
            this.luo_lista_button.Size = new System.Drawing.Size(110, 30);
            this.luo_lista_button.TabIndex = 3;
            this.luo_lista_button.Text = "Luo lista";
            this.luo_lista_button.UseVisualStyleBackColor = true;
            this.luo_lista_button.Click += new System.EventHandler(this.luo_lista_button_Click);
            // 
            // lisaa_button1
            // 
            this.lisaa_button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lisaa_button1.Location = new System.Drawing.Point(290, 251);
            this.lisaa_button1.Name = "lisaa_button1";
            this.lisaa_button1.Size = new System.Drawing.Size(110, 30);
            this.lisaa_button1.TabIndex = 4;
            this.lisaa_button1.Text = "Lisää";
            this.lisaa_button1.UseVisualStyleBackColor = true;
            this.lisaa_button1.Click += new System.EventHandler(this.lisaa_button1_Click);
            // 
            // hae_button2
            // 
            this.hae_button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hae_button2.Location = new System.Drawing.Point(290, 388);
            this.hae_button2.Name = "hae_button2";
            this.hae_button2.Size = new System.Drawing.Size(110, 30);
            this.hae_button2.TabIndex = 5;
            this.hae_button2.Text = "Hae";
            this.hae_button2.UseVisualStyleBackColor = true;
            this.hae_button2.Click += new System.EventHandler(this.hae_button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(39, 252);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 27);
            this.textBox1.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(39, 390);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(245, 28);
            this.comboBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.hae_button2);
            this.Controls.Add(this.lisaa_button1);
            this.Controls.Add(this.luo_lista_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button luo_lista_button;
        private System.Windows.Forms.Button lisaa_button1;
        private System.Windows.Forms.Button hae_button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

