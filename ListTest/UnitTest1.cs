using NUnit.Framework;
using DadaStructure;
using DadaStructure.LinkList;
using DadaStructure.ArrayList;
using DadaStructure.BiDerList;


namespace ListTests
{
    [TestFixture("array")]
    [TestFixture("List")]
    [TestFixture("BinList")]
    public class ListTest
    {
        IList actual;
        string q;

        public ListTest(string _q)
        {
            q = _q;
        }

        [SetUp]
        public void ListSelect()
        {
            switch (q)
            {
                case "array":
                    actual = new ArrayList();
                    break;
                case "List":
                    actual = new LinkedList();
                    break;
                case "BinList":
                    actual = new L2List();
                    break;
            }
        }
        //AddTheEndTest
        [TestCase(new int[] { 1, 1, 1, 1 }, 0, ExpectedResult = new int[] { 1, 1, 1, 1, 0 })]
        [TestCase(new int[] { 1 }, 0, ExpectedResult = new int[] { 1, 0 })]
        [TestCase(new int[] { }, 1, ExpectedResult = new int[] { 1 })]
        public int[] AddTheEndTest(int[] array, int a)
        {
            actual.AddTheEnd(array);
            actual.AddTheEnd(a);
            return actual.ReturnArray();
        }

        //AddTheStartTest
        [TestCase(new int[] { 1, 1, 1, 1 }, 0, ExpectedResult = new int[] { 0, 1, 1, 1, 1 })]
        [TestCase(new int[] { 1 }, 0, ExpectedResult = new int[] { 0, 1 })]
        [TestCase(new int[] { }, 1, ExpectedResult = new int[] { 1 })]
        public int[] AddTheStartTest(int[] array, int a)
        {
            actual.AddTheStart(array);
            actual.AddTheStart(a);
            return actual.ReturnArray();
        }
        //AddTheIndexTest
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, 0, ExpectedResult = new int[] { 1, 2, 0, 3, 4, 5 })]
        [TestCase(new int[] { 3 }, 2, 0, ExpectedResult = new int[] { 0 })]
        [TestCase(new int[] { }, 2, 2, ExpectedResult = new int[] { 0 })]
        public int[] AddTheIndexTest(int[] array, int i, int n)
        {
            actual.AddTheEnd(array);
            actual.AddTheIndex(i, n);
            return actual.ReturnArray();
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, new int[] { 0, 0, 0, 0 }, ExpectedResult = new int[] { 1, 2, 0, 0, 0, 0, 3, 4, 5 })]
        [TestCase(new int[] { }, 2, new int[] { 0, 0, 0, 0 }, ExpectedResult = new int[] { 0, 0, 0, 0 })]
        public int[] AddTheIndexTest(int[] array, int i, int[] n)
        {
            actual.AddTheEnd(array);
            actual.AddTheIndex(i, n);
            return actual.ReturnArray();
        }

        //RemoveFromStartTest
        [TestCase(new int[] { 3, 4, 6, 7 }, ExpectedResult = new int[] { 4, 6, 7 })]
        [TestCase(new int[] { 3 }, ExpectedResult = new int[] { 0 })]
        [TestCase(new int[] { }, ExpectedResult = new int[] { 0 })]
        public int[] RemoveFromStartTest(int[] array)
        {
            actual.AddTheEnd(array);
            actual.RemoveFromStart();
            return actual.ReturnArray();
        }
        [TestCase(new int[] { 3, 4, 6, 7, 4, 2, 1 }, 3, ExpectedResult = new int[] { 7, 4, 2, 1 })]
        [TestCase(new int[] { 3 }, 3, ExpectedResult = new int[] { 0 })]
        [TestCase(new int[] { }, 3, ExpectedResult = new int[] { 0 })]
        public int[] RemoveFromStartTest(int[] array, int a)
        {
            actual.AddTheEnd(array);
            actual.RemoveFromStart(a);
            return actual.ReturnArray();
        }

        //ReturmLengthTest
        [TestCase(new int[] { 3, 4, 6, 7 }, ExpectedResult = 4)]
        [TestCase(new int[] { 3 }, ExpectedResult = 1)]
        [TestCase(new int[] { 3, 4, 6, 7, 5, 6 }, ExpectedResult = 6)]
        public int ReturmLengthTest(int[] array)
        {
            actual.AddTheEnd(array);
            return actual.Length;
        }

        //RemoveFromEndTest
        [TestCase(new int[] { 3, 4, 6, 7 }, ExpectedResult = new int[] { 3, 4, 6, })]
        [TestCase(new int[] { 3 }, ExpectedResult = new int[] { 0 })]
        [TestCase(new int[] { }, ExpectedResult = new int[] { 0 })]
        public int[] RemoveFromEndTest(int[] array)
        {
            actual.AddTheEnd(array);
            actual.RemoveFromEnd();
            return actual.ReturnArray();
        }
        [TestCase(new int[] { 3, 4, 6, 7, 3, 2 }, 3, ExpectedResult = new int[] { 3, 4, 6, })]
        [TestCase(new int[] { 3 }, 3, ExpectedResult = new int[] { 0 })]
        [TestCase(new int[] { }, 3, ExpectedResult = new int[] { 0 })]
        public int[] RemoveFromEndTest(int[] array, int a)
        {
            actual.AddTheEnd(array);
            actual.RemoveFromEnd(a);
            return actual.ReturnArray();
        }

        //RemovebyIndexTest
        [TestCase(new int[] { 3, 4, 6, 7, 9, 11 }, 3, ExpectedResult = new int[] { 3, 4, 6, 9, 11 })]
        [TestCase(new int[] { 3 }, 3, ExpectedResult = new int[] { 0 })]
        [TestCase(new int[] { }, 3, ExpectedResult = new int[] { 0 })]
        public int[] RemovebyIndexTest(int[] array, int a)
        {
            actual.AddTheEnd(array);
            actual.RemovebyIndex(a);
            return actual.ReturnArray();
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 2, 4, ExpectedResult = new int[] { 1, 2, 7, 8 })]
        [TestCase(new int[] { 3 }, 3, 4, ExpectedResult = new int[] { 0 })]
        [TestCase(new int[] { }, 3, 4, ExpectedResult = new int[] { 0 })]
        public int[] RemovebyIndexTest(int[] array, int a, int b)
        {
            actual.AddTheEnd(array);
            actual.RemovebyIndex(a, b);
            return actual.ReturnArray();
        }

        //SetIndexTest
        [TestCase(new int[] { 1, 2, 3 }, 1, 9, ExpectedResult = new int[] { 1, 9, 3 })]
       // [TestCase(new int[] { }, 1, 9, ExpectedResult = new int[] { 9 })] выдаст плановую ошибку
        public int[] SetIndexTest(int[] array, int i, int a)
        {
            actual.AddTheEnd(array);
            actual[i] = a;
            return actual.ReturnArray();
        }

        //ReversTest
        [TestCase(new int[] { 3, 4, 6, 7 }, ExpectedResult = new int[] { 7, 6, 4, 3 })]
        public int[] ReversTest(int[] array)
        {
            actual.AddTheEnd(array);
            actual.Revers();
            return actual.ReturnArray();
        }

        //AccessbyIndexTest
        [TestCase(new int[] { 3, 4, 6, 7 }, 2, ExpectedResult = 6)]
        [TestCase(new int[] { 3 }, 0, ExpectedResult = 3)]
        [TestCase(new int[] { 3, 4, 6, 7, 5, 6 }, 4, ExpectedResult = 5)]
        public int AccessbyIndexTest(int[] array, int b)
        {
            actual.AddTheEnd(array);
            return actual[b];
        }

        //ChangingtheValuebyIndexTest
        [TestCase(new int[] { 3, 4, 6, 7 }, 2, 0, ExpectedResult = new int[] { 3, 4, 0, 7 })]
        public int[] ChangingtheValuebyIndexTest(int[] array, int b, int val)
        {
            actual.AddTheEnd(array);
            actual[b] = val;
            return actual.ReturnArray();
        }

        //MaximalTest
        [TestCase(new int[] { 1, 2, 3 }, ExpectedResult = 3)]
        //[TestCase(new int[] { }, ExpectedResult = 0)]
        public int MaximalTest(int[] array)
        {
            actual.AddTheEnd(array);
            return actual.Maximum;
        }

        //MinimumTest
        [TestCase(new int[] { 1, 2, 3 }, ExpectedResult = 1)]
        [TestCase(new int[] { }, ExpectedResult = 0)]
        public int MinimumTest(int[] array)
        {
            actual.AddTheEnd(array);
            return actual.Minimum;
        }

        //MaxITest
        [TestCase(new int[] { 1, 2, 3 }, ExpectedResult = 2)]
        [TestCase(new int[] { 3, 5, 1, 2, 3 }, ExpectedResult = 1)]
        [TestCase(new int[] { 5, 1, 2, 3 }, ExpectedResult = 0)]
        [TestCase(new int[] { }, ExpectedResult = 0)]
        public int MaxITest(int[] array)
        {
            actual.AddTheEnd(array);
            return actual.MaxI;
        }

        //MinITest
        [TestCase(new int[] { 1, 2, 3 }, ExpectedResult = 0)]
        [TestCase(new int[] { 3, 5, 1, 2, 3 }, ExpectedResult = 2)]
        [TestCase(new int[] { }, ExpectedResult = 0)]
        public int MinITest(int[] array)
        {
            actual.AddTheEnd(array);
            return actual.MinI;
        }

        ////MaxMinTest
        //[TestCase(new int[] { 3, 8, 6, 7 }, ExpectedResult = new int[] { 8, 7, 6, 3 })]
        //public int[] MaxMinSelectTest(int[] array)
        //{
        //    actual.AddTheEnd(array);
        //    actual.MaxMin();
        //    return actual.ReturnArray();
        //}

        ////MinMaxBubbleTest
        //[TestCase(new int[] { 3, 8, 6, 7 }, ExpectedResult = new int[] { 3, 6, 7, 8 })]
        //public int[] MinMaxTest(int[] array)
        //{
        //    actual.AddTheEnd(array);
        //    actual.MinMax();
        //    return actual.ReturnArray();
        //}

        //IndexbyValueTest
        [TestCase(new int[] { 3, 8, 6, 7 }, 6, ExpectedResult = new int[] { 2 })]
        public int[] IndexbyValueTest(int[] array, int b)
        {
            actual.AddTheEnd(array);
            actual.IndexbyValue(b);
            return actual.ReturnArray();
        }

        // DeletbyValueTest
        [TestCase(new int[] { 2, 4, 0, 5, 7, 0, 6, 5 }, 0, ExpectedResult = new int[] { 2, 4, 5, 7, 6, 5 })]
        public int[] DeletbyValueTest(int[] array, int b)
        {
            actual.AddTheEnd(array);
            actual.DeletbyValue(b);
            return actual.ReturnArray();
        }


    }
}