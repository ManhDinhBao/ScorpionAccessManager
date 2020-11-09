using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ScorpionAccessManager.ViewModel
{
    class MainViewModel
    {
        private IList<UserControl> _UCList;

        public IList<UserControl> UCList
        {
            get { return _UCList; }
            set { _UCList = value; }
        }

        public MainViewModel()
        {
            _UCList = new List<UserControl>
            {

            };
        }

    }
}
