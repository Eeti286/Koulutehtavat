
namespace Tehtava_10
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
            this.luo_button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.key_textBox1 = new System.Windows.Forms.TextBox();
            this.value_textBox2 = new System.Windows.Forms.TextBox();
            this.key_hae_textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lisaa_button2 = new System.Windows.Forms.Button();
            this.hae_button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tulosta_label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(106, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Luodaan dictionary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(106, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lisätään elementtejä";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(106, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Haetaan elementtejä";
            // 
            // luo_button1
            // 
            this.luo_button1.Location = new System.Drawing.Point(122, 83);
            this.luo_button1.Name = "luo_button1";
            this.luo_button1.Size = new System.Drawing.Size(150, 30);
            this.luo_button1.TabIndex = 3;
            this.luo_button1.Text = "Luo Dictionary";
            this.luo_button1.UseVisualStyleBackColor = true;
            this.luo_button1.Click += new System.EventHandler(this.luo_button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Key:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Value:";
            // 
            // key_textBox1
            // 
            this.key_textBox1.Location = new System.Drawing.Point(106, 200);
            this.key_textBox1.Name = "key_textBox1";
            this.key_textBox1.Size = new System.Drawing.Size(166, 27);
            this.key_textBox1.TabIndex = 6;
            // 
            // value_textBox2
            // 
            this.value_textBox2.Location = new System.Drawing.Point(106, 262);
            this.value_textBox2.Name = "value_textBox2";
            this.value_textBox2.Size = new System.Drawing.Size(166, 27);
            this.value_textBox2.TabIndex = 7;
            // 
            // key_hae_textBox3
            // 
            this.key_hae_textBox3.Location = new System.Drawing.Point(106, 364);
            this.key_hae_textBox3.Name = "key_hae_textBox3";
            this.key_hae_textBox3.Size = new System.Drawing.Size(166, 27);
            this.key_hae_textBox3.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Key:";
            // 
            // lisaa_button2
            // 
            this.lisaa_button2.Location = new System.Drawing.Point(287, 262);
            this.lisaa_button2.Name = "lisaa_button2";
            this.lisaa_button2.Size = new System.Drawing.Size(94, 29);
            this.lisaa_button2.TabIndex = 10;
            this.lisaa_button2.Text = "Lisää";
            this.lisaa_button2.UseVisualStyleBackColor = true;
            this.lisaa_button2.Click += new System.EventHandler(this.lisaa_button2_Click);
            // 
            // hae_button3
            // 
            this.hae_button3.Location = new System.Drawing.Point(287, 364);
            this.hae_button3.Name = "hae_button3";
            this.hae_button3.Size = new System.Drawing.Size(94, 29);
            this.hae_button3.TabIndex = 11;
            this.hae_button3.Text = "Hae";
            this.hae_button3.UseVisualStyleBackColor = true;
            this.hae_button3.Click += new System.EventHandler(this.hae_button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Value:";
            // 
            // tulosta_label8
            // 
            this.tulosta_label8.AutoSize = true;
            this.tulosta_label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tulosta_label8.Location = new System.Drawing.Point(106, 409);
            this.tulosta_label8.Name = "tulosta_label8";
            this.tulosta_label8.Size = new System.Drawing.Size(55, 28);
            this.tulosta_label8.TabIndex = 13;
            this.tulosta_label8.Text = "Auto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 450);
            this.Controls.Add(this.tulosta_label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.hae_button3);
            this.Controls.Add(this.lisaa_button2);
            this.Controls.Add(this.key_hae_textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.value_textBox2);
            this.Controls.Add(this.key_textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.luo_button1);
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
        private System.Windows.Forms.Button luo_button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox key_textBox1;
        private System.Windows.Forms.TextBox value_textBox2;
        private System.Windows.Forms.TextBox key_hae_textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button lisaa_button2;
        private System.Windows.Forms.Button hae_button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label tulosta_label8;
    }
}

