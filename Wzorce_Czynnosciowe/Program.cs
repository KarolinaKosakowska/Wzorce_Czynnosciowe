using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wzorce_Czynnosciowe.Chain_of_responsibiity;
using Wzorce_Czynnosciowe.Interpreter;
using Wzorce_Czynnosciowe.ITERATOR;
using Wzorce_Czynnosciowe.MEMENTO;
using Wzorce_Czynnosciowe.OBSERVER;
using Wzorce_Czynnosciowe.STATE;
using Wzorce_Czynnosciowe.STRATEGY;

namespace Wzorce_Czynnosciowe
{
    class Program
    {
        //static Memento memento;
        //static string path = @"D:\text.txt";
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

            //// MEMENTO
            //File.WriteAllText(path,"pierwszy tekst");
            //if (path != ""&& File.Exists(path))
            //{
            //    memento = new Memento(path, File.ReadAllBytes(path));
            //}
            //File.WriteAllText(path, "drugi tekst");
            //memento.RevertFromMemento();

            //File.WriteAllText(path, "trzeci tekst(do zapamietania)");
            //memento.SetNewData(path);
            //File.WriteAllText(path, "czwarty tekst");
            //memento.RevertFromMemento();

            //STATE
            //var small = new SmallState();
            //Contextt context = new Contextt(small);
            //Console.Read();
            //context.Change();
            //Console.Read();
            //context.Change();
            //Console.Read();
            //context.Change();

            ////STRATEGY
            //bool onceAgain = true;
            //while (onceAgain)
            //{
            //    Console.WriteLine("Wybierz postać: A,B,C");
            //    Console.WriteLine();
            //    ConsoleKeyInfo figure = Console.ReadKey(true);
            //    IFigure ifigure = null;
            //    switch (figure.Key)
            //    {
            //        case ConsoleKey.A:
            //            ifigure = new Figure1();
            //            break;
            //        case ConsoleKey.B:
            //            ifigure = new Figure2();
            //            break;
            //        case ConsoleKey.C:
            //            ifigure = new Figure3();
            //            break;
            //    }
            //    Console.WriteLine($"Wybrałes postać: { figure.Key}");
            //    Console.WriteLine(ifigure.Kopnięcie()[0]);
            //    Console.WriteLine(ifigure.Uderzenie()[0]);
            //    Console.WriteLine();
            //    onceAgain = true;
            //}
            //ITERATOR
            //ConcreteIterable concreteIterable = new ConcreteIterable();
            //concreteIterable[0] = 1;
            //concreteIterable[1] = 2;
            //concreteIterable[2] = 3;
            //IIterator iterator = concreteIterable.GetIterator();
            //Console.WriteLine(iterator.First());
            //while(!iterator.IsEnd())
            //{
            //    Console.WriteLine(iterator.Next());                               
            //}

            // OBSERVATOR
            //ConcreteSubject concreteSubject = new ConcreteSubject();
            //concreteSubject.Attach(new ConcreteObserver(concreteSubject, "Pierwszy"));
            //concreteSubject.Attach(new ConcreteObserver(concreteSubject, "Drugi"));
            //var third = new ConcreteObserver(concreteSubject, "trzeci");
            //concreteSubject.Attach(third);
            //concreteSubject.SubjectState = "Super stan";
            //concreteSubject.Notify();
            //concreteSubject.Detach(third);
            //concreteSubject.Notify();

            //Chain
            Handler h1 = new ConcreteHandler1();
            Handler h2 = new ConcreteHandler2();
            Handler h3 = new ConcreteHandler3();
            h1.SetSuccessor(h2);
            h2.SetSuccessor(h3);

            int[] request = { 1, 2, 3, 10,11,22,25 };
            foreach (var item in request)
            {
                h3.HandleRequest(item);
            }


                  
            Console.Read();
        }
    }
}
