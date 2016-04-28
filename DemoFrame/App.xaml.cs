﻿using Caliburn.Micro;
using DemoFrame.ViewModels;
using WeYa.Core;
using WeYa.Tools;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;

namespace DemoFrame
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
        }
        protected override void Configure()
        {
            base.Configure();
            
            _container.PerRequest<MainViewModel>()
                .PerRequest<InitMainViewModel>()
                .PerRequest<InitContentViewModel>()
                .PerRequest<ContentViewModel>()
                .PerRequest<CollectViewModel>()
                .PerRequest<ShellViewModel>();

            _container.RegisterSingleton(typeof(INotifyFrameChanged), string.Empty, typeof(PhoneFrameMgr));

            Settings.getInstance.setValues<string>(Settings.KEY_FOLDER, "hello world! key-values");
            string data = Settings.getInstance.getValues<string>(Settings.KEY_FOLDER, string.Empty);
        }

        protected override void OnLaunched(LaunchActivatedEventArgs args)
        {
            DisplayRootViewFor<MainViewModel>();

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
