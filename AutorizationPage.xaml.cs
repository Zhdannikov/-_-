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
    /// Логика взаимодействия для AutorizationPage.xaml
    /// </summary>
    public partial class AutorizationPage : Page
    {
        public AutorizationPage()
        {
            InitializeComponent();
        }
        
        private void Vxod_Click(object sender, RoutedEventArgs e)
        {
            var login = Login.Text;
            var password = Password.Password;
            var db = new Entities();
            var user = db.Users.Where(w => w.Login == login && w.Password == password).FirstOrDefault();
            if (user != null)
            {
                if (user.Rol.Rol1.Trim() == "Менеджер")
                    NavigationService.Content = new TovarPage();
            }
            else MessageBox.Show("Такой пользователь не найден");

        }
    }
}
