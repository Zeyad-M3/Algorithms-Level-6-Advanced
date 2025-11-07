//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linear_Search_Implementation_In_C_
//{
//    public class Check_Balanced_Parentheses
//    {
//        public static bool IsBalanced(string exp)
//        {
//            Stack<char> s = new Stack<char>();
//            for (int i = 0; i < exp.Length; i++)
//            {
//                char c = exp[i];
//                if (c == '(' || c == '[' || c == '{')
//                {
//                    s.Push(c);
//                }
//                else
//                {
//                    if (s.Count == 0)
//                    {
//                        return false;
//                    }
//                    char top = s.Pop();
//                    if ((c == ')' && top != '(') || (c == ']' && top != '[') || (c == '}' && top != '{'))
//                    {
//                        return false;
//                    }
//                }
                
//            }
//            return true;

            
    
//        }
//        public static void Main(string[] args)
//        {
//            Console.WriteLine(IsBalanced("({[]})"));

//        }
//    }
//}
