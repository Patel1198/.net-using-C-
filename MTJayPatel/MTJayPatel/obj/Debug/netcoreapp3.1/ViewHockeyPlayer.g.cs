﻿#pragma checksum "..\..\..\ViewHockeyPlayer.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10BB00BB6DAFC29A0360D39C28F1115B42235973"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MTJayPatel;
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


namespace MTJayPatel {
    
    
    /// <summary>
    /// ViewHockeyPlayer
    /// </summary>
    public partial class ViewHockeyPlayer : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\ViewHockeyPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstHockeyPlayers;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\ViewHockeyPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPlayerId;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\ViewHockeyPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPlayerName;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\ViewHockeyPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTeamName;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\ViewHockeyPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtGamesPlayed;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\ViewHockeyPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtGoals;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\ViewHockeyPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAssists;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\ViewHockeyPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPoints;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\ViewHockeyPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddPlayer;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\ViewHockeyPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpdatePlayer;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\ViewHockeyPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDeletePlayer;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MTJayPatel;component/viewhockeyplayer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ViewHockeyPlayer.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\ViewHockeyPlayer.xaml"
            ((MTJayPatel.ViewHockeyPlayer)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 8 "..\..\..\ViewHockeyPlayer.xaml"
            ((MTJayPatel.ViewHockeyPlayer)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lstHockeyPlayers = ((System.Windows.Controls.ListBox)(target));
            
            #line 14 "..\..\..\ViewHockeyPlayer.xaml"
            this.lstHockeyPlayers.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lstHockeyPlayers_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtPlayerId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtPlayerName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtTeamName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtGamesPlayed = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtGoals = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txtAssists = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.txtPoints = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.btnAddPlayer = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\ViewHockeyPlayer.xaml"
            this.btnAddPlayer.Click += new System.Windows.RoutedEventHandler(this.btnAddPlayer_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnUpdatePlayer = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\ViewHockeyPlayer.xaml"
            this.btnUpdatePlayer.Click += new System.Windows.RoutedEventHandler(this.btnUpdatePlayer_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.btnDeletePlayer = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\ViewHockeyPlayer.xaml"
            this.btnDeletePlayer.Click += new System.Windows.RoutedEventHandler(this.btnDeletePlayer_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 39 "..\..\..\ViewHockeyPlayer.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.btnQuit_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 44 "..\..\..\ViewHockeyPlayer.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.btnAddPlayer_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 45 "..\..\..\ViewHockeyPlayer.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.btnUpdatePlayer_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 46 "..\..\..\ViewHockeyPlayer.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.btnDeletePlayer_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 48 "..\..\..\ViewHockeyPlayer.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.btnHelp_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

