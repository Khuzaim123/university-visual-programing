using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string>li = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if(text.Text != "")
            {
                if (!li.Contains(text.Text))
                {
                    li.Add(text.Text);
                    players.ItemsSource = null;
                    players.ItemsSource = li;
                    text.Text = "";
                    MessageBox.Show("Player has been added sucessfully!");
                }
                else
                {
                    MessageBox.Show("This player is already in the list");
                }
            }
            else
            {
                MessageBox.Show("Please! Enter name of the player");
            }
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            li.RemoveAt(players.SelectedIndex);
            players.ItemsSource = null;
            players.ItemsSource = li;
            MessageBox.Show("Player has been deleted sucessfully!");
        }
    }
}
