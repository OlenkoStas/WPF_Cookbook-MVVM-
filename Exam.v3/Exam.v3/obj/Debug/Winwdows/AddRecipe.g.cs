﻿#pragma checksum "..\..\..\Winwdows\AddRecipe.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BC3DC109B3D910B58B790B5AE3675FC33D74210C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Exam.v3.Winwdows;
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


namespace Exam.v3.Winwdows {
    
    
    /// <summary>
    /// AddRecipe
    /// </summary>
    public partial class AddRecipe : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Winwdows\AddRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Exam.v3.Winwdows.AddRecipe NewRecipeWindow;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Winwdows\AddRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbName;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Winwdows\AddRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbType;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Winwdows\AddRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbKitchen;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\Winwdows\AddRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbInstruction;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\..\Winwdows\AddRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbIngredients;
        
        #line default
        #line hidden
        
        
        #line 140 "..\..\..\Winwdows\AddRecipe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Apply;
        
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
            System.Uri resourceLocater = new System.Uri("/Exam.v3;component/winwdows/addrecipe.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Winwdows\AddRecipe.xaml"
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
            this.NewRecipeWindow = ((Exam.v3.Winwdows.AddRecipe)(target));
            return;
            case 2:
            this.tbName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.cbType = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.cbKitchen = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.tbInstruction = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tbIngredients = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.Apply = ((System.Windows.Controls.Button)(target));
            
            #line 139 "..\..\..\Winwdows\AddRecipe.xaml"
            this.Apply.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

