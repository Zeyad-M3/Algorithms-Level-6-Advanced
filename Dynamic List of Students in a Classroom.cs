//using System;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.Collections.Specialized;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linear_Search_Implementation_In_C_.Observable_Collection_Problems
//{
//    internal class Dynamic_List_of_Students_in_a_Classroom
//    {
//        public static void Main(string[] args)
//        { 
            
//            ObservableCollection<string> studentsObservableCollection = new ObservableCollection<string>();
            
//            studentsObservableCollection.CollectionChanged += Names_CollectionChanged;


//            studentsObservableCollection.Add("John");
//            studentsObservableCollection.Add("Mike");
//            studentsObservableCollection.Add("Jane");
//            studentsObservableCollection.Add("Sue");
//            studentsObservableCollection.Add("Bob");
//            studentsObservableCollection.Add("Mary");
//            studentsObservableCollection.Add("Tom");
//            studentsObservableCollection.Remove("Tom");
//            var index = studentsObservableCollection.IndexOf("Jane");
//            if (index != -1)
//            {
//                studentsObservableCollection[index] = "Jenny";
//            }

//            static void Names_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
//        {
//            Console.WriteLine($"Collection changed: {e.Action}");
//        }


//    }
//    }
//}
