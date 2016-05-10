/********************************************************************************
** 作者： androllen
** 日期： 16/4/12 19:15:40
** 微博： http://weibo.com/Androllen
*********************************************************************************/
using System.Threading.Tasks;
using Caliburn.Micro;
using WeYa.Tools.Utils;
using System.Collections.ObjectModel;
using Windows.ApplicationModel;
using WeYa.Core;
using WeYa.Domain.Models;
using Windows.UI.Popups;
using System;

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
    

        public async void GridItemViewSelected(GridItemViewModel character)
        {
            var dialog = new MessageDialog(String.Format("{0} selected.", character.Name), "Character Selected");

            await dialog.ShowAsync();
        }
        public BindableCollection<GridItemViewModel> myGridView { get; set; }

        public InitMainViewModel(INotifyFrameChanged frame) 
            : base(frame)
        {
            myGridView = new IncrementalLoadingCollection<GridItemViewModel>(new GeneratingDataSource());
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
  
    }
}
