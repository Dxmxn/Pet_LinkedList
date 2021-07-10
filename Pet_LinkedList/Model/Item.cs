using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_LinkedList.Model
{
    class Item<T>
    {
        private T Data = default(T);
        private Item<T> next = null;

    }
}
