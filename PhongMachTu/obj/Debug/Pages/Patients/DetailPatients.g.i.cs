﻿#pragma checksum "..\..\..\..\Pages\Patients\DetailPatients.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4C44BF5487E071EECAC273DB6502C73C2E58790F3B4C1267996715F8A791F74F"
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
using PhongMachTu.Pages.Patients;
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


namespace PhongMachTu.Pages.Patients {
    
    
    /// <summary>
    /// DetailPatients
    /// </summary>
    public partial class DetailPatients : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 65 "..\..\..\..\Pages\Patients\DetailPatients.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txt_MaBN;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\Pages\Patients\DetailPatients.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_FullName;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\Pages\Patients\DetailPatients.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker txt_Birthday;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\..\Pages\Patients\DetailPatients.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_GioiTinh;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\..\Pages\Patients\DetailPatients.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_SDT;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\..\Pages\Patients\DetailPatients.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_DiaChi;
        
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
            System.Uri resourceLocater = new System.Uri("/PhongMachTu;component/pages/patients/detailpatients.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Patients\DetailPatients.xaml"
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
            
            #line 39 "..\..\..\..\Pages\Patients\DetailPatients.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Back_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txt_MaBN = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.txt_FullName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txt_Birthday = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.txt_GioiTinh = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txt_SDT = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txt_DiaChi = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 114 "..\..\..\..\Pages\Patients\DetailPatients.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Save_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 123 "..\..\..\..\Pages\Patients\DetailPatients.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Delete_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

