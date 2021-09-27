
namespace Tehtava_15
{
    partial class aloitus_Forms
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.poistu_button = new System.Windows.Forms.Button();
            this.kirjaudu_button = new System.Windows.Forms.Button();
            this.kayttajatunnus_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.taulukko_richTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(158)))));
            this.panel1.Controls.Add(this.poistu_button);
            this.panel1.Controls.Add(this.kirjaudu_button);
            this.panel1.Controls.Add(this.kayttajatunnus_textBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 398);
            this.panel1.TabIndex = 0;
            // 
            // poistu_button
            // 
            this.poistu_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.poistu_button.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.poistu_button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.poistu_button.Location = new System.Drawing.Point(-8, 269);
            this.poistu_button.Name = "poistu_button";
            this.poistu_button.Size = new System.Drawing.Size(270, 62);
            this.poistu_button.TabIndex = 4;
            this.poistu_button.Text = "Poistu";
            this.poistu_button.UseVisualStyleBackColor = false;
            this.poistu_button.Click += new System.EventHandler(this.poistu_button_Click);
            // 
            // kirjaudu_button
            // 
            this.kirjaudu_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.kirjaudu_button.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kirjaudu_button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.kirjaudu_button.Location = new System.Drawing.Point(-8, 201);
            this.kirjaudu_button.Name = "kirjaudu_button";
            this.kirjaudu_button.Size = new System.Drawing.Size(270, 62);
            this.kirjaudu_button.TabIndex = 3;
            this.kirjaudu_button.Text = "Kirjaudu";
            this.kirjaudu_button.UseVisualStyleBackColor = false;
            this.kirjaudu_button.Click += new System.EventHandler(this.kirjaudu_button_Click);
            // 
            // kayttajatunnus_textBox
            // 
            this.kayttajatunnus_textBox.BackColor = System.Drawing.SystemColors.Menu;
            this.kayttajatunnus_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kayttajatunnus_textBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kayttajatunnus_textBox.Location = new System.Drawing.Point(-8, 136);
            this.kayttajatunnus_textBox.Name = "kayttajatunnus_textBox";
            this.kayttajatunnus_textBox.Size = new System.Drawing.Size(270, 34);
            this.kayttajatunnus_textBox.TabIndex = 2;
            this.kayttajatunnus_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(49, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Käyttäjätunnus";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(61, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "KIRJAUDU";
            // 
            // taulukko_richTextBox
            // 
            this.taulukko_richTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.taulukko_richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taulukko_richTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.taulukko_richTextBox.Location = new System.Drawing.Point(283, 108);
            this.taulukko_richTextBox.Name = "taulukko_richTextBox";
            this.taulukko_richTextBox.Size = new System.Drawing.Size(349, 265);
            this.taulukko_richTextBox.TabIndex = 1;
            this.taulukko_richTextBox.Text = "";
            this.taulukko_richTextBox.TextChanged += new System.EventHandler(this.taulukko_richTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(359, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "PISTETAULUKKO";
            // 
            // aloitus_Forms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(658, 398);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.taulukko_richTextBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "aloitus_Forms";
            this.Text = "aloitus_Forms";
            this.Load += new System.EventHandler(this.aloitus_Forms_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox taulukko_richTextBox;
        private System.Windows.Forms.Button poistu_button;
        private System.Windows.Forms.Button kirjaudu_button;
        private System.Windows.Forms.TextBox kayttajatunnus_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}