//using DocumentFormat.OpenXml.Spreadsheet;
//using Microsoft.VisualBasic;
//using System;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.Collections.Specialized;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linear_Search_Implementation_In_C_.Observable_Collection_Problems
//{
//    internal class Real_Time_Stock_Prices
//    {

//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Real-Time Stock Prices");
//            ObservableCollection<Tuple<string, int>> StockPrices = new ObservableCollection<Tuple<string, int>>();
//            StockPrices.CollectionChanged += (sender, e) =>

//            {
//                if (e.Action == NotifyCollectionChangedAction.Add)
//                    Console.WriteLine($"Weather : {e.NewItems[0]}");
//                if (e.Action == NotifyCollectionChangedAction.Remove)
//                    Console.WriteLine($"Weather Remove: {e.OldItems[0]}");
//                if (e.Action == NotifyCollectionChangedAction.Replace)
//                    Console.WriteLine($"Weather Updates: {e.OldItems[0]} -> {e.NewItems[0]}");


//            };
//            StockPrices.Add(new Tuple<string, int>("usa", 12));
//            StockPrices.Add(new Tuple<string, int>("egypt", 32));
//            StockPrices.Add(new Tuple<string, int>("uk", 21));
//            StockPrices.Add(new Tuple<string, int>("moroco", 33));

//            StockPrices.Add(new Tuple<string, int>("ksa", 43));


//            string stockNameToUpdate = "ksa";  // السهم اللي هنحدثه
//            int newPrice = 47;                // السعر الجديد

//            // نبحث عن العنصر المطلوب
//            for (int i = 0; i < StockPrices.Count; i++)
//            {
//                if (StockPrices[i].Item1 == stockNameToUpdate)
//                {
//                    // نحدث العنصر (نعمل Tuple جديد)
//                    StockPrices[i] = System.Tuple.Create(stockNameToUpdate, newPrice);
//                    break; // نوقف بعد أول تحديث
//                }
//            }








//        }
//    }
//}
