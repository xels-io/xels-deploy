﻿#pragma checksum "..\..\..\..\..\Views\layout\MainLayout.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "AAE56E050ADEA86AEFDAA88142806AB6C28BB251"
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
using XelsCCDesktopWalletApp.Views.layout;


namespace XelsCCDesktopWalletApp.Views.layout {
    
    
    /// <summary>
    /// MainLayout
    /// </summary>
    public partial class MainLayout : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 101 "..\..\..\..\..\Views\layout\MainLayout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame PageContent;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\..\..\..\Views\layout\MainLayout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDashboard;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\..\..\..\Views\layout\MainLayout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Exchange;
        
        #line default
        #line hidden
        
        
        #line 154 "..\..\..\..\..\Views\layout\MainLayout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_SmartContract;
        
        #line default
        #line hidden
        
        
        #line 178 "..\..\..\..\..\Views\layout\MainLayout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridBarraTitulo;
        
        #line default
        #line hidden
        
        
        #line 180 "..\..\..\..\..\Views\layout\MainLayout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labCheckChainMessage;
        
        #line default
        #line hidden
        
        
        #line 181 "..\..\..\..\..\Views\layout\MainLayout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labWalletName;
        
        #line default
        #line hidden
        
        
        #line 207 "..\..\..\..\..\Views\layout\MainLayout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button windowMin;
        
        #line default
        #line hidden
        
        
        #line 210 "..\..\..\..\..\Views\layout\MainLayout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonFechar;
        
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
            System.Uri resourceLocater = new System.Uri("/XelsCCDesktopWalletApp;component/views/layout/mainlayout.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\layout\MainLayout.xaml"
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
            
            #line 8 "..\..\..\..\..\Views\layout\MainLayout.xaml"
            ((XelsCCDesktopWalletApp.Views.layout.MainLayout)(target)).Initialized += new System.EventHandler(this.Window_Initialized);
            
            #line default
            #line hidden
            return;
            case 2:
            this.PageContent = ((System.Windows.Controls.Frame)(target));
            return;
            case 3:
            this.btnDashboard = ((System.Windows.Controls.Button)(target));
            
            #line 130 "..\..\..\..\..\Views\layout\MainLayout.xaml"
            this.btnDashboard.Click += new System.Windows.RoutedEventHandler(this.btnDashboard_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 138 "..\..\..\..\..\Views\layout\MainLayout.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnHistory_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_Exchange = ((System.Windows.Controls.Button)(target));
            
            #line 146 "..\..\..\..\..\Views\layout\MainLayout.xaml"
            this.btn_Exchange.Click += new System.Windows.RoutedEventHandler(this.btn_Exchange_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_SmartContract = ((System.Windows.Controls.Button)(target));
            
            #line 154 "..\..\..\..\..\Views\layout\MainLayout.xaml"
            this.btn_SmartContract.Click += new System.Windows.RoutedEventHandler(this.btn_SmartContract_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.GridBarraTitulo = ((System.Windows.Controls.Grid)(target));
            
            #line 178 "..\..\..\..\..\Views\layout\MainLayout.xaml"
            this.GridBarraTitulo.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.GridBarraTitulo_MouseDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.labCheckChainMessage = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.labWalletName = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            
            #line 190 "..\..\..\..\..\Views\layout\MainLayout.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddressBookButton_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 192 "..\..\..\..\..\Views\layout\MainLayout.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AdvancedButton_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 194 "..\..\..\..\..\Views\layout\MainLayout.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LogOut_Button);
            
            #line default
            #line hidden
            return;
            case 13:
            this.windowMin = ((System.Windows.Controls.Button)(target));
            
            #line 207 "..\..\..\..\..\Views\layout\MainLayout.xaml"
            this.windowMin.Click += new System.Windows.RoutedEventHandler(this.windowMin_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.ButtonFechar = ((System.Windows.Controls.Button)(target));
            
            #line 210 "..\..\..\..\..\Views\layout\MainLayout.xaml"
            this.ButtonFechar.Click += new System.Windows.RoutedEventHandler(this.ButtonFechar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
