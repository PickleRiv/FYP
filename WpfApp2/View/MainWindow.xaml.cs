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
using WpfApp2.Controller;
using WpfApp2.View.ViewModel;
using WpfApp2.View;

namespace WpfApp2
{

    /// Interaction logic for MainWindow.xaml
    public partial class MainWindow : Window
    {
        ControllerMain controller;
        ViewModelMain viewModel;
        public MainWindow()
        {
            controller = new ControllerMain();
            viewModel = new ViewModelMain();
            InitializeComponent();

            this.DataContext = viewModel;
        }
        //Original code
        private void ButtonSearch_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(viewModel.Region))
                return;
            if (string.IsNullOrEmpty(viewModel.SummonerName))
                return;

            if (controller.GetSummoner(viewModel.SummonerName))
            {
                ProfileWindow profile = new ProfileWindow();
                profile.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong User or Server!");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}