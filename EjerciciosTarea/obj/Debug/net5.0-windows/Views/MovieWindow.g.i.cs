// Updated by XamlIntelliSenseFileGenerator 26/2/2022 00:21:48
#pragma checksum "..\..\..\..\Views\MovieWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B2A20DA502E96B591AD4A2AEB54BE07B59985CBD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using EjerciciosTarea.Views;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace EjerciciosTarea.Views
{


    /// <summary>
    /// MovieWindow
    /// </summary>
    public partial class MovieWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 22 "..\..\..\..\Views\MovieWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboxMovie;

#line default
#line hidden


#line 26 "..\..\..\..\Views\MovieWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbox2D;

#line default
#line hidden


#line 27 "..\..\..\..\Views\MovieWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbox3D;

#line default
#line hidden


#line 31 "..\..\..\..\Views\MovieWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelAdults;

#line default
#line hidden


#line 32 "..\..\..\..\Views\MovieWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelKids;

#line default
#line hidden


#line 36 "..\..\..\..\Views\MovieWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAdult;

#line default
#line hidden


#line 37 "..\..\..\..\Views\MovieWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtKids;

#line default
#line hidden


#line 41 "..\..\..\..\Views\MovieWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelPagar;

#line default
#line hidden


#line 44 "..\..\..\..\Views\MovieWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCalc;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.2.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/EjerciciosTarea;component/views/moviewindow.xaml", System.UriKind.Relative);

#line 1 "..\..\..\..\Views\MovieWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.cboxMovie = ((System.Windows.Controls.ComboBox)(target));

#line 22 "..\..\..\..\Views\MovieWindow.xaml"
                    this.cboxMovie.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cboxChecked);

#line default
#line hidden
                    return;
                case 2:
                    this.cbox2D = ((System.Windows.Controls.CheckBox)(target));

#line 26 "..\..\..\..\Views\MovieWindow.xaml"
                    this.cbox2D.Checked += new System.Windows.RoutedEventHandler(this.cboxChecked);

#line default
#line hidden
                    return;
                case 3:
                    this.cbox3D = ((System.Windows.Controls.CheckBox)(target));

#line 27 "..\..\..\..\Views\MovieWindow.xaml"
                    this.cbox3D.Checked += new System.Windows.RoutedEventHandler(this.cboxChecked);

#line default
#line hidden
                    return;
                case 4:
                    this.labelAdults = ((System.Windows.Controls.Label)(target));
                    return;
                case 5:
                    this.labelKids = ((System.Windows.Controls.Label)(target));
                    return;
                case 6:
                    this.txtAdult = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 7:
                    this.txtKids = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 8:
                    this.labelPagar = ((System.Windows.Controls.Label)(target));
                    return;
                case 9:
                    this.txt = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 10:
                    this.labelCambio = ((System.Windows.Controls.Label)(target));
                    return;
                case 11:
                    this.btnCalc = ((System.Windows.Controls.Button)(target));

#line 44 "..\..\..\..\Views\MovieWindow.xaml"
                    this.btnCalc.Click += new System.Windows.RoutedEventHandler(this.btnCalc_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }
    }
}

