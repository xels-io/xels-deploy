﻿#pragma checksum "..\..\..\..\..\Views\Pages\ExchangePage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8D13A44B9D72E38D32CD91541005FFE20E3D34B0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using XelsXLCDesktopWalletApp.Views.Pages;


namespace XelsXLCDesktopWalletApp.Views.Pages {
    
    
    /// <summary>
    /// ExchangePage
    /// </summary>
    public partial class ExchangePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 13 "..\..\..\..\..\Views\Pages\ExchangePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Exchange;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\..\Views\Pages\ExchangePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel depositStactPannal;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\..\Views\Pages\ExchangePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Combobox;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\..\Views\Pages\ExchangePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AmountTxt;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\..\Views\Pages\ExchangePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock MessageTxt;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\..\Views\Pages\ExchangePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exchangeSubmit;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\..\..\Views\Pages\ExchangePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid NoData;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\..\..\Views\Pages\ExchangePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ListData;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\..\..\..\Views\Pages\ExchangePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ExchangesList;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/XelsXLCDesktopWalletApp;component/views/pages/exchangepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Pages\ExchangePage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Exchange = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.depositStactPannal = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.Combobox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.AmountTxt = ((System.Windows.Controls.TextBox)(target));
            
            #line 47 "..\..\..\..\..\Views\Pages\ExchangePage.xaml"
            this.AmountTxt.KeyUp += new System.Windows.Input.KeyEventHandler(this.AmountTxt_KeyUp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.MessageTxt = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.exchangeSubmit = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\..\..\..\Views\Pages\ExchangePage.xaml"
            this.exchangeSubmit.Click += new System.Windows.RoutedEventHandler(this.ExchangeOrderSubmitButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.NoData = ((System.Windows.Controls.Grid)(target));
            return;
            case 8:
            this.ListData = ((System.Windows.Controls.Grid)(target));
            return;
            case 9:
            this.ExchangesList = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 10:
            
            #line 128 "..\..\..\..\..\Views\Pages\ExchangePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DepositButton_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

