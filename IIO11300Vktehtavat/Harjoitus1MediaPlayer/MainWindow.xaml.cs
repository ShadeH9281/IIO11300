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
using Microsoft.Win32;

namespace Harjoitus1MediaPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            LoadMediaFile();



        }

        //@"D:\H9281\CoffeeMaker.mp4";

        private void LoadMediaFile()
        {
            string filu = @"D:\H9281\CoffeeMaker.mp4";

            if (System.IO.File.Exists(filu))
            {


                mediaElement.Source = new Uri(filu);

            }
            else {
                MessageBox.Show("File not found");
            }

        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {

            
                
                mediaElement.Play();
            

            }


        

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            mediaElement.Pause();
        }

        private void btnFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = "d:\\H9281";
            dlg.Filter = "Rock files (*.mp3)[*.mp3]Media files (*.wmv)[*wmv]";
        }
    }
}
