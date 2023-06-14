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
    /// Логика взаимодействия для TovarPage.xaml
    /// </summary>
    public partial class TovarPage : Page
    {
        public TovarPage()
        {
            Entities bd = new Entities();
            InitializeComponent();
            L1.ItemsSource = null;
            L1.ItemsSource = bd.Tovar.ToList();
        }

        /// <summary>
        /// Переход на страницу добавления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dob_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Content = new TovarAdd();
        }
    }
}
