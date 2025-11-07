//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linear_Search_Implementation_In_C_.Dictionary___Hashset_Problems__20_
//{
//    internal class Find_Elements_Not_in_the_Second_Arrayزؤس
//    {
//        public static void Main(string[] args)
//        {
//            int[] A = { 1, 2, 3, 4, 5 };
//            int[] B = { 3, 4, 5, 6 };
//            HashSet<int> setB = new HashSet<int>(B);
//            List<int> list = new List<int>();
//            foreach (var item in A)
//            {
//                if (!setB.Contains(item))
//                {
//                    list.Add(item);
//                }
//            }
//            Console.WriteLine(string.Join(" ", list));
//        }
//    }
//}
