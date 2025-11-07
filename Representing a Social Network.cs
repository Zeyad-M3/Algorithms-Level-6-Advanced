//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linear_Search_Implementation_In_C_.Trees_Problems__12_
//{
//    internal class Representing_a_Social_Network
//    {
//        public class Node
//        {
//            public string name;
//            public List<Node> connections;
//            public Node(string name)
//            {
//                this.name = name;
//                this.connections = new List<Node>();
//            }
//            // print the tree
//            public override string ToString()
//            {
//                return name;
//            }

//            public static void Main(string[] args)
//            {
//                var alice = new Node("Alice");
//                var bob = new Node("Bob");
//                var charlie = new Node("Charlie");
//                var david = new Node("David");
//                david.connections.Add(alice);
//                var emma = new Node("Emma");
//                emma.connections.Add(bob);
//                emma.connections.Add(charlie);
//                var frank = new Node("Frank");
//                frank.connections.Add(david);
//                bob.connections.Add(emma);
//                bob.connections.Add(frank);
//                // print the social network
//                Console.WriteLine("Social Network:");
//                foreach (var node in emma.connections)
//                {
//                    Console.WriteLine(node.ToString());
//                }

               
                
                    

//             }  
//        }
//    }
//}

