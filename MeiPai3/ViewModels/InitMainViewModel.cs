/********************************************************************************
** 作者： androllen
** 日期： 16/4/12 19:15:40
** 微博： http://weibo.com/Androllen
*********************************************************************************/
using System.Threading.Tasks;
using Caliburn.Micro;
using System.Collections.ObjectModel;
using WeYa.Core;
using MeiPai3.ViewModels.DataSource;
using WeYa.Domain.Models;
using Windows.UI.Popups;
using System;
using Windows.UI.Xaml.Controls;
using CCUWPToolkit.Controls;
using WeYa.Domain;
using WeYa.Domain.Util;
using WeYa.Utils;

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

        private int currentPage = 1;
        public BindableCollection<GridItemViewModel> channelHotView { get; set; }
        private readonly MainService _service;
        public InitMainViewModel(INotifyFrameChanged frame) 
            : base(frame)
        {
            _service = new MainService();
            channelHotView = new IncrementalLoadingCollection<GridItemViewModel>((cancellationToken, count) => Task.Run(GetMoreData, cancellationToken));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private async Task<BindableCollection<GridItemViewModel>> GetMoreData()
        {
            return await FakeApiCallAsync(currentPage++);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pageNumber"></param>
        /// <param name="itemsPerPage"></param>
        /// <returns></returns>
        private async Task<BindableCollection<GridItemViewModel>> FakeApiCallAsync(int pageNumber)
        {
            var items = new BindableCollection<GridItemViewModel>();
            await _service.HotGet(new ServiceArgument() { id = 1, feature = "new", page = pageNumber, type = 1 }, Item =>
            {
                foreach (var hot in Item)
                {
                    var vm = new GridItemViewModel(hot.RecommendCaption, hot.RecommendCoverPic,hot.Media);
                    items.Add(vm);
                    WeYaLog.Instance.Info(this.ToString(),hot.RecommendCaption);
                }
            });

            return items;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="character"></param>
        public async void channelHotSelected(GridItemViewModel character)
        {
            var dialog = new MessageDialog(String.Format("{0} selected.", character.RecommendCaption), "Character Selected");

            await dialog.ShowAsync();
        }
        /// <summary>
        /// cm:Message.Attach="[Loaded] = [PivotLoaded($source)]"
        /// </summary>
        /// <param name="pivot"></param>
        public void PivotLoaded(Pivot pivot)
        {
            PivotItem pvt;
            for (int i = 0; i < 12; i++)
            {
                pvt = new PivotItem();
                pvt.Header ="item "+ i.ToString();
                pvt.Margin = new Windows.UI.Xaml.Thickness(5, 0, 5, 0);
                var stack = new TextBlock() { Text = i.ToString() };
                pvt.Content = stack;
                pivot.Items.Add(pvt);
                pvt = null;
            }
        }

        protected override void OnActivate()
        {
            base.OnActivate();
        }
        protected override void OnInitialize()
        {
            base.OnInitialize();

        }

        protected override void OnViewLoaded(object view)
        {
            base.OnViewLoaded(view);

        }

        protected override void OnDeactivate(bool close)
        {
            base.OnDeactivate(close);
        }
        public void WYHeaderTitleBar_LeftClick()
        {
            var toast = new WYToastDialog();
            toast.ShowAsync("WYHeaderTitleBar_LeftClick");
        }

        public void WYHeaderTitleBar_RightClick()
        {
            var toast = new WYToastDialog();
            toast.ShowAsync("WYHeaderTitleBar_RightClick");
        }
    }
}
