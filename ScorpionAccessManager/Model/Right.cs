using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScorpionAccessManager.Model
{
    public class Right
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ObservableCollection<CardHolder> CardHolders { get; set; }
        public ObservableCollection<Door> Doors { get; set; }
        public ObservableCollection<Schedule> Schedules { get; set; }
    }
}
