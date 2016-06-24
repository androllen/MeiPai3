/********************************************************************************
** 作者： androllen
** 日期： 16/4/28 14:02:37
** 微博： http://weibo.com/Androllen
*********************************************************************************/
using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeYa.Core;
using WeYa.Domain;
using WeYa.Domain.Models;
using WeYa.Domain.Util;
using WeYa.Utils;

namespace MeiPai3.ViewModels.DataSource
{
    public class GeneratingDataSource : IVirtualisedDataSource<Hot>
    {
        private readonly int _count;
        private int _page;
        private readonly BindableCollection<Hot> items = null;
        private readonly MainService _service;
        private readonly TopicsType _topicsType;
        public GeneratingDataSource(MainService service, TopicsType type=TopicsType.Baby)
        {
            _count = 1000000;
            items = new BindableCollection<Hot>();
            _topicsType = type;
            _service = service;
        }

        public Task<int> GetCountAsync()
        {
            return Task.FromResult(_count);
        }

        public Task<int> GetPageStartIndexAsync()
        {
            return Task.FromResult(_page++);
        }
        public async Task<BindableCollection<Hot>> GetItemsAsync(uint startIndex, uint count)
        {
            int total = ((int)count == 1 ? 18 : (int)count);

            await _service.HotGet(new ServiceArgument() { id = 1, feature = "new", page = _page}, Item =>
            {
                var view = new BindableCollection<Hot>();
                foreach(var item in Item)
                {
                    items.Add(item);
                }
            });

            return items;
        }

    }
}
