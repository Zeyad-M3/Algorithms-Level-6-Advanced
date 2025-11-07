//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linear_Search_Implementation_In_C_
//{
//    public class Traffic_Signal_System_Simulation
//    {
//        public static void Main(string[] args)
//        {
//            string[] cars = { "car1", "Truck 1", "Bike 1", "Bus 1" };
//            Queue<string> queue = new Queue<string>();
//            Console.WriteLine("Traffic Signal System Simulation");
//            for (int i = 0; i < cars.Length; i++)
//            {
//                queue.Enqueue(cars[i]);
//            }
//            Console.WriteLine("Traffic Signal Simulation Started");
//            Console.WriteLine("The next car to cross the road is Vehicles waiting " + queue.Peek());
//            while (queue.Count > 0)
//            {
//                string vehicle = queue.Dequeue();
//                    Console.WriteLine(queue.Dequeue());
//                Console.WriteLine("Vehicle " + vehicle + " is crossing the road");
//               if (queue.Count == 0) { 
//                    Console.WriteLine("Traffic Signal Simulation Ended");
//                return;
//                }
//                Console.WriteLine("The next car to cross the road is Vehicles waiting " + queue.Peek());

//            }
//        }
//    }
//}
