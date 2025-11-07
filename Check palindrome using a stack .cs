//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linear_Search_Implementation_In_C_
//{
//    public class Check_palindrome_using_a_stack
//    {
//        public static bool IsPalindrome(string str)
//        {
//            Stack<char> s = new Stack<char>();
//            for (int i = 0; i < str.Length; i++)
//            {
//                s.Push(str[i]);
//            }
//            for (int i = 0; i < str.Length; i++)
//            {
               
//                if (str[i] == s.Pop())
//                    return true;
//                else
//                    return false;
//            }
//            return true;
//        }
//        public static void Main(string[] args)
//        {
//            string str = "hello";
//            Console.WriteLine(IsPalindrome(str));
//        }
//    }
//}
