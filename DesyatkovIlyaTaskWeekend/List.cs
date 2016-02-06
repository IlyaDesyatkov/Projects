using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesyatkovIlyaTaskWeekend
{
    public class List<T> : IList<T>
    {
        public class Cell
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
        private Cell head;
        private Cell tail;
        public List()
        {
            head = null;
            tail = null;
        }
        public void Append(T cellData) 
        {
            Cell t = new Cell(cellData);
            if (head == null)
            {
                head = t;
                tail = t;
            }
            else
            {
                t.Next = head;
                head = t;
            }
        }

        public T Get() 
        {
            if (head == null)
            {
                throw new Exception("Список пуст");
            }
            else
            {
                Cell t = head;
                head = head.Next;
                if (head == null)
                {
                    tail = null;
                }
                return t.Data;
            }
        }

        public bool IsEmpty 
        {
            get
            {
                if (head == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public Cell Find(int index)
        {
            Cell t = head;
            while (t != null)
            {
                if (((IComparable)(t.Data)).CompareTo(index) == 0)
                {
                    break;
                }
                else
                {
                    t = t.Next;
                }
            }
            return t;
        }
        public void Insert(int index, T newCell) 
        {
            Cell t = Find(index);
            if (t != null)
            {
                Cell p = new Cell(newCell);
                p.Next = t.Next;
                t.Next = p;
            }
        }
        public void Delete(int index)
        {
            if (head == null)
            {
                throw new Exception("Список пуст");
            }
            else
            {
                if (((IComparable)(head.Data)).CompareTo(index) == 0)
                {
                    head = head.Next;
                }
                else
                {
                    Cell t = head;
                    while (t.Next != null)
                    {
                        if (((IComparable)(t.Next.Data)).CompareTo(index) == 0)
                        {
                            t.Next = t.Next.Next;
                            break;
                        }
                        else
                        {
                            t = t.Next;
                        }
                    }
                }
            }
        }
    }
}
