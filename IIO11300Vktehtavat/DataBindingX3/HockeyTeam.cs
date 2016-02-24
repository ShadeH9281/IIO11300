using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H6DataBindingX3
{
    class HockeyTeam
    {
        #region PROPERTIES

        public string Name { get; set; }
        public string City { get; set; }

        #endregion

        #region CONSTRUCTORS

        public HockeyTeam()
        {
            Name = "";
            City = "unknown";
        }

        public HockeyTeam(string name, string city)
        {
            Name = name;
            City = City;
        }

        #endregion

        public override string ToString()
        {
            return Name + "@" + City;
        }
    }

    public class HockeyLeague
    {
        List<HockeyTeam> teams = new List<HockeyTeam>();
        public HockeyLeague()
        {
            teams.Add(new HockeyTeam("HIFK", "Helsinki"));
            teams.Add(new HockeyTeam("JYP", "Jyväskylä"));
            teams.Add(new HockeyTeam("Kalpa", "Kuopio"));
            teams.Add(new HockeyTeam("Sport", "Vaasa"));
        }

        public List<HockeyTeam> GetTeams()
        {
            return teams;
        }

    }

}
