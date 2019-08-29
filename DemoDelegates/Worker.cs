using System;

namespace DemoDelegates
{
    class Worker
    {
        private delegate int MyMethodRefType(int x, int y);

        private MyMethodRefType mref;

        private Func<int, int, int> nymref;

        public void Start()
        {
            mref = Add;

            Console.WriteLine("5 + 7 = " + mref(5, 7));

            mref = Mul;

            Console.WriteLine("5 * 7 = " + mref(5, 7));

            mref += Add;

            Console.WriteLine("5 ? 7 = " + mref(5, 7));

            mref += (i, j) => // Lambda expression
            {
                Console.WriteLine("SUB");
                return i - j;
            };

            Console.WriteLine("5 ? 7 = " + mref(5, 7));
        }

        private int Add(int i, int j)
        {
            Console.WriteLine("ADD");
            return i + j;
        }

        private int Mul(int i, int j)
        {
            Console.WriteLine("MUL");
            return i * j;
        }
    }
}