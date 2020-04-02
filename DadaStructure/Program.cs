using System;
using DadaStructure.LinkList;

namespace DadaStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList L = new LinkedList();
            int[] a = new int[] { 8,8,8 };
            //L.AddTheEnd(1);
            //L.AddTheEnd(2);
            //L.AddTheEnd(3);
            //L.AddTheEnd(4);
            //L.AddTheEnd(5);
            //L.AddTheEnd(6);
            //L.AddTheEnd(7);
            //L.AddTheEnd(8);
            //L.AddTheEnd(9);
            //L.AddTheEnd(10);
            int [] array = new int[] { 1, 2, 3, 4 ,5 };
           // L.AddMass(array);
            qqq(L.ReturnArray());
            // L.AddTheIndex(2, 0);
            //L.RemoveFromStart(3);
            // L.AddTheEnd(a);
            // L.AddTheIndex(2, a);
            //L.AddTheStart(a);
            //L.RemoveFromEnd(3);
            //L.RemovebyIndex(4, 3);
            //qqq(L.ReturnArray());

        }

        static void qqq(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
