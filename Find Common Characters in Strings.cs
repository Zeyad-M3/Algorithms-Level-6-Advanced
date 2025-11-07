//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linear_Search_Implementation_In_C_.Dictionary___Hashset_Problems__20_
//{
//    internal class Find_Common_Characters_in_Strings
//    {
//        public static List<string> CommonChars(string[] A)
//        { 
//            List<string> result = new List<string>();
//            for (int i = 0; i < A[0].Length; i++)
//            {
//                char ch = A[0][i];
//                bool flag = true;
//                for (int j = 1; j < A.Length; j++)
//                {
//                    if (A[j].IndexOf(ch) == -1)
//                    {
//                        flag = false;
//                        break;
//                    }
//                }
//                if (flag)
//                {
//                    result.Add(ch.ToString());
//                }
//            }
//            return result;

//        }
//        public static void Main(string[] args)
//        {
//            string[] A = { "bella", "label", "roller" };
//            Dictionary <char, int> dic = new Dictionary<char, int>();
//            List<string> result = CommonChars(A);
//            foreach (string s in result) {
//                Console.WriteLine(s);
//            }

//        }
//    }
//}
