//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linear_Search_Implementation_In_C_.Dictionary___Hashset_Problems__20_
//{
//    internal class Find_the_Frequency_of_Each_Character
//    {
//        public static void Main(string[] args)
//        {
//            string str = "Hello, World!";
//            Dictionary<char, int> frequency = new Dictionary<char, int>();
//            foreach (char c in str)
//            {
//                if (frequency.ContainsKey(c))
//                {
//                    frequency[c]++;
//                }
//                else
//                {
//                    frequency[c] = 1;
//                }
//            }
//            foreach (KeyValuePair<char, int> entry in frequency)
//            {
//                Console.WriteLine("Character: " + entry.Key + ", Frequency: " + entry.Value);
//            }
//        }
//    }
//}
