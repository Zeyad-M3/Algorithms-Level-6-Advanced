//using System;

//class RedBlackTree
//{
//    private Node root;

//    // Node class for Red-Black Tree
//    private class Node
//    {
//        public int Value;
//        public Node Left, Right, Parent;
//        public bool IsRed = true; // New nodes are red by default

//        public Node(int value)
//        {
//            Value = value;
//        }
//    }

//    // Public method to insert a value
//    public void Insert(int newValue)
//    {
//        Console.WriteLine($"\n=== INSERTING {newValue} ===");
//        Node newNode = new Node(newValue);

//        // Case: Empty tree
//        if (root == null)
//        {
//            root = newNode;
//            root.IsRed = false;
//            Console.WriteLine($"Root created: {newValue} (BLACK)");
//            PrintTree();
//            return;
//        }

//        // BST Insertion
//        Node current = root;
//        Node parent = null;

//        Console.WriteLine("Performing BST insertion...");
//        while (current != null)
//        {
//            parent = current;
//            if (newValue < current.Value)
//            {
//                Console.WriteLine($"  → {newValue} < {current.Value}, go LEFT");
//                current = current.Left;
//            }
//            else
//            {
//                Console.WriteLine($"  → {newValue} >= {current.Value}, go RIGHT");
//                current = current.Right;
//            }
//        }

//        // Attach new node
//        newNode.Parent = parent;
//        if (newValue < parent.Value)
//        {
//            parent.Left = newNode;
//            Console.WriteLine($"  → Attached {newValue} as LEFT child of {parent.Value}");
//        }
//        else
//        {
//            parent.Right = newNode;
//            Console.WriteLine($"  → Attached {newValue} as RIGHT child of {parent.Value}");
//        }

//        Console.WriteLine("BST insertion complete. Starting FixInsert...\n");
//        FixInsert(newNode);

//        Console.WriteLine($"=== INSERTION OF {newValue} COMPLETE ===");
//        PrintTree();
//        Console.WriteLine("------------------------------------------\n");
//    }

//    // Fix Red-Black properties after insertion
//    private void FixInsert(Node node)
//    {
//        Console.WriteLine($"FixInsert started for node: {node.Value} (RED)");

//        while (node != root && node.IsRed && node.Parent.IsRed)
//        {
//            Node parent = node.Parent;
//            Node grandparent = parent.Parent;
//            Node uncle = (parent == grandparent.Left) ? grandparent.Right : grandparent.Left;

//            Console.WriteLine($"\n--- Fix Loop ---");
//            Console.WriteLine($"  Node: {node.Value} (RED)");
//            Console.WriteLine($"  Parent: {parent.Value} ({(parent.IsRed ? "RED" : "BLACK")})");
//            Console.WriteLine($"  Grandparent: {grandparent.Value} ({(grandparent.IsRed ? "RED" : "BLACK")})");
//            Console.WriteLine($"  Uncle: {(uncle != null ? uncle.Value.ToString() : "NULL")} ({(uncle != null && uncle.IsRed ? "RED" : "BLACK")})");

//            if (parent == grandparent.Left)
//            {
//                // === LEFT SIDE CASES ===

//                if (uncle != null && uncle.IsRed)
//                {
//                    // Case 1: Uncle is RED → Recolor
//                    Console.WriteLine("  → CASE 1: Uncle is RED → Recolor");
//                    grandparent.IsRed = true;
//                    parent.IsRed = false;
//                    uncle.IsRed = false;
//                    Console.WriteLine($"    → Grandparent {grandparent.Value} → RED");
//                    Console.WriteLine($"    → Parent {parent.Value} → BLACK");
//                    Console.WriteLine($"    → Uncle {uncle.Value} → BLACK");
//                    node = grandparent;
//                }
//                else
//                {
//                    if (node == parent.Right)
//                    {
//                        // Case 2: Triangle → Rotate Left on Parent
//                        Console.WriteLine("  → CASE 2: Triangle (node is right child) → LEFT ROTATION on parent");
//                        RotateLeft(parent);
//                        node = parent;
//                        parent = node.Parent;
//                    }

//                    // Case 3: Line → Rotate Right on Grandparent
//                    Console.WriteLine("  → CASE 3: Line → RIGHT ROTATION on grandparent");
//                    RotateRight(grandparent);
//                    Console.WriteLine($"    → Swapping colors: Parent {parent.Value} ↔ Grandparent {grandparent.Value}");
//                    bool temp = parent.IsRed;
//                    parent.IsRed = grandparent.IsRed;
//                    grandparent.IsRed = temp;
//                    node = parent;
//                }
//            }
//            else
//            {
//                // === RIGHT SIDE CASES ===

//                if (uncle != null && uncle.IsRed)
//                {
//                    // Case 1: Uncle is RED → Recolor
//                    Console.WriteLine("  → CASE 1: Uncle is RED → Recolor");
//                    grandparent.IsRed = true;
//                    parent.IsRed = false;
//                    uncle.IsRed = false;
//                    Console.WriteLine($"    → Grandparent {grandparent.Value} → RED");
//                    Console.WriteLine($"    → Parent {parent.Value} → BLACK");
//                    Console.WriteLine($"    → Uncle {uncle.Value} → BLACK");
//                    node = grandparent;
//                }
//                else
//                {
//                    if (node == parent.Left)
//                    {
//                        // Case 2: Triangle → Rotate Right on Parent
//                        Console.WriteLine("  → CASE 2: Triangle (node is left child) → RIGHT ROTATION on parent");
//                        RotateRight(parent);
//                        node = parent;
//                        parent = node.Parent;
//                    }

//                    // Case 3: Line → Rotate Left on Grandparent
//                    Console.WriteLine("  → CASE 3: Line → LEFT ROTATION on grandparent");
//                    RotateLeft(grandparent);
//                    Console.WriteLine($"    → Swapping colors: Parent {parent.Value} ↔ Grandparent {grandparent.Value}");
//                    bool temp = parent.IsRed;
//                    parent.IsRed = grandparent.IsRed;
//                    grandparent.IsRed = temp;
//                    node = parent;
//                }
//            }
//        }

//        root.IsRed = false;
//        Console.WriteLine($"FixInsert complete. Root {root.Value} is BLACK.");
//    }

//    // Left Rotation
//    private void RotateLeft(Node node)
//    {
//        Console.WriteLine($"  → PERFORMING LEFT ROTATION on node {node.Value}");
//        Node right = node.Right;
//        node.Right = right.Left;
//        if (node.Right != null)
//            node.Right.Parent = node;

//        right.Parent = node.Parent;
//        if (node.Parent == null)
//            root = right;
//        else if (node == node.Parent.Left)
//            node.Parent.Left = right;
//        else
//            node.Parent.Right = right;

//        right.Left = node;
//        node.Parent = right;
//        Console.WriteLine($"    → New subtree root: {right.Value}");
//    }

//    // Right Rotation
//    private void RotateRight(Node node)
//    {
//        Console.WriteLine($"  → PERFORMING RIGHT ROTATION on node {node.Value}");
//        Node left = node.Left;
//        node.Left = left.Right;
//        if (node.Left != null)
//            node.Left.Parent = node;

//        left.Parent = node.Parent;
//        if (node.Parent == null)
//            root = left;
//        else if (node == node.Parent.Right)
//            node.Parent.Right = left;
//        else
//            node.Parent.Left = left;

//        left.Right = node;
//        node.Parent = left;
//        Console.WriteLine($"    → New subtree root: {left.Value}");
//    }

//    // Print the tree with color and structure
//    public void PrintTree()
//    {
//        Console.WriteLine("CURRENT TREE:");
//        PrintHelper(root, "", true);
//    }

//    private void PrintHelper(Node node, string indent, bool last)
//    {
//        if (node != null)
//        {
//            Console.Write(indent);
//            Console.Write(last ? "R----" : "L----");
//            string color = node.IsRed ? "RED" : "BLACK";
//            Console.WriteLine($"{node.Value} ({color})");
//            PrintHelper(node.Left, indent + (last ? "     " : "|    "), false);
//            PrintHelper(node.Right, indent + (last ? "     " : "|    "), true);
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        RedBlackTree rbTree = new RedBlackTree();

//        int[] values = { 10, 20, 30, 15, 25, 35, 5, 19 };

//        foreach (var value in values)
//        {
//            rbTree.Insert(value);
//        }

//        Console.WriteLine("Final Tree:");
//        rbTree.PrintTree();
//        Console.ReadKey();
//    }
//}