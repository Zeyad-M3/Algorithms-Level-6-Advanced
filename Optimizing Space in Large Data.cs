//using System;
//using System.Collections;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linear_Search_Implementation_In_C_.BitArray_Problems__12_
//{
//    internal class Optimizing_Space_in_Large_Data
//    {
//        public static void Main(string[] args)
//        {
//            //Task: Use BitArray to track which seats (1,000 seats) in a theater are booked.


//            BitArray seats = new BitArray(1000);
//            seats[100] = true; // Seat 101 booked

//            for   (int i = 0; i < 750; i++)
//            {
//                seats[i] = true;
//            }
//            for (int i = 0; i < seats.Length; i++)
//            {
//                Console.WriteLine($"seat {i + 1}: {seats[i]}");
//            }

//            Console.WriteLine($"Seat 101 booked: {seats[100]}"); // Output: True
//        }
//    }
//}
