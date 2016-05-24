using Caliburn.Micro;
using MeiPai3.ViewModels;
using MeiPai3.Views;
using System.Threading.Tasks;
using WeYa.Core;
using WeYa.Domain;
using WeYa.Utils;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace MeiPai3
{
    /// <summary>
    /// 提供特定于应用程序的行为，以补充默认的应用程序类。
    /// </summary>
    public sealed partial class App
    {
        /// <summary>
        /// 初始化单一实例应用程序对象。这是执行的创作代码的第一行，
        /// 已执行，逻辑上等同于 main() 或 WinMain()。
        /// </summary>
        public App()
        {
            this.InitializeComponent();
            SquareCategoriesItems = new BindableCollection<SquareCategories>();
        }
        protected override void Configure()
        {
            MessageBinder.SpecialValues.Add("$clickeditem", c => ((ItemClickEventArgs)c.EventArgs).ClickedItem);

            base.Configure();

            _container.PerRequest<MainViewModel>()
                .PerRequest<InitMainViewModel>()
                .PerRequest<InitContentViewModel>()
                .PerRequest<ContentViewModel>()
                .PerRequest<CollectViewModel>()
                .PerRequest<ChannelLiveViewModel>()
                .PerRequest<InitSquareViewModel>()
                .PerRequest<ShellViewModel>();



            _container.RegisterSingleton(typeof(INotifyFrameChanged), string.Empty, typeof(PhoneFrameMgr));

            SettingUtil.getInstance.setValues<string>(SettingUtil.KEY_FOLDER, "hello world! key-values");
            string data = SettingUtil.getInstance.getValues<string>(SettingUtil.KEY_FOLDER, string.Empty);

            var globalInfoManager = Resources["GlobalInfoManager"];
            _container.RegisterInstance(typeof(GlobalInfoManager), null, globalInfoManager);

            _container.RegisterInstance(typeof(INotifyFileCache), string.Empty, typeof(MainFileCache));
        }

        /// <summary>
        /// 加载主题
        /// </summary>
        /// <param name="e"></param>
        private void LoadThemeResource(ElementTheme e)
        {
            var mainBrush = (Resources.ThemeDictionaries[e.ToString()] as ResourceDictionary)["album_bottom_bg"] as SolidColorBrush;
            if (DeviceUtil.IsType(DeviceFamily.Desktop))
            {
                var titleBar = ApplicationView.GetForCurrentView().TitleBar;
                titleBar.BackgroundColor = titleBar.ButtonBackgroundColor = mainBrush.Color;
                titleBar.ButtonForegroundColor = titleBar.ForegroundColor = Colors.White;
            }
            else
            {
                var mainFrame = IoC.Get<INotifyFrameChanged>().MainFrame;
                if (mainFrame != null)
                    mainFrame.Background = mainBrush;
            }
        }
        public BindableCollection<SquareCategories> SquareCategoriesItems { get; set; }
        /// <summary>
        /// 当主题改变的时候调用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GlobalInfoManager_notifyElementThemeEvent(object sender, Windows.UI.Xaml.ElementTheme e)
        {
            LoadThemeResource(e);
        }
        private async Task getCommon()
        {
            MainService mainService = new MainService();
            await mainService.OnCommon<SquareCategories>(new ServiceArgument(), callback =>
            {
                foreach (var item in callback)
                {
                    SquareCategoriesItems.Add(item);
                }
            });

        }
        protected override void OnLaunched(LaunchActivatedEventArgs args)
        {
            if (Window.Current.Content == null)
            {
                //await getCommon();

                DisplayRootViewFor<MainViewModel>();

                var globalInfoManager = IoC.Get<GlobalInfoManager>();
                LoadThemeResource(globalInfoManager.mAppTheme);
                globalInfoManager.notifyElementThemeEvent += GlobalInfoManager_notifyElementThemeEvent;

                /**
                 * 在设置页面 开关
                 * globalInfoManager.mIsCacheMode = (1 != 2) ? WeYa.Utils.EnumType.CacheType.Close : WeYa.Utils.EnumType.CacheType.Open;
                 * get 在网络请求的地方调用 传参
                 * 
                 * **/
            }
            else
                Window.Current.Activate();


            //var view = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView();
            //if (view != null)
            //{
            //    if (DeviceInfoHelper.IsType(DeviceFamily.Mobile))
            //    {
            //        view.SetPreferredMinSize(new Size(320, 768));
            //    }
            //}
        }

    }
}
