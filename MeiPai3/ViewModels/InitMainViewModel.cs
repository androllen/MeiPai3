/********************************************************************************
** 作者： androllen
** 日期： 16/4/12 19:15:40
** 微博： http://weibo.com/Androllen
*********************************************************************************/
using System.Threading.Tasks;
using Caliburn.Micro;
using WeYa.Tools.Utils;
using System.Collections.ObjectModel;
using Windows.ApplicationModel;
using WeYa.Core;
using WeYa.Domain.Models;

namespace MeiPai3.ViewModels
{
    public class InitMainViewModel : BaseViewModel
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
                    NotifyOfPropertyChange(()=> Title);
                }
            }
        }  

        public InitMainViewModel(INotifyFrameChanged frame) 
            : base(frame)
        {
      
        }

    }
}
