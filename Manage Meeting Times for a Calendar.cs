//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linear_Search_Implementation_In_C_.Hash_Table_SortedList__SortedSet_Problems__13_
//{
//    internal class Manage_Meeting_Times_for_a_Calendar
//    {
//        public class MeetingTimes : IComparable<MeetingTimes>
//        {
//            public string EventName { get; set; }
//            public DateTime StartTime { get; set; }
//            public DateTime EndTime { get; set; }

//            public int CompareTo(MeetingTimes? obj)
//            {
//                return this.StartTime.CompareTo(obj?.StartTime);
//            }

//            public override string ToString()
//            {
//                return $"Event Name: {EventName}, Start Time: {StartTime}, End Time: {EndTime}";
//            }

//            public MeetingTimes(string eventName, DateTime startTime, DateTime endTime)
//            {
//                EventName = eventName;
//                StartTime = startTime;
//            }
//        }
//        public static void Main(string[] args)
//        {
//            SortedSet<MeetingTimes> eventTimelines = new SortedSet<MeetingTimes>();
//            eventTimelines.Add(new MeetingTimes("Event 1", new DateTime(2026, 1, 1, 9, 0, 0), new DateTime(2027, 1, 1, 10, 0, 0)));
//            eventTimelines.Add(new MeetingTimes("Event 2", new DateTime(2024, 1, 1, 9, 0, 0), new DateTime(2027, 1, 1, 10, 0, 0)));
//            eventTimelines.Add(new MeetingTimes("Event 3", new DateTime(2023, 1, 1, 9, 0, 0), new DateTime(2027, 1, 1, 10, 0, 0)));
//            foreach  (MeetingTimes eventTimeline in eventTimelines)
//            {
               
//                    Console.WriteLine(eventTimeline);
                
//            }

//        }
//    }
//}
