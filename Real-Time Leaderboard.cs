//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linear_Search_Implementation_In_C_.Sorted_List_Problems__11_
//{
//    internal class Real_Time_Leaderboard
//    {
//        public static void Main(string[] args)
//        {
//            //Problem: Track players’ scores in a game, sorted by player names.
//            SortedSet<Tuple<string,int>> leaderboard = new SortedSet<Tuple<string, int >> ();
//            leaderboard.Add(new Tuple<string, int>("Player1", 100));
//            leaderboard.Add(new Tuple<string, int>("Player2", 43));
//            leaderboard.Add(new Tuple<string, int>("Player3", 55));
//            leaderboard.Add(new Tuple<string, int>("Player4", 89));
//            foreach
//                (var item in leaderboard)
//            {
//                if  (item.Item2 > 50)
//                {
//                    Console.WriteLine();
//                    Console.WriteLine("Your Score");
//                    Console.WriteLine($"{item.Item1} {item.Item2}");
//                }
//                else
//                {
//                    Console.WriteLine();
//                    Console.WriteLine("Not Eligible");
//                    Console.WriteLine($"{item.Item1} {item.Item2}");
//                }
//            }



//        }
//    }
//}
