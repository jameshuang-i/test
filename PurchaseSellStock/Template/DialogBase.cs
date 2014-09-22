using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace PurchaseSellStock.Template
{
    public partial class DialogBase : Window
    {
        public DialogBase()
        {
            this.Style = (Style)App.Current.Resources["BaseDialogStyle"];
            this.Loaded += delegate { InitializeEvent(); };
        }

        private void InitializeEvent()
        {
            ControlTemplate baseDialogTemplate = (ControlTemplate)App.Current.Resources["BaseDialogControlTemplate"];

            Border borderTitle = (Border)baseDialogTemplate.FindName("borderTitle", this);
            Button closeBtn = (Button)baseDialogTemplate.FindName("btnClose", this);
            TextBlock txtTitle = (TextBlock)baseDialogTemplate.FindName("txtTitle", this);

            txtTitle.Text = this.Title;
            closeBtn.Click += delegate { this.Close(); };
            borderTitle.MouseMove += delegate(object sender, MouseEventArgs e)
            {
                if (e.LeftButton == MouseButtonState.Pressed)
                {
                    this.DragMove();
                }
            };
        }
    }
}
