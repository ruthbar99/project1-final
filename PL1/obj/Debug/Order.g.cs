﻿#pragma checksum "..\..\Order.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7DE2CA666884BE3B48A30E728680691D3ABE61C4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PL1;
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


namespace PL1 {
    
    
    /// <summary>
    /// Order
    /// </summary>
    public partial class Order : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox StatusCmb;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label StatusLl;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker registration;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker entry;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox privateName;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox family;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox adult;
        
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
            System.Uri resourceLocater = new System.Uri("/PL1;component/order.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Order.xaml"
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
            this.StatusCmb = ((System.Windows.Controls.ComboBox)(target));
            
            #line 10 "..\..\Order.xaml"
            this.StatusCmb.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.StatusCmb_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.StatusLl = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.registration = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.entry = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.privateName = ((System.Windows.Controls.TextBox)(target));
            
            #line 14 "..\..\Order.xaml"
            this.privateName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.PrivateName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.family = ((System.Windows.Controls.TextBox)(target));
            
            #line 15 "..\..\Order.xaml"
            this.family.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Family_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.adult = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\Order.xaml"
            this.adult.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Adult_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

