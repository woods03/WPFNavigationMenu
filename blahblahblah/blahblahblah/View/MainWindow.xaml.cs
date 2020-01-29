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
using blahblahblah.Navigator;

namespace blahblahblah.View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private NavigatorMenu Navigator;

        public MainWindow()
        {
            InitializeComponent();

            Navigator = new NavigatorMenu();
        }

        private void page1OpenBtn_Click(object sender, RoutedEventArgs e)
        {
            Page1Open();
        }

        private void page2OpenBtn_Click(object sender, RoutedEventArgs e)
        {
            Page2Open();
        }

        private void Page1Open()
        {
            var page1andVm = Navigator.OpenPage(ViewModelEnums.Page1VM);
            page1andVm.Key.changePageDelegate = Page2Open;

            page1andVm.Value.DataContext = page1andVm.Key;
            mainFrame.Content = page1andVm.Value;
        }

        private void Page2Open()
        {
            var page2andVM = Navigator.OpenPage(ViewModelEnums.Page2VM);
            page2andVM.Key.changePageDelegate = Page1Open;

            page2andVM.Value.DataContext = page2andVM.Key;
            mainFrame.Content = page2andVM.Value;
        }
    }
}
