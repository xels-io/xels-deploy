﻿#pragma checksum "..\..\..\..\..\..\Views\Pages\Modals\ImportSelsBelsUserControl.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D8CEFCC9D173957ED684C4CFAF7EFA73AAB90A0B"
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
using XelsCCDesktopWalletApp.Views.Pages.Modals;


namespace XelsCCDesktopWalletApp.Views.Pages.Modals {
    
    
    /// <summary>
    /// ImportSelsBelsUserControl
    /// </summary>
    public partial class ImportSelsBelsUserControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\..\..\..\Views\Pages\Modals\ImportSelsBelsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Import_Sels_Bels;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\..\..\Views\Pages\Modals\ImportSelsBelsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MnemonicTxt;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\..\..\Views\Pages\Modals\ImportSelsBelsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label mnemonic_error;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\..\..\..\Views\Pages\Modals\ImportSelsBelsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CheckboxPkey;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\..\..\..\Views\Pages\Modals\ImportSelsBelsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border SelsBelsBorder;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\..\..\..\Views\Pages\Modals\ImportSelsBelsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SELSPrivateKeyTxt;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\..\..\..\Views\Pages\Modals\ImportSelsBelsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BELSPrivateKeyTxt;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\..\..\..\..\Views\Pages\Modals\ImportSelsBelsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ImportSelsBelsButton;
        
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
            System.Uri resourceLocater = new System.Uri("/XelsCCDesktopWalletApp;V5.0.0.0;component/views/pages/modals/importselsbelsuserc" +
                    "ontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Views\Pages\Modals\ImportSelsBelsUserControl.xaml"
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
            this.Import_Sels_Bels = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            
            #line 10 "..\..\..\..\..\..\Views\Pages\Modals\ImportSelsBelsUserControl.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Rectangle_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 30 "..\..\..\..\..\..\Views\Pages\Modals\ImportSelsBelsUserControl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.HidePopup_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MnemonicTxt = ((System.Windows.Controls.TextBox)(target));
            
            #line 57 "..\..\..\..\..\..\Views\Pages\Modals\ImportSelsBelsUserControl.xaml"
            this.MnemonicTxt.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Mnemonic_null_check_onchange);
            
            #line default
            #line hidden
            return;
            case 5:
            this.mnemonic_error = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.CheckboxPkey = ((System.Windows.Controls.CheckBox)(target));
            
            #line 69 "..\..\..\..\..\..\Views\Pages\Modals\ImportSelsBelsUserControl.xaml"
            this.CheckboxPkey.Checked += new System.Windows.RoutedEventHandler(this.CheckBox_Checked);
            
            #line default
            #line hidden
            
            #line 69 "..\..\..\..\..\..\Views\Pages\Modals\ImportSelsBelsUserControl.xaml"
            this.CheckboxPkey.Unchecked += new System.Windows.RoutedEventHandler(this.CheckBox_Unchecked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.SelsBelsBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 8:
            this.SELSPrivateKeyTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.BELSPrivateKeyTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.ImportSelsBelsButton = ((System.Windows.Controls.Button)(target));
            
            #line 115 "..\..\..\..\..\..\Views\Pages\Modals\ImportSelsBelsUserControl.xaml"
            this.ImportSelsBelsButton.Click += new System.Windows.RoutedEventHandler(this.ImportSelsBelsButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
