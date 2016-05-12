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
using Caliburn.Micro;
using MeiPai3.ViewModels;
using Windows.UI.Xaml.Media.Animation;
using Windows.ApplicationModel.Resources;
using CCUWPToolkit.Controls;
// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上提供

namespace MeiPai3.Views
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class InitMainView 
    {
        public InitMainView()
        {
            this.InitializeComponent();
            //ResourceLoader loader = ResourceLoader.GetForCurrentView();
            //var text = loader.GetString("header_channel_live");
            //var item = new PivotItem();
            //item.Header = text;
            //item.Content=new ch
            //myPivot.Items.Add(item);
        }
        #region PivotItemLoaded
        private void Fade(UIElement element)
        {
            var animation = new DoubleAnimation
            {
                From = 0,
                To = 1,
                Duration = new Duration(TimeSpan.FromSeconds(.5)),
                EasingFunction = new CircleEase()
            };

            Storyboard.SetTarget(animation, element);
            Storyboard.SetTargetProperty(animation, "Opacity");

            var storyboard = new Storyboard();
            storyboard.Children.Add(animation);
            storyboard.Begin();
        }
        private void myPivot_PivotItemLoaded(Pivot sender, PivotItemEventArgs args)
        {
            if (args.Item != null)
            {
                VisControl(args.Item);
            }
        }
        private void VisControl(PivotItem pi)
        {
            foreach (var item in myPivot.Items)
            {
                var pivotItem = item as PivotItem;
                if (pi != pivotItem)
                {
                    (pivotItem.Content as UIElement).Visibility = Visibility.Collapsed;
                }
                else
                {
                    (pivotItem.Content as UIElement).Visibility = Visibility.Visible;
                    Fade(pivotItem);
                }
            }
        }
        #endregion

        #region SizeChanged
        private void LiveGrid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            var panel = channelLiveView.ItemsPanelRoot as ItemsWrapGrid;
            double itemSize = 0.0;
            if (e.NewSize.Width <= 600)
                itemSize = e.NewSize.Width / 2;
            else if (e.NewSize.Width >= 600 && e.NewSize.Width <= 700)
                itemSize = e.NewSize.Width / 3;
            else if (e.NewSize.Width >= 700)
                itemSize = e.NewSize.Width / 4;

            panel.ItemWidth = itemSize;
            panel.ItemHeight = itemSize;
        }

        private void HotGrid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            var panel = channelHotView.ItemsPanelRoot as ItemsWrapGrid;
            double itemSize = 0.0;
            if (e.NewSize.Width <= 600)
                itemSize = e.NewSize.Width / 2;
            else if (e.NewSize.Width >= 600 && e.NewSize.Width <= 700)
                itemSize = e.NewSize.Width / 3;
            else if (e.NewSize.Width >= 700)
                itemSize = e.NewSize.Width / 4;

            panel.ItemWidth = itemSize;
            panel.ItemHeight = itemSize;
        }

        private void GourmetGrid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            var panel = channelGourmetView.ItemsPanelRoot as ItemsWrapGrid;
            double itemSize = 0.0;
            if (e.NewSize.Width <= 600)
                itemSize = e.NewSize.Width / 2;
            else if (e.NewSize.Width >= 600 && e.NewSize.Width <= 700)
                itemSize = e.NewSize.Width / 3;
            else if (e.NewSize.Width >= 700)
                itemSize = e.NewSize.Width / 4;

            panel.ItemWidth = itemSize;
            panel.ItemHeight = itemSize;
        }

        private void FunnyGrid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            var panel = channelFunnyView.ItemsPanelRoot as ItemsWrapGrid;
            double itemSize = 0.0;
            if (e.NewSize.Width <= 600)
                itemSize = e.NewSize.Width / 2;
            else if (e.NewSize.Width >= 600 && e.NewSize.Width <= 700)
                itemSize = e.NewSize.Width / 3;
            else if (e.NewSize.Width >= 700)
                itemSize = e.NewSize.Width / 4;

            panel.ItemWidth = itemSize;
            panel.ItemHeight = itemSize;
        }

        private void FashionGrid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            var panel = channelFashionView.ItemsPanelRoot as ItemsWrapGrid;
            double itemSize = 0.0;
            if (e.NewSize.Width <= 600)
                itemSize = e.NewSize.Width / 2;
            else if (e.NewSize.Width >= 600 && e.NewSize.Width <= 700)
                itemSize = e.NewSize.Width / 3;
            else if (e.NewSize.Width >= 700)
                itemSize = e.NewSize.Width / 4;

            panel.ItemWidth = itemSize;
            panel.ItemHeight = itemSize;
        }

        private void MusicGrid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            var panel = channelMusicView.ItemsPanelRoot as ItemsWrapGrid;
            double itemSize = 0.0;
            if (e.NewSize.Width <= 600)
                itemSize = e.NewSize.Width / 2;
            else if (e.NewSize.Width >= 600 && e.NewSize.Width <= 700)
                itemSize = e.NewSize.Width / 3;
            else if (e.NewSize.Width >= 700)
                itemSize = e.NewSize.Width / 4;

            panel.ItemWidth = itemSize;
            panel.ItemHeight = itemSize;
        }

        private void DanceGrid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            var panel = channelDanceView.ItemsPanelRoot as ItemsWrapGrid;
            double itemSize = 0.0;
            if (e.NewSize.Width <= 600)
                itemSize = e.NewSize.Width / 2;
            else if (e.NewSize.Width >= 600 && e.NewSize.Width <= 700)
                itemSize = e.NewSize.Width / 3;
            else if (e.NewSize.Width >= 700)
                itemSize = e.NewSize.Width / 4;

            panel.ItemWidth = itemSize;
            panel.ItemHeight = itemSize;
        }

        private void BabyGrid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            var panel = channelBabyView.ItemsPanelRoot as ItemsWrapGrid;
            double itemSize = 0.0;
            if (e.NewSize.Width <= 600)
                itemSize = e.NewSize.Width / 2;
            else if (e.NewSize.Width >= 600 && e.NewSize.Width <= 700)
                itemSize = e.NewSize.Width / 3;
            else if (e.NewSize.Width >= 700)
                itemSize = e.NewSize.Width / 4;

            panel.ItemWidth = itemSize;
            panel.ItemHeight = itemSize;
        }

        private void CelebrityGrid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            var panel = channelCelebrityView.ItemsPanelRoot as ItemsWrapGrid;
            double itemSize = 0.0;
            if (e.NewSize.Width <= 600)
                itemSize = e.NewSize.Width / 2;
            else if (e.NewSize.Width >= 600 && e.NewSize.Width <= 700)
                itemSize = e.NewSize.Width / 3;
            else if (e.NewSize.Width >= 700)
                itemSize = e.NewSize.Width / 4;

            panel.ItemWidth = itemSize;
            panel.ItemHeight = itemSize;
        }

        private void BeautyGrid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            var panel = channelBeautyView.ItemsPanelRoot as ItemsWrapGrid;
            double itemSize = 0.0;
            if (e.NewSize.Width <= 600)
                itemSize = e.NewSize.Width / 2;
            else if (e.NewSize.Width >= 600 && e.NewSize.Width <= 700)
                itemSize = e.NewSize.Width / 3;
            else if (e.NewSize.Width >= 700)
                itemSize = e.NewSize.Width / 4;

            panel.ItemWidth = itemSize;
            panel.ItemHeight = itemSize;
        }

        private void TravelGrid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            var panel = channelTravelView.ItemsPanelRoot as ItemsWrapGrid;
            double itemSize = 0.0;
            if (e.NewSize.Width <= 600)
                itemSize = e.NewSize.Width / 2;
            else if (e.NewSize.Width >= 600 && e.NewSize.Width <= 700)
                itemSize = e.NewSize.Width / 3;
            else if (e.NewSize.Width >= 700)
                itemSize = e.NewSize.Width / 4;

            panel.ItemWidth = itemSize;
            panel.ItemHeight = itemSize;
        }

        private void CreativeGrid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            var panel = channelCreativeView.ItemsPanelRoot as ItemsWrapGrid;
            double itemSize = 0.0;
            if (e.NewSize.Width <= 600)
                itemSize = e.NewSize.Width / 2;
            else if (e.NewSize.Width >= 600 && e.NewSize.Width <= 700)
                itemSize = e.NewSize.Width / 3;
            else if (e.NewSize.Width >= 700)
                itemSize = e.NewSize.Width / 4;

            panel.ItemWidth = itemSize;
            panel.ItemHeight = itemSize;
        }

        private void PetGrid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            var panel = channelPetView.ItemsPanelRoot as ItemsWrapGrid;
            double itemSize = 0.0;
            if (e.NewSize.Width <= 600)
                itemSize = e.NewSize.Width / 2;
            else if (e.NewSize.Width >= 600 && e.NewSize.Width <= 700)
                itemSize = e.NewSize.Width / 3;
            else if (e.NewSize.Width >= 700)
                itemSize = e.NewSize.Width / 4;

            panel.ItemWidth = itemSize;
            panel.ItemHeight = itemSize;
        }

        private void HotGuysGrid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            var panel = channelHot_GuysView.ItemsPanelRoot as ItemsWrapGrid;
            double itemSize = 0.0;
            if (e.NewSize.Width <= 600)
                itemSize = e.NewSize.Width / 2;
            else if (e.NewSize.Width >= 600 && e.NewSize.Width <= 700)
                itemSize = e.NewSize.Width / 3;
            else if (e.NewSize.Width >= 700)
                itemSize = e.NewSize.Width / 4;

            panel.ItemWidth = itemSize;
            panel.ItemHeight = itemSize;
        }

        #endregion

        private void myPivot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (myPivot.SelectedIndex)
            {
                case 0:
                    
                    var wy = new WYToastDialog();
                    wy.ShowAsync("000000000000000000");


                    break;
                case 1:
                    wy = new WYToastDialog();
                    wy.ShowAsync("11111111111111111111");
                    break;
                case 2:
                    wy = new WYToastDialog();
                    wy.ShowAsync("222222222222222222222");
                    break;
                case 3:
                    wy = new WYToastDialog();
                    wy.ShowAsync("333333333333333333");
                    break;
                case 4:
                    wy = new WYToastDialog();
                    wy.ShowAsync("4444444444444444");
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
            }
        }
    }
}
