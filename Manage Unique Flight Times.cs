//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linear_Search_Implementation_In_C_.Hash_Table_SortedList__SortedSet_Problems__13_
//{
//    internal class Manage_Unique_Flight_Times
//    {
//        public class FlightTime : IComparable<FlightTime>
//        {
//            public string FlightNumber { get; set; }
//            public DateTime DepartureTime { get; set; }
//            public DateTime ArrivalTime { get; set; }
//            // constractor
//            public FlightTime(string flightNumber, DateTime departureTime, DateTime arrivalTime)
//            {
//                FlightNumber = flightNumber;
//                DepartureTime = departureTime;
//                ArrivalTime = arrivalTime;
//            }

//            public int CompareTo(FlightTime? other)
//            {
//                if (other == null)
//                {
//                    return 1;
//                }

//                int compareResult = this.DepartureTime.CompareTo(other.DepartureTime);
//                if (compareResult != 0)
//                {
//                    return compareResult;
//                }

//                return this.ArrivalTime.CompareTo(other.ArrivalTime);
//            }
//            public override string ToString()
//            {
//                return $"{this.FlightNumber} - T->{this.DepartureTime} - T->{this.ArrivalTime}";
//            }

//        }
//        public static void Main(string[] args)
//        {
//            SortedSet<FlightTime> flightTimes = new SortedSet<FlightTime>();
//            flightTimes.Add(new FlightTime("Flight 1", new DateTime(2023, 5, 1, 9, 0, 0), new DateTime(2023, 5, 1, 10, 0, 0)));
//            flightTimes.Add(new FlightTime("Flight 2", new DateTime(2023, 5, 1, 10, 0, 0), new DateTime(2023, 5, 1, 11, 0, 0)));
//            flightTimes.Add(new FlightTime("Flight 3", new DateTime(2025, 5, 1, 10, 0, 0), new DateTime(2025, 5, 1, 11, 0, 0)));
//            foreach  (var t in flightTimes)
//                Console.WriteLine(t);

//        }
//    }
//}
