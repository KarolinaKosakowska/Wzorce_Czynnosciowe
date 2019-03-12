using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_Czynnosciowe.STATE
{
    public class SmallState : State
    {
        public override void Handle(Contextt context)
        {
            Console.SetWindowSize(70, Console.WindowHeight);
            context.State = new BigState();
        }
    }
}
