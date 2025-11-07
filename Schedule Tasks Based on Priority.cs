//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linear_Search_Implementation_In_C_.Hash_Table_SortedList__SortedSet_Problems__13_
//{
//    internal class Schedule_Tasks_Based_on_Priority
//    {
//        public class Task :  IComparable<Task>
//        {
//            public string Name;
//            public int Priority;

//            public Task(string name, int priority)
//            {
//                Name = name;
//                Priority = priority;
//            }
//            public override string ToString()
//            {
//                return $"Name: {Name}, Priority: {Priority}";
//            }
//            public int CompareTo(Task? other)
//            {
//                if (other == null)
//                    return 1;
//                return Priority.CompareTo(other.Priority);
//            }
//        }
//        public static void Main(string[] args)
//        {
//            SortedSet<Task> tasks = new SortedSet<Task>();
//            tasks.Add(new Task("Task 1", 3));
//            tasks.Add(new Task("Task 2", 2));
//            tasks.Add(new Task("Task 3", 1));
//            tasks.Add(new Task("Task 4", 4));

          
//            foreach  (var task in tasks)
//            {
//                Console.WriteLine(task);
//            }
            

//        }
//    }
//}
