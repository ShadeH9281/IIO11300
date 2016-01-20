/*
* Copyright (C) JAMK/IT/Esa Salmikangas
* This file is part of the IIO11300 course project.
* Created: 12.1.2015 Modified 20.1.2016
* Authors: Esa Salmikangas, Toni Pajukanta
*/

/*Modified 20.1.2016
 * I was trying to data inputted from MainWindow.xaml to xaml.cs
 * 
 * Status:
 * UI is pretty much finished. However getting the data input is little confusing thus is has slowed down the rest.
 * 
 *Modified 20.1.2016: later on the same day
 *
 *Status:
 *UI and data input and output had been done. Only thing that is really missing is error checking for putting letters instead of numbers and such.
 */
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

namespace Tehtava1
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {

            /*
            //TODO
            try
            {
                double result;
                result = BusinessLogicWindow.CalculatePerimeter(1, 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //yield to an user that everything okay
            }
            */
            try
            {

                // gets data
                double widht = double.Parse(txtWidht.Text);
                double height = double.Parse(txtHeight.Text);
                double woodWd = double.Parse(txtWoodWd.Text);

                // calculates window area
                double area1 = widht * height;

                // adds wooden frame to calculations
                double woodWinWd = widht + woodWd;
                double woodWinHt = height + woodWd;

                // calculates perimeter of the wooden frame
                double parameter = woodWinHt * 2 + woodWinWd * 2;
                // calculates area of the window and it's frame.     
                double area2 = woodWinHt * woodWinWd;

                // outputs the information to MainWindow
                windowArea.Text = area1.ToString();
                frameArea.Text = parameter.ToString();
                framePerim.Text = area2.ToString();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message)

                
            }



        }

    private void btnClose_Click(object sender, RoutedEventArgs e)
    {

    }
  }

    /*
  public class BusinessLogicWindow
    {
    /// <summary>
    /// CalculatePerimeter calculates the perimeter of a window
    /// </summary>
    

            
    public static double CalculatePerimeter(double widht, double height)
        {
            
            
            throw new System.NotImplementedException();
        }

    }

*/    

}
