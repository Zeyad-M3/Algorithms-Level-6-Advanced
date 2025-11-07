//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linear_Search_Implementation_In_C_
//{
//    public class Palindrome_Queue
//    {
//        public bool IsPalindrome(Queue<int> q)
//        {
//            Stack<int> stack = new Stack<int>();
//            int n = q.Count;

//            // انسخ القيم بدون ما تغيّر ترتيب الـ Queue الأصلي
//            int[] arr = q.ToArray();

//            // احط كل العناصر في Stack
//            foreach (int item in arr)
//                stack.Push(item);

//            // اقارن كل عنصر من بداية الـ Queue مع اللي في Stack (من النهاية)
//            foreach (int item in arr)
//            {
//                if (item != stack.Pop())
//                    return false;
//            }

//            return true;
//        }

//        public static void Main(string[] args)
//        {
//            //Example:
//            // Input: Queue = [1, 2, 3, 2, 1]
//            // Output: True
//            Queue<int> q = new Queue<int>();
//            q.Enqueue(1);
//            q.Enqueue(2);
//            q.Enqueue(3);
//            q.Enqueue(3);
//            q.Enqueue(2);
//            q.Enqueue(1);

//            Palindrome_Queue pq = new Palindrome_Queue();
//            Console.WriteLine(value: pq.IsPalindrome(q));
//        }
//    }
//}
