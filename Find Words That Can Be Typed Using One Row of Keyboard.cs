//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linear_Search_Implementation_In_C_.Dictionary___Hashset_Problems__20_
//{
//    internal class Find_Words_That_Can_Be_Typed_Using_One_Row_of_Keyboard
//    {
//        public static string[] Find_Words_That_Can_Be_Typed_Using_One_Row_ofKeyboard(string[] words)
//        {
//            string row1 = "qwertyuiop";
//            string row2 = "asdfghjkl";
//            string row3 = "zxcvbnm";
//            List<string> result = new List<string>();
//            for (int i = 0; i < words.Length; i++)
//            {
//                string wordLower = words[i].ToLower();
//                char firstChar = wordLower[0];
//                string row = row1.Contains(firstChar) ? row1 : row2.Contains(firstChar) ? row2 : row3.Contains(firstChar) ? row3 : "";
//                bool canBeTyped = true;
//                foreach (char c in wordLower)
//                {
//                    if (!row.Contains(c))
//                    {
//                        canBeTyped = false;
//                        break;
//                    }
//                }
//                if (canBeTyped)
//                {
//                    result.Add(words[i]);
//                }
//            }
//            return result.ToArray();
//        }
//        public static void Main(string[] args)
//        {
//            string[] words = { "Hello", "Alaska", "Dad", "Peace" };
//            string[] result = Find_Words_That_Can_Be_Typed_Using_One_Row_ofKeyboard(words);
//            Console.WriteLine(string.Join(", ", result));
//        }
//    }
//}
