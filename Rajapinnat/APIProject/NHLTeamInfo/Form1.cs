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
            GetNHLTeams(); // get all nhl teams
            MoreButtonClick(sender, e, "/api/v1/teams/1"); // load the first team in the right side info panel
        }

        private string RequestApi(string url) // reguest information from api
        {
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

        private void GetNHLTeams() // get all nhl teams
        {
            string result = RequestApi("https://statsapi.web.nhl.com/api/v1/teams?expand=team.stats"); // request from api
            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(result); // use NHLTeam class
            foreach (var item in myDeserializedClass.teams) // loop api information
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

                string TeamNameLogoFormat = item.teamName;
                if (TeamNameLogoFormat.Contains(""))
                {
                    TeamNameLogoFormat = item.teamName.Replace(" ", "");
                }
                WebRequest request = WebRequest.Create("https://b.fssta.com/uploads/application/nhl/team-logos/" + TeamNameLogoFormat + ".vresize.350.350.medium.0.png"); // request team logo
                Image image;
                using (var response = request.GetResponse())
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        image = Bitmap.FromStream(stream);
                    }
                }

                CreateGrid(item.teamName, item.officialSiteUrl, wins, loss, ot, item.link, image); // create left side team list
            }
        }

        private void CreateGrid(string name, string officialSite, string Wins, string Loss, string ot, string teamAPIurl, Image image)
        {
            // single grid panel
            Panel singelGrid = new Panel();
            singelGrid.BackColor = Color.White;
            singelGrid.Location = new System.Drawing.Point(0, GridPosition);
            singelGrid.Size = new System.Drawing.Size(GridPanel.Width - 20, 50);
            GridPanel.Controls.Add(singelGrid);

            // bottom line
            Panel bottomLine = new Panel();
            bottomLine.BackColor = Color.LightGray;
            bottomLine.Location = new System.Drawing.Point(0, GridPosition + 55);
            bottomLine.Size = new System.Drawing.Size(GridPanel.Width - 25, 1);
            GridPanel.Controls.Add(bottomLine);

            // team name
            LinkLabel teamName = new LinkLabel();
            teamName.Size = new System.Drawing.Size(120, singelGrid.Height);
            teamName.Font = new Font("Consolas", 10, FontStyle.Italic);
            teamName.Location = new System.Drawing.Point(50, 0);
            teamName.TextAlign = ContentAlignment.MiddleLeft;
            teamName.Text = name.ToString();
            teamName.LinkClicked += (sender, e) => LinkClicked(sender, e, officialSite);
            teamName.LinkColor = Color.Black;
            teamName.ActiveLinkColor = Color.LightGray;
            teamName.VisitedLinkColor = Color.Black;
            singelGrid.Controls.Add(teamName);

            // team score WIN | TIE | LOSS
            Label teamScore = new Label();
            teamScore.Size = new System.Drawing.Size(100, singelGrid.Height);
            teamScore.Location = new System.Drawing.Point(175, 0);
            teamScore.Font = new Font("Consolas", 10, FontStyle.Bold);
            teamScore.TextAlign = ContentAlignment.MiddleLeft;
            teamScore.Text = Wins + " | " + ot + " | " + Loss;
            singelGrid.Controls.Add(teamScore);

            // More info button
            Button moreButton = new Button();
            moreButton.Size = new System.Drawing.Size(75, singelGrid.Height - 10);
            moreButton.Location = new System.Drawing.Point(300, 5);
            moreButton.Font = new Font("Consolas", 10, FontStyle.Regular);
            moreButton.TextAlign = ContentAlignment.MiddleCenter;
            moreButton.Text = "More";
            moreButton.BackColor = Color.White;
            moreButton.Click += (sender, e) => MoreButtonClick(sender, e, teamAPIurl);
            singelGrid.Controls.Add(moreButton);

            // taam logo
            PictureBox teamLogo = new PictureBox();
            teamLogo.Size = new System.Drawing.Size(singelGrid.Height - 10, singelGrid.Height - 10);
            teamLogo.Location = new System.Drawing.Point(0, 5);
            teamLogo.BackColor = Color.White;
            teamLogo.Image = image;
            teamLogo.SizeMode = PictureBoxSizeMode.Zoom;
            singelGrid.Controls.Add(teamLogo);

            GridPosition += 60;
        }

        void MoreButtonClick(object sender, EventArgs e, string url) // load the clicked team's right side info panel
        {
            roster.Items.Clear();
            string result = RequestApi("https://statsapi.web.nhl.com" + url + "?expand=team.schedule.next,team.stats,team.roster"); // request from api
            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(result); // use NHLTeam class

            foreach (var item in myDeserializedClass.teams)
            {
                string TeamNameLogoFormat = item.teamName;
                if (TeamNameLogoFormat.Contains(""))
                {
                    TeamNameLogoFormat = item.teamName.Replace(" ", "");
                }
                WebRequest request = WebRequest.Create("https://b.fssta.com/uploads/application/nhl/team-logos/" + TeamNameLogoFormat + ".vresize.350.350.medium.0.png"); // request team logo
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
                    MatchDate.Text = item.nextGameSchedule.dates[0].games[0].gameDate.ToString("dd.MM H:mm");
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

        private void LinkClicked(object sender, EventArgs e, string officailSite) // load web url
        {
            System.Diagnostics.Process.Start(officailSite);
        }
    }
}

