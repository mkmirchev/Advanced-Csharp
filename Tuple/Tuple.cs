using System;
using System.Collections.Generic;
using System.Text;

namespace Genereics
{
   public class Tuple<FItem, SItem>
    {
        public Tuple(FItem fElement, SItem sElement)
        {
            FElement = fElement;
            SElement = sElement;
        }
        public FItem FElement { get; private set; }
        public SItem SElement { get; private set; }

        public override string ToString()
        {
            return $"{FElement} -> {SElement}";
        }
    }
}
