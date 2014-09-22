using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using PurchaseSellStock.Template;


namespace PurchaseSellStock
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class DialogLogin : DialogBase
    {
        public DialogLogin()
        {
            InitializeComponent();
            
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (!Data.User.Vaild(comboxUserName.Text, textPassword.Password))
            {
                labMessage.Content = Data.User.GetLastErr;
                textPassword.Focus();
                textPassword.Background = new SolidColorBrush(Colors.Red);
                return;
            }
          
            WindowMain objMain = new WindowMain();
            objMain.Show();
            this.Close(); 
        }

        private void DialogBase_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> lstUsers = Data.User.GetUserList();
            foreach(string strUser in lstUsers)
            {
                ComboBoxItem cbItem = new ComboBoxItem();
                cbItem.Content = strUser;
                comboxUserName.Items.Add(cbItem);
            }
        }

        private void textPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                btnLogin_Click(null, null);
                e.Handled = true;
            }
        }

        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Uri.AbsoluteUri);
            e.Handled = true;
        }
    }
}
