﻿#pragma checksum "..\..\TransferMan.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F7F1B99548C0D64D79DD5AD41B7DAA9FC7A1A39A332F5F6CA2521404A29CDF3B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Login;
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


namespace Login {
    
    
    /// <summary>
    /// TransferMan
    /// </summary>
    public partial class TransferMan : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\TransferMan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Amount;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\TransferMan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Transfered;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\TransferMan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox T1;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\TransferMan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox T2;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\TransferMan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox T3;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\TransferMan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox T4;
        
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
            System.Uri resourceLocater = new System.Uri("/Login;component/transferman.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TransferMan.xaml"
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
            
            #line 8 "..\..\TransferMan.xaml"
            ((Login.TransferMan)(target)).Closed += new System.EventHandler(this.Window_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Amount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Transfered = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\TransferMan.xaml"
            this.Transfered.Click += new System.Windows.RoutedEventHandler(this.Transfered_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.T1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.T2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.T3 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.T4 = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
