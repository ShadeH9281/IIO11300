using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace H6DataBindingX3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        HockeyLeague smliiga;
        List<HockeyTeam> joukkueet;
        int clicked = 0;
        public MainWindow()
        {
            InitializeComponent();
            FillMyCombobox();
            smliiga = new HockeyLeague();
            joukkueet = smliiga.GetTeams();
        }

        private void FillMyCombobox()
        {
            cbCourses2.Items.Add("IIO12110 Ohjelmistotuotanto");
            cbCourses2.Items.Add("Ruotsi sucks");
            cbCourses2.Items.Add("And such");
        }

        //btnSetUser_Click txtUsername.Text

        /*
        btnForward
        clicked++;
        myGrid.DataContext = joukkueet[clicked];
        */

        /*
        btnBackward
        clicked--;
        myGrid.DataContext = joukkueet[clicked];
        */
    }
}
