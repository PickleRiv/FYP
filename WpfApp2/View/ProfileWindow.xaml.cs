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
using System.Windows.Shapes;
using WpfApp2.Controller;

namespace WpfApp2.View
{

    /// Interaction logic for WindowProfile.xaml
    public partial class ProfileWindow : Window
    {
        ControllerProfile controller;

        public ProfileWindow()
        {
            controller = new ControllerProfile();
            InitializeComponent();
            this.DataContext = controller.GetContext();
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            controller.OpenMain();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
