﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Caliburn.Micro;
using DemoFrame.ViewModels;
// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上提供

namespace DemoFrame.Views
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class InitMainView 
    {
        public InitMainView()
        {
            this.InitializeComponent();
        }
        private void Grid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            var panel = myGridView.ItemsPanelRoot as ItemsWrapGrid;
            if (e.NewSize.Width < 500)
            {
                var itemSize = e.NewSize.Width / 2;
                panel.ItemWidth = itemSize;
                panel.ItemHeight = itemSize;
            }
            else if (e.NewSize.Width >= 500 && e.NewSize.Width <= 600)
            {
                var itemSize = e.NewSize.Width / 2;
                panel.ItemWidth = itemSize;
                panel.ItemHeight = itemSize;
            }
            else if (e.NewSize.Width >= 600 && e.NewSize.Width <= 700)
            {
                var itemSize = e.NewSize.Width / 3;
                panel.ItemWidth = itemSize;
                panel.ItemHeight = itemSize;
            }
            else if (e.NewSize.Width >= 700)
            {
                var itemSize = e.NewSize.Width / 4;
                panel.ItemWidth = itemSize;
                panel.ItemHeight = itemSize;
            }
        }
    }
}
