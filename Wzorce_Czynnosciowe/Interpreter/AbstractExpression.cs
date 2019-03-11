using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_Czynnosciowe.Interpreter
{
    abstract class AbstractExpression
    {
        public abstract string Interpret(Context context);
    }
}

   
