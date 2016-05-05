using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using WeYa.Domain;
using WeYa.Domain.Models;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上提供

namespace DemoFrame.Views
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class InitContentView : Page
    {
        public InitContentView()
        {
            this.InitializeComponent();

            //ResourceLoader loader = ResourceLoader.GetForCurrentView();
            //var text = loader.GetString("StatusBar_Success");
            //var toast = new CCUWPToolkit.Controls.WYToastDialog();
            //toast.ShowAsync(text);
        }

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
    }
}
