using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_Czynnosciowe.OBSERVER
{
    class ConcreteObserver : Observer
    {
        private readonly string name;
        private string observerState;
        public ConcreteSubject Subject { get; set; }

        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            this.Subject = subject;
            this.name = name;
        }

        public override void Update()
        {
            observerState = Subject.SubjectState;
            Console.WriteLine($"Obserwator {name} ma nowy stan {observerState}");
        }
    }
}
