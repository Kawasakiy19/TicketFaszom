﻿#pragma checksum "..\..\CreateProfileWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A2B50DE570DC49E7E882E8574BE65AA19DA0264058C53AF05F33FF2326A0257A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using NewTicketWPF;
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


namespace NewTicketWPF {
    
    
    /// <summary>
    /// ProfileWindow
    /// </summary>
    public partial class ProfileWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\CreateProfileWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock text;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\CreateProfileWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ProfileInput;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\CreateProfileWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TTypeCB;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\CreateProfileWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TMaximumAmount;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\CreateProfileWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox customField;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\CreateProfileWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock customText;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\CreateProfileWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NewProfileBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/TicketApp;component/createprofilewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CreateProfileWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
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
            this.text = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.ProfileInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TTypeCB = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.TMaximumAmount = ((System.Windows.Controls.ComboBox)(target));
            
            #line 27 "..\..\CreateProfileWindow.xaml"
            this.TMaximumAmount.DropDownClosed += new System.EventHandler(this.TMaximumAmount_DropDownClosed);
            
            #line default
            #line hidden
            return;
            case 5:
            this.customField = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.customText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.NewProfileBtn = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\CreateProfileWindow.xaml"
            this.NewProfileBtn.Click += new System.Windows.RoutedEventHandler(this.CreateNewProfile);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

