using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScorpionAccessManager.Model
{
    public class DoorMode
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ReaderUse { get; set; }
        public int InputUse { get; set; }
        public int OutputUse { get; set; }
    }
}
