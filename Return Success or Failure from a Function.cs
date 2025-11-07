//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linear_Search_Implementation_In_C_.Tuples_Problems__5_
//{
//    internal class Return_Success_or_Failure_from_a_Function
//    {
//        //Problem: Write a function that check the student mark and returns success status and the mark value.

//        public static Tuple<bool, int> thetuble(Tuple<bool,int> sutdent)
//        {
//            if (sutdent.Item2 >= 50)
//            {
//                return Tuple.Create(true, sutdent.Item2);
//            }
//            else
//            {
//                return Tuple.Create(false, sutdent.Item2);
//            }
//            return Tuple.Create(sutdent.Item1, sutdent.Item2);
//        }
//        public static void Main(string[] args)
//        {
//            Tuple<bool, int> student1 = Tuple.Create(false, 22);
//            Tuple<bool, int> student2 = Tuple.Create(false, 32);
//            Tuple<bool, int> student3 = Tuple.Create(false, 66);

//           var data = thetuble(student1);
//            var data2 = thetuble(student2);
//            var data3 = thetuble(student3);

//            Console.WriteLine("student mark: " + data.Item1);
//            Console.WriteLine("Student Score: " + data.Item2);
//            Console.WriteLine("student mark: " + data2.Item1);
//            Console.WriteLine("Student Score: " + data2.Item2);
//            Console.WriteLine("student mark: " + data3.Item1);
//            Console.WriteLine("Student Score: " + data3.Item2);


//        }
//    }
//}
