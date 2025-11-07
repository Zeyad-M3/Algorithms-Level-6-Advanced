//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linear_Search_Implementation_In_C_
//{
//    public class Web_Page_Request_Handling
//    {
//        public static void Main(string[] args)
//        {
//            string[] WebPageRequest = { "Request1", "Request2", "Request3", "Request4", "Request5" };
//            Queue<string> WebPageRequestQueue = new Queue<string>();

//            for (int i = 0; i < WebPageRequest.Length; i++)
//            {
//                WebPageRequestQueue.Enqueue(WebPageRequest[i]);
//            }
//            while (WebPageRequestQueue.Count > 0)
//            {
//                Console.WriteLine("Done wiht the Request  " + WebPageRequestQueue.Dequeue());
//                if (WebPageRequestQueue.Count > 0)
//                {
//                    Console.WriteLine("The next Request  is " + WebPageRequestQueue.Peek());
//                    string currentCustomer = WebPageRequestQueue.Peek();
//                }
//                else
//                {
//                    Console.WriteLine("No more Request ");
//                    return;
//                }


//            }
//        }
//    }
//}
