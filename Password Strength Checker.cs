//using System;
//using System.Collections;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linear_Search_Implementation_In_C_.BitArray_Problems__12_
//{
//    internal class Password_Strength_Checker
//    {
//        public static void Main(string[] args)
//        {
//            BitArray pass = new BitArray(5);
//            Console.WriteLine("Enter your password: ");
//            string password = Console.ReadLine();
//            foreach (char c in password)
//            { 
//                if (char.IsUpper(c))
//                {
//                    pass[0] = true;
//                }
//                else if (char.IsLower(c))
//                {
//                    pass[1] = true;
//                }
//                else if (char.IsDigit(c))
//                {
//                    pass[2] = true;
//                }
//                else
//                {
//                    pass[3] = true;
//                }
//                if (password.Length >= 8)
//                {
//                    pass[4] = true;
//                }
              
//            }
//            for (int i = 0; i < password.Length; i++)
//            {
               

//                if (pass[0] && pass[1] && pass[2] && pass[3] && pass[4])
//                {
                  
//                    Console.WriteLine("Strong"); return ;
//                }
//                else
//                {
//                    Console.WriteLine("Weak");
//                    return;
//                }
                
//            }
          
//        }
//    }
//}
