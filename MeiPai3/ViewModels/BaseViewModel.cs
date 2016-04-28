﻿/********************************************************************************
** 作者： androllen
** 日期： 16/4/12 19:15:40
** 微博： http://weibo.com/Androllen
*********************************************************************************/
using Caliburn.Micro;
using WeYa.Core;

namespace MeiPai3.ViewModels
{
    public abstract class BaseViewModel : Screen
    {
        public virtual string Title { get; set; }
        protected readonly INotifyFrameChanged _frame;

        public BaseViewModel(INotifyFrameChanged frame)
        {
            _frame = frame;

        }

    }
}
