//using System;
//using System.Collections;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linear_Search_Implementation_In_C_.BitArray_Problems__12_
//{
//    internal class Count_the_Number_of_True_Bits_False_Bits_in_a_BitArray
//    {
//        public static void Main(string[] args)
//        {
//            BitArray bitArray = new BitArray(10);
//            bitArray[0] = true;
//            bitArray[1] = false;
//            bitArray[2] = true;
//            bitArray[3] = false;
//            bitArray[4] = true;

//            int trueBits = bitArray.Cast<bool>().Count(b => b);
//            int falseBits = bitArray.Cast<bool>().Count(b => !b);
//            Console.WriteLine($"Number of True Bits: {trueBits}");
//            Console.WriteLine($"Number of False Bits: {falseBits}");
//        }
//    }
//}
