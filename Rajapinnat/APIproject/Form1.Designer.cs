
namespace APIproject
{
    partial class NHLAPIProject
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
            this.GridPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TeamName = new System.Windows.Forms.Label();
            this.TeamDescription = new System.Windows.Forms.Label();
            this.MatchInfoLabel = new System.Windows.Forms.Label();
            this.NextMatch = new System.Windows.Forms.Label();
            this.Venue = new System.Windows.Forms.Label();
            this.VenueInfo = new System.Windows.Forms.Label();
            this.MatchDate = new System.Windows.Forms.Label();
            this.TeamLogo = new System.Windows.Forms.PictureBox();
            this.roster = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TeamLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // GridPanel
            // 
            this.GridPanel.AutoScroll = true;
            this.GridPanel.Location = new System.Drawing.Point(12, 44);
            this.GridPanel.Name = "GridPanel";
            this.GridPanel.Size = new System.Drawing.Size(466, 697);
            this.GridPanel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(182, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "W | T | L";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(14, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Teams";
            // 
            // TeamName
            // 
            this.TeamName.AutoSize = true;
            this.TeamName.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold);
            this.TeamName.Location = new System.Drawing.Point(480, 46);
            this.TeamName.Name = "TeamName";
            this.TeamName.Size = new System.Drawing.Size(0, 29);
            this.TeamName.TabIndex = 8;
            this.TeamName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TeamDescription
            // 
            this.TeamDescription.AutoSize = true;
            this.TeamDescription.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic);
            this.TeamDescription.Location = new System.Drawing.Point(483, 78);
            this.TeamDescription.Name = "TeamDescription";
            this.TeamDescription.Size = new System.Drawing.Size(0, 20);
            this.TeamDescription.TabIndex = 9;
            this.TeamDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MatchInfoLabel
            // 
            this.MatchInfoLabel.AutoSize = true;
            this.MatchInfoLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.MatchInfoLabel.Location = new System.Drawing.Point(480, 156);
            this.MatchInfoLabel.Name = "MatchInfoLabel";
            this.MatchInfoLabel.Size = new System.Drawing.Size(131, 23);
            this.MatchInfoLabel.TabIndex = 10;
            this.MatchInfoLabel.Text = "Next match:";
            this.MatchInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NextMatch
            // 
            this.NextMatch.AutoSize = true;
            this.NextMatch.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextMatch.Location = new System.Drawing.Point(482, 187);
            this.NextMatch.Name = "NextMatch";
            this.NextMatch.Size = new System.Drawing.Size(0, 20);
            this.NextMatch.TabIndex = 11;
            this.NextMatch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Venue
            // 
            this.Venue.AutoSize = true;
            this.Venue.Font = new System.Drawing.Font("Consolas", 10F);
            this.Venue.Location = new System.Drawing.Point(481, 275);
            this.Venue.Name = "Venue";
            this.Venue.Size = new System.Drawing.Size(0, 20);
            this.Venue.TabIndex = 13;
            this.Venue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VenueInfo
            // 
            this.VenueInfo.AutoSize = true;
            this.VenueInfo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.VenueInfo.Location = new System.Drawing.Point(479, 244);
            this.VenueInfo.Name = "VenueInfo";
            this.VenueInfo.Size = new System.Drawing.Size(76, 23);
            this.VenueInfo.TabIndex = 12;
            this.VenueInfo.Text = "Venue:";
            this.VenueInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MatchDate
            // 
            this.MatchDate.AutoSize = true;
            this.MatchDate.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatchDate.Location = new System.Drawing.Point(482, 207);
            this.MatchDate.Name = "MatchDate";
            this.MatchDate.Size = new System.Drawing.Size(0, 20);
            this.MatchDate.TabIndex = 14;
            this.MatchDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TeamLogo
            // 
            this.TeamLogo.BackColor = System.Drawing.SystemColors.Control;
            this.TeamLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TeamLogo.Cursor = System.Windows.Forms.Cursors.No;
            this.TeamLogo.Location = new System.Drawing.Point(863, 12);
            this.TeamLogo.Name = "TeamLogo";
            this.TeamLogo.Size = new System.Drawing.Size(100, 100);
            this.TeamLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TeamLogo.TabIndex = 15;
            this.TeamLogo.TabStop = false;
            // 
            // roster
            // 
            this.roster.AccessibleName = "roster";
            this.roster.BackColor = System.Drawing.SystemColors.Menu;
            this.roster.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roster.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roster.ForeColor = System.Drawing.SystemColors.ControlText;
            this.roster.FormattingEnabled = true;
            this.roster.ItemHeight = 20;
            this.roster.Location = new System.Drawing.Point(483, 361);
            this.roster.Name = "roster";
            this.roster.Size = new System.Drawing.Size(480, 380);
            this.roster.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(480, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Roster:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NHLAPIProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 753);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roster);
            this.Controls.Add(this.TeamLogo);
            this.Controls.Add(this.MatchDate);
            this.Controls.Add(this.Venue);
            this.Controls.Add(this.VenueInfo);
            this.Controls.Add(this.NextMatch);
            this.Controls.Add(this.MatchInfoLabel);
            this.Controls.Add(this.TeamDescription);
            this.Controls.Add(this.TeamName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GridPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "NHLAPIProject";
            this.Text = "NHL";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TeamLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel GridPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TeamName;
        private System.Windows.Forms.Label TeamDescription;
        private System.Windows.Forms.Label MatchInfoLabel;
        private System.Windows.Forms.Label NextMatch;
        private System.Windows.Forms.Label Venue;
        private System.Windows.Forms.Label VenueInfo;
        private System.Windows.Forms.Label MatchDate;
        private System.Windows.Forms.PictureBox TeamLogo;
        private System.Windows.Forms.ListBox roster;
        private System.Windows.Forms.Label label1;
    }
}

