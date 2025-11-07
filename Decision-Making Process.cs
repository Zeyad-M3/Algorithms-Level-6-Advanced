//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linear_Search_Implementation_In_C_.Trees_Problems__12_
//{
//    internal class Decision_Making_Process
//    {
//        // Create a decision tree for a simple yes/no quiz to recommend a type of pet based on answers to questions.


//        public static string GetPetRecommendation(bool hasFriends, bool likesCats, bool likesDogs)
//        {
//            if (hasFriends && likesCats)
//            {
//                return "A cat";
//            }
//            else if (hasFriends && likesDogs)
//            {
//                return "A dog";
//            }
//            else if (!hasFriends && likesCats)
//            {
//                return "A rabbit";
//            }
//            else if (!hasFriends && likesDogs)
//            {
//                return "A hamster";
//            }
//            else
//            {
//                return "No recommendation";
//            }
//        }
//        public static void Main(string[] args)
//        { 
//            Console.WriteLine(GetPetRecommendation(true, true, true));
//            Console.WriteLine(GetPetRecommendation(false, true, true));
//        }
//    }
//}
