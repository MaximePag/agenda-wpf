#pragma checksum "..\..\..\Pages\ListCustomer.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6FE30D8DD6C1EB7D49A7A965BC1B96DD0F081166D0E97B4791A6656FF45FFCE0"
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
    /// ListCustomer
    /// </summary>
    public partial class ListCustomer : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Pages\ListCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgCustomers;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Pages\ListCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox lastname_input;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Pages\ListCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox firstname_input;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Pages\ListCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox mail_input;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Pages\ListCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox phoneNumber_input;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Pages\ListCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox budget_input;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Pages\ListCustomer.xaml"
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
            System.Uri resourceLocater = new System.Uri("/AgendaWPF;component/pages/listcustomer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\ListCustomer.xaml"
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
            this.dgCustomers = ((System.Windows.Controls.DataGrid)(target));
            
            #line 12 "..\..\..\Pages\ListCustomer.xaml"
            this.dgCustomers.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgCustomers_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 22 "..\..\..\Pages\ListCustomer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Edit_Button);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 23 "..\..\..\Pages\ListCustomer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Delete_Button);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 24 "..\..\..\Pages\ListCustomer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Abort_Button);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lastname_input = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.firstname_input = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.mail_input = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.phoneNumber_input = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.budget_input = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.error_message = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

