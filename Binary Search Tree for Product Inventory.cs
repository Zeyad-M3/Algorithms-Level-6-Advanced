//using BinarySearchTreeDemo;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linear_Search_Implementation_In_C_.Trees_Problems__12_
//{
//    internal class Binary_Search_Tree_for_Product_Inventory
//    {
//        public class BinarySearchTreeNode : IComparable<BinarySearchTreeNode>
//        {
           
//            public string Name { get; set; }
//            public string uniqueID { get; set; }
//            public BinarySearchTreeNode Left { get; set; }
//            public BinarySearchTreeNode Right { get; set; }

//            public BinarySearchTreeNode( string name, string uniqueID)
//            {
                
//                Left = null;
//                Right = null;
//                Name = name;
//                this.uniqueID = uniqueID;
//            }

//            int IComparable<BinarySearchTreeNode>.CompareTo(BinarySearchTreeNode? other)
//            {
//                return ((IComparable<BinarySearchTreeNode>)Left).CompareTo(other);
//            }
//        }

//        public class BinarySearchTree : IComparable<BinarySearchTreeNode>
//        {
//            public BinarySearchTreeNode Root { get; private set; }

//            public BinarySearchTree()
//            {
//                Root = null;
//            }

//            public void Insert(string Name, string uniqueID)
//            {
//                Root = Insert(Root, Name, uniqueID);
               
//            }

//            private BinarySearchTreeNode Insert(BinarySearchTreeNode node, string Name,string uniqueID)
//            {
//                if (node == null)
//                {
//                    return new BinarySearchTreeNode(Name,uniqueID);
//                }
//                else if (Name.CompareTo(node.Name) < 0)
//                {
//                    node.Left = Insert(node.Left, Name,uniqueID);
//                }
//                else if (Name.CompareTo(node.Name) > 0)
//                {
//                    node.Right = Insert(node.Right, Name,uniqueID);
//                }
//                return node;
                
                
//            }


//            public void InOrderTraversal()
//            {
//                InOrderTraversal(Root);
//                Console.WriteLine();
//            }

//            private void InOrderTraversal(BinarySearchTreeNode node)
//            {
//                if (node != null)
//                {
//                    InOrderTraversal(node.Left);
                  
//                    InOrderTraversal(node.Right);
//                }
//            }

//            public void PreOrderTraversal()
//            {
//                PreOrderTraversal(Root);
//                Console.WriteLine();
//            }

//            private void PreOrderTraversal(BinarySearchTreeNode node)
//            {
//                if (node != null)
//                {
        
//                    PreOrderTraversal(node.Left);
//                    PreOrderTraversal(node.Right);
//                }
//            }

//            public void PostOrderTraversal()
//            {
//                PostOrderTraversal(Root);
//                Console.WriteLine();
//            }

//            private void PostOrderTraversal(BinarySearchTreeNode node)
//            {
//                if (node != null)
//                {
//                    PostOrderTraversal(node.Left);
//                    PostOrderTraversal(node.Right);
                  
//                }
//            }

//            // Print the tree visually
//            public void PrintTree()
//            {
//                PrintTree(Root, 0);
//            }
//            // add serch for the tree
//            public bool Search(string value)
//            {
//                return Search(Root, value);
//            }
//            private bool Search(BinarySearchTreeNode root, string value)
//            {
//                if (root == null)
//                    return false;
//                if (root.Name.Equals(value))
//                    return true;
//                if (value.CompareTo(root.Name) < 0)
//                    return Search(root.Left, value);
//                else
//                    return Search(root.Right, value);
//            }


//            private void PrintTree(BinarySearchTreeNode root, int space)
//            {
//                int COUNT = 10;  // Distance between levels
//                if (root == null)
//                    return;

//                space += COUNT;
//                PrintTree(root.Right, space);

//                Console.WriteLine();
//                for (int i = COUNT; i < space; i++)
//                    Console.Write(" ");
//                Console.WriteLine(root.Name);
//                PrintTree(root.Left, space);
//            }

//            int IComparable<BinarySearchTreeNode>.CompareTo(BinarySearchTreeNode? other)
//            {
//                throw new NotImplementedException();
//            }
//        }
//        public static void Main(string[] args)
//        {
            
//            var tree = new BinarySearchTree();
//            tree.Insert("Phone12","!221s");
//            tree.Insert("Phone212", "3223s");
//            tree.Insert("lap3221", "dde33");
//            tree.Insert("pc4e", "3ddes");
//            tree.Insert("vga32", "fgs");
//            tree.Insert("monitor", "hjh");
//            // print the tree
//            tree.PrintTree();
//            Console.WriteLine();
//            Console.WriteLine(tree.Search("Phone12"));
//            Console.WriteLine();
//            Console.WriteLine(tree.Search("Phone212"));
//            Console.WriteLine();





//        }


//    }
    
//}
