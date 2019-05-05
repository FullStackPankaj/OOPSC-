using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    public class MyChildClass : BaseClass
    {
       public MyChildClass()
        {

        }

        public void setParentValues()
        {
            myPublic = 10;
            myProtected = 12;
            myInternal = 13;
            myProtectedInternal = 14;

        }
    }


    public class class3
    {

        public void setMydata3()
        {
            BaseClass b = new BaseClass();
            b.myInternal = 2;
            b.myProtectedInternal = 2;
            b.myPublic = 3;
        }
    }
}
