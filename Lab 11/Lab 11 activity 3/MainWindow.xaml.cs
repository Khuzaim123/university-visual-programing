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

namespace Lab_11_activity_3
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

        private void change(object sender, RoutedEventArgs e)
        {
            if (combo1.SelectedItem is ComboBoxItem selectedItem)
            {
                text1.Text = selectedItem.Content.ToString();
            }

            if (combo2.SelectedItem is ComboBoxItem selecteItem)
            {
                text2.Text = selecteItem.Content.ToString();
            }
        }
    }
}
