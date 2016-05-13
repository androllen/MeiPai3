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

        private void myPivot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (myPivot.SelectedIndex)
            {
                case 0:
                    channelLiveView.UpdateLayout();
                    break;
                case 1:
                    channelHotView.UpdateLayout();
                    break;
                case 2:
                    channelGourmetView.UpdateLayout();
                    break;
                case 3:
                    break;
                case 4:
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
