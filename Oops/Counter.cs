using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    public class Counter
    {
        
            private Counter() { }
            public static int currentCount;
            public static int IncrementCount()
            {
                return ++currentCount;
            }
       

    }
}
