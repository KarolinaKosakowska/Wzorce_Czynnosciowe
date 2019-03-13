using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_Czynnosciowe.Chain_of_responsibiity
{
    class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 0 && request < 10)
            {
                Console.WriteLine($"{this.GetType().Name} Obsłużony request {request}");
            }
            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }

}