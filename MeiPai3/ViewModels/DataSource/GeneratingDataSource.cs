﻿/********************************************************************************
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
    public class GeneratingDataSource : IVirtualisedDataSource<GridItemViewModel>
    {
        private readonly int _count;
        private int _page;
        private readonly BindableCollection<GridItemViewModel> items = null;
        private readonly MainService _service;
        private readonly TopicsType _topicsType;
        public GeneratingDataSource(MainService service, TopicsType type=TopicsType.Baby)
        {
            _count = 1000000;
            items = new BindableCollection<GridItemViewModel>();
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
        public async Task<BindableCollection<GridItemViewModel>> GetItemsAsync(uint startIndex, uint count)
        {
            int total = ((int)count == 1 ? 18 : (int)count);

            items.Clear();
           
            await _service.HotGet<Hot>(new ServiceArgument() { id = 1, feature = "new", page = _page}, Item =>
            {
                var view = new BindableCollection<GridItemViewModel>();
                for (int i = 0; i < Item.Count; i++)
                {
                    var vm = new GridItemViewModel(Item[i].recommend_caption, Item[i].recommend_cover_pic);
                    view.Add(vm);
                }
                foreach (var hot in view)
                {
                    items.Add(hot);
                }

            });

            return items;
        }

    }
}
