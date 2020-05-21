using System;

namespace DataStructures
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            HashingLinearProbe hlp = new HashingLinearProbe(10);
            HashingQuadraticProbe hqp = new HashingQuadraticProbe(10);
            DoubleHashing dh = new DoubleHashing(10);

            Console.WriteLine("Using Linear Probing");
            hlp.insert(11);
            hlp.insert(12);
            hlp.insert(13);
            hlp.insert(14);
            hlp.insert(15);
            hlp.print();
            hlp.insert(25);
            hlp.print();
            hlp.search(25);

            Console.WriteLine("Using Quadratic Probing");
            hqp.insert(11);
            hqp.insert(12);
            hqp.insert(13);
            hqp.insert(14);
            hqp.insert(15);
            hqp.print();
            hqp.insert(25);
            hqp.print();
            hqp.search(25);

            Console.WriteLine("Using Double Hashing");
            dh.insert(11);
            dh.insert(12);
            dh.insert(13);
            dh.insert(14);
            dh.insert(15);
            dh.print();
            dh.insert(25);
            dh.print();
            dh.search(25);
        }
    }
}
