using System;
using System.Collections.Generic;
using System.Text;

namespace DadaStructure.ArrayList
{
    public class ArrayList: IList
    {
        private int[] array;
        private int length;
        private int max;
        private int min;
        private int minIdx;
        private int maxIdx;
        private int val;
        public int this[int a] //Доступ по индексу, изм по индексу 
        {
            get { return array[a]; }
            set
            {
                //if (a > length || a < 0)
                //{
                //    throw new Exception("Индекс выходит за границы списка");
                //}
                if (length != 0)
                {
                    array[a] = value;
                }
                else
                {
                    if (length >= array.Length)
                    {
                        UpArraySize();
                    }
                    length++;
                    array[0] = value;
                }
            }
        }
        public int Length  { get { return length; } } //возврат длины массива
        public int[] ReturnArray() //возврат массива
        {
            int[] arrayToReturn = new int[length];
            for (int i = 0; i < length; i++)
            {
                arrayToReturn[i] = array[i];
            }

            return arrayToReturn;
        }

        public ArrayList() //конструктор массива
        {
            array = new int[0];
            length = 0;
        }

        public ArrayList(int a) //конструктор массива
        {
            array = new int[1] { a };
            length = 1;
        }

        public ArrayList(int[] a) //конструктор массива
        {
            array = a;
            length = a.Length;
        }

        public void UpArraySize() //увеличение длинны массива
        {
            int newL = Convert.ToInt32(array.Length * 1.3d + 1);
            int[] newArray = new int[newL];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            array = newArray;
        }

        public void AddTheEnd(int a) //добавление в конец массива одного числа
        {
            if (length >= array.Length)
            {
                UpArraySize();
            }

            array[length] = a;
            length++;
        }

        public void AddTheEnd(int[] a) //добавление в конец массива  несколько чисел
        {
            if (length != 0)
            {
                while (length + a.Length > array.Length)
                {
                    UpArraySize();
                }

                for (int i = 0; i < length; i++)
                {
                    array[length + i] = a[i];
                }
                length += a.Length;
            }
            else
            {
                length = a.Length;
                array = a;
            }
        }
        public void AddTheStart(int a) //добавление элемента в начало
        {
            if (length >= array.Length)
            {
                UpArraySize();
            }
            length++;
            for(int i = array.Length - 1; i>0; i-- )
            {
                array[i] = array[i-1];
            }
            array[0] = a;
        }
        public void AddTheStart(int[] a) //добавление N элементof в начало !!!!!!!!!!
        {
            while (length + a.Length > array.Length)
            {
                UpArraySize();
            }
            for (int i = array.Length; i > a.Length; i--)
            {
                array[i-1] = array[i - a.Length - 1]; // Сдвигаем элементы на N назад
            }
            for (int i = 0; i < a.Length; i++)
            {
              array[i] = a[i];
            }
            length += a.Length;
        }

        public void AddTheIndex(int indx, int a) //добавление элемента по индексу 
        {
            if (indx > length || indx < 0)
            {
                //throw new Exception("Индекс выходит за границы списка");
                array = new int[1] { 0 };
                length = 1;
            }
            else
            {
                if (length >= array.Length)
                {
                    UpArraySize();
                }
                length++;
                for (int i = array.Length - 2; i > indx; i--)
                {
                    array[i] = array[i - 1];
                }
                array[indx] = a;
            }
        }
        public void AddTheIndex(int indx, int [] a) //добавление N элементof по индексу 
        {
            //if (indx > length || indx < 0)
            //{
            //    throw new Exception("Индекс выходит за границы списка");
            //}
            if (length != 0 && length!=1)
            {
                while (length + a.Length > array.Length)
                {
                    UpArraySize();
                }
                length += a.Length;
                for (int i = indx; i < (a.Length + indx); i++)
                {
                    array[a.Length + i] = array[i]; // Сдвигаем элементы на N 
                }
                for (int i = 0; i < a.Length; i++)
                {
                    array[indx + i] = a[i];
                }
            }
            else
            {
                while (length + a.Length > array.Length)
                {
                    UpArraySize();
                }
                length += a.Length;
                array = a;
            }
        }
        public void RemoveFromStart() //удалени элемента из начала 
        {
            if (length == 0)
            {
                //throw new Exception("Hельзя удалить элемент из пустого массива");
                length++;
                array = new int[] { 0 };
            }
            if (length == 1)
            {
                length = 1;
                array[0] = 0;
            }
            else
            {
                for (int i = 1; i < array.Length; i++)
                {
                    array[i - 1] = array[i]; //Сдвигаем элементы на один назад
                }
                length--; //Уменьшаем длину
            }
            //else
           
        }
        public void RemoveFromStart(int a) //удалени N элементof из начала 
        {
            if (length == 0)
            {
                //throw new Exception("Hельзя удалить элемент из пустого массива");
                length++;
                array = new int[] { 0 };
            }
            if (length == 1)
            {
                length = 1;
                array[0] = 0;
            }
            else
            {
                for (int j = 1; j <= a; j++)
                {
                    for (int i = 1; i < array.Length; i++)
                    {
                        array[i - 1] = array[i]; //Сдвигаем элементы на один назад
                    }
                    //array[array.Length - 1] = Convert.ToInt32(null);
                    length--; //Уменьшаем длину
                }
            }
        }
        public void RemoveFromEnd() //удалени элемента из конца
        {
            if (length == 1)
            {
                length--;
            }
            if (length != 0)
            {
                length--;
            }
            else
            {
                {
                    //throw new Exception("Hельзя удалить элемент из пустого массива");
                    length++;
                    array = new int[] { 0 };
                }
            }
        }
        public void RemoveFromEnd(int a) //удалени N элементof из конца
        {
            if (length == 1)
            {
                length--;
            }
            if (length != 0)
            {
                for (int i = 1; i <= a; i++)
                {
                    length--;
                }
            }
            else
            {
                {
                    //throw new Exception("Hельзя удалить элементы из пустого массива");
                    length++;
                    array = new int[] { 0 };
                }
            }
        }
        public void RemovebyIndex(int n) //удaлени элемента по индексу
        {
            //if (n > length || n < 0)
            //{
            //    throw new Exception("Индекс выходит за границы списка");
            //}
            if (length == 1)
            {
                length--;
            }
            if (length == 0)
            {
                length++;
                array = new int[] { 0 };
            }
            else
            {
                for (int i = n + 1; i < array.Length; i++)
                {
                    array[i - 1] = array[i]; //Сдвигаем элементы на один назад
                }
                length--; //Уменьшаем длину
            }
        }
        public void RemovebyIndex(int n, int m) //удaлени элемента по индексу
        {
            //if (n > length || n < 0)
            //{
            //    throw new Exception("Индекс выходит за границы списка");
            //}
            if (length == 1)
            {
                length--;
            }
            if (length != 0)
            {
                for (int i = 1; i <= m; i++)
                {
                    for (int j = n + 1; j < array.Length; j++)
                    {
                        array[j - 1] = array[j]; //Сдвигаем элементы на один назад
                    }
                    length--;
                }
            }
            else
            {
                //throw new Exception("Hельзя удалить элементы из пустого массива");    
                length++;
                array = new int[] { 0 };
            }
        }
        public void Revers() // Revers
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int t = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = t;
            }
        }
        public int Maximum 
        { get 
            {
                if (length != 0)
                {
                    max = array[0];
                    for (int i = 1; i < length; i++)
                    {
                        if (max < array[i])
                        {
                            max = array[i];
                        }
                    }
                }
                else
                {
                    //throw new Exception("Hельзя найти элемент в пустом массиве");
                    max = 0;
                }
                   
         return max; } }
        public int Minimum 
        { get 
            {
                if (length != 0)
                {
                    min = array[0];
                    for (int i = 1; i < length; i++)
                    {
                        if (min > array[i])
                        {
                            min = array[i];
                        }
                    }
                }
                else
                {
                    //throw new Exception("Hельзя найти элемент в пустом массиве");
                    min = 0;
                }
                return min; } }
        
        public int MinI
        { get 
            {
                int minIdx = 0;
                if (length == 0)
                {
                    //throw new Exception("Hельзя найти интедкс элемента в пустом массиве");
                    minIdx = 0;
                }
                else
                {
                    int min = array[0];
                    
                    for (int i = 1; i < length; i++)
                    {
                        if (min > array[i])
                        {
                            min = array[i];
                            minIdx = i;
                        }
                    }
                }
                return minIdx; } }
        public int MaxI
        {
            get
            {
                int maxIdx = 0;
                if (length == 0)
                {
                    //throw new Exception("Hельзя найти интедкс элемента в пустом массиве");
                    maxIdx = 0;
                }
                else
                {
                    int max = array[0];
                    for (int i = 1; i < length; i++)
                    {
                        if (max < array[i])
                        {
                            max = array[i];
                            maxIdx = i;
                        }
                    }
                }
             return maxIdx;
            }
        }
        public void MaxMin() // Сортировка по убыв
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] > array[min])
                    {
                        min = j;
                    }
                }
                int temp = array[min];
                array[min] = array[i];
                array[i] = temp;
            }
        }
        public void MinMax() // Сортировка по возр
        {
            int temp;
            for (int i = 0; i < array.Length; i++)

            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
        public void IndexbyValue(int val)
        {
            if (length !=0)
            {
                for (int i = 0; i < length; i++)
                {
                    if (array[i] == val)
                    {
                        length = 1;
                        array[0] = i;
                    }
                }
            }
            else
            {
                //throw new Exception("Hельзя удалить элементы из пустого массива");    
                length++;
                array = new int[] { 0 };
            }
            

        }
        public void DeletbyValue(int val)
        {
            if (length == 1)
            {
                array = new int[1] { 0 };
                length = 1;
            }
            if (length != 0)
            {
                for (int i = 0; i < length; i++)
                {
                    if (array[i] == val)
                    {
                        for (int j = i + 1; j < array.Length; j++)
                        {
                            array[j - 1] = array[j]; //Сдвигаем элементы на один назад
                        }
                        length--;
                    }
                }
            }
            else
            {
                //throw new Exception("Hельзя удалить элементы из пустого массива");    
                length++;
                array = new int[] { 0 };
            } 
        }
    }
}

