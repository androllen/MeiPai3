﻿/********************************************************************************
** 作者： androllen
** 日期： 16/4/12 19:15:40
** 微博： http://weibo.com/Androllen
*********************************************************************************/
using Caliburn.Micro;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls;
using WeYa.Core;
using WeYa.Domain;
using WeYa.Tools;

namespace DemoFrame.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private ObservableCollection<NavLink> _navLinks = new ObservableCollection<NavLink>()
        {
            new NavLink() { Label = TextInfoHelper.Instance.GetString("App_Home"), Symbol = Symbol.Home},
            new NavLink() { Label = TextInfoHelper.Instance.GetString("App_Follow"), Symbol = Symbol.People},
            new NavLink() { Label = TextInfoHelper.Instance.GetString("App_Find"), Symbol = Symbol.Target},
            new NavLink() { Label = TextInfoHelper.Instance.GetString("App_Me"), Symbol = Symbol.Contact }
        };
        public ObservableCollection<NavLink> NavLinks
        {
            get { return _navLinks; }
        }
        protected readonly WinRTContainer _container;
        private int _index;
        public int SelectedIndex
        {
            get { return _index; }
            set
            {
                if (_index != value)
                {
                    _index = value;
                    NotifyOfPropertyChange(()=> SelectedIndex);
                }
            }
        }
        protected override void OnActivate()
        {
            base.OnActivate();
        }
        protected override void OnDeactivate(bool close)
        {
            base.OnDeactivate(close);
        }

        public MainViewModel(WinRTContainer container, INotifyFrameChanged frame) 
            : base(frame)
        {
   


            _container = container;
            SelectedIndex = 0;
        }
        public void ListViewItemClick(ItemClickEventArgs args)
        {
            var categoryInfo = (NavLink)args.ClickedItem;
            switch (categoryInfo.Label)
            {
                case "首页":
                    {
                        _frame.ClearPivotItemView(mainService => 
                        {
                            mainService.For<InitMainViewModel>().WithParam(vm => vm.Title, categoryInfo.Label).Navigate();
                        }, 0);
                    }
                    break;
                case "收藏":
                    {
                        _frame.ClearPivotItemView(mainService =>
                        {
                            mainService.For<CollectViewModel>().WithParam(vm => vm.Title, categoryInfo.Label).Navigate();
                        }, 1);
                    }
                    break;
                case "下载":
                    {
                        _frame.ClearPivotItemView(mainService =>
                        {
                            mainService.For<DownloadViewModel>().WithParam(vm => vm.Title, categoryInfo.Label).Navigate();
                        }, 2);
                    }
                    break;
                case "关于":
                    {
                        _frame.ClearPivotItemView(mainService =>
                        {
                            mainService.For<AboutViewModel>().WithParam(vm => vm.Title, categoryInfo.Label).Navigate();
                        }, 3);
                    }
                    break;
                case "设置":
                    {
                        _frame.ClearPivotItemView(mainService =>
                        {
                            mainService.For<SettingViewModel>().WithParam(vm => vm.Title, categoryInfo.Label).Navigate();
                        }, 4);
                    }
                    break;
            }
        }
        public void SetupPhoneNavigationService(Frame frame)
        {
            _frame.OnPhoneFrame(frame);
        }

        public void SetupDesktopMainNavigationService(Frame frame)
        {
            _frame.MainFrame= frame;
            _frame.MainNavigationService.For<InitMainViewModel>().WithParam(vm => vm.Title, "首页").Navigate();
        }
        public void SetupDesktopContentNavigationService(Frame frame)
        {
            _frame.ContentFrame= frame;
            _frame.ContentNavigationService.For<InitContentViewModel>().Navigate();
        }

        public void TitleClick(ItemClickEventArgs e)
        {
            NavLink link = e.ClickedItem as NavLink;
            //_frame.MainNavigationService.GoTo<MainViewModel>();
        }

        public void onBackKeyPressed()
        {

        }
    }
}
