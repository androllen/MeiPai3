/********************************************************************************
** 作者： androllen
** 日期： 16/4/27 18:52:15
** 微博： http://weibo.com/Androllen
*********************************************************************************/

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeYa.Core;
using WeYa.Domain;
using Windows.UI.Xaml;
using MeiPai3.ViewModels;
using Caliburn.Micro;

namespace MeiPai3.Trigger
{
    public enum AdaptiveType
    {
        Show1,
        Show2,
        Show12
    }
    public class DeviceAdaptiveTrigger : StateTriggerBase
    {
        private readonly INotifyFrameChanged _frameManager;
        //private readonly GlobalInfoManager _globalInfoManager;
        private const double minwidth = 648;
        private const double maxwidth = 800;
        public DeviceAdaptiveTrigger()
        {
            Window.Current.SizeChanged += Current_SizeChanged;
            _frameManager = IoC.Get<INotifyFrameChanged>();
        }

        private void Current_SizeChanged(object sender, Windows.UI.Core.WindowSizeChangedEventArgs e)
        {
            var _adaptiveType = AdaptiveDevice(e.Size.Width);
            SetActive(_adaptiveType == adaptiveType);
        }
        public AdaptiveType AdaptiveDevice(double width)
        {
            if(_frameManager.ContentFrame?.Content !=null 
                && _frameManager.ContentFrame.Content.GetType() == typeof(CollectViewModel))
            {
                return AdaptiveType.Show2;
            }
            else
            {
                if (width > 0 && width <= minwidth)
                {
                    if (_frameManager.IsHasContent())
                    {
                        return AdaptiveType.Show2;
                    }
                    else
                        return AdaptiveType.Show1;
                }
                else
                    return AdaptiveType.Show12;
            }

        }

        private AdaptiveType _adaptiveType;
        public AdaptiveType adaptiveType
        {
            get { return _adaptiveType; }
            set
            {
                _adaptiveType = value;
                var device = AdaptiveDevice(Window.Current.Bounds.Width);
                SetActive(device == _adaptiveType);
            }
        }

        //public static readonly DependencyProperty MinWindowWidthProperty = 
        //    DependencyProperty.Register(
        //    "MinWindowWidth", 
        //    typeof(double), 
        //    typeof(DeviceAdaptiveTrigger), 
        //    new PropertyMetadata(0.0));

        //public double MinWindowWidth
        //{
        //    get { return (double)GetValue(MinWindowWidthProperty); }
        //    set { SetValue(MinWindowWidthProperty, value); }
        //}
    }
}
