using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_Czynnosciowe.ITERATOR
{
    class MyIterator : IIterator
    {
        ConcreteIterable iterable;
        int current = 0;
        public MyIterator(ConcreteIterable iterable)
        {
            this.iterable = iterable;
        }
        public object Current()
        {
            return iterable[current];
        }

        public object First()
        {
            return iterable[0];
        }

        public bool IsEnd()
        {
            return current < iterable.Count-1;
        }

        public object Next()
        {
            if (current < iterable.Count - 1)
                return iterable[++current];
            return null;
        }
    }
}
