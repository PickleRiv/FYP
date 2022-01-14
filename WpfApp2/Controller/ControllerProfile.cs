using WpfApp2.API;
using WpfApp2.Model;
using WpfApp2.Utils;
using WpfApp2.View.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Controller
{       //code done by Abel Dutra


    public class ControllerProfile
    {
        public object GetContext()
        {
            var summoner = Constants.Summoner;
            var position = GetPosition(summoner);

            return new ViewModelProfile(summoner.Name, summoner.ProfileIconId, summoner.SummonerLevel, position.Tier, position.Rank,
                position.Wins, position.Losses);
        }
        //Original code
        private LeagueListDTO GetPosition(SummonerDTO summoner)
        {
            League_V4 league = new League_V4(Constants.Region);

            var position = league.GetPositions(summoner.Id).Where(p => p.QueueType.Equals("RANKED_SOLO_5x5")).FirstOrDefault();

            return position != null ? position : new LeagueListDTO();
        }


        public void OpenMain()
        {
            MainWindow profile = new MainWindow();
            profile.Show();
        }
    }
}