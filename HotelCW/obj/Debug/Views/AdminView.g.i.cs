﻿#pragma checksum "..\..\..\Views\AdminView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7087062914F135F11B101C22BD18910C5543AE80F4DA2194987EC5F6B50788F1"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using HotelCW.Views;
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


namespace HotelCW.Views {
    
    
    /// <summary>
    /// AdminView
    /// </summary>
    public partial class AdminView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\Views\AdminView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exit;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Views\AdminView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAdminName;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Views\AdminView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtPassword;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Views\AdminView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtControlWord;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Views\AdminView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSubmit;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Views\AdminView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button register;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Views\AdminView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button VKlink;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Views\AdminView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MetanitLink;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Views\AdminView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GithubLink;
        
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
            System.Uri resourceLocater = new System.Uri("/HotelCW;component/views/adminview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\AdminView.xaml"
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
            this.exit = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Views\AdminView.xaml"
            this.exit.Click += new System.Windows.RoutedEventHandler(this.exit_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtAdminName = ((System.Windows.Controls.TextBox)(target));
            
            #line 36 "..\..\..\Views\AdminView.xaml"
            this.txtAdminName.KeyUp += new System.Windows.Input.KeyEventHandler(this.TxtPassword_OnKeyUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtPassword = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 39 "..\..\..\Views\AdminView.xaml"
            this.txtPassword.KeyUp += new System.Windows.Input.KeyEventHandler(this.TxtPassword_OnKeyUp);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtControlWord = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 42 "..\..\..\Views\AdminView.xaml"
            this.txtControlWord.KeyUp += new System.Windows.Input.KeyEventHandler(this.txtControlword_OnKeyUp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnSubmit = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\Views\AdminView.xaml"
            this.btnSubmit.Click += new System.Windows.RoutedEventHandler(this.btnSubmit_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.register = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\Views\AdminView.xaml"
            this.register.Click += new System.Windows.RoutedEventHandler(this.register_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.VKlink = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\Views\AdminView.xaml"
            this.VKlink.Click += new System.Windows.RoutedEventHandler(this.VKlink_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.MetanitLink = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\Views\AdminView.xaml"
            this.MetanitLink.Click += new System.Windows.RoutedEventHandler(this.MetanitLink_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.GithubLink = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\Views\AdminView.xaml"
            this.GithubLink.Click += new System.Windows.RoutedEventHandler(this.GithubLink_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

