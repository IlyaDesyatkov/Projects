using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesyatkovIlyaTask_07
{
    class Task_01
    {
        public static void Main(string[] args)
        {
            int[] listpeople = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; 
            Queue<int> list = new Queue<int>(listpeople); 
             
            while (list.Count != 1)
            {
                list.Enqueue(list.Dequeue()); 
                list.Dequeue();
            } 
        }
    }
}
