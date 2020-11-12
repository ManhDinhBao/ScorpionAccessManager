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
    class RightViewModel:ViewModelBase
    {
        private ObservableCollection<Right> rights;

        public ObservableCollection<Right> Rights
        {
            get
            {
                return rights;
            }
            set
            {
                rights = value;
                RaisePropertyChanged("Rights");
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
                    View.Filter = new Predicate<object>(o => ((Right)o).Name == value);
            }
        }


        public RightViewModel()
        {
            rights = new ObservableCollection<Right>
            {
                new Right{Id="RIGHT1",Name="Day shift",Description="Day shift"},
                new Right{Id="RIGHT2",Name="Night shift",Description="Day shift"},
                new Right{Id="RIGHT3",Name="Holiday",Description="Day shift"},

            };

            this._view = new ListCollectionView(this.rights);
        }
    }
}
