/********************************************************************************
** 作者： androllen
** 日期： 16/4/28 14:02:37
** 微博： http://weibo.com/Androllen
*********************************************************************************/
using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeYa.Domain.Models;
using WeYa.Tools.Utils;

namespace MeiPai3.ViewModels.DataSource
{
    public class GeneratingDataSource : IVirtualisedDataSource<GridItemViewModel>
    {
        private readonly int _count;
        private int _pagecount;

        public GeneratingDataSource(int count = 1000000)
        {
            _count = count;
        }

        public Task<int> GetCountAsync()
        {
            return Task.FromResult(_count);
        }
        public Task<int> GetPageStartIndexAsync()
        {
            return Task.FromResult(_pagecount++);
        }
        public Task<BindableCollection<GridItemViewModel>> GetItemsAsync(uint startIndex, uint count)
        {
            return Task.Run(() =>
            {
                var items = new BindableCollection<GridItemViewModel>();

                for (int i = (int)startIndex; i < count+ startIndex; i++)
                {
                    items.Add(new GridItemViewModel(i.ToString(),"https://ss0.bdstatic.com/5aV1bjqh_Q23odCf/static/superman/img/logo/logo_white_fe6da1ec.png"));
                }

                return items;
            });
        }

    }
}
