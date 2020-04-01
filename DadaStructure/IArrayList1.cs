using System;
using System.Collections.Generic;
using System.Text;

namespace DadaStructure
{
    interface IArrayList
    {
        public int[] ReturnArray(); //возврат массива
        public int Length { get; } //возврат длины
        public void UpArraySize(); //увеличение длинны массива
        public void AddTheEnd(int a); //добавление в конец массива одного числа
        public void AddTheEnd(int[] a); //добавление в конец массива  несколько чисел
        public void AddTheStart(int a); //добавление элемента в начало
        public void AddTheStart(int[] a); //добавление N элементof в начало !!!!!!!!!!
        public void AddTheIndex(int indx, int a); //добавление элемента по индексу 
        public void AddTheIndex(int indx, int[] a); //добавление N элементof по индексу 
        public void RemoveFromStart(); //удалени элемента из начала 
        public void RemoveFromStart(int a); //удалени N элементof из начала 
        public void RemoveFromEnd(); //удалени элемента из конца
        public void RemoveFromEnd(int a); //удалени N элементof из конца
        public void RemovebyIndex(int n); //удaлени элемента по индексу
        public void RemovebyIndex(int n, int m); //удaлени N элементof по индексу
        public void Revers(); // Revers
        public int Maximum { get; }
        public int Minimum { get; }
        public int MinI { get; }
        public int MaxI { get; }
        public void MaxMinSelect(); // Сортировка по возрастанию
        public void MinMaxBubble(); // Сортировка по убыванию
        public void IndexbyValue(int val); //Индекс по знаению
        public void DeletbyValue(int val); //Удалит по значению
    }
}
