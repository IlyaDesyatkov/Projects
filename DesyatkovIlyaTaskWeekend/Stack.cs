using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesyatkovIlyaTaskWeekend
{
    public class Stack<T> : IStack<T>
    {
        private class Cell
        {
            private T data; 
            private Cell next; 
            public Cell(T firstCellData) 
            {
                data = firstCellData;
                next = null;
            }
            public Cell Next
            {
                get { return next; }
                set { next = value; }
            }
            public T Data
            {
                get { return data; }
                set { data = value; }
            }
        }
        private Cell top; 

        public Stack() 
        {
            top = null;
        }

        public void PushS(T newCellData) 
        {
            Cell t = new Cell(newCellData);
            t.Next = top;
            top = t;
        }

        public T PopS() 
        {
            if (top == null)
            {
                throw new Exception("Стек пуст"); 
            }
            else
            {
                Cell t = top;
                top = t.Next;
                return t.Data;
            }
        }
    }
}
