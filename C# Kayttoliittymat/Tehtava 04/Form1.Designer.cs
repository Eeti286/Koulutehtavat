
namespace Tehtava_04
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
            this.valinta1_button = new System.Windows.Forms.Button();
            this.valinta2_button = new System.Windows.Forms.Button();
            this.valinta3_button = new System.Windows.Forms.Button();
            this.valinta4_button = new System.Windows.Forms.Button();
            this.default_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // valinta1_button
            // 
            this.valinta1_button.Location = new System.Drawing.Point(110, 27);
            this.valinta1_button.Name = "valinta1_button";
            this.valinta1_button.Size = new System.Drawing.Size(94, 29);
            this.valinta1_button.TabIndex = 0;
            this.valinta1_button.Text = "Valinta1";
            this.valinta1_button.UseVisualStyleBackColor = true;
            this.valinta1_button.Click += new System.EventHandler(this.ButtonClick);
            // 
            // valinta2_button
            // 
            this.valinta2_button.Location = new System.Drawing.Point(110, 83);
            this.valinta2_button.Name = "valinta2_button";
            this.valinta2_button.Size = new System.Drawing.Size(94, 29);
            this.valinta2_button.TabIndex = 1;
            this.valinta2_button.Text = "Valinta2";
            this.valinta2_button.UseVisualStyleBackColor = true;
            this.valinta2_button.Click += new System.EventHandler(this.ButtonClick);
            // 
            // valinta3_button
            // 
            this.valinta3_button.Location = new System.Drawing.Point(110, 139);
            this.valinta3_button.Name = "valinta3_button";
            this.valinta3_button.Size = new System.Drawing.Size(94, 29);
            this.valinta3_button.TabIndex = 2;
            this.valinta3_button.Text = "Valinta3";
            this.valinta3_button.UseVisualStyleBackColor = true;
            this.valinta3_button.Click += new System.EventHandler(this.ButtonClick);
            // 
            // valinta4_button
            // 
            this.valinta4_button.Location = new System.Drawing.Point(110, 196);
            this.valinta4_button.Name = "valinta4_button";
            this.valinta4_button.Size = new System.Drawing.Size(94, 29);
            this.valinta4_button.TabIndex = 3;
            this.valinta4_button.Text = "Valinta4";
            this.valinta4_button.UseVisualStyleBackColor = true;
            this.valinta4_button.Click += new System.EventHandler(this.ButtonClick);
            // 
            // default_button
            // 
            this.default_button.Location = new System.Drawing.Point(110, 251);
            this.default_button.Name = "default_button";
            this.default_button.Size = new System.Drawing.Size(94, 29);
            this.default_button.TabIndex = 4;
            this.default_button.Text = "Default";
            this.default_button.UseVisualStyleBackColor = true;
            this.default_button.Click += new System.EventHandler(this.default_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 412);
            this.Controls.Add(this.default_button);
            this.Controls.Add(this.valinta4_button);
            this.Controls.Add(this.valinta3_button);
            this.Controls.Add(this.valinta2_button);
            this.Controls.Add(this.valinta1_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button valinta1_button;
        private System.Windows.Forms.Button valinta2_button;
        private System.Windows.Forms.Button valinta3_button;
        private System.Windows.Forms.Button valinta4_button;
        private System.Windows.Forms.Button default_button;
    }
}

