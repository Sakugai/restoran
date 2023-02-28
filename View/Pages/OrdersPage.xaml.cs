using Restoran.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Restoran.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для OrdersPage.xaml
    /// </summary>
    public partial class OrdersPage : Page
    {
        Table _selectedTable;
        public OrdersPage()
        {
            InitializeComponent();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //Загрузка столов
            TablesLb.ItemsSource = App.context.Table.ToList();

            OpenTablesLb.ItemsSource = App.context.Cheque.ToList();
        }
        private void TablesLb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _selectedTable=TablesLb.SelectedItem as Table;

            if (_selectedTable.IsFree)
            {
                NavigationService.Navigate(new CreateChequePage());
            }
            else
            {
                MessageBox.Show("Выбранный стол занят, выберите другой стол с помощью \"Открытые чеки\" или измените его");
            }
        }

        private void OpenTablesLb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        
    }
}
