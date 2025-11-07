//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Collections.ObjectModel;
//using System.Collections.Specialized;
//namespace Linear_Search_Implementation_In_C_.Observable_Collection_Problems
//{
//    internal class Live_Chat_Application
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Live Chat Application");
//            ObservableCollection<string> NotificationSystem = new ObservableCollection<string>();
//            NotificationSystem.CollectionChanged += (sender, e) =>
//            {
//                if (e.Action == NotifyCollectionChangedAction.Add)
//                    Console.WriteLine($"New Order arrive: {e.NewItems[0]}");
//            };
//            NotificationSystem.Add("new Order 12");
//            NotificationSystem.Add("new Order Phone");
//            NotificationSystem.Add("new Order Phone.");
//            NotificationSystem.Add("What about you?");
//            NotificationSystem.Add("I'm good, thanks.");

//        }
//    }
//}
