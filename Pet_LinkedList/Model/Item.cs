using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_LinkedList.Model
{
    /// <summary>
    /// Ячейка списка
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Item<T>
    {
        private T data = default(T);
        /// <summary>
        /// Данные хранимые в ячейке списка
        /// </summary>
        public T Data 
        {
            get { return data; }
            set 
            {
                if (value != null)
                    data = value;
                else
                    throw new ArgumentNullException(nameof(value));
            }
        }
        /// <summary>
        /// Следующая ячейка списка
        /// </summary>
        public Item<T> Next { get; set; }
        public Item(T Data)
        {
            data = Data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }

    }
}
