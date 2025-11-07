//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using static System.Runtime.InteropServices.JavaScript.JSType;

//namespace Linear_Search_Implementation_In_C_.Dictionary___Hashset_Problems__20_
//{
   
//    internal class Find_Missing_Number_in_an_Array
//    {
       
//        public static void Main(string[] args)
//        { 
//            int[] arr = { 3, 0, 1 };
//            Dictionary<int, int> MissingNumber = new Dictionary<int, int>();
         
//            for (int i = 0; i < arr.Length; i++)
//            {
//                MissingNumber[arr[i]] = i;
//            }
//            for (int i = 0; i < arr.Length; i++)
//            {
//                if (!MissingNumber.ContainsKey(i))
//                {
//                    Console.WriteLine("Missing number is: " + i);
//                    return;
//                }
//            }
           
          
           

//        }
       
    
//    }
//}
