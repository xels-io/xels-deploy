﻿#pragma checksum "..\..\..\..\..\Views\SendConfirmationMainChain.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "637750CC91634A92C199CDE751AAF578A1BA3E85"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using XelsXLCDesktopWalletApp.Views;


namespace XelsXLCDesktopWalletApp.Views {
    
    
    /// <summary>
    /// SendConfirmationMainChain
    /// </summary>
    public partial class SendConfirmationMainChain : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\..\..\Views\SendConfirmationMainChain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label AmountSent;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\..\Views\SendConfirmationMainChain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label AmountSentType;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\..\Views\SendConfirmationMainChain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Fee;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\..\Views\SendConfirmationMainChain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label FeeType;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\..\Views\SendConfirmationMainChain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Total;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\..\Views\SendConfirmationMainChain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label TotalType;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\..\Views\SendConfirmationMainChain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Destination;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\..\..\Views\SendConfirmationMainChain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.13.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/XelsXLCDesktopWalletApp;component/views/sendconfirmationmainchain.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\SendConfirmationMainChain.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.13.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 11 "..\..\..\..\..\Views\SendConfirmationMainChain.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Rectangle_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.AmountSent = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.AmountSentType = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.Fee = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.FeeType = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.Total = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.TotalType = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.Destination = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.cancelButton = ((System.Windows.Controls.Button)(target));
            
            #line 85 "..\..\..\..\..\Views\SendConfirmationMainChain.xaml"
            this.cancelButton.Click += new System.Windows.RoutedEventHandler(this.cancelButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
