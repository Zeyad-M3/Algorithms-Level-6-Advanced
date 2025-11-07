//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linear_Search_Implementation_In_C_.Dictionary___Hashset_Problems__20_
//{
//    public class Track_Unique_Visitors_to_a_Website
//    {
//        public static void Main(string[] args)
//        {
//            HashSet<string> uniqueVisitors = new HashSet<string>();
//            string[] websiteLogs = { "user1 visited website1", "user2 visited website2", "user1 visited website3", "user3 visited website4", "user2 visited website5" };
//            foreach (string log in websiteLogs)
//            {
//                string[] parts = log.Split(' ');
//                string user = parts[0];
//                uniqueVisitors.Add(user);
//            }
//            Console.WriteLine("Number of unique visitors: " + uniqueVisitors.Count);
//        }
//    }
//}
