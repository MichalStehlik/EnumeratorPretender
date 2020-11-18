using System;
using System.Collections;

namespace EnumeratorPretender
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pole = { 0, 1, 2, 3, 4, 5, 6 };
            //--
            for (int i = 0; i < pole.Length; i++)
            {
                Console.WriteLine(pole[i]);
            }
            //--
            foreach(int n in pole)
            {
                Console.WriteLine(n);
            }
            //--
            IEnumerator pe = pole.GetEnumerator();

            pe.Reset();
            while (pe.MoveNext())
            {
                Console.WriteLine(pe.Current);
            }
            //--
            pe.Reset();
            pe.MoveNext();
            Console.WriteLine(pe.Current);
            pe.MoveNext();
            Console.WriteLine(pe.Current);
            pe.Reset();
            pe.MoveNext();
            Console.WriteLine(pe.Current);
            //--
            EnuPretender e = new EnuPretender();
            foreach (int n in e)
            {
                Console.WriteLine(n);
            }
            //--
            EnuPretender2 e2 = new EnuPretender2();
            foreach (int n in e2)
            {
                Console.WriteLine(n);
            }
        }
    }
}
