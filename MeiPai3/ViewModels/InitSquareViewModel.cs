/********************************************************************************
** 作者： androllen
** 日期： 16/5/24 15:57:12
** 微博： http://weibo.com/Androllen
*********************************************************************************/
using CCUWPToolkit.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeYa.Core;
using Windows.UI.Xaml.Media.Imaging;

namespace MeiPai3.ViewModels
{
    public class InitSquareViewModel : BaseViewModel
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
                    NotifyOfPropertyChange(() => Title);
                }
            }
        }
        public InitSquareViewModel(INotifyFrameChanged frame)
            : base(frame)
        {
            HotImg = "http://mvimg1.meitudata.com/573ec1c5616ce8363.jpg";

            FunnyImg = "http://mvimg2.meitudata.com/561b5917778e88231.jpg";
            CelebrityImg = "http://mvimg2.meitudata.com/561b58ff50f4d8030.jpg";
            FashionImg = "http://mvimg2.meitudata.com/5590e965c5bd67360.jpg";

            BeautyImg = "http://mvimg2.meitudata.com/55779965254291780.jpg";
            DanceImg = "http://mvimg1.meitudata.com/55b7509df142a6511.jpg";
            MusicImg = "http://mvimg1.meitudata.com/55a85f57cb95a9888.jpg";
            GourmetImg = "http://mvimg1.meitudata.com/557e95e12e5aa2332.jpg";
            TravelImg = "http://mvimg2.meitudata.com/557015a5e230d8455.jpg";
            GuysImg = "http://mvimg1.meitudata.com/55a4dec81e3746703.jpg";
            CreativeImg = "http://mvimg2.meitudata.com/5582873d32ac01707.jpg";
            BabyImg = "http://mvimg2.meitudata.com/557014ad4c0137158.jpg";
            PetImg = "http://mvimg2.meitudata.com/557014686763a5734.jpg";
            ActivityImg = "http://mvimg1.meitudata.com/543c923756a997677.png";


        }

        private string _hotimg;
        public string HotImg
        {
            get { return _hotimg; }
            set
            {
                if (_hotimg != value)
                {
                    _hotimg = value;
                    NotifyOfPropertyChange(() => HotImg);
                }
            }
        }
        private string _funny;
        public string FunnyImg
        {
            get { return _funny; }
            set
            {
                if (_funny != value)
                {
                    _funny = value;
                    NotifyOfPropertyChange(() => FunnyImg);
                }
            }
        }


        private string _celebrity;
        public string CelebrityImg
        {
            get { return _celebrity; }
            set
            {
                if (_celebrity != value)
                {
                    _celebrity = value;
                    NotifyOfPropertyChange(() => CelebrityImg);
                }
            }
        }

        private string _beauty;
        public string BeautyImg
        {
            get { return _beauty; }
            set
            {
                if (_beauty != value)
                {
                    _beauty = value;
                    NotifyOfPropertyChange(() => BeautyImg);
                }
            }
        }

        private string _dance;
        public string DanceImg
        {
            get { return _dance; }
            set
            {
                if (_dance != value)
                {
                    _dance = value;
                    NotifyOfPropertyChange(() => DanceImg);
                }
            }
        }

        private string _music;
        public string MusicImg
        {
            get { return _music; }
            set
            {
                if (_music != value)
                {
                    _music = value;
                    NotifyOfPropertyChange(() => MusicImg);
                }
            }
        }

        private string _gourmet;
        public string GourmetImg
        {
            get { return _gourmet; }
            set
            {
                if (_gourmet != value)
                {
                    _gourmet = value;
                    NotifyOfPropertyChange(() => GourmetImg);
                }
            }
        }

        private string _fashion;
        public string FashionImg
        {
            get { return _fashion; }
            set
            {
                if (_fashion != value)
                {
                    _fashion = value;
                    NotifyOfPropertyChange(() => FashionImg);
                }
            }
        }

        private string _travel;
        public string TravelImg
        {
            get { return _travel; }
            set
            {
                if (_travel != value)
                {
                    _travel = value;
                    NotifyOfPropertyChange(() => TravelImg);
                }
            }
        }

        private string _guys;
        public string GuysImg
        {
            get { return _guys; }
            set
            {
                if (_guys != value)
                {
                    _guys = value;
                    NotifyOfPropertyChange(() => GuysImg);
                }
            }
        }

        private string _greative;
        public string CreativeImg
        {
            get { return _greative; }
            set
            {
                if (_greative != value)
                {
                    _greative = value;
                    NotifyOfPropertyChange(() => CreativeImg);
                }
            }
        }

        private string _bady;
        public string BabyImg
        {
            get { return _bady; }
            set
            {
                if (_bady != value)
                {
                    _bady = value;
                    NotifyOfPropertyChange(() => BabyImg);
                }
            }
        }

        private string _pet;
        public string PetImg
        {
            get { return _pet; }
            set
            {
                if (_pet != value)
                {
                    _pet = value;
                    NotifyOfPropertyChange(() => PetImg);
                }
            }
        }

        private string _activity;
        public string ActivityImg
        {
            get { return _activity; }
            set
            {
                if (_activity != value)
                {
                    _activity = value;
                    NotifyOfPropertyChange(() => ActivityImg);
                }
            }
        }

        public void ShowHot()
        {
            var toast = new WYToastDialog();
            toast.ShowAsync("WYHeaderTitleBar_LeftClick");
        }
        public void ShowFunny()
        {

        }
        public void ShowCelebrity()
        {

        }
        public void ShowBeauty()
        {

        }
        public void ShowDance()
        {

        }
        public void ShowMusic()
        {

        }
        public void ShowGourmet()
        {

        }
        public void ShowFashion()
        {

        }
        public void ShowTravel()
        {

        }
        public void ShowGuys()
        {

        }
        public void ShowCreative()
        {

        }
        public void ShowBaby()
        {

        }
        public void ShowPet()
        {

        }
        public void ShowActivity()
        {

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
