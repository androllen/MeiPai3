/********************************************************************************
** 作者： androllen
** 日期： 16/4/12 19:15:40
** 微博： http://weibo.com/Androllen
*********************************************************************************/

using WeYa.Core;
using WeYa.Domain.Models;
using WeYa.Tools.Utils;

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
        private GeneratingDataSource dataSource { get; set; }
        public IncrementalLoadingCollection<IncrementedItem> InfiniteItems { get; set; }
        public InitContentViewModel(INotifyFrameChanged frame) 
            : base(frame)
        {
            dataSource = new GeneratingDataSource();

        }
        public void ContentService()
        {
            InfiniteItems = new IncrementalLoadingCollection<IncrementedItem>(dataSource);
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
