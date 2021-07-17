using System;

namespace Pet_LinkedList.Model
{
    class DoublyConnectedItem<T>
    {
        public T Data { get; set; }
        public DoublyConnectedItem<T> Previous { get; set; }
        public DoublyConnectedItem<T> Next { get; set; }
        public DoublyConnectedItem(T data)
        {
            Data = data;
        }
        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
