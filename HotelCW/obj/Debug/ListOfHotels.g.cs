﻿#pragma checksum "..\..\ListOfHotels.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "63AE9477A7A6C9D7AAE1E376AF7E87B1432AE408E143F1C22D38048E4EA21CAB"
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
    /// ListOfHotels
    /// </summary>
    public partial class ListOfHotels : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\ListOfHotels.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel countriesColumn;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\ListOfHotels.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addCountry;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\ListOfHotels.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deleteCountry;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\ListOfHotels.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel hotelsColumn;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\ListOfHotels.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addHotel;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\ListOfHotels.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deleteHotel;
        
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
            System.Uri resourceLocater = new System.Uri("/HotelCW;component/listofhotels.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ListOfHotels.xaml"
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
            this.countriesColumn = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.addCountry = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\ListOfHotels.xaml"
            this.addCountry.Click += new System.Windows.RoutedEventHandler(this.addCountry_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.deleteCountry = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\ListOfHotels.xaml"
            this.deleteCountry.Click += new System.Windows.RoutedEventHandler(this.deleteCountry_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.hotelsColumn = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 5:
            this.addHotel = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.deleteHotel = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

