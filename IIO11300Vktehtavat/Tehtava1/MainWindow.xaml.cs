﻿/*
* Copyright (C) JAMK/IT/Esa Salmikangas
* This file is part of the IIO11300 course project.
* Created: 12.1.2015 Modified 20.1.2016
* Authors: Esa Salmikangas, Toni Pajukanta
*/

/*
 * I was trying to data inputted from MainWindow.xaml to xaml.cs
 * 
 * Status:
 * UI is pretty much finished. However getting the data input is little confusing thus is has slowed down the rest.
 * 
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
        }

    private void btnClose_Click(object sender, RoutedEventArgs e)
    {

    }
  }

  public class BusinessLogicWindow
    {
    /// <summary>
    /// CalculatePerimeter calculates the perimeter of a window
    /// </summary>
    public static double CalculatePerimeter(double widht, double height)
        {
            
            txtWidht.Text = widht;
            txtHeight.Text = height;
            throw new System.NotImplementedException();
        }
    }

    

}
