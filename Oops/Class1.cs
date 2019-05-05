using Oops;


namespace ClassLibrary1
{
    public class Class1
    {
        BaseClass baseClass = new BaseClass();

        public void setData()
        {
            baseClass.myPublic = 10;
        }

    }


    public class class2 : BaseClass
    {
        public void setMydata()
        {
            myPublic = 10;
            myProtected = 12;
            myProtectedInternal = 12;


        }
    }


   
}
