using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.Model;

namespace WpfApp2.API
{   //Original code
    public class League_V4 : Api
    {
        public League_V4(string region) : base(region)
        {
        }

        public List<LeagueListDTO> GetPositions(string summonerId)
        {   
            string path = "league/v4/entries/by-summoner/" + summonerId;

            var response = GET(GetURI(path));
            string content = response.Content.ReadAsStringAsync().Result;

           
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject < List <LeagueListDTO>> (content);
            }
            else
            {
                return null;
            }
        }
    }
}