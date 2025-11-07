//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linear_Search_Implementation_In_C_.Tuples_Problems__5_
//{
//    internal class Return_Multiple_Values_from_a_Function
//    {
//        public static Tuple<int,int> thetuble(int[] arr)
//        {
//            int min = arr[0];
//            int max = arr[0];

//            for (int i = 1; i < arr.Length; i++)
//            {
//                if (arr[i] < min)
//                {
//                    min = arr[i];
//                }
//                else if (arr[i] > max)
//                {
//                    max = arr[i];
//                }
//            }
//            return Tuple.Create(min, max);

           
//        }
//        public static void Main(string[] args)
//        {
//            int[] arr = { 5, 2, 9, 1, 7 };
//            Tuple<int, int> result = thetuble(arr);
//            Console.WriteLine("Minimum: " + result.Item1);
//            Console.WriteLine("Maximum: " + result.Item2);
//        }
//    }
//}
