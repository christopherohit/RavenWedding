using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace Telerik.Examples.WinControls.ChartView.NullValues
{
    class ExampleData
    {
        List<FootballTeam> _data;

        public List<FootballTeam> AccumulatedData
        {
            get
            {
                return this._data;
            }
            set
            {
                this._data = value;
            }
        }

        public ExampleData()
        {
            this.GetData(@"..\ChartView\NullValues\Premierleaguedata.csv");
        }

        void GetData(string fileName)
        {
            using (StreamReader fileReader = new StreamReader(fileName))
            {
                this.GetDataCompleted(this.ParseData(fileReader));
            }
        }

        protected void GetDataCompleted(IEnumerable data)
        {
            List<FootballTeamStats> footballTeamStats = data as List<FootballTeamStats>;

            Dictionary<string, FootballTeam> teamStats = new Dictionary<string, FootballTeam>();

            foreach (FootballTeamStats entry in footballTeamStats)
            {
                if (!teamStats.ContainsKey(entry.Name))
                {
                    FootballTeam team = new FootballTeam();
                    team.Name = entry.Name;
                    team.LogoPath = entry.LogoPath;
                    team.Stats = new List<FootballTeamStats>();
                    team.TotalWins = entry.Wins == null ? 0 : entry.Wins;
                    team.TotalDraws = entry.Draws == null ? 0 : entry.Draws;
                    team.TotalLosses = entry.Losses == null ? 0 : entry.Losses;
                    teamStats.Add(entry.Name, team);
                }
                else
                {
                    FootballTeam team = teamStats[entry.Name];
                    team.Stats.Add(entry);
                    team.TotalWins += entry.Wins == null ? 0 : entry.Wins;
                    team.TotalDraws += entry.Draws == null ? 0 : entry.Draws;
                    team.TotalLosses += entry.Losses == null ? 0 : entry.Losses;
                }
            }

            List<FootballTeam> items = new List<FootballTeam>();
            items.AddRange(teamStats.Values);
            _data = items;
        }

        protected IEnumerable<FootballTeamStats> ParseData(TextReader dataReader)
        {
            string line;
            List<FootballTeamStats> dataList = new List<FootballTeamStats>();

            while ((line = dataReader.ReadLine()) != null)
            {
                if (string.IsNullOrEmpty(line))
                    continue;

                string[] data = line.Split(',');

                var stat = new FootballTeamStats();
                stat.Name = data[0].Trim();
                stat.Season = data[1].Trim();
                if (!string.IsNullOrEmpty(data[2]))
                {
                    stat.Wins = int.Parse(data[2], CultureInfo.InvariantCulture);
                }
                if (!string.IsNullOrEmpty(data[3]))
                {
                    stat.Draws = int.Parse(data[3], CultureInfo.InvariantCulture);
                }
                if (!string.IsNullOrEmpty(data[4]))
                {
                    stat.Losses = int.Parse(data[4], CultureInfo.InvariantCulture);
                }
                if (!string.IsNullOrEmpty(data[5]))
                {
                    stat.GoalDifference = int.Parse(data[5], CultureInfo.InvariantCulture);
                }
                if (!string.IsNullOrEmpty(data[6]))
                {
                    stat.Points = int.Parse(data[6], CultureInfo.InvariantCulture);
                }
                if (!string.IsNullOrEmpty(data[7]))
                {
                    stat.Position = int.Parse(data[7], CultureInfo.InvariantCulture);
                }
                stat.LogoPath = string.Format("..\\Resources\\SoccerTeamsLogos\\{0}", data[8].Trim());

                dataList.Add(stat);
            }

            return dataList;
        }
    }
}
