using System;
using System.Collections.Generic;

namespace Stack
{
    public class Stack
    {
        private List<object> NewStack { get; set; }

        public Stack()
        {
            this.NewStack = new List<object>();
        }

        public void Push(object obj)
        {
            if (obj != null)
            {
                NewStack.Add(obj);
            }
            else
            {
                throw new InvalidOperationException("Passed null");
            }
        }

        public object Pop()
        {
            var l = NewStack.Count;
            if (l > 0)
            {
                var index = l - 1;
                var toReturn = NewStack[index];
                NewStack.RemoveAt(index);
                return toReturn;
            }
            else
            {
                return new InvalidOperationException("Empty stack");
            }
        }

        public void Clear()
        {
            NewStack.Clear();
            Console.WriteLine("Stack is now empty");
        }
    }
}