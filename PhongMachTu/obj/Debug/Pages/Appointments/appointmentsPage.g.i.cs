﻿#pragma checksum "..\..\..\..\Pages\Appointments\appointmentsPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A947F0656B295305F9D8E4F2AEFA5BC00BF3D132867E2356F71D8FE79F3F0FAC"
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
using PhongMachTu.Pages;
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


namespace PhongMachTu.Pages {
    
    
    /// <summary>
    /// appointmentsPage
    /// </summary>
    public partial class appointmentsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\..\Pages\Appointments\appointmentsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PhongMachTu.Pages.appointmentsPage Appointment;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Pages\Appointments\appointmentsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgCurrentUser;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\Pages\Appointments\appointmentsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtCurrentUser;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Pages\Appointments\appointmentsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtCurrentUserRole;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\..\Pages\Appointments\appointmentsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_Filter;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\..\Pages\Appointments\appointmentsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_LayMaBN;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\..\..\Pages\Appointments\appointmentsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView dsPhieuKhamBenh;
        
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
            System.Uri resourceLocater = new System.Uri("/PhongMachTu;component/pages/appointments/appointmentspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Appointments\appointmentsPage.xaml"
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
            this.Appointment = ((PhongMachTu.Pages.appointmentsPage)(target));
            return;
            case 2:
            this.imgCurrentUser = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.txtCurrentUser = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.txtCurrentUserRole = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.txt_Filter = ((System.Windows.Controls.TextBox)(target));
            
            #line 90 "..\..\..\..\Pages\Appointments\appointmentsPage.xaml"
            this.txt_Filter.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txt_Filter_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txt_LayMaBN = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            
            #line 107 "..\..\..\..\Pages\Appointments\appointmentsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Add_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.dsPhieuKhamBenh = ((System.Windows.Controls.ListView)(target));
            
            #line 120 "..\..\..\..\Pages\Appointments\appointmentsPage.xaml"
            this.dsPhieuKhamBenh.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.dsPhieuKhamBenh_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

