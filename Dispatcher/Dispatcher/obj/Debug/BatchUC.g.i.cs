// Updated by XamlIntelliSenseFileGenerator 09.11.2021 2:02:00
#pragma checksum "..\..\BatchUC.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6B387A77236A29149F9084CACEC700D107839FCDEE52D217CFC8A2B97D0A84F6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Dispatcher;
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


namespace Dispatcher
{


    /// <summary>
    /// BatchUC
    /// </summary>
    public partial class BatchUC : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {


#line 19 "..\..\BatchUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpdateButton;

#line default
#line hidden


#line 22 "..\..\BatchUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteButton;

#line default
#line hidden


#line 25 "..\..\BatchUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateButton;

#line default
#line hidden


#line 28 "..\..\BatchUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpgradeButton;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Dispatcher;component/batchuc.xaml", System.UriKind.Relative);

#line 1 "..\..\BatchUC.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.UpdateButton = ((System.Windows.Controls.Button)(target));

#line 19 "..\..\BatchUC.xaml"
                    this.UpdateButton.Click += new System.Windows.RoutedEventHandler(this.UpdateButton_Click);

#line default
#line hidden
                    return;
                case 2:
                    this.DeleteButton = ((System.Windows.Controls.Button)(target));

#line 22 "..\..\BatchUC.xaml"
                    this.DeleteButton.Click += new System.Windows.RoutedEventHandler(this.DeleteButton_Click);

#line default
#line hidden
                    return;
                case 3:
                    this.CreateButton = ((System.Windows.Controls.Button)(target));

#line 25 "..\..\BatchUC.xaml"
                    this.CreateButton.Click += new System.Windows.RoutedEventHandler(this.CreateButton_Click);

#line default
#line hidden
                    return;
                case 4:
                    this.UpgradeButton = ((System.Windows.Controls.Button)(target));

#line 28 "..\..\BatchUC.xaml"
                    this.UpgradeButton.Click += new System.Windows.RoutedEventHandler(this.UpgradeButton_Click);

#line default
#line hidden
                    return;
                case 5:
                    this.idStatusTB = ((System.Windows.Controls.TextBox)(target));

#line 35 "..\..\BatchUC.xaml"
                    this.idStatusTB.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);

#line default
#line hidden
                    return;
                case 6:
                    this.decodingTB = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 7:
                    this.StuffStatusDataGrid = ((System.Windows.Controls.DataGrid)(target));

#line 42 "..\..\BatchUC.xaml"
                    this.StuffStatusDataGrid.IsMouseCapturedChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.StuffStatusDataGrid_IsMouseCapturedChanged);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.TextBox idPostTB;
        internal System.Windows.Controls.TextBox nameTB;
        internal System.Windows.Controls.DataGrid PostDataGrid;
    }
}
