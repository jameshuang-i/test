using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.ComponentModel;
using System.Windows.Media;

namespace PurchaseSellStock.Template
{
   
    public class MyTextBox
    {
        //Prompt属性
        public static readonly DependencyProperty PromptProperty = DependencyProperty.RegisterAttached("Prompt", typeof(string), typeof(MyTextBox));
        public static void SetPrompt(System.Windows.UIElement element, string value)
        {
            element.SetValue(PromptProperty, value);
        }
        public static string GetPrompt(System.Windows.UIElement element)
        {
            return (string)element.GetValue(PromptProperty);
        }
        //Hint属性
        public static readonly DependencyProperty HintProperty = DependencyProperty.RegisterAttached("Hint", typeof(string), typeof(MyTextBox));
        public static void SetHint(System.Windows.UIElement element, string value)
        {
            element.SetValue(HintProperty, value);
        }
        public static string GetHint(System.Windows.UIElement element)
        {
            return (string)element.GetValue(HintProperty);
        }
        //Enter2Tab属性
        public static readonly DependencyProperty Enter2TabProperty = DependencyProperty.RegisterAttached("Enter2Tab", typeof(bool), typeof(MyTextBox), new PropertyMetadata(false, OnEnter2TablePropertyChanged));
        public static void SetEnter2Tab(System.Windows.UIElement element, Boolean value)
        {
            element.SetValue(Enter2TabProperty, value);
        }
        public static Boolean GetUpdatePropertySourceWhenEnterPressed(DependencyObject dp)
        {
            return (Boolean)dp.GetValue(Enter2TabProperty);
        }
        private static void OnEnter2TablePropertyChanged(DependencyObject dp, DependencyPropertyChangedEventArgs e)
        {
            UIElement element = dp as UIElement;

            if (element == null)
                return;

            bool bRet = (bool)e.NewValue;
            if (bRet)
                element.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(HandlePreviewKeyDown);
            else
                element.PreviewKeyDown -= HandlePreviewKeyDown;
        }
        private static void HandlePreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                System.Windows.Input.FocusNavigationDirection focusDirection = System.Windows.Input.FocusNavigationDirection.Next;
                System.Windows.Input.TraversalRequest request = new System.Windows.Input.TraversalRequest(focusDirection);
                UIElement elementWithFocus = sender as UIElement;

                if (elementWithFocus != null)
                    elementWithFocus.MoveFocus(request);
                e.Handled = true;
            }
        }
        //IsMonitoring属性
        public static readonly DependencyProperty IsMonitoringProperty = DependencyProperty.RegisterAttached("IsMonitoring", typeof(bool), typeof(MyTextBox), new UIPropertyMetadata(false, OnIsMonitoringChanged));
        public static bool GetIsMonitoring(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsMonitoringProperty);
        }
        public static void SetIsMonitoring(DependencyObject obj, bool value)
        {
            obj.SetValue(IsMonitoringProperty, value);
        }

        public static int GetPasswordLength(DependencyObject obj)
        {
            return (int)obj.GetValue(PasswordLengthProperty);
        }

        public static void SetPasswordLength(DependencyObject obj, int value)
        {
            obj.SetValue(PasswordLengthProperty, value);
        }

        //PasswordLength属性
        public static readonly DependencyProperty PasswordLengthProperty = DependencyProperty.RegisterAttached("PasswordLength", typeof(int), typeof(MyTextBox), new UIPropertyMetadata(0));

        private static void OnIsMonitoringChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var pb = d as System.Windows.Controls.PasswordBox;
            if (pb == null)
            {
                return;
            }
            if ((bool)e.NewValue)
            {
                pb.PasswordChanged += PasswordChanged;
            }
            else
            {
                pb.PasswordChanged -= PasswordChanged;
            }
        }

        static void PasswordChanged(object sender, RoutedEventArgs e)
        {
            var pb = sender as System.Windows.Controls.PasswordBox;
            if (pb == null)
            {
                return;
            }
            SetPasswordLength(pb, pb.Password.Length);
        }
    }

    public class MyImageButton
    {
        public static readonly DependencyProperty ImageSourceProperty = DependencyProperty.RegisterAttached("ImageSource", typeof(string), typeof(MyImageButton), new UIPropertyMetadata("", OnImageSourceChanged));
        public static void SetImageSource(System.Windows.UIElement element, string value)
        {
            element.SetValue(ImageSourceProperty, value);
        }
        public static string GetImageSource(System.Windows.UIElement element)
        {
            return (string)element.GetValue(ImageSourceProperty);
        }
        private static void OnImageSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var pb = d as System.Windows.Controls.Button;
            if (pb == null)
            {
                return;
            }
            string strValue = e.NewValue as string;
            if (string.IsNullOrEmpty(strValue))
                SetHasImage(pb, false);
            else
                SetHasImage(pb, true);
        }

        public static readonly DependencyProperty HasImageProperty = DependencyProperty.RegisterAttached("HasImage", typeof(bool), typeof(MyImageButton), new UIPropertyMetadata(false));
        public static bool GetHasImage(System.Windows.UIElement element)
        {
            return (bool)element.GetValue(HasImageProperty);
        }
        public static void SetHasImage(System.Windows.UIElement element, bool value)
        {
            element.SetValue(HasImageProperty, value);
        }
    }

}
