#pragma checksum "..\..\..\Pages\ListAppointment.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "507855D709E38B6777CC33514D9FA4735F8682C193E086FC4773317B19482875"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using AgendaWPF.Pages;
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


namespace AgendaWPF.Pages {
    
    
    /// <summary>
    /// ListAppointment
    /// </summary>
    public partial class ListAppointment : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Pages\ListAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgAppointments;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Pages\ListAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker date_input;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Pages\ListAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox hour_input;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Pages\ListAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox minute_input;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Pages\ListAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox subject_input;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Pages\ListAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox brokers_list;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Pages\ListAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox customers_list;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Pages\ListAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock error_message;
        
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
            System.Uri resourceLocater = new System.Uri("/AgendaWPF;component/pages/listappointment.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\ListAppointment.xaml"
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
            this.dgAppointments = ((System.Windows.Controls.DataGrid)(target));
            
            #line 12 "..\..\..\Pages\ListAppointment.xaml"
            this.dgAppointments.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgAppointments_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 21 "..\..\..\Pages\ListAppointment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Edit_Button);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 22 "..\..\..\Pages\ListAppointment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Delete_Button);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 23 "..\..\..\Pages\ListAppointment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Abort_Button);
            
            #line default
            #line hidden
            return;
            case 5:
            this.date_input = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.hour_input = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.minute_input = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.subject_input = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.brokers_list = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.customers_list = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 11:
            this.error_message = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

