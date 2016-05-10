using System;
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
using MeiPai3.ViewModels;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace MeiPai3.Views
{
    public sealed partial class ChannelLiveView
    {
        private ChannelLiveViewModel vm = new ChannelLiveViewModel();
        public ChannelLiveView()
        {
            this.InitializeComponent();
            this.DataContext = vm;
            this.Loaded += ChannelLiveView_Loaded;
        }

        private void ChannelLiveView_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void Grid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            //var panel = myGridView.ItemsPanelRoot as ItemsWrapGrid;
            //double itemSize = 0.0;
            //if (e.NewSize.Width <= 600)
            //{
            //    itemSize = e.NewSize.Width / 2;
            //    panel.ItemWidth = itemSize;
            //    panel.ItemHeight = itemSize;
            //}
            //else if (e.NewSize.Width >= 600 && e.NewSize.Width <= 700)
            //{
            //    itemSize = e.NewSize.Width / 3;
            //    panel.ItemWidth = itemSize;
            //    panel.ItemHeight = itemSize;
            //}
            //else if (e.NewSize.Width >= 700)
            //{
            //    itemSize = e.NewSize.Width / 4;
            //    panel.ItemWidth = itemSize;
            //    panel.ItemHeight = itemSize;
            //}
        }
    }
}
