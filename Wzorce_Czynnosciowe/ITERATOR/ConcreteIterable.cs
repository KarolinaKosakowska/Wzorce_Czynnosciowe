using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_Czynnosciowe.ITERATOR
{
    class ConcreteIterable : IIterable
    {       
        private ArrayList items = new ArrayList();
        public IIterator GetIterator()
        {
            return new MyIterator(this);
        }
        public int Count
        {
            get { return items.Count; }
        }
        public object this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index, value); }
        }
    }
}
