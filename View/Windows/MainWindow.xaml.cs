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

namespace Restoran.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MainFrame.NavigationService.Navigate(new View.Pages.OrdersPage());
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            //Для перехода на страницу назад нужно сделать:
            //1)Проверку можем ли мы перейти назад
            //2)Если можем, то используем метод GoBack

            if (MainFrame.CanGoBack)
            {
                MainFrame.GoBack();
            }
        }
    }
}
