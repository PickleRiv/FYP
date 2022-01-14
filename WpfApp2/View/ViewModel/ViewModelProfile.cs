using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.View.ViewModel
{   //Original Code
    public class ViewModelProfile
    {
        public string SummonerName { get; private set; }
        public string Icon { get; private set; }
        public long Level { get; private set; }
        public string Tier { get; private set; }
        public int Wins { get; private set; }
        public int Losses { get; private set; }
        public string Rank { get; private set; }
        public string Emblem { get; private set; }

        public ViewModelProfile(string summonerName, int icon, long level, string tier, string rank, int wins, int losses)
        {
            SummonerName = summonerName;
            Icon = "http://opgg-static.akamaized.net/images/profile_icons/profileIcon" + icon + ".jpg";
            Level = level;
            Tier = tier;
            Wins = wins;
            Losses = losses;
            Rank = rank;
            Emblem = "/WpfApp2;component/Assets/Ranks/Rank_" + tier + ".png";
        }
    }
}