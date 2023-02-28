using Restoran.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration.Conventions;
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
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void PinBtn_Click(object sender, RoutedEventArgs e)
        {
            PinPb.Password += ((sender as Button).Content.ToString());

            if (PinPb.Password.Length == 4)
            {
                Waiter waiter = ModelHelpper.con.Waiter.FirstOrDefault(w => w.Pincode == PinPb.Password);//Waiter это таблица

                if(waiter != null)
                {
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Неправильный PIN-код");
                    PinPb.Clear();
                }
            }
        }

        private void DelPinBtn_Click(object sender, RoutedEventArgs e)
        {
            if (PinPb.Password.Length > 0)
            {
                PinPb.Password=PinPb.Password.Remove(PinPb.Password.Length-1);//Позволяет получить индекс последнего символа и удалить его
            }
        }
    }
}
