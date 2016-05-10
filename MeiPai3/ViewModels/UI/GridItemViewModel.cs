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

namespace MeiPai3.ViewModels
{
    public class GridItemViewModel
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
        public GridItemViewModel(string image)
        {
            Image = image;
        }
    }
}
