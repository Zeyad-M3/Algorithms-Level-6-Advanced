//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linear_Search_Implementation_In_C_
//{
//    public class First_Non_Repeating_Character_in_a_Stream
//    {
//        public static string FirstNonRepeating(string str)
//        {
//            string ss = null; // Initialize ss to avoid CS0165
//            foreach (var c in str)
//            {
//                Queue<string> q = new Queue<string>();
//                // Change this line:
//                // q.Enqueue(c);
//                // To:
//                q.Enqueue(c.ToString());
              
//                while (q.Count > 0)
//                {
//                    string ch = q.Peek();
//                    q.Dequeue();
//                    if (str.IndexOf(ch) == str.LastIndexOf(ch))
//                    {
//                        ss += ch.ToString(); // Fix: convert char to string
//                    }
//                }
//            }
//            // Add a return statement to handle the case when no non-repeating character is found
//            return ss;
//        }
//        public static void Main(string[] args)
//        { 
//            Console.WriteLine(FirstNonRepeating("aabsawe3rfdffcf"));
//        }
//    }
//}
