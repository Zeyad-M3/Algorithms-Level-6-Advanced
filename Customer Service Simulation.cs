//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linear_Search_Implementation_In_C_
//{
//    public class Customer_Service_Simulation
//    {
//        public static void Main(string[] args)
//        {
//            string[] Customer_Service_Simulation = { "clint1","clint2","clint3","clint4","clint5"};
//            Queue<string> Customer_Service_Simulationstack = new Queue<string>();

//            for (int i = 0; i < Customer_Service_Simulation.Length; i++)
//            {
//                Customer_Service_Simulationstack.Enqueue(Customer_Service_Simulation[i]);
//            }
//            while (Customer_Service_Simulationstack.Count > 0)
//            {
//                Console.WriteLine("Done wiht the service "+Customer_Service_Simulationstack.Dequeue());
//                if  (Customer_Service_Simulationstack.Count > 0)
//                {
//                    Console.WriteLine("The next customer is " + Customer_Service_Simulationstack.Peek());
//                string currentCustomer = Customer_Service_Simulationstack.Peek();
//                }
//                else
//                {
//                    Console.WriteLine("No more customers");
//                    return;
//                }
                
           
//            }
//        }
//    }
//}
