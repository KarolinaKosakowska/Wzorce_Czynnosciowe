using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_Czynnosciowe.Interpreter
{
    class NonterminalExpression : AbstractExpression
    {
        public override string Interpret(Context context)
        {
            return "Called Nonterminal.Interpret()";
        }
    }
}
