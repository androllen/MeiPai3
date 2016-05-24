/********************************************************************************
** 作者： androllen
** 日期： 16/5/24 17:20:13
** 微博： http://weibo.com/Androllen
*********************************************************************************/
using CCUWPToolkit.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeYa.Core;

namespace MeiPai3.ViewModels
{
    public class SquareItemViewModel : BaseViewModel
    {
        public string Name
        {
            get;
            private set;
        }

        public string Image
        {
            get;
            private set;
        }

        public string Id
        {
            get;
            private set;
        }
        public SquareItemViewModel(INotifyFrameChanged frame, string name, string image)
            : base(frame)
        {
            Name = name;
            Image = image;
        }

        public void ShowHot()
        {
            var toast = new WYToastDialog();
            toast.ShowAsync("WYHeaderTitleBar_LeftClick");
        }
    }
}
