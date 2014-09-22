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


namespace PurchaseSellStock
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class WindowMain : Window
    {
        private System.Windows.Threading.DispatcherTimer timerCloseRecentPopup=null;

        public WindowMain()
        {
            InitializeComponent();
            timerCloseRecentPopup = new System.Windows.Threading.DispatcherTimer();
            timerCloseRecentPopup.Interval = TimeSpan.FromSeconds(0.2);
            timerCloseRecentPopup.Tag = PMenu;
            timerCloseRecentPopup.Tick += closePopup;
        }

        private void btnNavigation_MouseEnter(object sender, MouseEventArgs e)
        {
            PMenu.IsOpen = true;
        }
        private void btnNavigation_MouseLeave(object sender, MouseEventArgs e)
        {
            if (PMenu.IsOpen)
            {
                timerCloseRecentPopup.Stop();
                timerCloseRecentPopup.Start();
            }
        }

        private void btnNavigation_Click(object sender, RoutedEventArgs e)
        {
            PMenu.IsOpen = false;
            frameNavigation.Source = new Uri("PageNavigation.xaml",UriKind.Relative);
        }

        private void closePopup(object state, EventArgs e)
        {
            System.Windows.Controls.Primitives.Popup pop = timerCloseRecentPopup.Tag as System.Windows.Controls.Primitives.Popup;
            if (pop == null)
            {
                //todo timer里面的Assert没有对话框出来
                System.Diagnostics.Debug.Assert(true, "pop==null");
                return;
            }

            Control control = pop.PlacementTarget as Control;

            if (!pop.IsMouseOver)
            {
                if (control != null)
                {
                    if (!control.IsMouseOver)
                    {
                        pop.IsOpen = false;
                        timerCloseRecentPopup.Stop();
                    }
                }
                else
                {
                    pop.IsOpen = false;
                    timerCloseRecentPopup.Stop();
                }
            }
        }

        private void PMenu_MouseLeave(object sender, MouseEventArgs e)
        {
            timerCloseRecentPopup.Stop();
            timerCloseRecentPopup.Start();
        }

        
    }
}
