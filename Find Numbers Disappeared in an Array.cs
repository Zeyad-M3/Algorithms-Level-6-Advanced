//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linear_Search_Implementation_In_C_.Dictionary___Hashset_Problems__20_
//{
//    internal class Find_Numbers_Disappeared_in_an_Array
//    {
//        public static void Main(string[] args)
//        { 
//            int[] nums = { 4, 3, 2, 7, 8, 2, 3, 1 };
//            List<int> missing = new List<int>();
//            HashSet<int> numbers = new HashSet<int>();
//            for (int i = 0; i < nums.Length; i++)
//            {
//                numbers.Add(nums[i]);
//            }
//            for (int i = 1; i <= nums.Length; i++)
//            {
//                if (!numbers.Contains(i))
//                {
//                    missing.Add(i);
//                }
//            }
//            foreach (var item in missing)
//            {
//                Console.Write(item + " ");

                
//            }
//        }
//    }
//}
