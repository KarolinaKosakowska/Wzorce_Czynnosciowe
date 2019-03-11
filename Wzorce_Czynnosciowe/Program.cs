using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wzorce_Czynnosciowe.Interpreter;

namespace Wzorce_Czynnosciowe
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context();

            var list = new List<AbstractExpression>();

            list.Add(new TerminalExpression());
            list.Add(new NonterminalExpression());
            list.Add(new TerminalExpression());
            list.Add(new TerminalExpression());

            foreach (AbstractExpression exp in list)
            {
                Console.WriteLine(exp.Interpret(context));
            }
            Console.Read();
        }
    }
}
