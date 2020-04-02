using System;
using System.Collections.Generic;
using System.Text;

namespace DadaStructure.LinkList
{
    public class LinkedList: IList
    {
        private Node root;

        public int Lenght { get; private set; }

        public int Maximum => throw new NotImplementedException();

        public int Minimum => throw new NotImplementedException();

        public int MinI => throw new NotImplementedException();

        public int MaxI => throw new NotImplementedException();

        public LinkedList()
        {
            root = null;
            Lenght = 0;
        }

        public LinkedList(int a)
        {
            root = new Node(a);
            Lenght = 1;
        }
       
        public void AddTheEnd(int a)
        {
            if (Lenght == 0)//(root==null)
            {
                root = new Node(a);
                Lenght = 1;
            }
            else if (Lenght == 1)//(root!=null&&root.Next==null)
            {
                root.Next = new Node(a);
                Lenght++;
            }
            else
            {
                Node tmp = root;
                while (tmp.Next != null)
                {
                    tmp = tmp.Next;
                }
                tmp.Next = new Node(a);
                Lenght++;
            }
        }
        public void AddTheEnd(int[] a)
        {
            for (int i = 0; i<a.Length; i++)
            {
                AddTheEnd(a[i]);
            }
        }
        public int[] ReturnArray()
        {
            int[] array = new int[Lenght];
            if (Lenght != 0)
            {
                int i = 0;
                Node tmp = root;
                do
                {
                    array[i] = tmp.Value;
                    i++;
                    tmp = tmp.Next;
                } while (tmp != null);
            }
            return array;
        }

        public void AddTheStart(int a)
        {
            Node tmp = new Node(a);
            tmp.Next = root;
            root = tmp;
            Lenght++;
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
            Node tmp = root;
            Node add = new Node(a);
            for (int i = 1; i<indx; i++)
            {
                tmp = tmp.Next;
            }
            add.Next = tmp.Next;
            tmp.Next = add;
            Lenght++;      
        }
       

        public void AddTheIndex(int indx,  int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = indx; j < a.Length; j++)
                AddTheIndex(j, a[i]);
            }
        }

        public void RemoveFromStart()
        {
            if (root == null)
            {
                throw new Exception("Hельзя удалить первый элемент из пустого списка");
            }
            else
            {
                Node tmp = root;
                root = tmp.Next;
                Lenght--;
            }
        }

        public void RemoveFromStart(int a)
        {
            for (int i = 1; i<=a; i++)
            {
                RemoveFromStart();
            }
        }

        public void RemoveFromEnd()
        {
            if (root == null)
            {
                throw new Exception("Нельзя удалить первый элемент из пустого списка");
            }
            Node tmp = root;
            while (tmp.Next.Next != null)
            {
                tmp = tmp.Next; 
            }
            tmp.Next = null;
            Lenght--;
        }

        public void RemoveFromEnd(int a)
        {
            for (int i = 0; i< a; i ++)
            {
                RemoveFromEnd();
            }
        }

        public void RemovebyIndex(int n)
        {
            Node tmp = root;
            for (int i = 1; i < n-1; i++)
            {
                tmp = tmp.Next;
            }
            tmp.Next = tmp.Next.Next;
            Lenght--;
        }

        public void RemovebyIndex(int n, int m)
        {
            for (int i = 0; i < m; i++)
            {
                RemovebyIndex(n);
            }   
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
