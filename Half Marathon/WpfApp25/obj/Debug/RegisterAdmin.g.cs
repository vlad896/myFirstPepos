﻿#pragma checksum "..\..\RegisterAdmin.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1A22C84037ACA10AC4D8E161873A2947D901F0F8D28A3029559C388C0C07454B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.IconPacks;
using MahApps.Metro.IconPacks.Converter;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using WpfApp25;


namespace WpfApp25 {
    
    
    /// <summary>
    /// RegisterAdmin
    /// </summary>
    public partial class RegisterAdmin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 84 "..\..\RegisterAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EmailTextbox;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\RegisterAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox Password;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\RegisterAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox Cpass;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\RegisterAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameTextBox;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\RegisterAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SurTextBox;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\RegisterAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton MaleRadio;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\RegisterAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextMale;
        
        #line default
        #line hidden
        
        
        #line 154 "..\..\RegisterAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton FemaleRadio;
        
        #line default
        #line hidden
        
        
        #line 166 "..\..\RegisterAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextFMale;
        
        #line default
        #line hidden
        
        
        #line 186 "..\..\RegisterAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxTime;
        
        #line default
        #line hidden
        
        
        #line 193 "..\..\RegisterAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CountryCombo;
        
        #line default
        #line hidden
        
        
        #line 213 "..\..\RegisterAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RegButton;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp25;component/registeradmin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\RegisterAdmin.xaml"
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
            
            #line 15 "..\..\RegisterAdmin.xaml"
            ((WpfApp25.RegisterAdmin)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 48 "..\..\RegisterAdmin.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.TextBlock_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 56 "..\..\RegisterAdmin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.EmailTextbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Password = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 6:
            this.Cpass = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 7:
            this.NameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.SurTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.MaleRadio = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 10:
            this.TextMale = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.FemaleRadio = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 12:
            this.TextFMale = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 13:
            this.TextBoxTime = ((System.Windows.Controls.TextBox)(target));
            return;
            case 14:
            this.CountryCombo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 15:
            this.RegButton = ((System.Windows.Controls.Button)(target));
            
            #line 215 "..\..\RegisterAdmin.xaml"
            this.RegButton.Click += new System.Windows.RoutedEventHandler(this.RegButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
