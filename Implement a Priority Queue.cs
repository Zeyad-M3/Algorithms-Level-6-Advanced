//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linear_Search_Implementation_In_C_
//{
//    public class Implement_a_Priority_Queue
//    {
//        public static Queue<int> Enqueue(Queue<int> pq, int priority)
//        {
//          if (priority > pq.FirstOrDefault())
//           { 
//                pq.Enqueue(priority);
          
//           }
//          else
//           {
//               pq.Enqueue(priority);
//               pq.Enqueue(pq.Dequeue());
//           }
//          return pq;

            

         
//        }
//        public static void Main(string[] args)
//        {
//            Queue<int> pq = new Queue<int>();
//            // Use the Enqueue method defined in this class to add an item with a priority
//            pq = Enqueue(pq, 23);
//            pq = Enqueue(pq, 22);
//            pq = Enqueue(pq, 32);
//            // print
//            Console.WriteLine(pq.Dequeue());
//            Console.WriteLine(pq.Dequeue());
//            Console.WriteLine(pq.Dequeue());
//            Console.ReadLine();
           


//        }
//    }
//}
