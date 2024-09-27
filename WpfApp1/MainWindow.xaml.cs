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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DbModelContext.DB = new REGEntities();
        }

        private void TbEmail_TextChanged(object sender, TextChangedEventArgs e)
        {

            try
            {
                DbModelContext.DB.Users.Add(new UserControl()
                {
                    UserLogin = TbLogin.Text,
                    UserPassword = PdPassword.Password,
                    UserPhone = TbPhone.Text,
                    UserEmail = TbEmail.Text
                });
                DbModelContext.DB.SaveChanges();
                MessageBox.Show("Данные успешно сохранены",
                    "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),
                              "Системное мообщение",
                               MessageBoxButton.OK, MessageBoxImage.Information);









            }
        }

    }

}
}