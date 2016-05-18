/********************************************************************************
** 作者： androllen
** 日期： 16/5/17 15:15:56
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

namespace MeiPai3.ViewModels.DataSource
{
    public class HotViewDataSource : IVirtualisedDataSource<GridItemViewModel>
    {
        private readonly int _count;
        private int _pagecount;
        private readonly BindableCollection<GridItemViewModel> items = null;
        private MainService _service;
        public HotViewDataSource(int count = 1000000)
        {
            _count = count;
            items = new BindableCollection<GridItemViewModel>();

            _service = new MainService(new MainDeserializer());
        }

        public Task<int> GetCountAsync()
        {
            return Task.FromResult(_count);
        }
        public Task<int> GetPageStartIndexAsync()
        {
            return Task.FromResult(_pagecount++);
        }
        public async Task<BindableCollection<GridItemViewModel>> GetItemsAsync(uint startIndex, uint count)
        {
            //启用缓存
            //网络请求
            var item = new BindableCollection<GridItemViewModel>();

            BindableCollection<UserInfo> hots = await _service.GetCategory(_pagecount);
            foreach (var view in hots)
            {
                var vm = new GridItemViewModel(view.Avatar, view.Name);
                item.Add(vm);
            }

            foreach(var hot in item)
            {
                items.Add(hot);
            }

            return items;
        }
    }
}
