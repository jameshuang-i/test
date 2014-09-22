using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace PurchaseSellStock
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            SplashScreen s = new SplashScreen(@"Images\Splash.png");
            s.Show(false);
            s.Close(new TimeSpan(0, 0, 5));

            App.Current.Resources.MergedDictionaries.Add(Application.LoadComponent(new Uri(@"Template/DialogBaseStyle.xaml", UriKind.Relative)) as ResourceDictionary);
            App.Current.Resources.MergedDictionaries.Add(Application.LoadComponent(new Uri(@"Template/GeneralStyle.xaml", UriKind.Relative)) as ResourceDictionary);

            PurchaseSellStock.Properties.Settings.Default.MachineSerial = Data.SysParam.GetMachineSerial("00");
            PurchaseSellStock.Properties.Settings.Default.Version = string.Format("{0} V{1}.{2}",
                PurchaseSellStock.Properties.Settings.Default.VersionType,
                Application.ResourceAssembly.GetName().Version.Major, 
                Application.ResourceAssembly.GetName().Version.Minor);

            DialogRegister dialog = new DialogRegister();
            dialog.Show();

            //if (PurchaseSellStock.Properties.Settings.Default.NeedLogin)
            //{
            //    DialogLogin dialog = new DialogLogin();
            //    dialog.Show();
            //}
            //else
            //{
            //    string strLoginName = PurchaseSellStock.Properties.Settings.Default.LastLoginName;
            //    Data.User.UserName = strLoginName;
            //    WindowMain objMain = new WindowMain();
            //    objMain.Show();
            //}

            //base.OnStartup(e);
        }
    }
}
