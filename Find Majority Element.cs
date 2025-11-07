//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linear_Search_Implementation_In_C_.Dictionary___Hashset_Problems__20_
//{
//    internal class Find_Majority_Element
//    {
//        public static void Main(string[] args)
//        { 
//            Dictionary<int, int> frequency = new Dictionary<int, int>();
//            int n = 5;
//            int[] arr = { 1, 4, 3, 4, 4 };
//            for (int i = 0; i < n; i++)
//            {
//                if (frequency.ContainsKey(arr[i]))
//                {
//                    frequency[arr[i]]++;
//                }
//                else
//                {
//                    frequency[arr[i]] = 1;
//                }
//            }
//            foreach (KeyValuePair<int, int> entry in frequency)
//            {
//                if (entry.Value > n / 2)
//                {
//                    Console.WriteLine("Majority element is: " + entry.Key);
//                    return;
//                }
//            }
            
//        }
//    }
//}
