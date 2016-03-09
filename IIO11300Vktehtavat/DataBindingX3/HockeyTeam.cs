using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H6DataBindingX3
{

    public class HockeyPLayer : INotifyPropertyChanged
    {
        private string name;
        private string number;

        private string Number
        {
           
            set { number = value; Notify("Number"); Notify("NameAndNumber"); }
            get { return number; }
        }
        public string Name {
            set {name = value; Notify("Name"); Notify("NameAndNumber"); }

            get { return name;}
        }

        public string NameAndNumber
        {
            get { return name + "#" + number; }

        }
    }

    public HockeyPlayer()
    {



    }

    public HockeyPlayer(string name)
    {
        this.name = name;
        this.number = number;
    }

    public override string ToString() {
        return name + "#" + number;
    }

    public event PropertyChangedEventHandler PropertyChanged;

    void Notify(string propName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propName));

        }
    }

    public class HockeyTeam
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
