/********************************************************************************
** 作者： androllen
** 日期： 16/4/12 19:15:40
** 微博： http://weibo.com/Androllen
*********************************************************************************/
using System.Threading.Tasks;
using Caliburn.Micro;
using WeYa.Tools.Utils;
using System.Collections.ObjectModel;
using WeYa.Core;
using MeiPai3.ViewModels.DataSource;
using WeYa.Domain.Models;
using Windows.UI.Popups;
using System;
using Windows.UI.Xaml.Controls;
using CCUWPToolkit.Controls;

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

        #region GridViewItemSelected
        public async void channelLiveSelected(GridItemViewModel character)
        {
            var dialog = new MessageDialog(String.Format("{0} selected.", character.Name), "Character Selected");

            await dialog.ShowAsync();
        }

        public async void channelHotSelected(GridItemViewModel character)
        {
            var dialog = new MessageDialog(String.Format("{0} selected.", character.Name), "Character Selected");

            await dialog.ShowAsync();
        }
        public async void channelGourmetSelected(GridItemViewModel character)
        {
            var dialog = new MessageDialog(String.Format("{0} selected.", character.Name), "Character Selected");

            await dialog.ShowAsync();
        }

        public async void channelFunnySelected(GridItemViewModel character)
        {
            var dialog = new MessageDialog(String.Format("{0} selected.", character.Name), "Character Selected");

            await dialog.ShowAsync();
        }
        public async void channelFashionSelected(GridItemViewModel character)
        {
            var dialog = new MessageDialog(String.Format("{0} selected.", character.Name), "Character Selected");

            await dialog.ShowAsync();
        }

        public async void channelMusicSelected(GridItemViewModel character)
        {
            var dialog = new MessageDialog(String.Format("{0} selected.", character.Name), "Character Selected");

            await dialog.ShowAsync();
        }
        public async void channelDanceSelected(GridItemViewModel character)
        {
            var dialog = new MessageDialog(String.Format("{0} selected.", character.Name), "Character Selected");

            await dialog.ShowAsync();
        }

        public async void channelBabySelected(GridItemViewModel character)
        {
            var dialog = new MessageDialog(String.Format("{0} selected.", character.Name), "Character Selected");

            await dialog.ShowAsync();
        }
        public async void channelCelebritySelected(GridItemViewModel character)
        {
            var dialog = new MessageDialog(String.Format("{0} selected.", character.Name), "Character Selected");

            await dialog.ShowAsync();
        }

        public async void channelBeautySelected(GridItemViewModel character)
        {
            var dialog = new MessageDialog(String.Format("{0} selected.", character.Name), "Character Selected");

            await dialog.ShowAsync();
        }
        public async void channelTravelSelected(GridItemViewModel character)
        {
            var dialog = new MessageDialog(String.Format("{0} selected.", character.Name), "Character Selected");

            await dialog.ShowAsync();
        }

        public async void channelCreativeSelected(GridItemViewModel character)
        {
            var dialog = new MessageDialog(String.Format("{0} selected.", character.Name), "Character Selected");

            await dialog.ShowAsync();
        }
        public async void channelPetSelected(GridItemViewModel character)
        {
            var dialog = new MessageDialog(String.Format("{0} selected.", character.Name), "Character Selected");

            await dialog.ShowAsync();
        }

        public async void channelGuysSelected(GridItemViewModel character)
        {
            var dialog = new MessageDialog(String.Format("{0} selected.", character.Name), "Character Selected");

            await dialog.ShowAsync();
        }
        #endregion

        public BindableCollection<GridItemViewModel> channelLiveView { get; set; }
        public BindableCollection<GridItemViewModel> channelHotView { get; set; }
        public BindableCollection<GridItemViewModel> channelGourmetView { get; set; }
        public BindableCollection<GridItemViewModel> channelFunnyView { get; set; }
        public BindableCollection<GridItemViewModel> channelFashionView { get; set; }
        public BindableCollection<GridItemViewModel> channelMusicView { get; set; }
        public BindableCollection<GridItemViewModel> channelDanceView { get; set; }
        public BindableCollection<GridItemViewModel> channelBabyView { get; set; }
        public BindableCollection<GridItemViewModel> channelCelebrityView { get; set; }
        public BindableCollection<GridItemViewModel> channelBeautyView { get; set; }
        public BindableCollection<GridItemViewModel> channelTravelView { get; set; }
        public BindableCollection<GridItemViewModel> channelCreativeView { get; set; }
        public BindableCollection<GridItemViewModel> channelPetView { get; set; }
        public BindableCollection<GridItemViewModel> channelGuysView { get; set; }

        public InitMainViewModel(INotifyFrameChanged frame) 
            : base(frame)
        {
            channelLiveView = new IncrementalLoadingCollection<GridItemViewModel>(new GeneratingDataSource());
            channelHotView = new IncrementalLoadingCollection<GridItemViewModel>(new GeneratingDataSource());
            channelGourmetView = new IncrementalLoadingCollection<GridItemViewModel>(new GeneratingDataSource());
            channelFunnyView = new IncrementalLoadingCollection<GridItemViewModel>(new GeneratingDataSource());
            channelFashionView = new IncrementalLoadingCollection<GridItemViewModel>(new GeneratingDataSource());
            channelMusicView = new IncrementalLoadingCollection<GridItemViewModel>(new GeneratingDataSource());
            channelDanceView = new IncrementalLoadingCollection<GridItemViewModel>(new GeneratingDataSource());
            channelBabyView = new IncrementalLoadingCollection<GridItemViewModel>(new GeneratingDataSource());
            channelCelebrityView = new IncrementalLoadingCollection<GridItemViewModel>(new GeneratingDataSource());
            channelBeautyView = new IncrementalLoadingCollection<GridItemViewModel>(new GeneratingDataSource());
            channelTravelView = new IncrementalLoadingCollection<GridItemViewModel>(new GeneratingDataSource());
            channelCreativeView = new IncrementalLoadingCollection<GridItemViewModel>(new GeneratingDataSource());
            channelPetView = new IncrementalLoadingCollection<GridItemViewModel>(new GeneratingDataSource());
            channelGuysView = new IncrementalLoadingCollection<GridItemViewModel>(new GeneratingDataSource());
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
