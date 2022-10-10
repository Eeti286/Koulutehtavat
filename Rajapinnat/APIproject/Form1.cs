using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using APIproject.NHLTeam;

namespace APIproject
{
    public partial class NHLAPIProject : Form
    {

        int GridPosition = 0;
        public delegate void LinkClickedHandler(object sender, EventArgs e);

        public NHLAPIProject()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(Width, Height);
            this.MaximumSize = this.MinimumSize;
            GetNHLTeams();
            MoreButtonClick(sender, e, "/api/v1/teams/1");
        }

        private string RequestApi(string url)
        {
            //string url = String.Format(url);
            WebRequest requestOject = WebRequest.Create(url);
            requestOject.Method = "GET";
            requestOject.ContentType = "application/json; charset=utf-8";
            HttpWebResponse responseObject = null;
            responseObject = (HttpWebResponse)requestOject.GetResponse();

            string result = null;
            using (Stream stream = responseObject.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                result = sr.ReadToEnd();
                sr.Close();
            }
            return result;
        }

        private void GetNHLTeams()
        {
            string result = RequestApi("https://statsapi.web.nhl.com/api/v1/teams?expand=team.stats");
            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(result);
            foreach (var item in myDeserializedClass.teams)
            {
                string wins = "0";
                string loss = "0";
                string ot = "0";
                try 
                { 
                    foreach (var stats in item.teamStats)
                    {
                        wins = stats.splits[0].stat.wins.ToString();
                        loss = stats.splits[0].stat.losses.ToString();
                        ot = stats.splits[0].stat.ot.ToString();
                    } 
                }
                catch
                {

                }
                CreateGrid(item.teamName, item.officialSiteUrl, wins, loss, ot, item.link);
            }
        }

        private void CreateGrid(string name, string officialSite, string Wins, string Loss, string ot, string teamAPIurl)
        {
            Panel panel = new Panel();
            panel.BackColor = Color.LightGray;
            panel.Location = new System.Drawing.Point(0, GridPosition);
            panel.Size = new System.Drawing.Size(GridPanel.Width - 20, 50);
            GridPanel.Controls.Add(panel);

            Panel panel1 = new Panel();
            panel1.BackColor = Color.FromArgb(175, 0, 0, 0);
            panel1.Location = new System.Drawing.Point(2, GridPosition + 2);
            panel1.Size = new System.Drawing.Size(GridPanel.Width - 20, 50);
            GridPanel.Controls.Add(panel1);

            LinkLabel NameLB = new LinkLabel();
            NameLB.Size = new System.Drawing.Size(120, panel.Height);
            NameLB.Font = new Font("Consolas", 10, FontStyle.Italic);
            NameLB.Location = new System.Drawing.Point(0, 0);
            NameLB.TextAlign = ContentAlignment.MiddleLeft;
            NameLB.Text = name.ToString();
            NameLB.LinkClicked += (sender, e) => LinkClicked(sender, e, officialSite);
            NameLB.LinkColor = Color.Black;
            NameLB.ActiveLinkColor = Color.LightGray;
            NameLB.VisitedLinkColor = Color.Black;
            panel.Controls.Add(NameLB);

            Label AgeLB = new Label();
            AgeLB.Size = new System.Drawing.Size(100, panel.Height);
            AgeLB.Location = new System.Drawing.Point(125, 0);
            AgeLB.Font = new Font("Consolas", 10, FontStyle.Bold);
            AgeLB.TextAlign = ContentAlignment.MiddleLeft;
            AgeLB.Text = Wins + " | " + ot + " | " + Loss;
            panel.Controls.Add(AgeLB);

            Button button = new Button();
            button.Size = new System.Drawing.Size(75, panel.Height - 10);
            button.Location = new System.Drawing.Point(250, 5);
            button.Font = new Font("Consolas", 10, FontStyle.Regular);
            button.TextAlign = ContentAlignment.MiddleCenter;
            button.Text = "More";
            button.BackColor = Color.White;
            button.Click += (sender, e) => MoreButtonClick(sender, e, teamAPIurl);
            panel.Controls.Add(button);


            GridPosition += 60;
        }

        void MoreButtonClick(object sender, EventArgs e, string url)
        {
            roster.Items.Clear();
            string result = RequestApi("https://statsapi.web.nhl.com" + url + "?expand=team.schedule.next,team.stats,team.roster");
            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(result);

            foreach (var item in myDeserializedClass.teams)
            {
                string TeamNameLogoFormat = item.teamName;
                if (TeamNameLogoFormat.Contains(""))
                {
                    TeamNameLogoFormat = item.teamName.Replace(" ", "");
                }
                WebRequest request = WebRequest.Create("https://b.fssta.com/uploads/application/nhl/team-logos/" + TeamNameLogoFormat + ".vresize.350.350.medium.0.png");
                using (var response = request.GetResponse())
                {
                    using (var stream = response.GetResponseStream())
                    {
                        TeamLogo.Image = Bitmap.FromStream(stream);
                    }
                }

                TeamName.Text = item.name;
                Venue.Text = item.venue.name;
                if (item.nextGameSchedule.dates[0].games.Count != 0)
                {
                    NextMatch.Text = item.nextGameSchedule.dates[0].games[0].teams.home.team.name + " vs " + item.nextGameSchedule.dates[0].games[0].teams.away.team.name;
                    MatchDate.Text = item.nextGameSchedule.dates[0].games[0].gameDate.ToString("dd.mm HH.m");
                }
                else
                {
                    NextMatch.Text = "No Game Known";
                    MatchDate.Text = " ";
                }

                foreach (var teamStat in item.teamStats)
                {
                    TeamDescription.Text = teamStat.type.gameType.description;
                }
                foreach (var player in item.roster.roster)
                {
                    roster.Items.Add(player.person.fullName + " " +player.jerseyNumber);
                }
            }
        }

        private void LinkClicked(object sender, EventArgs e, string officailSite)
        {
            System.Diagnostics.Process.Start(officailSite);
        }
    }
}

