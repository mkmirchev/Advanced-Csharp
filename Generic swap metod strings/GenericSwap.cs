using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class GenericSwap<T1,T2,T3>
    {
        public GenericSwap(T1 elementOne, T2 elementTwo, T3 elementThree)
        {
            ElementOne = elementOne;
            ElementTwo = elementTwo;
            ElementThree = elementThree;
        }
        public T1 ElementOne { get; set; }
        public T2 ElementTwo { get; set; }
        public T3 ElementThree { get; set; }
    }
}
