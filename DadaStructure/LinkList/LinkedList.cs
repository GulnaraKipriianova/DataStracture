using System;
using System.Collections.Generic;
using System.Text;

namespace DadaStructure.LinkList
{
    public class LinkedList: IList
    {
        private Node root;

        public int Length { get; private set; }
        public int this[int a] //Доступ по индексу, изм по индексу 
        {
            //get { return Node; }
            set
            {
                if (Length != 0)
                {
                    Node tmp = root;
                    for (int i = 0; i < a; i++)
                    {
                        tmp = tmp.Next;
                    }
                    tmp.Value = value;
                }
                else
                {
                    throw new Exception("Индекс выходит за границы списка");
                }
            }
        }
        public int Maximum
        {
            get
            {
                Node tmp = root;
                Node max = root;
                if (Length == 0)
                {
                    root = new Node(0);
                    Length = 1;
                    max.Value = 0;
                }
                else
                {
                    for (int i = 1; i < Length; i++)
                    {
                        tmp = tmp.Next;
                        if (tmp.Value > max.Value)
                        {
                            max = tmp;
                        }
                    }
                }
                return max.Value;
            }
        }
        public int Minimum
        {
            get
            {
                Node tmp = root;
                Node min = root;
                if (Length == 0)
                {
                    root = null;
                    Length = 0;
                    min.Value = 0;
                }
                else
                {
                    for (int i = 1; i < Length; i++)
                    {
                        tmp = tmp.Next;
                        if (tmp.Value < min.Value)
                        {
                            min = tmp;
                        }
                    }
                }
                return min.Value;
            }
        }

        public int MinI
        {
            get
            {
                Node number = root;
                Node tmp = root;
                Node min = root;
                if (Length == 0)
                {
                    root = new Node(0);
                    Length = 1;
                    number = null;
                }
                else
                {
                    for (int i = 1; i < Length; i++)
                    {
                        tmp = tmp.Next;
                        if (tmp.Value < min.Value)
                        {
                            min = tmp;
                            number.Value = i;
                        }
                    }
                }
                return number.Value;
            }
        }
        public int MaxI
        {
            get
            {
                Node number = root;
                Node tmp = root;
                Node max = root;
                if (Length == 0)
                {
                    root = new Node(0);
                    Length = 1;
                    number = null;
                }
                else
                {
                    for (int i = 1; i < Length; i++)
                    {
                        tmp = tmp.Next;
                        if (tmp.Value > max.Value)
                        {
                            max = tmp;
                            number.Value = i;
                        }
                    }
                }
                return number.Value;
            }
        }

        public LinkedList()
        {
            root = null;
            Length = 0;
        }

        public LinkedList(int a)
        {
            root = new Node(a);
            Length = 1;
        }
        public LinkedList(int[] a)
        {
            if (a.Length == null)
            {
                root = null;
                Length = 0;
            }
            for (int i = a.Length -1; i > 0; i--)
            {
                AddTheStart(a[i]);
            }
        }
        public void AddTheEnd(int a)
        {
            if (Length == 0)//(root==null)
            {
                root = new Node(a);
                Length = 1;
            }
            else if (Length == 1)//(root!=null&&root.Next==null)
            {
                root.Next = new Node(a);
                Length++;
            }
            else
            {
                Node tmp = root;
                while (tmp.Next != null)
                {
                    tmp = tmp.Next;
                }
                tmp.Next = new Node(a);
                Length++;
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
            int[] array = new int[Length];
            if (Length != 0)
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
            Length++;
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
            if (root == null)
            AddTheEnd(a);
            else
            {
                Node tmp = root;
                Node add = new Node(a);
                for (int i = 1; i < indx; i++)
                {
                    tmp = tmp.Next;
                }
                add.Next = tmp.Next;
                tmp.Next = add;
                Length++;
            } 
        }
        public void AddTheIndex(int indx,  int[] a)
        {
            //if (indx > Length || indx < 0)
            //{
            //    throw new Exception("Индекс выходит за границы списка");
            //}
            if (root == null)
                AddTheEnd(a);
            else
            {
                for (int i = 0; i < a.Length; i++)
                {
                    AddTheIndex(indx, a[i]);
                    indx++;
                }
            }
        }
        public void RemoveFromStart()
        {
            if (root == null)
            {
                //throw new Exception("Hельзя удалить первый элемент из пустого списка");
                root = new Node(0);
                Length = 1;
            }
            else
            {
                Node tmp = root;
                root = tmp.Next;
                Length--;
            }
        }
        public void RemoveFromStart(int a)
        {
            //if (a > Length || a < 0)
            //{
            //    throw new Exception("Ваше число не подходит");
            //}
            for (int i = 1; i<=a; i++)
            {
                RemoveFromStart();
            }
        }

        public void RemoveFromEnd()
        {
            if (root == null)
            {
                //throw new Exception("Hельзя удалить первый элемент из пустого списка");
                root = new Node(0);
                Length = 1;
            }
            else
            {
                Node tmp = root;
                while (tmp.Next.Next != null)
                {
                    tmp = tmp.Next;
                }
                tmp.Next = null;
                Length--;
            }
        }

        public void RemoveFromEnd(int a)
        {
            //if (a > Length || a < 0)
            //{
            //    throw new Exception("Ваше число не подходит");
            //}
            if (root == null)
            {
                //throw new Exception("Hельзя удалить первый элемент из пустого списка");
                root = new Node(0);
                Length = 1;
            }
            else
            for (int i = 0; i< a; i ++)
            {
                RemoveFromEnd();
            }
        }

        public void RemovebyIndex(int n)
        {
            //if (n > Length || n<0)
            //{
            //    throw new Exception("Индекс выходит за границы списка");
            //}
            if (root == null)
            {
                //throw new Exception("Hельзя удалить первый элемент из пустого списка");
                root = new Node(0);
                Length = 1;
            }
            else
            {
                Node tmp = root;
                for (int i = 0; i < n - 1; i++)
                {
                    tmp = tmp.Next;
                }
                tmp.Next = tmp.Next.Next;
                Length--;
            }
        }

        public void RemovebyIndex(int n, int m)
        {
            //if (a > Length || a < 0)
            //{
            //    throw new Exception("Ваше число не подходит");
            //}
            //if (n > Length || n<0)
            //{
            //    throw new Exception("Индекс выходит за границы списка");
            //}
            if (root == null)
            {
                //throw new Exception("Hельзя удалить первый элемент из пустого списка");
                root = new Node(0);
                Length = 1;
            }
            else
            {
                for (int i = 0; i < m; i++)
                {
                    RemovebyIndex(n);
                }
            }  
        }

        public void Revers()
        {
            if (root == null)
            {
                //throw new Exception("Hельзя удалить первый элемент из пустого списка");
                root = new Node(0);
                Length = 1;
            }
            else
            {
                Node tmpRoot = root;
                while(tmpRoot.Next != null)
                {
                    Node tmp = tmpRoot.Next;
                    tmpRoot.Next = tmpRoot.Next.Next;
                    tmp.Next = root;
                    root = tmp;
                }
            }
        }

        public void MaxMin()
        {
            throw new NotImplementedException();
        }

        public void MinMax()
        {
            Node tmp = root;
            Node min = root;
            for (int i= 1; i< Length;i++)
            {
                tmp = tmp.Next;
                if (tmp.Value<min.Value)
                {
                    min.Next = tmp.Next;
                    tmp.Next = min;
                    min = min.Next;
                }  
            }
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
