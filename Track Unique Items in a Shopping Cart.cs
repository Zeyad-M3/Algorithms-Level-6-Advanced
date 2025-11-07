//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linear_Search_Implementation_In_C_.Hash_Table_SortedList__SortedSet_Problems__13_
//{
//    internal class Track_Unique_Items_in_a_Shopping_Cart
//    {
//        public class Item : IComparable<Item> 
//        {
//            public string Name { get; set; }
//            public float Price { get; set; }
//            public int CompareTo(Item? obj)
//            {
//                return this.Name.CompareTo(obj?.Name);
//            }
//            public Item(string name, float price)
//            {
//                this.Name = name;
//                this.Price = price;
//            }
//            public override string ToString()
//            {
//                return $"{this.Name} - ${this.Price}";
//            }


//        }
//        public static void Main(string[] args)
//        {
//            SortedSet<Item> cart = new SortedSet<Item>();
//            cart.Add(new Item("Apple", 2));
//            cart.Add(new Item("Banana", 12));
//            cart.Add(new Item("Orange", 32));
//            cart.Add(new Item("Mango", 2));
//            foreach (Item item in cart)
//            {
//                Console.WriteLine(item);
//            }



//        }
//    }
//}
