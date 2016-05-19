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
        private int _page;
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
            return Task.FromResult(_page++);
        }
        public async Task<BindableCollection<GridItemViewModel>> GetItemsAsync(uint startIndex, uint count)
        {
            await _service.HotGet<Hot>(new ServiceArgument() { feature="new",page=_page}, Item=> 
            {
                int total = ((int)count == 1 ? 20 : (int)count);
                for (int i = (int)startIndex; i < total; i++)
                {
                    var vm = new GridItemViewModel(Item[i].recommend_caption, Item[i].recommend_cover_pic);
                    items.Add(vm);
                }
            });


            return items;
        }
    }
}
