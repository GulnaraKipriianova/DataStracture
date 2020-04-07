using DadaStructure.LinkList;
using System;
using System.Collections.Generic;
using System.Text;

namespace DadaStructure.BiDerList
{
    public class L2List : IList
    {
        private L2Node root;
        private L2Node end;
        public int Length { get; private set; }
        public int this[int a]
        {
            get
            {
                if (a > Length || a < 0)
                {
                    throw new Exception("Индекс выходит за границы списка");
                }
                else
                {
                    L2Node tmp;
                    if (Length/2 > a)
                    {
                        tmp = root;
                        for (int i = 0; i < a; i++)
                        {
                            tmp = tmp.Next;
                        }
                    }
                    else
                    {
                        tmp = end;
                        for (int i = Length-1; i > a; i--)
                        {
                            ;
                            tmp = tmp.Previous;
                        }
                    } 
                    return tmp.Value;
                }
            }
            set
            {
                if (a > Length || a < 0)
                {
                    throw new Exception("Индекс выходит за границы списка");
                }
                else
                {
                    L2Node tmp = root;
                    if (Length / 2 > a)
                    {
                        for (int i = 0; i < a; i++)
                        {
                            tmp = tmp.Next;
                        }
                    }
                    else
                    {
                        for (int i = Length; i > a; i--)
                        {
                            tmp = end;
                            tmp = tmp.Previous;
                        }
                    }
                    tmp.Value = value;
                }
                
            }
        }

        public int Maximum 
        {
            get
            {
                L2Node tmp = root;
                L2Node max = root;
                if (Length == 0)
                {
                    //throw new Exception("Hельзя найти максимальный эелемент в пустом списке");
                    root = new L2Node(0);
                    Length = 1;
                    max = root;
                }
                else 
                {
                    while (tmp.Next != null)
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
                L2Node tmp = root;
                L2Node min = root;
                if (Length == 0)
                {
                    //throw new Exception("Hельзя найти минимальный эелемент в пустом списке");
                    root = new L2Node(0);
                    Length = 1;
                    min = root;
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
                L2Node number = new L2Node(0);
                L2Node tmp = root;
                L2Node min = root;
                if (Length == 0)
                {
                    //throw new Exception("Hельзя найти интедкс минимального эелемента в пустом списке");
                    root = new L2Node(0);
                    Length = 1;
                    number = root;
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
                L2Node number = new L2Node(0);
                L2Node tmp = root;
                L2Node max = root;
                if (Length == 0)
                {
                    //throw new Exception("Hельзя найти интедкс минимального эелемента в пустом списке");
                    root = new L2Node(0);
                    Length = 1;
                    number = root;
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
        public L2List()
        {
            root = null;
            end = null;
            Length = 0;
        }

        public L2List(int a)
        {
            root = new L2Node(a);
            end = root;
            Length = 1;
        }
        public L2List(int[] a)
        {
            if (a.Length == null)
            {
                root = null;
                end = null;
                Length = 0;
            }
            else
            {
                AddTheEnd(a);
            }
        }
        public int[] ReturnArray()
        {
            int[] array = new int[Length];
            if (Length != 0)
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
            if (Length == 0)
            {
                root = new L2Node(a);
                end = root;
                Length = 1;
            }
            else
            {
                end.Next = new L2Node(a);
                end.Next.Previous = end;
                end = end.Next;
                Length++;
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
            if (Length == 0)
            {
                root = new L2Node(a);
                end = root;
                Length = 1;
            }
            else
            {
                root.Previous = new L2Node(a);
                root.Previous.Next = root;
                root = root.Previous;
                Length++;
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
            if (root == null)
            {
                root = new L2Node(a);
                end = root;
                Length = 1;
            }
            if (Length == 1)
            {
                root = new L2Node(0);
                end = root;
                Length = 1;
            }
            else
            {
                if (Length / 2 > indx)
                {
                    L2Node tmp = root;
                    L2Node add = new L2Node(a);
                    for (int i = 1; i < indx; i++)
                    {
                        tmp = tmp.Next;
                    }
                    add.Next = tmp.Next;
                    tmp.Next.Previous = add;
                    tmp.Next = add;
                    add.Previous = tmp;
                    Length++;
                }
                else
                { 
                    L2Node tmp = end;
                    L2Node add = new L2Node(a);
                    for (int i = Length-1; i > indx; i--)
                    {
                        tmp = tmp.Previous;
                    }
                    add.Previous = tmp.Previous;
                    tmp.Previous.Next = add; 
                    tmp.Previous = add;
                    add.Next = tmp;
                    Length++;
                }
            }
        }
        public void AddTheIndex(int indx, int[] a)
        {
            //if (indx > Length)
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
                root = new L2Node (0);
                end = root;
                Length = 1;
            }
            if (root == end)
            {
                root = new L2Node(0);
                end = root;
                Length = 1;
            }
            else
            {
                L2Node tmp = root;
                root = tmp.Next;
                Length--;
            }
        }

        public void RemoveFromStart(int a)
        {
            for (int i = 1; i <= a; i++)
            {
                RemoveFromStart();
            }
        }

        public void RemoveFromEnd()
        {
            if (root == null)
            {
                //throw new Exception("Hельзя удалить первый элемент из пустого списка");
                root = new L2Node(0);
                end = root;
                Length = 1;
            }
            if (root == end)
            {
                root = new L2Node(0);
                end = root;
                Length = 1;
            }
            else
            {
                end = end.Previous;
                end.Next = null;
                Length--;
            }
        }
        public void RemoveFromEnd(int a)
        {
            if (root == null)
            {
                //throw new Exception("Hельзя удалить первый элемент из пустого списка");
                root = new L2Node(0);
                end = root;
                Length = 1;
            }
            else
            {
                for (int i = 0; i < a; i++)
                {
                    RemoveFromEnd();
                }
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
                root = new L2Node(0);
                end = root;
                Length = 1;
            }
            if (root == end)
            {
                root = new L2Node(0);
                end = root;
                Length = 1;
            }
            else
            {
                if (Length / 2 > n)
                {
                    L2Node tmp = root;
                    for (int i = 0; i < n-1; i++)
                    {
                        tmp = tmp.Next;
                    }
                    tmp.Next = tmp.Next.Next;
                    tmp.Next.Next.Previous = tmp.Next.Next.Previous.Previous;
                    Length--;
                }
                else
                {
                    L2Node tmp = end;
                    for (int i = 1; i < Length -n-2; i++)
                    {
                        tmp = tmp.Previous;
                    }
                    tmp.Previous = tmp.Previous.Previous;
                    tmp.Previous.Previous.Next = tmp.Previous.Previous.Next.Next;
                    Length--;
                }
            }
        }

        public void RemovebyIndex(int n, int m)
        {
            //if (n > Length || n<0)
            //{
            //    throw new Exception("Индекс выходит за границы списка");
            //}
            if (root == null)
            {
                //throw new Exception("Hельзя удалить первый элемент из пустого списка");
                root = new L2Node(0);
                end = root;
                Length = 1;
            }
            else
            {
                for (int i = 0; i < m; i++)
                {
                    RemovebyIndex(m);
                }
            }
        }

        public void Revers()
        {
            L2Node right = root;
            L2Node left = root;
            while (right.Next != null)
            {
                right = right.Next;
            }
            while (left != right && left.Previous != right)
            {
                int t = left.Value;
                left.Value = right.Value;
                right.Value = t;
                left = left.Next;
                right = right.Previous;
            }
        }
        public void MaxMin()
        {
            if(Length > 1)
            {
                for (int i = 1; i < Length; i++)
                {
                    L2Node tmp = root;
                    if (root.Value < tmp.Next.Value)
                    {
                        tmp = tmp.Next;
                        root.Next = tmp.Next;
                        root.Previous = tmp;
                        tmp.Next = root;
                        tmp.Previous = null;
                        root = tmp;
                    }
                    while (tmp.Next.Next != null)
                    {
                        L2Node left = tmp.Next;
                        L2Node right = tmp.Next.Next;
                        if (left.Value < right.Value)
                        {
                            left.Next = right.Next;
                            left.Previous = right;
                            right.Next = left;
                            right.Previous = tmp;
                            tmp.Next = right;
                        }
                        tmp = tmp.Next;
                    }
                }
                if (Length == 1)
                {
                    //throw new Exception("Невозможно отсортироватьпутой список");
                }
                if (Length == null)
                {
                    //throw new Exception("Невозможно отсортироватьпутой список");
                    root = new L2Node(0);
                    Length = 1;
                }

            }
        }

        public void MinMax()
        {
            if (Length > 1)
            {
                for (int i = 1; i < Length; i++)
                {
                    L2Node tmp = root;
                    if (root.Value > tmp.Next.Value)
                    {
                        tmp = tmp.Next;
                        root.Next = tmp.Next;
                        root.Previous = tmp;
                        tmp.Next = root;
                        tmp.Previous = null;
                        root = tmp;
                    }
                    while (tmp.Next.Next != null)
                    {
                        L2Node left = tmp.Next;
                        L2Node right = tmp.Next.Next;
                        if (left.Value > right.Value)
                        {
                            left.Next = right.Next;
                            left.Previous = right;
                            right.Next = left;
                            right.Previous = tmp;
                            tmp.Next = right;
                        }
                        tmp = tmp.Next;
                    }
                }
                if (Length == 1)
                {
                    //throw new Exception("Невозможно отсортироватьпутой список");
                }
                if (Length == null)
                {
                    //throw new Exception("Невозможно отсортироватьпутой список");
                    root = new L2Node(0);
                    Length = 1;
                }

            }
        }

        public void IndexbyValue(int val)
        {
            if (Length != 0)
            {
                L2Node tmp = root;
                for (int i = 1; i < Length; i++)
                {
                    tmp = tmp.Next;
                    if (tmp.Value == val)
                    {
                        root = new L2Node(i);
                        Length = 1;
                    }
                }
            }
            else
            {
                //throw new Exception("Hельзя найти элементы в пустом списке");    
                root = null;
                Length = 0;
            }
        }

        public void DeletbyValue(int val)
        {
            if (Length != 0)
            {
                L2Node tmp = root;
                for (int i = 1; i < Length; i++)
                {
                    tmp = tmp.Next;
                    if (tmp.Value == val)
                    {
                        RemovebyIndex(i);
                        i--;
                    }
                }
            }
            else
            {
                //throw new Exception("Hельзя найти элементы в пустом списке");    
                root = null;
                Length = 0;
            }
        }
    }
}

