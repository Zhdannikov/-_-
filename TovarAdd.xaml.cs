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

namespace Магизин_одежды
{
    /// <summary>
    /// Логика взаимодействия для TovarAdd.xaml
    /// </summary>
    public partial class TovarAdd : Page
    {
        Tovar t;
        public TovarAdd()
        {
            InitializeComponent();
            Tovar t = new Tovar();
            DataContext = t;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                Entities.Demo.Tovar.Add(t);
                Entities.Demo.SaveChanges();
                MessageBox.Show("Запись добавлена");
            }
            catch
            {
                MessageBox.Show("Невозможно добавить данные", "Ошибка");
            }
        }
    }
}
