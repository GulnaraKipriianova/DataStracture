using System;
using System.Collections.Generic;
using System.Text;

namespace DadaStructure.BiDerList
{
    public class L2List : IList
    {
        private L2Node root;
        private L2Node end;
        public int Lenght { get; private set; }

        public int Maximum => throw new NotImplementedException();

        public int Minimum => throw new NotImplementedException();

        public int MinI => throw new NotImplementedException();

        public int MaxI => throw new NotImplementedException();

        public L2List()
        {
            root = null;
            end = null;
            Lenght = 0;
        }

        public L2List(int a)
        {
            root = new L2Node(a);
            end = root;
            Lenght = 1;
        }
        public int[] ReturnArray()
        {
            int[] array = new int[Lenght];
            if (Lenght != 0)
            {
                int i = 0;
                L2Node tmp = root;
                do
                {
                    array[i] = tmp.Value;
                    i++;
                    tmp = tmp.Next;
                } while (tmp != null);
            }
            return array;
        }

        public void AddTheEnd(int a)
        {
            if (Lenght == 0)
            {
                root = new L2Node(a);
                end = root;
                Lenght = 1;
            }
            else
            {
                end.Next = new L2Node(a);
                end.Next.Previous = end;
                end = end.Next;
                Lenght++;
            }
        }
        public void AddTheEnd(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                AddTheEnd(a[i]);
            }
        }
        public void AddTheStart(int a)
        {
            if (Lenght == 0)
            {
                root = new L2Node(a);
                end = root;
                Lenght = 1;
            }
            else
            {
                root.Previous = new L2Node(a);
                root.Previous.Next = root;
                root = root.Previous;
                Lenght++;
            }
        }
        public void AddTheStart(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                AddTheStart(a[i]);
            }
        }

        public void AddTheIndex(int indx, int a)
        {
            throw new NotImplementedException();
        }

        public void AddTheIndex(int indx, int[] a)
        {
            throw new NotImplementedException();
        }

        public void RemoveFromStart()
        {
            throw new NotImplementedException();
        }

        public void RemoveFromStart(int a)
        {
            throw new NotImplementedException();
        }

        public void RemoveFromEnd()
        {
            throw new NotImplementedException();
        }

        public void RemoveFromEnd(int a)
        {
            throw new NotImplementedException();
        }

        public void RemovebyIndex(int n)
        {
            throw new NotImplementedException();
        }

        public void RemovebyIndex(int n, int m)
        {
            throw new NotImplementedException();
        }

        public void Revers()
        {
            throw new NotImplementedException();
        }

        public void MaxMinSelect()
        {
            throw new NotImplementedException();
        }

        public void MinMaxBubble()
        {
            throw new NotImplementedException();
        }

        public void IndexbyValue(int val)
        {
            throw new NotImplementedException();
        }

        public void DeletbyValue(int val)
        {
            throw new NotImplementedException();
        }
    }
}

