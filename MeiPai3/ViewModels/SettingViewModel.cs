/********************************************************************************
** 作者： androllen
** 日期： 16/4/12 19:15:40
** 微博： http://weibo.com/Androllen
*********************************************************************************/
using WeYa.Core;

namespace MeiPai3.ViewModels
{
    public class SettingViewModel : BaseViewModel
    {
        private string _title;
        public override string Title
        {
            get { return _title; }
            set
            {
                if (_title != value)
                {
                    _title = value;
                    NotifyOfPropertyChange(() => Title);
                }
            }
        }

        public SettingViewModel(INotifyFrameChanged frame)
            : base(frame)
        {
        }
    }
}
