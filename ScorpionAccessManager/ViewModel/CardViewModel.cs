using ScorpionAccessManager.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;
using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;

namespace ScorpionAccessManager.ViewModel
{
    public class CardViewModel : ViewModelBase
    {
        private ObservableCollection<Card> cards;

        public ObservableCollection<Card> Cards
        {
            get
            {
                return cards;
            }
            set
            {
                cards = value;
                RaisePropertyChanged("Cards");
            }
        }

        public CardViewModel()
        {
            cards = new ObservableCollection<Card>
            {
                new Card{Serial="101",Number="No1",StartTime=new DateTime(2020,01,01),EndTime= new DateTime(2020,12,12) },
                new Card{Serial="102",Number="No2",StartTime=new DateTime(2020,02,01),EndTime= new DateTime(2020,11,12) },
                new Card{Serial="103",Number="No3",StartTime=new DateTime(2020,05,01),EndTime= new DateTime(2020,06,12) },
                new Card{Serial="104",Number="No4",StartTime=new DateTime(2020,11,04),EndTime= new DateTime(2020,12,24) },
                new Card{Serial="105",Number="No5",StartTime=new DateTime(2020,11,01),EndTime= new DateTime(2020,09,12) },
                new Card{Serial="106",Number="No6",StartTime=new DateTime(2020,11,06),EndTime= new DateTime(2020,12,12) },
                new Card{Serial="107",Number="No7",StartTime=new DateTime(2020,01,01),EndTime= new DateTime(2020,12,30) },
            };
        }
    }
}
