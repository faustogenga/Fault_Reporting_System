﻿#pragma checksum "..\..\..\..\wpf\Register.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5C881A53C630E882448F7A9DA3F9AEA5FDE4C209"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Proyecto_Final.wpf;
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


namespace Proyecto_Final.wpf {
    
    
    /// <summary>
    /// Register
    /// </summary>
    public partial class Register : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 46 "..\..\..\..\wpf\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Textboxname;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\wpf\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Textboxapellido;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\..\wpf\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Textboxcedula;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\..\..\wpf\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Textboxcorreo;
        
        #line default
        #line hidden
        
        
        #line 159 "..\..\..\..\wpf\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox Textboxpass1;
        
        #line default
        #line hidden
        
        
        #line 201 "..\..\..\..\wpf\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox Textboxpass2;
        
        #line default
        #line hidden
        
        
        #line 230 "..\..\..\..\wpf\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Proyecto Final;component/wpf/register.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\wpf\Register.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 13 "..\..\..\..\wpf\Register.xaml"
            ((Proyecto_Final.wpf.Register)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Textboxname = ((System.Windows.Controls.TextBox)(target));
            
            #line 59 "..\..\..\..\wpf\Register.xaml"
            this.Textboxname.GotFocus += new System.Windows.RoutedEventHandler(this.TextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 60 "..\..\..\..\wpf\Register.xaml"
            this.Textboxname.LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Textboxapellido = ((System.Windows.Controls.TextBox)(target));
            
            #line 83 "..\..\..\..\wpf\Register.xaml"
            this.Textboxapellido.GotFocus += new System.Windows.RoutedEventHandler(this.TextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 84 "..\..\..\..\wpf\Register.xaml"
            this.Textboxapellido.LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Textboxcedula = ((System.Windows.Controls.TextBox)(target));
            
            #line 107 "..\..\..\..\wpf\Register.xaml"
            this.Textboxcedula.GotFocus += new System.Windows.RoutedEventHandler(this.TextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 108 "..\..\..\..\wpf\Register.xaml"
            this.Textboxcedula.LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus);
            
            #line default
            #line hidden
            
            #line 108 "..\..\..\..\wpf\Register.xaml"
            this.Textboxcedula.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Textboxcedula_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Textboxcorreo = ((System.Windows.Controls.TextBox)(target));
            
            #line 132 "..\..\..\..\wpf\Register.xaml"
            this.Textboxcorreo.GotFocus += new System.Windows.RoutedEventHandler(this.TextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 133 "..\..\..\..\wpf\Register.xaml"
            this.Textboxcorreo.LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Textboxpass1 = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 172 "..\..\..\..\wpf\Register.xaml"
            this.Textboxpass1.GotFocus += new System.Windows.RoutedEventHandler(this.PasswordBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 173 "..\..\..\..\wpf\Register.xaml"
            this.Textboxpass1.LostFocus += new System.Windows.RoutedEventHandler(this.PasswordBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Textboxpass2 = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 213 "..\..\..\..\wpf\Register.xaml"
            this.Textboxpass2.GotFocus += new System.Windows.RoutedEventHandler(this.PasswordBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 214 "..\..\..\..\wpf\Register.xaml"
            this.Textboxpass2.LostFocus += new System.Windows.RoutedEventHandler(this.PasswordBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 8:
            this.CloseButton = ((System.Windows.Controls.Button)(target));
            
            #line 236 "..\..\..\..\wpf\Register.xaml"
            this.CloseButton.Click += new System.Windows.RoutedEventHandler(this.CloseButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 257 "..\..\..\..\wpf\Register.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Register_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 280 "..\..\..\..\wpf\Register.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Cancel_Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
