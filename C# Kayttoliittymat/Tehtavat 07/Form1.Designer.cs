
namespace Tehtavat_07
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
            this.otsikko_label1 = new System.Windows.Forms.Label();
            this.otsikko_label2 = new System.Windows.Forms.Label();
            this.otsikko_label3 = new System.Windows.Forms.Label();
            this.luo_taulukko_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tallenna_button = new System.Windows.Forms.Button();
            this.hae_button = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // otsikko_label1
            // 
            this.otsikko_label1.AutoSize = true;
            this.otsikko_label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.otsikko_label1.Location = new System.Drawing.Point(34, 26);
            this.otsikko_label1.Name = "otsikko_label1";
            this.otsikko_label1.Size = new System.Drawing.Size(146, 28);
            this.otsikko_label1.TabIndex = 0;
            this.otsikko_label1.Text = "Taulukon luonti";
            // 
            // otsikko_label2
            // 
            this.otsikko_label2.AutoSize = true;
            this.otsikko_label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.otsikko_label2.Location = new System.Drawing.Point(34, 141);
            this.otsikko_label2.Name = "otsikko_label2";
            this.otsikko_label2.Size = new System.Drawing.Size(91, 28);
            this.otsikko_label2.TabIndex = 1;
            this.otsikko_label2.Text = "Tallennus";
            // 
            // otsikko_label3
            // 
            this.otsikko_label3.AutoSize = true;
            this.otsikko_label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.otsikko_label3.Location = new System.Drawing.Point(34, 279);
            this.otsikko_label3.Name = "otsikko_label3";
            this.otsikko_label3.Size = new System.Drawing.Size(57, 28);
            this.otsikko_label3.TabIndex = 2;
            this.otsikko_label3.Text = "Haku";
            // 
            // luo_taulukko_button
            // 
            this.luo_taulukko_button.Location = new System.Drawing.Point(302, 91);
            this.luo_taulukko_button.Name = "luo_taulukko_button";
            this.luo_taulukko_button.Size = new System.Drawing.Size(113, 29);
            this.luo_taulukko_button.TabIndex = 3;
            this.luo_taulukko_button.Text = "Luo taulukko";
            this.luo_taulukko_button.UseVisualStyleBackColor = true;
            this.luo_taulukko_button.Click += new System.EventHandler(this.luo_taulukko_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(185, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 27);
            this.textBox1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(34, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Taulkon koko:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(34, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Talletuspaikan indexi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(34, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tallennettava numero:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(239, 189);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 27);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(239, 228);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(75, 27);
            this.textBox3.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(34, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Talletuspaikan indexi:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(239, 315);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(75, 27);
            this.textBox4.TabIndex = 11;
            // 
            // tallenna_button
            // 
            this.tallenna_button.Location = new System.Drawing.Point(331, 228);
            this.tallenna_button.Name = "tallenna_button";
            this.tallenna_button.Size = new System.Drawing.Size(84, 29);
            this.tallenna_button.TabIndex = 12;
            this.tallenna_button.Text = "Tallenna";
            this.tallenna_button.UseVisualStyleBackColor = true;
            this.tallenna_button.Click += new System.EventHandler(this.tallenna_button_Click);
            // 
            // hae_button
            // 
            this.hae_button.Location = new System.Drawing.Point(331, 315);
            this.hae_button.Name = "hae_button";
            this.hae_button.Size = new System.Drawing.Size(84, 29);
            this.hae_button.TabIndex = 13;
            this.hae_button.Text = "Hae";
            this.hae_button.UseVisualStyleBackColor = true;
            this.hae_button.Click += new System.EventHandler(this.hae_button_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(34, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 35);
            this.label8.TabIndex = 14;
            this.label8.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.hae_button);
            this.Controls.Add(this.tallenna_button);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.luo_taulukko_button);
            this.Controls.Add(this.otsikko_label3);
            this.Controls.Add(this.otsikko_label2);
            this.Controls.Add(this.otsikko_label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label otsikko_label1;
        private System.Windows.Forms.Label otsikko_label2;
        private System.Windows.Forms.Label otsikko_label3;
        private System.Windows.Forms.Button luo_taulukko_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button tallenna_button;
        private System.Windows.Forms.Button hae_button;
        private System.Windows.Forms.Label label8;
    }
}

