
namespace Ristinolla
{
    partial class Form2
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
            this.aloita_peli_button = new System.Windows.Forms.Button();
            this.PelaajaA_textBox = new System.Windows.Forms.TextBox();
            this.PelaajaB_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aloita_peli_button
            // 
            this.aloita_peli_button.BackColor = System.Drawing.Color.White;
            this.aloita_peli_button.Font = new System.Drawing.Font("Rubik", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aloita_peli_button.ForeColor = System.Drawing.Color.MediumPurple;
            this.aloita_peli_button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.aloita_peli_button.Location = new System.Drawing.Point(170, 173);
            this.aloita_peli_button.Name = "aloita_peli_button";
            this.aloita_peli_button.Size = new System.Drawing.Size(200, 60);
            this.aloita_peli_button.TabIndex = 2;
            this.aloita_peli_button.Text = "Pelaa";
            this.aloita_peli_button.UseVisualStyleBackColor = false;
            this.aloita_peli_button.Click += new System.EventHandler(this.aloita_peli_button_Click);
            // 
            // PelaajaA_textBox
            // 
            this.PelaajaA_textBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PelaajaA_textBox.Location = new System.Drawing.Point(12, 125);
            this.PelaajaA_textBox.Name = "PelaajaA_textBox";
            this.PelaajaA_textBox.Size = new System.Drawing.Size(163, 34);
            this.PelaajaA_textBox.TabIndex = 3;
            // 
            // PelaajaB_textBox
            // 
            this.PelaajaB_textBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PelaajaB_textBox.Location = new System.Drawing.Point(367, 125);
            this.PelaajaB_textBox.Name = "PelaajaB_textBox";
            this.PelaajaB_textBox.Size = new System.Drawing.Size(173, 34);
            this.PelaajaB_textBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rubik", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(49, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pelaaja1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rubik", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(411, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pelaaja2";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rubik", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(108, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 46);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tervetuloa pelaamaan ristinollaa. \r\nSyötä pelaajien nimet aloittaaksesti!";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(552, 245);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PelaajaB_textBox);
            this.Controls.Add(this.PelaajaA_textBox);
            this.Controls.Add(this.aloita_peli_button);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aloita_peli_button;
        private System.Windows.Forms.TextBox PelaajaA_textBox;
        private System.Windows.Forms.TextBox PelaajaB_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}