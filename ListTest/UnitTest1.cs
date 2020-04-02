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

        [TestCase (new int[] {1, 1, 1, 1}, 0, ExpectedResult =new int[] {1, 1, 1, 1, 0})]
        public int[] AddTest(int[] array, int a)
        {
            actual.AddTheEnd(array);
            actual.AddTheEnd(a);
            return actual.ReturnArray();
        }


        //public void AddMass(int[] array)
        //{
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        actual.AddTheEnd(array[i]);
        //    }
        //}
    }
}