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
//            ObservableCollection<string> ChatMessages = new ObservableCollection<string>();
//            ChatMessages.CollectionChanged += (sender, e) =>
//            {
//                if (e.Action == NotifyCollectionChangedAction.Add)
//                    Console.WriteLine($"New Message: {e.NewItems[0]}");
//            };
//            ChatMessages.Add("Hello");
//            ChatMessages.Add("How are you?");
//            ChatMessages.Add("I'm fine, thank you.");
//            ChatMessages.Add("What about you?");
//            ChatMessages.Add("I'm good, thanks.");

//        }
//    }
//}
