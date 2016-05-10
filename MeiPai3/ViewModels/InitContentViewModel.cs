/********************************************************************************
** 作者： androllen
** 日期： 16/4/12 19:15:40
** 微博： http://weibo.com/Androllen
*********************************************************************************/
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using WeYa.Core;
using WeYa.Domain;
using WeYa.Domain.Models;

namespace MeiPai3.ViewModels
{
    public class InitContentViewModel : BaseViewModel
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
                    NotifyOfPropertyChange(nameof(Title));
                }
            }
        }
 
        public ObservableCollection<SampleDataModel> NewItems { get; set; }
        public ObservableCollection<SampleDataModel> FlaggedItems { get; set; }
        public ObservableCollection<SampleDataModel> AllItems { get; set; }

        public InitContentViewModel(INotifyFrameChanged frame) 
            : base(frame)
        {
          var newItems = SampleDataModel.GetSampleData().Where(x => x.IsNew).ToList();
            var flaggedItems = SampleDataModel.GetSampleData().Where(x => x.IsFlagged).ToList();
           var allItems = SampleDataModel.GetSampleData().ToList();
            this.NewItems = new ObservableCollection<SampleDataModel>();
            this.FlaggedItems = new ObservableCollection<SampleDataModel>();
            this.AllItems = new ObservableCollection<SampleDataModel>();

            newItems.ForEach((b) => NewItems.Add(b));
            flaggedItems.ForEach((b) => FlaggedItems.Add(b));
            allItems.ForEach((b) => AllItems.Add(b));

        }
        public void ShowClickItem()
        {
            //_frame.ContentNavigationService.For<AboutViewModel>().Navigate();
            //_frame.MainNavigationService.For<InitMainViewModel>()
            //  .WithParam(vm => vm.Title, categoryInfo.Label)
            //  .Navigate();
        }
    }
}
