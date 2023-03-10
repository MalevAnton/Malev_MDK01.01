using ProjectMalev.Classes;
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

namespace ProjectMalev.Pages
{
    /// <summary>
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        TableMaster master;
        public AdminPage(TableMaster master)
        {
            InitializeComponent();
            dgMaster.ItemsSource = BaseClass.ME.TableMaster.ToList();
            this.master = master;
        }

        private void btnShowApplication_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.MainFrame.Navigate(new ShowApplicationPage());
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.MainFrame.Navigate(new CreateApplicationPage());
        }

        private void btnPersonal_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.MainFrame.Navigate(new PersonalPage(master));
        }

        private void btnShowMaster_Click(object sender, RoutedEventArgs e)
        {
            dgMaster.Visibility = Visibility.Visible;
            btnShowMaster.Visibility = Visibility.Collapsed;
            btnPrivateMaster.Visibility = Visibility.Visible;
        }

        private void btnPrivateMaster_Click(object sender, RoutedEventArgs e)
        {
            dgMaster.Visibility = Visibility.Collapsed;
            btnShowMaster.Visibility = Visibility.Visible;
            btnPrivateMaster.Visibility = Visibility.Collapsed;
        }
    }
}
