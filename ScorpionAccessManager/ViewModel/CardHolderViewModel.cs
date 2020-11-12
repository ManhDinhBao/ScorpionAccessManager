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
    public class CardHolderViewModel : ViewModelBase
    {
        private ObservableCollection<CardHolder> holders;

        public ObservableCollection<CardHolder> Holders
        {
            get
            {
                return holders;
            }
            set
            {
                holders = value;
                RaisePropertyChanged("Holders");
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
                    View.Filter = new Predicate<object>(o => ((CardHolder)o).Name == value);
            }
        }

        public CardHolderViewModel()
        {
            holders = new ObservableCollection<CardHolder>
            {
                new CardHolder{Id="C1",Name="manh",Gender=0,DOB=new DateTime(1993,07,12),Address="Phu Tho",PhoneNumber="0977822336",Email="baomanhict@gmail.com",Description="null"},
                new CardHolder{Id="C2",Name="minh",Gender=0,DOB=new DateTime(1986,07,12),Address="Ha Noi",PhoneNumber="0977822336",Email="minhnt@gmail.com",Description="null"},
                new CardHolder{Id="C3",Name="tu",Gender=0,DOB=new DateTime(1992,07,12),Address="Ha Noi",PhoneNumber="0977822336",Email="tunn@gmail.com",Description="null"},
                new CardHolder{Id="C4",Name="chieu",Gender=0,DOB=new DateTime(1991,07,12),Address="Hai Duong",PhoneNumber="0977822336",Email="chieunx@gmail.com",Description="null"},
                new CardHolder{Id="C5",Name="long",Gender=0,DOB=new DateTime(1995,07,12),Address="Hai Phong",PhoneNumber="0977822336",Email="longnk@gmail.com",Description="null"},
                new CardHolder{Id="C6",Name="duy",Gender=0,DOB=new DateTime(1994,07,12),Address="Thai Binh",PhoneNumber="0977822336",Email="duynv@gmail.com",Description="null"},
                new CardHolder{Id="C7",Name="son",Gender=0,DOB=new DateTime(1995,07,12),Address="Vinh Phuc",PhoneNumber="0977822336",Email="sonnv@gmail.com",Description="null"},
                new CardHolder{Id="C8",Name="dung",Gender=0,DOB=new DateTime(1994,07,12),Address="Nghe An",PhoneNumber="0977822336",Email="dunghn@gmail.com",Description="null"}

            };

            this._view = new ListCollectionView(this.holders);
        }
    }
}
