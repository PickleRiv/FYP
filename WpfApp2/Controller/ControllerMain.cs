using WpfApp2.API;
using WpfApp2.Utils;

namespace WpfApp2.Controller
{
    //code done by Abel Dutra
    public class ControllerMain
    {
        public bool GetSummoner(string summonerName)
        {
            Summoner_V4 summoner_V4 = new Summoner_V4(Constants.Region);

            var summoner = summoner_V4.GetSummonerByName(summonerName);

            Constants.Summoner = summoner;

            return summoner != null;
        }
    }
}