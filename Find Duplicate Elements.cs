//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linear_Search_Implementation_In_C_.Dictionary___Hashset_Problems__20_
//{
   
//    internal class Find_Duplicate_Elements
//    {
//        public static void Main(string[] args)
//        {
//            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 2, 3, 4, 5 };
//            Dictionary<int, int> frequency = new Dictionary<int, int>();
//            // print the duplicate elements
//            List<int> d =  FindDuplicateElements(arr);
//            Console.WriteLine("Duplicate elements are: ");
//            foreach (int i in d)
//            {
//                Console.WriteLine(i);
//            }

//            static List<int> FindDuplicateElements(int[] arr)
//            {

//                if (arr == null || arr.Length == 0)
//                    return new List<int>();

//                Dictionary<int, int> counts = new Dictionary<int, int>();
//                List<int> result = new List<int>();

//                foreach (var item in arr)
//                {
//                    if (counts.ContainsKey(item))
//                        counts[item]++;
//                    else
//                        counts[item] = 1;

//                    if (counts[item] == 2)
//                        result.Add(item);
//                }

//                return result;

//            }
//        }
//    }
//}
