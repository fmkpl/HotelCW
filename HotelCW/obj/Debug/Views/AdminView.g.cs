﻿#pragma checksum "..\..\..\Views\AdminView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0A0500F38D3560BB57DC7CA58193760DA80D8C93B7B98CB41D9E3562CC5F3366"
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
        
        
        #line 35 "..\..\..\Views\AdminView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAdminName;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Views\AdminView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtPassword;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Views\AdminView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtControlWord;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Views\AdminView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSubmit;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Views\AdminView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button register;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Views\AdminView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button VKlink;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Views\AdminView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MetanitLink;
        
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
            this.txtAdminName = ((System.Windows.Controls.TextBox)(target));
            
            #line 35 "..\..\..\Views\AdminView.xaml"
            this.txtAdminName.KeyUp += new System.Windows.Input.KeyEventHandler(this.TxtPassword_OnKeyUp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtPassword = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 38 "..\..\..\Views\AdminView.xaml"
            this.txtPassword.KeyUp += new System.Windows.Input.KeyEventHandler(this.TxtPassword_OnKeyUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtControlWord = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 41 "..\..\..\Views\AdminView.xaml"
            this.txtControlWord.KeyUp += new System.Windows.Input.KeyEventHandler(this.txtControlword_OnKeyUp);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnSubmit = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\Views\AdminView.xaml"
            this.btnSubmit.Click += new System.Windows.RoutedEventHandler(this.btnSubmit_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.register = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\Views\AdminView.xaml"
            this.register.Click += new System.Windows.RoutedEventHandler(this.register_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.VKlink = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\Views\AdminView.xaml"
            this.VKlink.Click += new System.Windows.RoutedEventHandler(this.VKlink_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.MetanitLink = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\Views\AdminView.xaml"
            this.MetanitLink.Click += new System.Windows.RoutedEventHandler(this.MetanitLink_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

