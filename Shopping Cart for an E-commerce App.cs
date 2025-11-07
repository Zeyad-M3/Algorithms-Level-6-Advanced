//using System;
//using System.Collections.ObjectModel;
//using System.Collections.Specialized;

//class Program
//{
//    static void Main()
//    {
//        ObservableCollection<string> cart = new ObservableCollection<string>();
//        cart.CollectionChanged += (sender, e) =>
//        {
//            if (e.Action == NotifyCollectionChangedAction.Add)
//                Console.WriteLine($"Item Added to Cart: {e.NewItems[0]}");
//            if (e.Action == NotifyCollectionChangedAction.Remove)
//                Console.WriteLine($"Item Removed from Cart: {e.OldItems[0]}");
//            if (e.Action == NotifyCollectionChangedAction.Replace)
//                Console.WriteLine($"Item Replaced in Cart: {e.OldItems[0]} -> {e.NewItems[0]}");
//        };

//        cart.Add("Laptop");
//        cart.Add("Mouse");
//        cart.Remove("Mouse");

//        var index = cart.IndexOf("Mouse");
//        if (index != -1)
//        {
//            cart[index] = "phone";
//        }

//        // Output:
//        // Item Added to Cart: Laptop
//        // Item Added to Cart: Mouse
//        // Item Removed from Cart: Mouse
//        Console.ReadKey();
//    }
//}