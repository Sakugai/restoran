using Restoran.Model;
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

namespace Restoran.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для CreateChequePage.xaml
    /// </summary>
    public partial class CreateChequePage : Page
    {
        //Добавление позиций в ListBox
        List<Position> positions=new List<Position>();

        //Список для работы с фильтром
        List<Category> categories=new List<Category>();

        Position _selectPosition;
        public CreateChequePage()
        {
            InitializeComponent();

            //добавление позиций в ListBox
            PositionsLb.ItemsSource = App.context.Position.ToList();

            //Добавление категорий в ComboBox
            categories = App.context.Category.ToList();

            //Добавление категории в качестве элемента ComboBox
            categories.Insert(0, new Category { Title="Все категории"});

            CategoryCmb.ItemsSource = categories;
        }

        private void CategoryCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            positions = App.context.Position.ToList();

            if(CategoryCmb.SelectedIndex != 0)
            {
                positions=positions.Where(p=>p.Category.CategoryId ==CategoryCmb.SelectedIndex).ToList();
                PositionsLb.ItemsSource=positions;
            }
            else
            {
                PositionsLb.ItemsSource = positions;
            }
        }

        private void SearchTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            positions = App.context.Position.ToList();

            if (SearchTb.Text != string.Empty)
            {
                positions = positions.Where(p=>p.Title.ToLower().Contains(SearchTb.Text.ToLower())).ToList();
                PositionsLb.ItemsSource=positions;
            }
        }

        private void PositionsLb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _selectPosition=PositionsLb.SelectedItem as Position;


        }
    }
}
