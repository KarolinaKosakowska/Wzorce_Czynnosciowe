using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wzorce_Czynnosciowe.Interpreter;
using Wzorce_Czynnosciowe.MEMENTO;

namespace Wzorce_Czynnosciowe
{
    class Program
    {
        static Memento memento;
        static string path = @"D:\text.txt";
        static void Main(string[] args)
        {
            //var context = new Context();

            //var list = new List<AbstractExpression>();

            //list.Add(new TerminalExpression());
            //list.Add(new NonterminalExpression());
            //list.Add(new TerminalExpression());
            //list.Add(new TerminalExpression());

            //foreach (AbstractExpression exp in list)
            //{
            //    Console.WriteLine(exp.Interpret(context));
            //}
           
            File.WriteAllText(path,"pierwszy tekst");
            if (path != ""&& File.Exists(path))
            {
                memento = new Memento(path, File.ReadAllBytes(path));
            }
            File.WriteAllText(path, "drugi tekst");
            memento.RevertFromMemento();

            File.WriteAllText(path, "trzeci tekst(do zapamietania)");
            memento.SetNewData(path);
            File.WriteAllText(path, "czwarty tekst");
            memento.RevertFromMemento();

            Console.Read();
        }
    }
}
