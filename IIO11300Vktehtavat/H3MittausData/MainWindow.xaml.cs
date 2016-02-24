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
using Data.Translator;

namespace H3MittausData
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<MittausData> mitatut;
        public MainWindow()
        {
            InitializeComponent();
            IniMyStuff();
        }

        private void IniMyStuff()
        {

            txt_Today.Text = DateTime.Today.ToShortDateString();
            mitatut = new List<MittausData>();

        }

        private void btnSaveData_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MittausData.SaveDataToFile(mitatut, txtDataName.Text);
                MessageBox.Show("Tiedot tallennettu upupupuu~");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ApplyChanges()
        {
            lbData.ItemSource = null;
            lbData.ItemSource = mitatut;

        }

        private void btnNewData_Click(object sender, RoutedEventArgs e)
        {
            MittausData md = new MittausData(txtClock.Text, txtData.Text);
            lbData.Items.Add(md);
            mitatut.Add(md);
            ApplyChanges();
        }

        private void btnFromFile_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                mitatut = null;
                mitatut = MittausData.ReadDataFromFile(txtFileName.Text);
                ApplyChanges();
                MessageBox.Show("Tiedot Luettu upupupupu~");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnSaveToXML_Click(object sender, RoutedEventArgs e)
        {
            Data.Translator.Serialisointi.SerialisoiXml(@"d:\testi.xml", mitatut);
        }
    }
}
