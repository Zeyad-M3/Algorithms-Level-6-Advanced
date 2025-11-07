//using DocumentFormat.OpenXml.Drawing;
//using System;

//namespace File_System_Organization
//{
//    public class DetermineifgivenTwoTreesareIdenticalornot

//    {
//        // عقدة الشجرة (كل ملف أو فولدر)
//        public class BinarySearchTreeNode : IComparable<BinarySearchTreeNode>
//        {
//            public string Name { get; set; }
//            public string File_Permission { get; set; }
//            public BinarySearchTreeNode Left { get; set; }
//            public BinarySearchTreeNode Right { get; set; }
//            public BinarySearchTreeNode Parent { get; set; }

//            public BinarySearchTreeNode(string name, string file_Permission = "")
//            {
//                Name = name;
//                File_Permission = file_Permission;
//                Left = null;
//                Right = null;
//                Parent = null;
//            }

//            public int CompareTo(BinarySearchTreeNode other)
//            {
//                return Name.CompareTo(other.Name);
//            }
//        }

//        // الكلاس الرئيسي للشجرة
//        public class BinarySearchTree
//        {
//            public BinarySearchTreeNode Root { get; private set; }

//            public BinarySearchTree()
//            {
//                Root = null;
//            }
//            // if given Two Trees are Identical 
//            public static bool IsIdentical(BinarySearchTreeNode root1, BinarySearchTreeNode root2)
//            {
//                // لو الاتنين null → متطابقين
//                if (root1 == null && root2 == null)
//                    return true;

//                // لو片 واحد null والتاني مش → مش متطابقين
//                if (root1 == null || root2 == null)
//                    return false;

//                // قارن القيم + الفروع اليمنى واليسرى
//                return (root1.Name == root2.Name &&
//                        root1.File_Permission == root2.File_Permission &&
//                        IsIdentical(root1.Left, root2.Left) &&
//                        IsIdentical(root1.Right, root2.Right));
//            }

//            public void Insert(string name, string file_Permission = "")
//            {
//                Root = Insert(Root, name, file_Permission, null);
//            }
//            // max  depth
//            public int MaxDepth(BinarySearchTreeNode node)
//            {
//                if (node == null)
//                    return 0;
//                else
//                {
//                    int leftDepth = MaxDepth(node.Left);
//                    int rightDepth = MaxDepth(node.Right);

//                    if (leftDepth > rightDepth)
//                        return leftDepth + 1;
//                    else
//                        return rightDepth + 1;
//                }
//            }

//            private BinarySearchTreeNode Insert(BinarySearchTreeNode node, string name, string file_Permission, BinarySearchTreeNode parent)
//            {
//                if (node == null)
//                {
//                    var newNode = new BinarySearchTreeNode(name, file_Permission);
//                    newNode.Parent = parent;

//                    // لو الصلاحية فاضية خذها من الأب (لو الأب موجود)
//                    if (string.IsNullOrEmpty(file_Permission) && parent != null)
//                        newNode.File_Permission = parent.File_Permission;

//                    return newNode;
//                }

//                if (name.CompareTo(node.Name) < 0)
//                    node.Left = Insert(node.Left, name, file_Permission, node);
//                else if (name.CompareTo(node.Name) > 0)
//                    node.Right = Insert(node.Right, name, file_Permission, node);
//                else
//                    Console.WriteLine($"⚠️ الملف '{name}' موجود بالفعل!");

//                return node;
//            }

//            public bool Search(string name)
//            {
//                return Search(Root, name);
//            }

//            private bool Search(BinarySearchTreeNode root, string name)
//            {
//                if (root == null)
//                    return false;
//                if (root.Name.Equals(name))
//                    return true;
//                if (name.CompareTo(root.Name) < 0)
//                    return Search(root.Left, name);
//                else
//                    return Search(root.Right, name);
//            }

//            public void PrintTree()
//            {
//                PrintTree(Root, 0);
//            }

//            private void PrintTree(BinarySearchTreeNode root, int space)
//            {
//                const int COUNT = 10;
//                if (root == null)
//                    return;

//                space += COUNT;
//                PrintTree(root.Right, space);

//                Console.WriteLine();
//                for (int i = COUNT; i < space; i++)
//                    Console.Write(" ");
//                Console.WriteLine($"{root.Name} -> {root.File_Permission}");

//                PrintTree(root.Left, space);
//            }
//        }

//        // دالة التشغيل الرئيسية
//        public static void Main(string[] args)
//        {
//            var tree = new BinarySearchTree();
//            tree.Insert("Folder5", "rwx");
//            tree.Insert("Folder2");
//            tree.Insert("Folder22");
//            tree.Insert("Folder12");
//            tree.Insert("Folder34", "e33");
//            tree.Insert("Folder3", "3wss");
//            tree.Insert("Folder6", "32ee"); // موجود بالفعل

//            var tree2 = new BinarySearchTree();
//            tree2.Insert("Folder5", "rwx");
//            tree2.Insert("Folder2");
//            tree2.Insert("Folder22");
//            tree2.Insert("Folder12");
//            tree2.Insert("Folder34", "e33");
//            tree2.Insert("Folder3", "3wss");
//            tree2.Insert("Folder6", "32ee"); // موجود بالفعل

//            var tree3 = new BinarySearchTree();
//            tree3.Insert("Folder5", "rwx");
//            tree3.Insert("Folder2");
//            tree3.Insert("Folder22");
//            tree3.Insert("Folder132");
//            tree3.Insert("Folder34", "e33");
//            tree3.Insert("Folder3", "3wss");
//            tree3.Insert("Folder6", "32ee"); // موجود بالفعل

//            Console.WriteLine("\nTree Structure:");
//            tree.PrintTree();

//            Console.WriteLine("\nSearching for Folder12:");
//            Console.WriteLine(tree.Search("Folder12") ? "✅ Found" : "❌ Not Found");
//            int k = tree.MaxDepth(tree.Root);
//            Console.WriteLine(
//                $"The maximum depth of the tree is: {k}"
//            );

//            bool identical = BinarySearchTree.IsIdentical(tree.Root, tree3.Root);
//            Console.WriteLine($"\nTrees identical? {identical}");



//            Console.ReadKey();
//        }
//    }
//}
