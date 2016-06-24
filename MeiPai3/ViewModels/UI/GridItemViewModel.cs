/********************************************************************************
** 作者： androllen
** 日期： 16/5/9 13:59:33
** 微博： http://weibo.com/Androllen
*********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeYa.Domain;

namespace MeiPai3.ViewModels
{
    public class GridItemViewModel
    {
        public string RecommendCaption
        {
            get;
            private set;
        }

        public string RecommendCoverPic
        {
            get;
            private set;
        }
        public Media Media
        {
            get;
            private set;
        }
 
        public GridItemViewModel(string caption, string pic, Media media)
        {
            RecommendCaption = caption;
            RecommendCoverPic = pic;
            Media = media;
        }


    }
}
