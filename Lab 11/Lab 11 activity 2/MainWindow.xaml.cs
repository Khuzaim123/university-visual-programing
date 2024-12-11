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

namespace Activity3
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

        private void check1_Checked(object sender, RoutedEventArgs e)
        {
            text1.Text = "Check Box 1 Checked";
        }

        private void check2_Checked(object sender, RoutedEventArgs e)
        {
            text2.Text = "Check Box 2 Checked";
        }

        private void check1_Unchecked(object sender, RoutedEventArgs e)
        {
            text1.Text = "";
        }

        private void check2_Unchecked(object sender, RoutedEventArgs e)
        {
            text2.Text = "";
        }
    }
}
