using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPOO
{
    public class EventPrueba
    {

        public event TickHandler Tick;
        public EventArgs e = null;
        public delegate void TickHandler(EventPrueba ev, EventArgs e);

    }
}
