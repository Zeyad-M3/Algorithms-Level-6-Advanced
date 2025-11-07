//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linear_Search_Implementation_In_C_
//{
//    public class Merge_Two_Sorted_Queues
//    {
//        static Queue<int> SortQueue(Queue<int> queue1, Queue<int> queue2)
//        {
//            // Merge both queues into a list
//            List<int> list = new List<int>();
//            list.AddRange(queue1);
//            list.AddRange(queue2);
//            list.Sort();

//            // this will generate a queue from list
//            return new Queue<int>(list);
//        }
        

        
//        static void Main()
//        {
//            Queue<int> q1 = new Queue<int>();
//            q1.Enqueue(1);
//            q1.Enqueue(3);
//            q1.Enqueue(5);


//            Queue<int> q2 = new Queue<int>();
//            q2.Enqueue(2);
//            q2.Enqueue(4);
//            q2.Enqueue(6);


//            q1 = SortQueue(q1, q2);
//            while (q1.Count > 0)
//            {
//                Console.Write(q1.Dequeue() + " ");
//            }
//        }
//    }
//}
