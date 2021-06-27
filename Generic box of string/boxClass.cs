using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Box<T>
    {
        public Box(T element)
        {
            Element = element;
        }
        public Box(List<T> listElements)
        {
            Elements = listElements;
        }
        public List<T> Elements { get; }
        public T Element { get; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (T item in Elements)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }
            return sb.ToString().TrimEnd();
        }
        public void Swap(List<T> lst, int indexOne, int indexTwo)
        {
            T fElement = lst[indexOne];
            lst[indexOne] = lst[indexTwo];
            lst[indexTwo] = fElement;
        }

    }
}
