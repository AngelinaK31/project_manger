﻿#pragma checksum "..\..\..\..\UI\Casements\WindAuth.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "396FED6217F4E47B41921EBAB45F4997B4C450E0DDFDF499CF4A4BEA0AF7FFDB"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ProjectManagerApp.UI.Casements;
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


namespace ProjectManagerApp.UI.Casements {
    
    
    /// <summary>
    /// WindAuth
    /// </summary>
    public partial class WindAuth : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\..\..\UI\Casements\WindAuth.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxLogin;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\UI\Casements\WindAuth.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxPassword;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\UI\Casements\WindAuth.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox pwdPassword;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\UI\Casements\WindAuth.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnShowPwd;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\UI\Casements\WindAuth.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogIn;
        
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
            System.Uri resourceLocater = new System.Uri("/ProjectManagerApp;component/ui/casements/windauth.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UI\Casements\WindAuth.xaml"
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
            
            #line 12 "..\..\..\..\UI\Casements\WindAuth.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 16 "..\..\..\..\UI\Casements\WindAuth.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnHideClick);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 19 "..\..\..\..\UI\Casements\WindAuth.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnResizeClick);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 22 "..\..\..\..\UI\Casements\WindAuth.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnCloseWind);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tbxLogin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tbxPassword = ((System.Windows.Controls.TextBox)(target));
            
            #line 44 "..\..\..\..\UI\Casements\WindAuth.xaml"
            this.tbxPassword.KeyUp += new System.Windows.Input.KeyEventHandler(this.tbxPasswordKeyUp);
            
            #line default
            #line hidden
            return;
            case 7:
            this.pwdPassword = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 46 "..\..\..\..\UI\Casements\WindAuth.xaml"
            this.pwdPassword.KeyUp += new System.Windows.Input.KeyEventHandler(this.pwdPasswordKeyUp);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnShowPwd = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\..\UI\Casements\WindAuth.xaml"
            this.btnShowPwd.Click += new System.Windows.RoutedEventHandler(this.btnShowPwdClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnLogIn = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\..\UI\Casements\WindAuth.xaml"
            this.btnLogIn.Click += new System.Windows.RoutedEventHandler(this.btnLogInClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

