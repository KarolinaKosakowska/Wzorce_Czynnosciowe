using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_Czynnosciowe.STATE
{
   public  abstract class State
    {
        public abstract void Handle(Contextt context);
    }


}

