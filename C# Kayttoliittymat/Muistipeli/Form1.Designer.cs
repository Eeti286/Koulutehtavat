
namespace Muistipeli
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
            this.components = new System.ComponentModel.Container();
            this.aloita_peli_button = new System.Windows.Forms.Button();
            this.min_label = new System.Windows.Forms.Label();
            this.helppo_radioButton = new System.Windows.Forms.RadioButton();
            this.vaikea_radioButton = new System.Windows.Forms.RadioButton();
            this.Box = new System.Windows.Forms.GroupBox();
            this.voitto_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cs_label = new System.Windows.Forms.Label();
            this.sec_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aloita_peli_button
            // 
            this.aloita_peli_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.aloita_peli_button.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aloita_peli_button.Location = new System.Drawing.Point(550, 48);
            this.aloita_peli_button.Name = "aloita_peli_button";
            this.aloita_peli_button.Size = new System.Drawing.Size(150, 50);
            this.aloita_peli_button.TabIndex = 0;
            this.aloita_peli_button.Text = "Aloita peli";
            this.aloita_peli_button.UseVisualStyleBackColor = true;
            this.aloita_peli_button.Click += new System.EventHandler(this.aloita_peli_button_Click);
            // 
            // min_label
            // 
            this.min_label.AutoSize = true;
            this.min_label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.min_label.Location = new System.Drawing.Point(611, 174);
            this.min_label.Name = "min_label";
            this.min_label.Size = new System.Drawing.Size(28, 35);
            this.min_label.TabIndex = 1;
            this.min_label.Text = "0";
            this.min_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // helppo_radioButton
            // 
            this.helppo_radioButton.AutoSize = true;
            this.helppo_radioButton.Checked = true;
            this.helppo_radioButton.Location = new System.Drawing.Point(550, 125);
            this.helppo_radioButton.Name = "helppo_radioButton";
            this.helppo_radioButton.Size = new System.Drawing.Size(83, 24);
            this.helppo_radioButton.TabIndex = 16;
            this.helppo_radioButton.TabStop = true;
            this.helppo_radioButton.Text = "HELPPO";
            this.helppo_radioButton.UseVisualStyleBackColor = true;
            this.helppo_radioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // vaikea_radioButton
            // 
            this.vaikea_radioButton.AutoSize = true;
            this.vaikea_radioButton.Location = new System.Drawing.Point(639, 125);
            this.vaikea_radioButton.Name = "vaikea_radioButton";
            this.vaikea_radioButton.Size = new System.Drawing.Size(79, 24);
            this.vaikea_radioButton.TabIndex = 17;
            this.vaikea_radioButton.Text = "VAIKEA";
            this.vaikea_radioButton.UseVisualStyleBackColor = true;
            this.vaikea_radioButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Box
            // 
            this.Box.Location = new System.Drawing.Point(4, 1);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(528, 501);
            this.Box.TabIndex = 18;
            this.Box.TabStop = false;
            // 
            // voitto_label
            // 
            this.voitto_label.AutoSize = true;
            this.voitto_label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.voitto_label.Location = new System.Drawing.Point(550, 363);
            this.voitto_label.Name = "voitto_label";
            this.voitto_label.Size = new System.Drawing.Size(0, 35);
            this.voitto_label.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(550, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 35);
            this.label1.TabIndex = 20;
            this.label1.Text = "aika:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cs_label
            // 
            this.cs_label.AutoSize = true;
            this.cs_label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cs_label.Location = new System.Drawing.Point(692, 174);
            this.cs_label.Name = "cs_label";
            this.cs_label.Size = new System.Drawing.Size(41, 35);
            this.cs_label.TabIndex = 21;
            this.cs_label.Text = "00";
            // 
            // sec_label
            // 
            this.sec_label.AutoSize = true;
            this.sec_label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sec_label.Location = new System.Drawing.Point(645, 174);
            this.sec_label.Name = "sec_label";
            this.sec_label.Size = new System.Drawing.Size(41, 35);
            this.sec_label.TabIndex = 22;
            this.sec_label.Text = "00";
            this.sec_label.Click += new System.EventHandler(this.sec_label_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(630, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 35);
            this.label2.TabIndex = 23;
            this.label2.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(680, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 35);
            this.label3.TabIndex = 24;
            this.label3.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 504);
            this.Controls.Add(this.cs_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sec_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.voitto_label);
            this.Controls.Add(this.Box);
            this.Controls.Add(this.vaikea_radioButton);
            this.Controls.Add(this.helppo_radioButton);
            this.Controls.Add(this.min_label);
            this.Controls.Add(this.aloita_peli_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aloita_peli_button;
        private System.Windows.Forms.Label min_label;
        private System.Windows.Forms.RadioButton helppo_radioButton;
        private System.Windows.Forms.RadioButton vaikea_radioButton;
        private System.Windows.Forms.GroupBox Box;
        private System.Windows.Forms.Label voitto_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label cs_label;
        private System.Windows.Forms.Label sec_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

