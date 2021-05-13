using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telerik.Examples.WinControls.ChartView.NullValues
{
    public class FootballTeamStats
    {
        string _name;
        string _logoPath;
        string _season;
        int? _wins;
        int? _draws;
        int? _losses;
        int? _goalDifference;
        int? _points;
        int? _position;

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        public string LogoPath
        {
            get
            {
                return this._logoPath;
            }
            set
            {
                this._logoPath = value;
            }
        }

        public string Season
        {
            get
            {
                return this._season;
            }
            set
            {
                this._season = value;
            }
        }

        public int? Wins
        {
            get
            {
                return this._wins;
            }
            set
            {
                this._wins = value;
            }
        }

        public int? Draws
        {
            get
            {
                return this._draws;
            }
            set
            {
                this._draws = value;
            }
        }

        public int? Losses
        {
            get
            {
                return this._losses;
            }
            set
            {
                this._losses = value;
            }
        }

        public int? GoalDifference
        {
            get
            {
                return this._goalDifference;
            }
            set
            {
                this._goalDifference = value;
            }
        }

        public int? Points
        {
            get
            {
                return this._points;
            }
            set
            {
                this._points = value;
            }
        }

        public int? Position
        {
            get
            {
                return this._position;
            }
            set
            {
                this._position = value;
            }
        }
    }
}
