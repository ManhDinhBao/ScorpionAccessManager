using GalaSoft.MvvmLight;
using ScorpionAccessManager.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ScorpionAccessManager.ViewModel
{
    public class ScheduleViewModel:ViewModelBase
    {
        private ObservableCollection<Schedule> schedules;

        public ObservableCollection<Schedule> Schedules
        {
            get
            {
                return schedules;
            }
            set
            {
                schedules = value;
                RaisePropertyChanged("Schedules");
            }
        }

        private ListCollectionView _view;
        public ICollectionView View
        {
            get { return this._view; }
        }

        private string _textSearch;

        public string TextSearch
        {
            get { return _textSearch; }
            set
            {
                _textSearch = value;
                RaisePropertyChanged("TextSearch");

                if (String.IsNullOrEmpty(value))
                    View.Filter = null;
                else
                    View.Filter = new Predicate<object>(o => ((Schedule)o).Name == value);
            }
        }


        public ScheduleViewModel()
        {
            schedules = new ObservableCollection<Schedule>
            {
                new Schedule{Id="SC01",Name="Đi ăn đêm",RightType=ERightType.RightType.DOOR_RIGHT,Description="Chi la test ma thoi" },
                new Schedule{Id="SC02",Name="Hẹn hò time",RightType=ERightType.RightType.DOOR_RIGHT,Description="Chi la test ma thoi" },
                new Schedule{Id="SC03",Name="Vụng trộm về đêm",RightType=ERightType.RightType.DOOR_RIGHT,Description="Chi la test ma thoi" },
                new Schedule{Id="SC04",Name="Đi ăn uống",RightType=ERightType.RightType.DOOR_RIGHT,Description="Chi la test ma thoi" },
                new Schedule{Id="SC05",Name="Ngủ",RightType=ERightType.RightType.DOOR_RIGHT,Description="Chi la test ma thoi" }
            };

            this._view = new ListCollectionView(this.schedules);
        }
    }
}
