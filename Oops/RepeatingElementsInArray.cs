using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    public class RepeatingElementsInArray
    {
        public void findrepeatinElementsArray()
        {
            int[] arr = { 4, 2, 4, 5, 2, 3, 1 };

            Dictionary<int, int> myDic = new Dictionary<int, int>();

            foreach(var item in arr)
            {
                if (myDic.ContainsKey(item))
                {
                    myDic[item]++;
                }else
                {
                    myDic[item] = 1;
                }

            }
        }
    }
}
