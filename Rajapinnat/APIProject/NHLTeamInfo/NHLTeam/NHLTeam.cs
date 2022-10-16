using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIproject.NHLTeam
{

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Away
    {
        public LeagueRecord leagueRecord { get; set; }
        public int score { get; set; }
        public Team team { get; set; }
    }

    public class Broadcast
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string site { get; set; }
        public string language { get; set; }
    }

    public class Conference
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
    }

    public class Content
    {
        public string link { get; set; }
    }

    public class Date
    {
        public string date { get; set; }
        public int totalItems { get; set; }
        public int totalEvents { get; set; }
        public int totalGames { get; set; }
        public int totalMatches { get; set; }
        public List<Game> games { get; set; }
        public List<object> events { get; set; }
        public List<object> matches { get; set; }
    }

    public class Division
    {
        public int id { get; set; }
        public string name { get; set; }
        public string nameShort { get; set; }
        public string link { get; set; }
        public string abbreviation { get; set; }
    }

    public class Franchise
    {
        public int franchiseId { get; set; }
        public string teamName { get; set; }
        public string link { get; set; }
    }

    public class Game
    {
        public int gamePk { get; set; }
        public string link { get; set; }
        public string gameType { get; set; }
        public string season { get; set; }
        public DateTime gameDate { get; set; }
        public Status status { get; set; }
        public Teams teams { get; set; }
        public Venue venue { get; set; }
        public List<Broadcast> broadcasts { get; set; }
        public List<RadioBroadcast> radioBroadcasts { get; set; }
        public Content content { get; set; }
        public MetaData metadata { get; set; }
    }

    public class Teams
    {
        public Away away { get; set; }
        public Home home { get; set; }
    }

    public class GameType
    {
        public string id { get; set; }
        public string description { get; set; }
        public bool postseason { get; set; }
    }

    public class Home
    {
        public LeagueRecord leagueRecord { get; set; }
        public int score { get; set; }
        public Team team { get; set; }
    }

    public class LeagueRecord
    {
        public int wins { get; set; }
        public int losses { get; set; }
        public int ot { get; set; }
        public string type { get; set; }
    }

    public class MetaData
    {
        public string timeStamp { get; set; }
    }

    public class Metadata2
    {
        public bool isManuallyScored { get; set; }
        public bool isSplitSquad { get; set; }
    }

    public class NextGameSchedule
    {
        public int totalItems { get; set; }
        public int totalEvents { get; set; }
        public int totalGames { get; set; }
        public int totalMatches { get; set; }
        public MetaData metaData { get; set; }
        public List<Date> dates { get; set; }
    }

    public class Person
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string link { get; set; }
    }

    public class Position
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string abbreviation { get; set; }
    }

    public class RadioBroadcast
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Root
    {
        public string copyright { get; set; }
        public List<Team> teams { get; set; }
    }

    public class Roster
    {
        public List<Roster> roster { get; set; }
        public string link { get; set; }
        public Person person { get; set; }
        public string jerseyNumber { get; set; }
        public Position position { get; set; }
    }

    public class Split
    {
        public Stat stat { get; set; }
        public Team team { get; set; }
    }

    public class Stat
    {
        public int gamesPlayed { get; set; }
        public object wins { get; set; }
        public object losses { get; set; }
        public object ot { get; set; }
        public object pts { get; set; }
        public string ptPctg { get; set; }
        public object goalsPerGame { get; set; }
        public object goalsAgainstPerGame { get; set; }
        public object evGGARatio { get; set; }
        public string powerPlayPercentage { get; set; }
        public object powerPlayGoals { get; set; }
        public object powerPlayGoalsAgainst { get; set; }
        public object powerPlayOpportunities { get; set; }
        public string penaltyKillPercentage { get; set; }
        public object shotsPerGame { get; set; }
        public object shotsAllowed { get; set; }
        public object winScoreFirst { get; set; }
        public object winOppScoreFirst { get; set; }
        public object winLeadFirstPer { get; set; }
        public object winLeadSecondPer { get; set; }
        public object winOutshootOpp { get; set; }
        public object winOutshotByOpp { get; set; }
        public object faceOffsTaken { get; set; }
        public object faceOffsWon { get; set; }
        public object faceOffsLost { get; set; }
        public string faceOffWinPercentage { get; set; }
        public double shootingPctg { get; set; }
        public double savePctg { get; set; }
        public string penaltyKillOpportunities { get; set; }
        public string savePctRank { get; set; }
        public string shootingPctRank { get; set; }
    }

    public class Status
    {
        public string abstractGameState { get; set; }
        public string codedGameState { get; set; }
        public string detailedState { get; set; }
        public string statusCode { get; set; }
        public bool startTimeTBD { get; set; }
    }

    public class Team
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
        public Venue venue { get; set; }
        public string abbreviation { get; set; }
        public string teamName { get; set; }
        public string locationName { get; set; }
        public string firstYearOfPlay { get; set; }
        public Division division { get; set; }
        public Conference conference { get; set; }
        public Franchise franchise { get; set; }
        public List<TeamStat> teamStats { get; set; }
        public Roster roster { get; set; }
        public NextGameSchedule nextGameSchedule { get; set; }
        public string shortName { get; set; }
        public string officialSiteUrl { get; set; }
        public int franchiseId { get; set; }
        public bool active { get; set; }
        public Away away { get; set; }
        public Home home { get; set; }
    }

    public class Team2
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
    }

    public class TeamStat
    {
        public Type type { get; set; }
        public List<Split> splits { get; set; }
    }

    public class TimeZone
    {
        public string id { get; set; }
        public int offset { get; set; }
        public string tz { get; set; }
    }

    public class Type
    {
        public string displayName { get; set; }
        public GameType gameType { get; set; }
    }

    public class Venue
    {
        public string name { get; set; }
        public string link { get; set; }
        public string city { get; set; }
        public TimeZone timeZone { get; set; }
        public int id { get; set; }
    }



}
