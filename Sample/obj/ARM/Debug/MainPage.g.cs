﻿#pragma checksum "C:\Users\App42Admin\Downloads\AppWarp_WP7_SDK_DLL-master\AppWarp_WP7_SDK_DLL-master\Sample\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "458D9E34BB1412935FBA6FD3F109235F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace AppWarp_WP7_TestSDK {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBox inputBox;
        
        internal System.Windows.Controls.TextBlock nameLabel;
        
        internal System.Windows.Controls.Button createButton;
        
        internal System.Windows.Controls.Button joinButton;
        
        internal System.Windows.Controls.TextBlock resutlBlock;
        
        internal System.Windows.Controls.Button button1;
        
        internal System.Windows.Controls.TextBox inputCreateRoomBox;
        
        internal System.Windows.Controls.TextBox inputJoinRoomIdBox;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/AppWarp_WP7_TestSDK;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.inputBox = ((System.Windows.Controls.TextBox)(this.FindName("inputBox")));
            this.nameLabel = ((System.Windows.Controls.TextBlock)(this.FindName("nameLabel")));
            this.createButton = ((System.Windows.Controls.Button)(this.FindName("createButton")));
            this.joinButton = ((System.Windows.Controls.Button)(this.FindName("joinButton")));
            this.resutlBlock = ((System.Windows.Controls.TextBlock)(this.FindName("resutlBlock")));
            this.button1 = ((System.Windows.Controls.Button)(this.FindName("button1")));
            this.inputCreateRoomBox = ((System.Windows.Controls.TextBox)(this.FindName("inputCreateRoomBox")));
            this.inputJoinRoomIdBox = ((System.Windows.Controls.TextBox)(this.FindName("inputJoinRoomIdBox")));
        }
    }
}

