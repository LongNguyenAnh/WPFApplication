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
using CefSharp;

namespace WpfApplication
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

        private void mnuChrome_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("ChromiumWebBrowser.xaml", UriKind.Relative));
        }

        private void mnuMain_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("HomePage.xaml", UriKind.Relative));
        }

        private void mnuExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
