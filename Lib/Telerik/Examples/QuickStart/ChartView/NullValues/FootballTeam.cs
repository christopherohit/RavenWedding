using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telerik.Examples.WinControls.ChartView.NullValues
{
    public class FootballTeam
    {
        string _name;
        string _logoPath;
        int? _totalWins;
        int? _totalDraws;
        int? _totalLosses;
        List<FootballTeamStats> _stats;

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

        public int? TotalWins
        {
            get
            {
                return this._totalWins;
            }
            set
            {
                this._totalWins = value;
            }
        }

        public int? TotalDraws
        {
            get
            {
                return this._totalDraws;
            }
            set
            {
                this._totalDraws = value;
            }
        }

        public int? TotalLosses
        {
            get
            {
                return this._totalLosses;
            }
            set
            {
                this._totalLosses = value;
            }
        }

        public List<FootballTeamStats> Stats
        {
            get
            {
                return this._stats;
            }
            set
            {
                this._stats = value;
            }
        }
    }
}