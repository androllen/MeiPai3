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
using Caliburn.Micro;

namespace MeiPai3.Trigger
{
    public enum AdaptiveType
    {
        //主要页
        Show1,
        //内容页
        Show2,
        //Desktop version
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
        /// <summary>
        /// 当屏幕小于648的时候
        /// 如果有内容页 设备自动适配 内容页
        /// 如果无内容页 设备自动适配 主要页
        /// 当屏幕大于648的时候
        /// 有无内容 设备自动适配 Desktop 版本
        /// </summary>
        /// <param name="width"></param>
        /// <returns></returns>
        public AdaptiveType AdaptiveDevice(double width)
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
    }
}
