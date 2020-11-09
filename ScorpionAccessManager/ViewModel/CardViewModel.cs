using ScorpionAccessManager.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;

namespace ScorpionAccessManager.ViewModel
{
    class CardViewModel
    {
        private IList<Card> _CardList;
        public CardViewModel()
        {
            _CardList = new List<Card>
            {
                new Card{Serial="1",Number="1x",StartTime=new DateTime(2020,01,01),EndTime=new DateTime(2020,12,01)},
                new Card{Serial="2",Number="2x",StartTime=new DateTime(2020,02,01),EndTime=new DateTime(2020,12,02)},
                new Card{Serial="3",Number="3x",StartTime=new DateTime(2020,03,01),EndTime=new DateTime(2020,12,03)},
                new Card{Serial="4",Number="4x",StartTime=new DateTime(2020,04,01),EndTime=new DateTime(2020,12,04)},
                new Card{Serial="5",Number="5x",StartTime=new DateTime(2020,05,01),EndTime=new DateTime(2020,12,05)},

            };
        }

        public IList<Card> Cards
        {
            get { return _CardList; }
            set { _CardList = value; }
        }

        private ICommand mUpdater;

        public ICommand UpdateCommand
        {
            get 
            {
                if (mUpdater == null) mUpdater = new Updater();
                return mUpdater;
            }
            set 
            {
                mUpdater = value; 
            }
        }

        private class Updater : ICommand
        {
            #region ICommand Members  

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged;

            public void Execute(object parameter)
            {

            }

            #endregion
        }

    }
}
