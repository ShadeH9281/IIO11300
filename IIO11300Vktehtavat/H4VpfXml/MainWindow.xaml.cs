﻿using System;
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
using System.Xml;
using System.Xml.Linq;

namespace H4VpfXml
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        XElement xe;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGetXML_Click(object sender, RoutedEventArgs e)
        {
            //ladataan xml tiedosta ja liatetaan datagridiin
            try
            {
                xe = XElement.Load(GetFileName());
                dgData.DataContext = xe.Elements("tyontekija");
                //lasketaan palkka summa ja työntekijöiden määrä
                int lkm = 0;
                lkm = xe.Elements().Count();
                tbMessage.Text = string.Format("Akun tehtaalla on kaikkiaan {0} työntekijää, joista {1} ovat vakituisia, heidän palkat ovat yhteensä {2}", lkm, CountWorkers("vakituinen"), CalculateSalarySum());

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }

        }

        private string GetFileName()
        {
            //return "d:\\tyontekijat.xml";

            //app config
            return H4VpfXml.Properties.Settings.Default.XMLtiedosto;
        }


        private decimal CalculateSalarySum() {

            decimal result = 0;
            //haetaan työtekijöiden LINQ-keselyllä
            var palkat = from ele in xe.Elements()
            select ele.Element("palkka");
            foreach (var item in palkat)
            {
                result += decimal.Parse(item.Value);

            }
            return result;
        }

        private int CountWorkers(string tyosuhde)
        {

            var tyontekijat = from ele in xe.Elements()
                              where ele.Element("tyosuhde").Value == tyosuhde
                              select ele.Element("etunimi");

            //palautetaan
            return tyontekijat.Count();
        }

    }
}
