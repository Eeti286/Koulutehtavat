namespace Autokauppa.view
{
    partial class MainMenu
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
            this.btnSeuraava = new System.Windows.Forms.Button();
            this.gbAuto = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPolttoaine = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbVari = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMalli = new System.Windows.Forms.ComboBox();
            this.dtpPaiva = new System.Windows.Forms.DateTimePicker();
            this.tbMittarilukema = new System.Windows.Forms.TextBox();
            this.tbTilavuus = new System.Windows.Forms.TextBox();
            this.tbHinta = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMerkki = new System.Windows.Forms.ComboBox();
            this.btnEdellinen = new System.Windows.Forms.Button();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.testaaTietokantayhteyttäToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.btnTyhjenna = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.gbAuto.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSeuraava
            // 
            this.btnSeuraava.Location = new System.Drawing.Point(127, 323);
            this.btnSeuraava.Name = "btnSeuraava";
            this.btnSeuraava.Size = new System.Drawing.Size(89, 33);
            this.btnSeuraava.TabIndex = 17;
            this.btnSeuraava.Text = "Seuraava";
            this.btnSeuraava.UseVisualStyleBackColor = true;
            this.btnSeuraava.Click += new System.EventHandler(this.btnSeuraava_Click);
            // 
            // gbAuto
            // 
            this.gbAuto.Controls.Add(this.label8);
            this.gbAuto.Controls.Add(this.label7);
            this.gbAuto.Controls.Add(this.label6);
            this.gbAuto.Controls.Add(this.label5);
            this.gbAuto.Controls.Add(this.label4);
            this.gbAuto.Controls.Add(this.cbPolttoaine);
            this.gbAuto.Controls.Add(this.label3);
            this.gbAuto.Controls.Add(this.cbVari);
            this.gbAuto.Controls.Add(this.label2);
            this.gbAuto.Controls.Add(this.cbMalli);
            this.gbAuto.Controls.Add(this.dtpPaiva);
            this.gbAuto.Controls.Add(this.tbMittarilukema);
            this.gbAuto.Controls.Add(this.tbTilavuus);
            this.gbAuto.Controls.Add(this.tbHinta);
            this.gbAuto.Controls.Add(this.tbId);
            this.gbAuto.Controls.Add(this.label1);
            this.gbAuto.Controls.Add(this.cbMerkki);
            this.gbAuto.Location = new System.Drawing.Point(12, 36);
            this.gbAuto.Name = "gbAuto";
            this.gbAuto.Size = new System.Drawing.Size(321, 275);
            this.gbAuto.TabIndex = 18;
            this.gbAuto.TabStop = false;
            this.gbAuto.Text = "Auton tiedot";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Mittarilukema";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "Tilavuus";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Hinta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Polttoaine";
            // 
            // cbPolttoaine
            // 
            this.cbPolttoaine.FormattingEnabled = true;
            this.cbPolttoaine.Location = new System.Drawing.Point(183, 204);
            this.cbPolttoaine.Name = "cbPolttoaine";
            this.cbPolttoaine.Size = new System.Drawing.Size(121, 24);
            this.cbPolttoaine.TabIndex = 28;
            this.cbPolttoaine.Click += new System.EventHandler(this.cbPolttoaine_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Väri";
            // 
            // cbVari
            // 
            this.cbVari.FormattingEnabled = true;
            this.cbVari.Location = new System.Drawing.Point(183, 147);
            this.cbVari.Name = "cbVari";
            this.cbVari.Size = new System.Drawing.Size(121, 24);
            this.cbVari.TabIndex = 26;
            this.cbVari.Click += new System.EventHandler(this.cbVari_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Malli";
            // 
            // cbMalli
            // 
            this.cbMalli.FormattingEnabled = true;
            this.cbMalli.Location = new System.Drawing.Point(183, 93);
            this.cbMalli.Name = "cbMalli";
            this.cbMalli.Size = new System.Drawing.Size(121, 24);
            this.cbMalli.TabIndex = 24;
            this.cbMalli.SelectedIndexChanged += new System.EventHandler(this.cbMalli_SelectedIndexChanged);
            this.cbMalli.Click += new System.EventHandler(this.cbMalli_Click);
            // 
            // dtpPaiva
            // 
            this.dtpPaiva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPaiva.Location = new System.Drawing.Point(17, 244);
            this.dtpPaiva.Name = "dtpPaiva";
            this.dtpPaiva.Size = new System.Drawing.Size(116, 22);
            this.dtpPaiva.TabIndex = 23;
            // 
            // tbMittarilukema
            // 
            this.tbMittarilukema.Location = new System.Drawing.Point(17, 206);
            this.tbMittarilukema.Name = "tbMittarilukema";
            this.tbMittarilukema.Size = new System.Drawing.Size(116, 22);
            this.tbMittarilukema.TabIndex = 22;
            // 
            // tbTilavuus
            // 
            this.tbTilavuus.Location = new System.Drawing.Point(17, 149);
            this.tbTilavuus.Name = "tbTilavuus";
            this.tbTilavuus.Size = new System.Drawing.Size(116, 22);
            this.tbTilavuus.TabIndex = 21;
            // 
            // tbHinta
            // 
            this.tbHinta.Location = new System.Drawing.Point(17, 95);
            this.tbHinta.Name = "tbHinta";
            this.tbHinta.Size = new System.Drawing.Size(116, 22);
            this.tbHinta.TabIndex = 20;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(17, 45);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(116, 22);
            this.tbId.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Automerkki";
            // 
            // cbMerkki
            // 
            this.cbMerkki.FormattingEnabled = true;
            this.cbMerkki.Location = new System.Drawing.Point(181, 43);
            this.cbMerkki.Name = "cbMerkki";
            this.cbMerkki.Size = new System.Drawing.Size(121, 24);
            this.cbMerkki.TabIndex = 17;
            this.cbMerkki.SelectedIndexChanged += new System.EventHandler(this.cbMerkki_SelectedIndexChanged);
            this.cbMerkki.Click += new System.EventHandler(this.cbMerkki_Click);
            // 
            // btnEdellinen
            // 
            this.btnEdellinen.Location = new System.Drawing.Point(12, 323);
            this.btnEdellinen.Name = "btnEdellinen";
            this.btnEdellinen.Size = new System.Drawing.Size(93, 33);
            this.btnEdellinen.TabIndex = 19;
            this.btnEdellinen.Text = "Edellinen";
            this.btnEdellinen.UseVisualStyleBackColor = true;
            this.btnEdellinen.Click += new System.EventHandler(this.btnEdellinen_Click);
            // 
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(244, 323);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(89, 33);
            this.btnLisaa.TabIndex = 21;
            this.btnLisaa.Text = "Lisää";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem2});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem2
            // 
            this.exitToolStripMenuItem2.Name = "exitToolStripMenuItem2";
            this.exitToolStripMenuItem2.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem2.Text = "Exit";
            this.exitToolStripMenuItem2.Click += new System.EventHandler(this.exitToolStripMenuItem2_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testaaTietokantayhteyttäToolStripMenuItem});
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // testaaTietokantayhteyttäToolStripMenuItem
            // 
            this.testaaTietokantayhteyttäToolStripMenuItem.Name = "testaaTietokantayhteyttäToolStripMenuItem";
            this.testaaTietokantayhteyttäToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.testaaTietokantayhteyttäToolStripMenuItem.Text = "Testaa tietokantayhteyttä";
            this.testaaTietokantayhteyttäToolStripMenuItem.Click += new System.EventHandler(this.TestDatabaseConnection);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(652, 28);
            this.menuStrip2.TabIndex = 22;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // btnTyhjenna
            // 
            this.btnTyhjenna.Location = new System.Drawing.Point(339, 323);
            this.btnTyhjenna.Name = "btnTyhjenna";
            this.btnTyhjenna.Size = new System.Drawing.Size(89, 33);
            this.btnTyhjenna.TabIndex = 23;
            this.btnTyhjenna.Text = "Tyhjennä";
            this.btnTyhjenna.UseVisualStyleBackColor = true;
            this.btnTyhjenna.Click += new System.EventHandler(this.btnTyhjenna_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(434, 323);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(89, 33);
            this.btnPoista.TabIndex = 24;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 373);
            this.Controls.Add(this.btnPoista);
            this.Controls.Add(this.btnTyhjenna);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.btnEdellinen);
            this.Controls.Add(this.gbAuto);
            this.Controls.Add(this.btnSeuraava);
            this.Controls.Add(this.menuStrip2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.gbAuto.ResumeLayout(false);
            this.gbAuto.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSeuraava;
        private System.Windows.Forms.GroupBox gbAuto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbPolttoaine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbVari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMalli;
        private System.Windows.Forms.DateTimePicker dtpPaiva;
        private System.Windows.Forms.TextBox tbMittarilukema;
        private System.Windows.Forms.TextBox tbTilavuus;
        private System.Windows.Forms.TextBox tbHinta;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMerkki;
        private System.Windows.Forms.Button btnEdellinen;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem testaaTietokantayhteyttäToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Button btnTyhjenna;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPoista;
    }
}