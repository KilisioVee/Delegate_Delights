using System;

delegate int NumberChanger2(int n);
namespace DelegateAppl
{
    class MulticastingDelegate
    {
        static int num = 10;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }
        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public static int getNum()
        {
            return num;
        }

    }
}