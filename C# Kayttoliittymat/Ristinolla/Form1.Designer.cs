
namespace Ristinolla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Box = new System.Windows.Forms.GroupBox();
            this.voitto_label = new System.Windows.Forms.Label();
            this.aloita_peli_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pelaajaA_pisteet_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pelaajaB_pisteet_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.peli_maara_trackBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.peli_maara_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.vuoro_pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peli_maara_trackBar)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vuoro_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Box
            // 
            this.Box.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Box, "Box");
            this.Box.Name = "Box";
            this.Box.TabStop = false;
            // 
            // voitto_label
            // 
            resources.ApplyResources(this.voitto_label, "voitto_label");
            this.voitto_label.ForeColor = System.Drawing.Color.White;
            this.voitto_label.Name = "voitto_label";
            this.voitto_label.UseMnemonic = false;
            // 
            // aloita_peli_button
            // 
            this.aloita_peli_button.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.aloita_peli_button, "aloita_peli_button");
            this.aloita_peli_button.ForeColor = System.Drawing.Color.MediumPurple;
            this.aloita_peli_button.Name = "aloita_peli_button";
            this.aloita_peli_button.UseVisualStyleBackColor = false;
            this.aloita_peli_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pelaajaA_pisteet_label);
            this.groupBox1.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // pelaajaA_pisteet_label
            // 
            resources.ApplyResources(this.pelaajaA_pisteet_label, "pelaajaA_pisteet_label");
            this.pelaajaA_pisteet_label.ForeColor = System.Drawing.Color.White;
            this.pelaajaA_pisteet_label.Name = "pelaajaA_pisteet_label";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.pelaajaB_pisteet_label);
            this.groupBox2.Controls.Add(this.label2);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // pelaajaB_pisteet_label
            // 
            resources.ApplyResources(this.pelaajaB_pisteet_label, "pelaajaB_pisteet_label");
            this.pelaajaB_pisteet_label.ForeColor = System.Drawing.Color.White;
            this.pelaajaB_pisteet_label.Name = "pelaajaB_pisteet_label";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // peli_maara_trackBar
            // 
            this.peli_maara_trackBar.BackColor = System.Drawing.Color.MediumPurple;
            resources.ApplyResources(this.peli_maara_trackBar, "peli_maara_trackBar");
            this.peli_maara_trackBar.Minimum = 1;
            this.peli_maara_trackBar.Name = "peli_maara_trackBar";
            this.peli_maara_trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.peli_maara_trackBar.Value = 1;
            this.peli_maara_trackBar.Scroll += new System.EventHandler(this.peli_maara_trackBar_Scroll);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // peli_maara_label
            // 
            resources.ApplyResources(this.peli_maara_label, "peli_maara_label");
            this.peli_maara_label.ForeColor = System.Drawing.Color.White;
            this.peli_maara_label.Name = "peli_maara_label";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BlueViolet;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.BlueViolet;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.vuoro_pictureBox);
            this.panel3.Controls.Add(this.voitto_label);
            this.panel3.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // vuoro_pictureBox
            // 
            resources.ApplyResources(this.vuoro_pictureBox, "vuoro_pictureBox");
            this.vuoro_pictureBox.Name = "vuoro_pictureBox";
            this.vuoro_pictureBox.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.peli_maara_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.peli_maara_trackBar);
            this.Controls.Add(this.aloita_peli_button);
            this.Controls.Add(this.Box);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peli_maara_trackBar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vuoro_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Box;
        private System.Windows.Forms.Button aloita_peli_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar peli_maara_trackBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label peli_maara_label;
        private System.Windows.Forms.Label pelaajaB_pisteet_label;
        private System.Windows.Forms.Label voitto_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label pelaajaA_pisteet_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox vuoro_pictureBox;
    }
}

