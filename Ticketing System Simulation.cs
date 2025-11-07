//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linear_Search_Implementation_In_C_
//{
//    public class Ticketing_System_Simulation
//    {
      
//        public static void Main(string[] args)
//        {
//            string[] Tickets = { "Ticket 101 issued.", "Ticket 102 issued. ", "Ticket 103 issued. ", "Ticket 104 issued.", "Ticket 105 issued." , "Ticket 106 issued." };
//            Queue<string> queue = new Queue<string>();
//            for (int i = 0; i < Tickets.Length; i++)
//            {
//                queue.Enqueue(Tickets[i]);
//            }
//            Console.WriteLine("Ticketing System Simulation start");
//            Console.WriteLine("The next ticket to be served is " + queue.Peek());
//            while (queue.Count > 0)
//            {
//                Console.WriteLine(queue.Dequeue());

//                if (queue.Count == 0)
//                {
//                    Console.WriteLine("The next ticket Simulation Ended");
//                    return;
//                }
//                Console.WriteLine("The next ticket to be served is " + queue.Peek());
//            }

//        }

//    }
//}
