//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linear_Search_Implementation_In_C_.Dictionary___Hashset_Problems__20_
//{
//    internal class Find_Longest_Consecutive_Sequence
//    {
//        public static void Main(string[] args)
//        {
//            int[] arr = { 100, 4, 200, 1, 3, 2 };
//            HashSet<int> set = new HashSet<int>(arr);
//            int maxLength = 0;
//            foreach (int num in set)
//            {
//                if (!set.Contains(num - 1))
//                {
//                    int currentNum = num;
//                    int currentLength = 1;
//                    while (set.Contains(currentNum + 1))
//                    {
//                        currentNum++;
//                        currentLength++;
//                    }
//                    maxLength = Math.Max(maxLength, currentLength);
//                }
//            }
//            Console.WriteLine("Longest consecutive sequence length: " + maxLength);
//        }
//    }
//}
