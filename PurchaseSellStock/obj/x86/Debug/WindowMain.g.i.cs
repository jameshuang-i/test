﻿#pragma checksum "..\..\..\WindowMain.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "726C6CD48B3013EE886168696E16218C"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34209
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using PurchaseSellStock.Data;
using PurchaseSellStock.Properties;
using PurchaseSellStock.Template;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace PurchaseSellStock {
    
    
    /// <summary>
    /// WindowMain
    /// </summary>
    public partial class WindowMain : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\WindowMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label txtUserName;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\WindowMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSuggest;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\WindowMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnHelp;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\WindowMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNavigation;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\WindowMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame frameNavigation;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\WindowMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup PMenu;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PurchaseSellStock;component/windowmain.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\WindowMain.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtUserName = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.btnSuggest = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.btnHelp = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.btnNavigation = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\WindowMain.xaml"
            this.btnNavigation.MouseEnter += new System.Windows.Input.MouseEventHandler(this.btnNavigation_MouseEnter);
            
            #line default
            #line hidden
            
            #line 51 "..\..\..\WindowMain.xaml"
            this.btnNavigation.Click += new System.Windows.RoutedEventHandler(this.btnNavigation_Click);
            
            #line default
            #line hidden
            
            #line 51 "..\..\..\WindowMain.xaml"
            this.btnNavigation.MouseLeave += new System.Windows.Input.MouseEventHandler(this.btnNavigation_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 5:
            this.frameNavigation = ((System.Windows.Controls.Frame)(target));
            return;
            case 6:
            this.PMenu = ((System.Windows.Controls.Primitives.Popup)(target));
            
            #line 58 "..\..\..\WindowMain.xaml"
            this.PMenu.MouseLeave += new System.Windows.Input.MouseEventHandler(this.PMenu_MouseLeave);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

