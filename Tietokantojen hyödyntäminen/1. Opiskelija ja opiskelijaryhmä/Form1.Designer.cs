
namespace _1.Opiskelija_ja_opiskelijaryhmä
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.etunimi_textBox = new System.Windows.Forms.TextBox();
            this.sukunimi_textBox = new System.Windows.Forms.TextBox();
            this.lisää_button = new System.Windows.Forms.Button();
            this.poista_button = new System.Windows.Forms.Button();
            this.hae_button = new System.Windows.Forms.Button();
            this.hae_textBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(775, 305);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // etunimi_textBox
            // 
            this.etunimi_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.etunimi_textBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.etunimi_textBox.Location = new System.Drawing.Point(13, 324);
            this.etunimi_textBox.Name = "etunimi_textBox";
            this.etunimi_textBox.Size = new System.Drawing.Size(208, 30);
            this.etunimi_textBox.TabIndex = 1;
            this.etunimi_textBox.Text = "Etunimi";
            this.etunimi_textBox.TextChanged += new System.EventHandler(this.etunimi_textBox_TextChanged);
            // 
            // sukunimi_textBox
            // 
            this.sukunimi_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sukunimi_textBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.sukunimi_textBox.Location = new System.Drawing.Point(13, 360);
            this.sukunimi_textBox.Name = "sukunimi_textBox";
            this.sukunimi_textBox.Size = new System.Drawing.Size(208, 30);
            this.sukunimi_textBox.TabIndex = 2;
            this.sukunimi_textBox.Text = "Sukunimi";
            // 
            // lisää_button
            // 
            this.lisää_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lisää_button.Location = new System.Drawing.Point(42, 442);
            this.lisää_button.Name = "lisää_button";
            this.lisää_button.Size = new System.Drawing.Size(135, 42);
            this.lisää_button.TabIndex = 3;
            this.lisää_button.Text = "LIsää";
            this.lisää_button.UseVisualStyleBackColor = true;
            this.lisää_button.Click += new System.EventHandler(this.lisää_button_Click);
            // 
            // poista_button
            // 
            this.poista_button.BackColor = System.Drawing.Color.Red;
            this.poista_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.poista_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.poista_button.Location = new System.Drawing.Point(349, 360);
            this.poista_button.Name = "poista_button";
            this.poista_button.Size = new System.Drawing.Size(127, 48);
            this.poista_button.TabIndex = 4;
            this.poista_button.Text = "Poista";
            this.poista_button.UseVisualStyleBackColor = false;
            this.poista_button.Click += new System.EventHandler(this.poista_button_Click);
            // 
            // hae_button
            // 
            this.hae_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.hae_button.Location = new System.Drawing.Point(609, 396);
            this.hae_button.Name = "hae_button";
            this.hae_button.Size = new System.Drawing.Size(135, 42);
            this.hae_button.TabIndex = 6;
            this.hae_button.Text = "Hae";
            this.hae_button.UseVisualStyleBackColor = true;
            // 
            // hae_textBox
            // 
            this.hae_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.hae_textBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.hae_textBox.Location = new System.Drawing.Point(580, 360);
            this.hae_textBox.Name = "hae_textBox";
            this.hae_textBox.Size = new System.Drawing.Size(208, 30);
            this.hae_textBox.TabIndex = 5;
            this.hae_textBox.Text = "Hae";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 396);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(208, 33);
            this.comboBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 571);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.hae_button);
            this.Controls.Add(this.hae_textBox);
            this.Controls.Add(this.poista_button);
            this.Controls.Add(this.lisää_button);
            this.Controls.Add(this.sukunimi_textBox);
            this.Controls.Add(this.etunimi_textBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox etunimi_textBox;
        private System.Windows.Forms.TextBox sukunimi_textBox;
        private System.Windows.Forms.Button lisää_button;
        private System.Windows.Forms.Button poista_button;
        private System.Windows.Forms.Button hae_button;
        private System.Windows.Forms.TextBox hae_textBox;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

