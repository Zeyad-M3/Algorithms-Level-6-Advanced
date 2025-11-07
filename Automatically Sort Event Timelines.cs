//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linear_Search_Implementation_In_C_.Hash_Table_SortedList__SortedSet_Problems__13_
//{
//    internal class Automatically_Sort_Event_Timelines
//    {
//        class EventTimelines : IComparable
//            { 
//            public string EventName;
//            public DateTime StartTime;
//            public DateTime EndTime;
//            public EventTimelines(string eventName, DateTime startTime, DateTime endTime)
//            {
//                EventName = eventName;
//                StartTime = startTime;
//                EndTime = endTime;
//            }
//            public override string ToString()
//            {
//                return $"Event Name: {EventName}, Start Time: {StartTime}, End Time: {EndTime}";
//            }
//            public static void SortEventTimelines(List<EventTimelines> eventTimelines)
//            {
//                eventTimelines.Sort((x, y) => x.StartTime.CompareTo(y.StartTime));
//            }

//            public int CompareTo(object? obj)
//            {
               
//                return StartTime.CompareTo(((EventTimelines)obj).StartTime);
                
//            }
//        }
//        public static void Main(string[] args)
//        {
//            // Maintain a sorted timeline of events by their occurrence times to show the upcoming ones first.
//            SortedSet<EventTimelines> eventTimelines = new SortedSet<EventTimelines>();
//            eventTimelines.Add(new EventTimelines("Event 1", new DateTime(2022, 1, 1, 9, 0, 0), new DateTime(2027, 1, 1, 10, 0, 0)));
//            eventTimelines.Add(new EventTimelines("Event 2", new DateTime(2025, 1, 1, 9, 0, 0), new DateTime(2026, 1, 1, 10, 0, 0)));
//            eventTimelines.Add(new EventTimelines("Event 3", new DateTime(2024, 1, 1, 9, 0, 0), new DateTime(2028, 1, 1, 10, 0, 0)));

//            foreach (var eventTimeline in eventTimelines)
//                Console.WriteLine(eventTimeline);
//            Console.ReadLine();
        


//        }
//    }
//}
