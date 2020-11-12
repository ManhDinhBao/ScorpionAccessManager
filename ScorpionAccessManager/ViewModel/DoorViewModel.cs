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
    public class DoorViewModel:ViewModelBase
    {
        private ObservableCollection<Door> doors;

        public ObservableCollection<Door> Doors
        {
            get
            {
                return doors;
            }
            set
            {
                doors = value;
                RaisePropertyChanged("Doors");
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
                    View.Filter = new Predicate<object>(o => ((Door)o).Name == value);
            }
        }

        public DoorViewModel()
        {
            doors = new ObservableCollection<Door>
            {
                new Door{Id="DO01",Name="Door 01"},
                new Door{Id="DO02",Name="Door 02"},
                new Door{Id="DO03",Name="Door 03"},
                new Door{Id="DO04",Name="Door 04"},
                new Door{Id="DO05",Name="Door 05"},
                new Door{Id="DO06",Name="Door 06"},
                new Door{Id="DO07",Name="Door 07"}
            };

            this._view = new ListCollectionView(this.doors);
        }
    }
}
