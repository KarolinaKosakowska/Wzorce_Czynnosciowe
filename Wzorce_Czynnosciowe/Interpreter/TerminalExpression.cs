using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_Czynnosciowe.Interpreter
{
    class TerminalExpression : AbstractExpression
    {
        public override string Interpret(Context context)
        {
            return "Called Terminal.Interpret()";
        }
    }
}
