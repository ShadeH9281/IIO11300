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
using System.Windows.Shapes;
using System.Xml;

namespace H5MoviesXML
{
    /// <summary>
    /// Interaction logic for Movies2.xaml
    /// </summary>
    public partial class Movies2 : Window
    {
        public Movies2()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Tallennetaan
                string filu = xdpMovies.Source.LocalPath;
                xdpMovies.Document.Save(filu);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (lbMovies.SelectedIndex > -1)
                {
                   
                    lbMovies.SelectedIndex = -1;

                } else
                {
                    string filu = xdpMovies.Source.LocalPath;
                    XmlDocument doc = xdpMovies.Document;
                    XmlNode root = doc.SelectSingleNode("/Movies");
                    XmlNode newMovie = doc.CreateElement("Movie");

                    XmlAttribute attr = doc.CreateAttribute("Name");
                    attr.Value = txtName.Text;
                    newMovie.Attributes.Append(attr);

                    XmlAttribute attr2 = doc.CreateAttribute("Director");
                    attr.Value = txtDir.Text;
                    newMovie.Attributes.Append(attr2);

                    XmlAttribute attr3 = doc.CreateAttribute("Country");
                    attr.Value = txtCountry.Text;
                    newMovie.Attributes.Append(attr3);

                    root.AppendChild(newMovie);
                    xdpMovies.Document.Save(filu);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Poistetaan

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
