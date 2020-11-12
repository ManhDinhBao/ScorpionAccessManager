using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScorpionAccessManager.Model
{
    public class Door
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DoorMode DMode { get; set; }
        public string Descriprtion { get; set; }
        public int LOTimeOut { get; set; }
        public int DOTimeOut { get; set; }
    }
}
