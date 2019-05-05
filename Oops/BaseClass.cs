using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
   public class BaseClass
    {
        public int myPublic;
        private int myPrivate;
        protected int myProtected;
        internal int myInternal;
        protected internal int myProtectedInternal;

       public BaseClass()
        {
            myPublic = 10;
            myPrivate = 12;
            myProtected = 13;
            myProtectedInternal = 14;
            myInternal = 15;
        }

        public void setMyvalues()
        {
            myPrivate = 20;
            myPublic = 21;
            myProtected = 22;
            myInternal = 23;
            myProtectedInternal = 24;
        }
    }
}
