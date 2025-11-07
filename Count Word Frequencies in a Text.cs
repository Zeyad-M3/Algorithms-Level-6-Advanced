//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linear_Search_Implementation_In_C_.Dictionary___Hashset_Problems__20_
//{
//    public class Count_Word_Frequencies_in_a_Text
//    {
//        public static void Main(string[] args)
//        { 
//            string text = "This is a sample text. This text is a sample.";
//            Dictionary<string, int> wordFrequency = new Dictionary<string, int>();
//            StringBuilder word = new StringBuilder();
//            foreach (char c in text)
//            {
//                if (char.IsLetter(c))
//                {
//                    word.Append(c);
//                }
//                else
//                {
//                    if (word.Length > 0)
//                    {
//                        string wordString = word.ToString();
//                        if (wordFrequency.ContainsKey(wordString))
//                        {
//                            wordFrequency[wordString]++;
//                        }
//                        else
//                        {
//                            wordFrequency.Add(wordString, 1);
//                        }
//                        word.Clear();
//                    }
//                }
//            }
//            Console.WriteLine("Word Frequency:");
//            foreach (var entry in wordFrequency)
//            {
//                Console.WriteLine("{0}: {1}", entry.Key, entry.Value);
//            }
//        }
//    }
//}
