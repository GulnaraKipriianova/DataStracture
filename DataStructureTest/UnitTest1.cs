using NUnit.Framework;
using DadaStructure;

namespace DataStructureTest
{
    public class Tests
    {
        //ReturnLengthTest
        [TestCase(new int[] {5,2,4,6 }, ExpectedResult = 4)]
        public int ReturnLengthTest(int[] a)
        {
            ArrayList actual = new ArrayList(a);
            return actual.Length;
        }
        //AddTheEndTest
        [TestCase(new int[] { 3, 4, 6 }, 7, ExpectedResult = new int[] { 3, 4, 6, 7 })]
        [TestCase(new int[] { }, 7, ExpectedResult = new int[] { 7 })]
        public int[] AddTheEndTest(int[] array, int a)
        {
            ArrayList actual = new ArrayList(array);
            actual.AddTheEnd(a);
            return actual.ReturnArray();
        }

        [TestCase(new int[] { 3, 4, 6 }, new int[] { 2, 5, 3 }, ExpectedResult = new int[] { 3, 4, 6, 2, 5, 3 })]
        [TestCase(new int[] { }, new int[] { 2, 5, 3 }, ExpectedResult = new int[] { 2, 5, 3 })]
        public int[] AddTheEndTest(int[] array, int[] a)
        {
            ArrayList actual = new ArrayList(array);
            actual.AddTheEnd(a);
            return actual.ReturnArray();
        }


        //AddTheStartTest
        [TestCase(new int[] { 3, 4, 6 }, 7, ExpectedResult = new int[] { 7, 3, 4, 6 })]
        [TestCase(new int[] { }, 7, ExpectedResult = new int[] { 7 })]
        public int[] AddTheStartTest(int[] array, int a)
        {
            ArrayList actual = new ArrayList(array);
            actual.AddTheStart(a);
            return actual.ReturnArray();
        }
        [TestCase(new int[] { 3, 4, 6 }, new int[] { 2, 5 }, ExpectedResult = new int[] { 2, 5, 3, 4, 6 })]
        [TestCase(new int[] {  }, new int[] { 2, 5, 7, 9 }, ExpectedResult = new int[] { 2, 5, 7, 9 })]
        public int[] AddTheStartTest(int[] array, int[] a)
        {
            ArrayList actual = new ArrayList(array);
            actual.AddTheStart(a);
            return actual.ReturnArray();
        }

        //AddTheIndexTest
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, 0, ExpectedResult = new int[] { 1, 2, 0, 3, 4, 5 })]
        [TestCase(new int[] { }, 2, 0, ExpectedResult = new int[] {0})]
        public int[] AddTheIndexTest(int[] array, int i, int n)
        {
            ArrayList actual = new ArrayList(array);
            actual.AddTheIndex(i, n);
            return actual.ReturnArray();
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, new int[] { 0, 0, 0, 0 }, ExpectedResult = new int[] { 1, 2, 0, 0, 0, 0, 3, 4, 5 })]
        [TestCase(new int[] { }, 2, new int[] { 0, 0, 0, 0 }, ExpectedResult = new int[] { 0, 0, 0, 0 } )]
        public int[] AddTheIndexTest(int[] array, int i, int[] n)
        {
            ArrayList actual = new ArrayList(array);
            actual.AddTheIndex(i, n);
            return actual.ReturnArray();
        }

        //SetIndexTest
        [TestCase(new int[] { 1, 2, 3 }, 1, 9, ExpectedResult = new int[] { 1, 9, 3 })]
        [TestCase(new int[] {  }, 1, 9, ExpectedResult = new int[] {9})]
        public int[] SetIndexTest(int[] array, int i, int a)
        {
            ArrayList actual = new ArrayList(array);
            actual[i] = a;
            return actual.ReturnArray();
        }

        //RemoveFromStartTest
        [TestCase(new int[] { 3, 4, 6, 7 }, ExpectedResult = new int[] { 4, 6, 7 })]
        [TestCase(new int[] { }, ExpectedResult = new int[] { 0 })]
        public int[] RemoveFromStartTest(int[] array)
        {
            ArrayList actual = new ArrayList(array);
            actual.RemoveFromStart();
            return actual.ReturnArray();
        }
        [TestCase(new int[] { 3, 4, 6, 7, 4, 2, 1 }, 3,  ExpectedResult = new int[] { 7, 4, 2, 1 })]
        [TestCase(new int[] { }, 3, ExpectedResult = new int[] { 0 })]
        public int[] RemoveFromStartTest(int[] array, int a)
        {
            ArrayList actual = new ArrayList(array);
            actual.RemoveFromStart(a);
            return actual.ReturnArray();
        }

        //RemoveFromEndTest
        [TestCase(new int[] { 3, 4, 6, 7 }, ExpectedResult = new int[] { 3, 4, 6, })]
        public int[] RemoveFromEndTest(int[] array)
        {
            ArrayList actual = new ArrayList(array);
            actual.RemoveFromEnd();
            return actual.ReturnArray();
        }
        [TestCase(new int[] { 3, 4, 6, 7, 3, 2 },3, ExpectedResult = new int[] { 3, 4, 6, })]
        public int[] RemoveFromEndTest(int[] array, int a)
        {
            ArrayList actual = new ArrayList(array);
            actual.RemoveFromEnd(a);
            return actual.ReturnArray();
        }

        //RemovebyIndexTest
        [TestCase(new int[] { 3, 4, 6, 7, 9, 11 }, 3, ExpectedResult = new int[] { 3, 4, 6, 9, 11 })]
        public int[] RemovebyIndexTest(int[] array, int a)
        {
            ArrayList actual = new ArrayList(array);
            actual.RemovebyIndex(a);
            return actual.ReturnArray();
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 2, 4, ExpectedResult = new int[] { 1, 2, 7, 8 })]
        public int[] RemovebyIndexTest(int[] array, int a, int b)
        {
            ArrayList actual = new ArrayList(array);
            actual.RemovebyIndex(a, b);
            return actual.ReturnArray();
        }

        //ReversTest
        [TestCase(new int[] { 3, 4, 6, 7 }, ExpectedResult = new int[] { 7, 6, 4, 3 })]
        public int[] ReversTest(int[] a)
        {
            ArrayList actual = new ArrayList(a);
            actual.Revers();
            return actual.ReturnArray();
        }

        //AccessbyIindexTest
        [TestCase(new int[] { 3, 4, 6, 7 }, 2, ExpectedResult = 6)]
        public int AccessbyIindexTest(int[] a, int b)
        {
            ArrayList actual = new ArrayList(a);
            return actual[b];
        }

        //ChangingtheValuebyIndexTest
        [TestCase(new int[] { 3, 4, 6, 7 }, 2, 0, ExpectedResult = new int[] { 3, 4, 0, 7 })]
        public int [] ChangingtheValuebyIndexTest(int[] a, int b, int val)
        {
            ArrayList actual = new ArrayList(a);
            actual[b] = val;
            return actual.ReturnArray();

        }

        //MaximalTest
        [TestCase(new int[] { 1, 2, 3 }, ExpectedResult = 3)]
        [TestCase(new int[] { }, ExpectedResult = 0)]
        public int MaximalTest(int[] a)
        {
            ArrayList actual = new ArrayList(a);
            return actual.Maximum;
        }

        //MinimumTest
        [TestCase(new int[] { 1, 2, 3 }, ExpectedResult = 1)]
        [TestCase(new int[] { }, ExpectedResult = 0)]
        public int MinimumTest(int[] a)
        {
            ArrayList actual = new ArrayList(a);
            return actual.Minimum;
        }

        //MaxITest
        [TestCase(new int[] { 1, 2, 3 }, ExpectedResult = 2)]
        [TestCase(new int[] { }, ExpectedResult = 0)]
        public int MaxITest(int[] a)
        {
            ArrayList actual = new ArrayList(a);
            return actual.MaxI;
        }

        //MinITest
        [TestCase(new int[] { 1, 2, 3 }, ExpectedResult = 0)]
        [TestCase(new int[] { }, ExpectedResult = 0)]
        public int MinITest(int[] a)
        {
            ArrayList actual = new ArrayList(a);
            return actual.MinI;
        }

        //MaxMinSelectTest
        [TestCase(new int[] { 3, 8, 6, 7 }, ExpectedResult = new int[] { 8, 7, 6, 3 })]
        public int[] MaxMinSelectTest(int[] a)
        {
            ArrayList actual = new ArrayList(a);
            actual.MaxMinSelect();
            return actual.ReturnArray();
        }

        //MinMaxBubbleTest
        [TestCase(new int[] { 3, 8, 6, 7 }, ExpectedResult = new int[] { 3, 6, 7, 8 })]
        public int[] MinMaxBubbleTest(int[] a)
        {
            ArrayList actual = new ArrayList(a);
            actual.MinMaxBubble();
            return actual.ReturnArray();
        }

        //IndexbyValueTest
        [TestCase(new int[] { 3, 8, 6, 7 }, 6, ExpectedResult = new int[] {2})]
        public int[] IndexbyValueTest(int[] a, int b)
        {
            ArrayList actual = new ArrayList(a);
            actual.IndexbyValue(b);
            return actual.ReturnArray();
        }

        // DeletbyValueTest
        [TestCase(new int[] { 2,4,0,5,7,0,6 }, 0, ExpectedResult = new int[] { 2, 4, 5, 7,6 })]
        public int[] DeletbyValueTest(int[] a, int b)
        {
            ArrayList actual = new ArrayList(a);
            actual.DeletbyValue(b);
            return actual.ReturnArray();
        }

    }
}