//using System;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.Collections.Specialized;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linear_Search_Implementation_In_C_.Observable_Collection_Problems
//{
//    internal class Task_Management_System
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Task Management System");
//            ObservableCollection<string> Task = new ObservableCollection<string>();
//            Task.Add("Task 1");
//            Task.Add("Task 2");
//            Task.Add("Task 3");
//            Task.Add("Task 4");
//            Task.Add("Task 5");
//            Task.CollectionChanged += (sender, e) =>

//            {
//                if (e.Action == NotifyCollectionChangedAction.Add)
//                    Console.WriteLine($"Task add: {e.NewItems[0]}");
//                if (e.Action == NotifyCollectionChangedAction.Remove)
//                    Console.WriteLine($"Task removed: {e.OldItems[0]}");
//                if (e.Action == NotifyCollectionChangedAction.Replace)
//                    Console.WriteLine($"Task Replace: {e.OldItems[0]} -> {e.NewItems[0]}");


//            };
//            Task.Remove("Task 5");
//            Task.Add("Task 4"); Task.Add("Task 4");
//            string stockNameToUpdate = "Task 4"; 
                  

//            // نبحث عن العنصر المطلوب
//            for (int i = 0; i < Task.Count; i++)
//            {
//                if (Task[i] == stockNameToUpdate)
//                {
//                    // نحدث العنصر (نعمل Tuple جديد)
//                    Task[i] = "Task";
//                    break; // نوقف بعد أول تحديث
//                }
//            }


//        }
//    }
//}
