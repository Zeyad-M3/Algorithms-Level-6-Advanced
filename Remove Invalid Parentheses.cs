//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linear_Search_Implementation_In_C_
//{
//    public class Remove_Invalid_Parentheses
//    {
       
//        public static List<string> RemoveInvalidParentheses(string s)
//        {
//            var visited = new HashSet<string>();
//            var queue = new Queue<string>();
//            var result = new List<string>();
//            bool found = false;

//            queue.Enqueue(s);
//            visited.Add(s);

//            while (queue.Count > 0)
//            {
//                string cur = queue.Dequeue();
//                if (IsValid(cur))
//                {
//                    result.Add(cur);
//                    found = true;
//                }
//                if (found) continue;
//                for (int i = 0; i < cur.Length; i++)
//                {
//                    if (cur[i] != '(' && cur[i] != ')') continue;
//                    string newStr = cur.Remove(i, 1);
//                    if (!visited.Contains(newStr))
//                    {
//                        queue.Enqueue(newStr);
//                        visited.Add(newStr);
//                    }
//                }
//            }
//            return result;
           
//        }
//        public static void Main(string[] args)
//        {
//            List<string> k = RemoveInvalidParentheses("(()))");
//            foreach (string s in k)
//            {
//                Console.WriteLine(s);
//                Console.WriteLine();
//            }
//        }
//        // Helper method to check if a string has valid parentheses
//        private static bool IsValid(string s)
//        {
//            int count = 0;
//            foreach (char c in s)
//            {
//                if (c == '(') count++;
//                if (c == ')')
//                {
//                    count--;
//                    if (count < 0) return false;
//                }
//            }
//            return count == 0;
//        }
//    }
//}
