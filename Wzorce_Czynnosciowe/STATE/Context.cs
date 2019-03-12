using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_Czynnosciowe.STATE
{
    public class Contextt
    {
        public Contextt(State state)
        {
            State = state;
        }
        public State State { get; set; }

        public void Change()
        {
            State.Handle(this);
        }
    }
}
