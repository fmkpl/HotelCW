﻿#pragma checksum "..\..\AdminControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "73DF60DE9736318071D0313CE4C47CE7D74007240E4988A9A1FF17DB2D32FA55"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using HotelCW;
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


namespace HotelCW {
    
    
    /// <summary>
    /// AdminControl
    /// </summary>
    public partial class AdminControl : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\AdminControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox numberOfNewRoom;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\AdminControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox priceOfNewRoom;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\AdminControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox typeOfNewRoom;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\AdminControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addRoom;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\AdminControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox numberOfNewRoomToDelete;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\AdminControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deleteRoom;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\AdminControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button updateTable;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\AdminControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exitAdmin;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\AdminControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock enjWorkTxt;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\AdminControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid clientsDataGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/HotelCW;component/admincontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AdminControl.xaml"
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
            this.numberOfNewRoom = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.priceOfNewRoom = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.typeOfNewRoom = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.addRoom = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\AdminControl.xaml"
            this.addRoom.Click += new System.Windows.RoutedEventHandler(this.addRoom_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.numberOfNewRoomToDelete = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.deleteRoom = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\AdminControl.xaml"
            this.deleteRoom.Click += new System.Windows.RoutedEventHandler(this.deleteRoom_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.updateTable = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\AdminControl.xaml"
            this.updateTable.Click += new System.Windows.RoutedEventHandler(this.updateTable_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.exitAdmin = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\AdminControl.xaml"
            this.exitAdmin.Click += new System.Windows.RoutedEventHandler(this.exitAdmin_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.enjWorkTxt = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.clientsDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

