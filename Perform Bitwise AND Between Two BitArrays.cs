//using System;
//using System.Collections;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linear_Search_Implementation_In_C_.BitArray_Problems__12_
//{
//    internal class Perform_Bitwise_AND_Between_Two_BitArrays
//    {
//        public static void Main(string[] args)
//        { 
//            BitArray bitArray1 = new BitArray(2);
//            bitArray1[0] = true;
//            bitArray1[1] = false;
//            BitArray bitArray2 = new BitArray(2);
//            bitArray2[0] = false;
//            bitArray2[1] = true;
            
//            BitArray result = new BitArray(2);
//            for (int i = 0; i < bitArray1.Length; i++)
//            {
//                result[i] = bitArray1[i] && bitArray2[i];
//            }
//            Console.WriteLine("Result:");
//            for (int i = 0; i < result.Length; i++)
//            {
//                Console.WriteLine(result[i]);
//            }
//        }
//    }
//}
