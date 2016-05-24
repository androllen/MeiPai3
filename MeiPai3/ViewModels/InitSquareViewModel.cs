/********************************************************************************
** 作者： androllen
** 日期： 16/5/24 15:57:12
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
    public class InitSquareViewModel : BaseViewModel
    {
        public InitSquareViewModel(INotifyFrameChanged frame)
            : base(frame)
        {

        }

        public void ShowHot()
        {
            var toast = new WYToastDialog();
            toast.ShowAsync("WYHeaderTitleBar_LeftClick");
        }
        public void ShowFunny()
        {

        }
        public void ShowCelebrity()
        {

        }
        public void ShowBeauty()
        {

        }
        public void ShowDance()
        {

        }
        public void ShowMusic()
        {

        }
        public void ShowGourmet()
        {

        }
        public void ShowFashion()
        {

        }
        public void ShowTravel()
        {

        }
        public void ShowGuys()
        {

        }
        public void ShowCreative()
        {

        }
        public void ShowBaby()
        {

        }
        public void ShowPet()
        {

        }
        public void ShowActivity()
        {

        }
    }
}
