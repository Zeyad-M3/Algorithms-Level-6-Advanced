//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linear_Search_Implementation_In_C_.Hash_Table_SortedList__SortedSet_Problems__13_
//{
//    internal class Organize_Movie_Showtimes
//    {

//        public class MovieShowtime : IComparable<MovieShowtime>
//        {
//            public string EventName { get; set; }
//            public DateTime StartTime { get; set; }
//            public DateTime EndTime { get; set; }
//            public MovieShowtime(string eventName, DateTime startTime, DateTime endTime)
//            {
//                EventName = eventName;
//                StartTime = startTime;
//                EndTime = endTime;
//            }
//            public int CompareTo(MovieShowtime? obj)
//            {
//                if (obj == null)
//                {
//                    return 1;
//                }
//                else if (StartTime.CompareTo(obj.StartTime) == 0)
//                    return EndTime.CompareTo(obj.EndTime);
//                return StartTime.CompareTo(obj.StartTime);
//            }
//            public override string ToString()
//            {
//                return $"Event Name: {EventName}, Start Time: {StartTime}, End Time: {EndTime}";
//            }

         
           

//        }

//        public static void Main(string[] args)
//        {
//            SortedSet<MovieShowtime> eventTimelines = new SortedSet<MovieShowtime>();
//            eventTimelines.Add(new MovieShowtime("Movie 1", new DateTime(2026, 1, 1, 9, 0, 0), new DateTime(2027, 1, 1, 10, 0, 0)));
//            eventTimelines.Add(new MovieShowtime("Movie 2", new DateTime(2025, 1, 1, 9, 0, 0), new DateTime(2027, 1, 1, 10, 0, 0)));
//            eventTimelines.Add(new MovieShowtime("Movie 3", new DateTime(2027, 1, 1, 9, 0, 0), new DateTime(2027, 1, 1, 10, 0, 0)));
//            foreach (MovieShowtime t in eventTimelines)
//                Console.WriteLine(t);
//            Console.ReadLine();

//        }
//    }
//}
