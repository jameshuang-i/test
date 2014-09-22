using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace PurchaseSellStock.Template
{
    public class TextBoxAc : System.Windows.Controls.TextBox
    {
        public static readonly DependencyProperty LabelProperty = DependencyProperty.Register("Label", typeof(string), typeof(TextBoxAc), new UIPropertyMetadata(""));
        public static readonly DependencyProperty LabelWidthProperty = DependencyProperty.Register("LabelWidth", typeof(GridLength), typeof(TextBoxAc),new UIPropertyMetadata(new GridLength(0.0)));
        public static readonly DependencyProperty LineThicknessProperty = DependencyProperty.Register("LineThickness", typeof(double), typeof(TextBoxAc), new UIPropertyMetadata(2.0));
        
        public string Label
        {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }
        public GridLength LabelWidth
        {
            get { return (GridLength)GetValue(LabelWidthProperty); }
            set { SetValue(LabelWidthProperty, value); }
        }
        public double LineThickness
        {
            get { return (double)GetValue(LineThicknessProperty); }
            set { SetValue(LineThicknessProperty, value); }
        }

    }
}
