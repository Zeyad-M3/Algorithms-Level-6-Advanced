//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linear_Search_Implementation_In_C_
//{
//    public class Clone_a_Queue_Without_Using_Extra_Space
//    {
//        public static Queue<int> Clone(Queue<int> q)
//        {
//            return new Queue<int>(q);

//        }

//        public static void Main(string[] args)
//        {
//            Queue<int> q = new Queue<int>();
//            q.Enqueue(1);
//            q.Enqueue(2);
//            q.Enqueue(3);
//            q.Enqueue(4);
//            q.Enqueue(5);
//            q.Enqueue(6);
//            q.Enqueue(7);
//            q.Enqueue(8);
//            q.Enqueue(9);
//            q.Enqueue(10);
//            Console.WriteLine("Original Queue: ");
//            foreach (int i in q)
//            {
//                Console.Write(i + " ");
//            }
//            Console.WriteLine();
//            Console.WriteLine("Cloned Queue: ");
//            Queue<int> q1 = new Queue<int>(q);
//            foreach (int i in q1)
//            {
//                Console.Write(i + " ");
//            }
//        }
//    }
//}
