//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linear_Search_Implementation_In_C_
//{
//    public class Evaluate_a_Postfix_Expression
//    {
//        public static int EvaluatePostfix(string exp)
//        {
//            Stack<int> stack = new Stack<int>();

//            for (int i = 0; i < exp.Length; i++)
//            {
//                char c = exp[i];
//                if (Char.IsDigit(c))
//                {
//                    stack.Push(c - '0');
//                }
//                else if (c == '+' || c == '-' || c == '*' || c == '/')
//                {
//                    int val1 = stack.Pop();
//                    int val2 = stack.Pop();
//                    switch (c)
//                    {
//                        case '+':
//                            stack.Push(val2 + val1);
//                            break;
//                        case '-':
//                            stack.Push(val2 - val1);
//                            break;
//                        case '*':
//                            stack.Push(val2 * val1);
//                            break;
//                        case '/':
//                            stack.Push(val2 / val1);
//                            break;
//                    }
//                }
//            }
//            return stack.Pop();
//        }
//        public static void Main(string[] args)
//        {
//            Console.WriteLine(EvaluatePostfix("231*+9-"));
//        }
//    }
//}
