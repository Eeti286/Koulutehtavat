
namespace Tehtava_01
{
    partial class Elokuvasovellus
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
            this.uusi_tietue_button = new System.Windows.Forms.Button();
            this.tallenna_button = new System.Windows.Forms.Button();
            this.poista_button = new System.Windows.Forms.Button();
            this.kesto_textBox = new System.Windows.Forms.TextBox();
            this.nimi_textBox = new System.Windows.Forms.TextBox();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.julkaisuvuosi_textBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.seuraava_button = new System.Windows.Forms.Button();
            this.edellinen_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.arvio = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.arvosana_numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.arvosana_numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.arvio_textBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tiedostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poistuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tietojaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testaaTietokantayhteyttäToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.arvio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arvosana_numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arvosana_numericUpDown1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uusi_tietue_button
            // 
            this.uusi_tietue_button.Location = new System.Drawing.Point(32, 47);
            this.uusi_tietue_button.Name = "uusi_tietue_button";
            this.uusi_tietue_button.Size = new System.Drawing.Size(280, 70);
            this.uusi_tietue_button.TabIndex = 0;
            this.uusi_tietue_button.Text = "Uusi tietue";
            this.uusi_tietue_button.UseVisualStyleBackColor = true;
            this.uusi_tietue_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // tallenna_button
            // 
            this.tallenna_button.BackColor = System.Drawing.Color.ForestGreen;
            this.tallenna_button.Location = new System.Drawing.Point(32, 139);
            this.tallenna_button.Name = "tallenna_button";
            this.tallenna_button.Size = new System.Drawing.Size(280, 70);
            this.tallenna_button.TabIndex = 1;
            this.tallenna_button.Text = "Tallenna ";
            this.tallenna_button.UseVisualStyleBackColor = false;
            this.tallenna_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // poista_button
            // 
            this.poista_button.BackColor = System.Drawing.SystemColors.Desktop;
            this.poista_button.Location = new System.Drawing.Point(32, 233);
            this.poista_button.Name = "poista_button";
            this.poista_button.Size = new System.Drawing.Size(280, 70);
            this.poista_button.TabIndex = 2;
            this.poista_button.Text = "Poista";
            this.poista_button.UseVisualStyleBackColor = false;
            // 
            // kesto_textBox
            // 
            this.kesto_textBox.Location = new System.Drawing.Point(177, 164);
            this.kesto_textBox.Name = "kesto_textBox";
            this.kesto_textBox.Size = new System.Drawing.Size(150, 27);
            this.kesto_textBox.TabIndex = 3;
            this.kesto_textBox.Click += new System.EventHandler(this.kesto_textBox_Click);
            this.kesto_textBox.Leave += new System.EventHandler(this.kesto_textBox_Leave);
            // 
            // nimi_textBox
            // 
            this.nimi_textBox.Location = new System.Drawing.Point(177, 69);
            this.nimi_textBox.Name = "nimi_textBox";
            this.nimi_textBox.Size = new System.Drawing.Size(200, 27);
            this.nimi_textBox.TabIndex = 4;
            this.nimi_textBox.Click += new System.EventHandler(this.nimi_textBox_Click);
            this.nimi_textBox.Leave += new System.EventHandler(this.nimi_textBox_Leave);
            // 
            // id_textBox
            // 
            this.id_textBox.Location = new System.Drawing.Point(177, 23);
            this.id_textBox.Name = "id_textBox";
            this.id_textBox.ReadOnly = true;
            this.id_textBox.Size = new System.Drawing.Size(150, 27);
            this.id_textBox.TabIndex = 5;
            this.id_textBox.TextChanged += new System.EventHandler(this.id_textBox_TextChanged);
            // 
            // julkaisuvuosi_textBox
            // 
            this.julkaisuvuosi_textBox.Location = new System.Drawing.Point(177, 116);
            this.julkaisuvuosi_textBox.Name = "julkaisuvuosi_textBox";
            this.julkaisuvuosi_textBox.Size = new System.Drawing.Size(150, 27);
            this.julkaisuvuosi_textBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.seuraava_button);
            this.groupBox1.Controls.Add(this.edellinen_button);
            this.groupBox1.Controls.Add(this.id_textBox);
            this.groupBox1.Controls.Add(this.nimi_textBox);
            this.groupBox1.Controls.Add(this.julkaisuvuosi_textBox);
            this.groupBox1.Controls.Add(this.kesto_textBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 293);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elokuvan tiedot";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Kesto (min):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Julkaisuvuosi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nimi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID:";
            // 
            // seuraava_button
            // 
            this.seuraava_button.Location = new System.Drawing.Point(227, 227);
            this.seuraava_button.Name = "seuraava_button";
            this.seuraava_button.Size = new System.Drawing.Size(150, 50);
            this.seuraava_button.TabIndex = 8;
            this.seuraava_button.Text = "Seuraava";
            this.seuraava_button.UseVisualStyleBackColor = true;
            // 
            // edellinen_button
            // 
            this.edellinen_button.Location = new System.Drawing.Point(35, 227);
            this.edellinen_button.Name = "edellinen_button";
            this.edellinen_button.Size = new System.Drawing.Size(150, 50);
            this.edellinen_button.TabIndex = 7;
            this.edellinen_button.Text = "Edellinen";
            this.edellinen_button.UseVisualStyleBackColor = true;
            this.edellinen_button.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.uusi_tietue_button);
            this.groupBox2.Controls.Add(this.tallenna_button);
            this.groupBox2.Controls.Add(this.poista_button);
            this.groupBox2.Location = new System.Drawing.Point(446, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 498);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Toiminnallisuus";
            // 
            // arvio
            // 
            this.arvio.Controls.Add(this.label1);
            this.arvio.Controls.Add(this.arvosana_numericUpDown2);
            this.arvio.Controls.Add(this.arvosana_numericUpDown1);
            this.arvio.Controls.Add(this.arvio_textBox);
            this.arvio.Location = new System.Drawing.Point(12, 344);
            this.arvio.Name = "arvio";
            this.arvio.Size = new System.Drawing.Size(428, 199);
            this.arvio.TabIndex = 10;
            this.arvio.TabStop = false;
            this.arvio.Text = "Arvio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Arvosana:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // arvosana_numericUpDown2
            // 
            this.arvosana_numericUpDown2.Location = new System.Drawing.Point(210, 170);
            this.arvosana_numericUpDown2.Name = "arvosana_numericUpDown2";
            this.arvosana_numericUpDown2.Size = new System.Drawing.Size(50, 27);
            this.arvosana_numericUpDown2.TabIndex = 2;
            // 
            // arvosana_numericUpDown1
            // 
            this.arvosana_numericUpDown1.Location = new System.Drawing.Point(136, 170);
            this.arvosana_numericUpDown1.Name = "arvosana_numericUpDown1";
            this.arvosana_numericUpDown1.Size = new System.Drawing.Size(50, 27);
            this.arvosana_numericUpDown1.TabIndex = 1;
            // 
            // arvio_textBox
            // 
            this.arvio_textBox.Location = new System.Drawing.Point(22, 26);
            this.arvio_textBox.Name = "arvio_textBox";
            this.arvio_textBox.Size = new System.Drawing.Size(386, 120);
            this.arvio_textBox.TabIndex = 0;
            this.arvio_textBox.Text = "";
            this.arvio_textBox.Click += new System.EventHandler(this.arvio_textBox_Click);
            this.arvio_textBox.Leave += new System.EventHandler(this.arvio_textBox_Leave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiedostoToolStripMenuItem,
            this.tietojaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tiedostoToolStripMenuItem
            // 
            this.tiedostoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poistuToolStripMenuItem});
            this.tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            this.tiedostoToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.tiedostoToolStripMenuItem.Text = "Tiedosto";
            // 
            // poistuToolStripMenuItem
            // 
            this.poistuToolStripMenuItem.Name = "poistuToolStripMenuItem";
            this.poistuToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.poistuToolStripMenuItem.Text = "Poistu";
            this.poistuToolStripMenuItem.Click += new System.EventHandler(this.poistuToolStripMenuItem_Click);
            // 
            // tietojaToolStripMenuItem
            // 
            this.tietojaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testaaTietokantayhteyttäToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.tietojaToolStripMenuItem.Name = "tietojaToolStripMenuItem";
            this.tietojaToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.tietojaToolStripMenuItem.Text = "Tietoja";
            // 
            // testaaTietokantayhteyttäToolStripMenuItem
            // 
            this.testaaTietokantayhteyttäToolStripMenuItem.Name = "testaaTietokantayhteyttäToolStripMenuItem";
            this.testaaTietokantayhteyttäToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.testaaTietokantayhteyttäToolStripMenuItem.Text = "Testaa tietokantayhteyttä";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // Elokuvasovellus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.arvio);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Elokuvasovellus";
            this.Text = "Elokuvasovellus";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.arvio.ResumeLayout(false);
            this.arvio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arvosana_numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arvosana_numericUpDown1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uusi_tietue_button;
        private System.Windows.Forms.Button tallenna_button;
        private System.Windows.Forms.Button poista_button;
        private System.Windows.Forms.TextBox kesto_textBox;
        private System.Windows.Forms.TextBox nimi_textBox;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.TextBox julkaisuvuosi_textBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button edellinen_button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox arvio;
        private System.Windows.Forms.Button seuraava_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown arvosana_numericUpDown2;
        private System.Windows.Forms.NumericUpDown arvosana_numericUpDown1;
        private System.Windows.Forms.RichTextBox arvio_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tiedostoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poistuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tietojaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testaaTietokantayhteyttäToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
    }
}

