//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linear_Search_Implementation_In_C_.Dictionary___Hashset_Problems__20_
//{
//    internal class Find_All_Unique_Elements
//    {
//        public static void Main(string[] args)
//        {
//            int[] arr = { 1, 2,6,2,3,4,5 ,3, 4, 5, 6, 7, 8, 9, 10, 1, 2, 3, 4, 5 };
//            Dictionary<int, int> pairs  = new Dictionary<int, int>();
//            List<int> uniqie = new List<int>();
//            foreach (var item in arr)
//            {
//                if (pairs.ContainsKey(item))
//                    pairs[item]++;
//                else
//                    pairs[item] = 1;
//                uniqie.Add(item);
//            }
//            foreach  (var item in pairs)
//            {
//                if (item.Value > 1)
//                {
//                    uniqie.Remove(item.Key);
//                }
//            }
//            foreach (var item in uniqie)
//            Console.WriteLine(item);


            
          
           
//        }

//    }
//}
