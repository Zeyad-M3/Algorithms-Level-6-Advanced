//using System;

//class AVLNode
//{
//    public int Value { get; set; }
//    public AVLNode Left { get; set; }
//    public AVLNode Right { get; set; }
//    public int Height { get; set; }

//    public AVLNode(int value)
//    {
//        Value = value;
//        Height = 1; // New node is a leaf, so height is 1
//    }
//}

//class AVLTree
//{
//    private AVLNode root;

//    // Public method to insert a value into the AVL tree
//    public void Insert(int value)
//    {
//        Console.WriteLine($"\nInserting value: {value}");
//        root = Insert(root, value);
//        Console.WriteLine("Tree after insertion:");
//        PrintTree();
//    }

//    // Recursive method to insert a value and balance the tree
//    private AVLNode Insert(AVLNode node, int value)
//    {
//        // Base case: If node is null, create a new node
//        if (node == null)
//        {
//            Console.WriteLine($"Creating new node with value: {value}");
//            return new AVLNode(value);
//        }

//        // Insert into left or right subtree based on value
//        if (value < node.Value)
//        {
//            Console.WriteLine($"Value {value} < {node.Value}, inserting into left subtree");
//            node.Left = Insert(node.Left, value);
//        }
//        else if (value > node.Value)
//        {
//            Console.WriteLine($"Value {value} > {node.Value}, inserting into right subtree");
//            node.Right = Insert(node.Right, value);
//        }
//        else
//        {
//            Console.WriteLine($"Duplicate value {value} found, ignoring");
//            return node; // Duplicate values are not allowed
//        }

//        // Update height of current node
//        UpdateHeight(node);

//        // Check balance factor and balance the tree if needed
//        return Balance(node);
//    }

//    // Updates the height of a node based on the maximum height of its children
//    private void UpdateHeight(AVLNode node)
//    {
//        int leftHeight = Height(node.Left);
//        int rightHeight = Height(node.Right);
//        node.Height = 1 + Math.Max(leftHeight, rightHeight);
//        Console.WriteLine($"Updated height of node {node.Value}: {node.Height} (Left: {leftHeight}, Right: {rightHeight})");
//    }

//    // Returns the height of a node (0 if null)
//    private int Height(AVLNode node)
//    {
//        return node != null ? node.Height : 0;
//    }

//    // Calculates the balance factor of a node (Height of left subtree - Height of right subtree)
//    private int GetBalanceFactor(AVLNode node)
//    {
//        if (node == null) return 0;
//        int balanceFactor = Height(node.Left) - Height(node.Right);
//        Console.WriteLine($"Balance factor of node {node.Value}: {balanceFactor}");
//        return balanceFactor;
//    }

//    // Balances the tree if the balance factor is > 1 or < -1
//    private AVLNode Balance(AVLNode node)
//    {
//        int balanceFactor = GetBalanceFactor(node);

//        // Left Heavy (LL or LR case)
//        if (balanceFactor > 1)
//        {
//            Console.WriteLine($"Node {node.Value} is left-heavy (Balance Factor = {balanceFactor})");
//            // LL Case: Left child is left-heavy or balanced
//            if (GetBalanceFactor(node.Left) >= 0)
//            {
//                Console.WriteLine("Performing Right Rotation (LL Case)");
//                return RightRotate(node);
//            }
//            // LR Case: Left child is right-heavy
//            else
//            {
//                Console.WriteLine("Performing Left-Right Rotation (LR Case)");
//                node.Left = LeftRotate(node.Left);
//                return RightRotate(node);
//            }
//        }

//        // Right Heavy (RR or RL case)
//        if (balanceFactor < -1)
//        {
//            Console.WriteLine($"Node {node.Value} is right-heavy (Balance Factor = {balanceFactor})");
//            // RR Case: Right child is right-heavy or balanced
//            if (GetBalanceFactor(node.Right) <= 0)
//            {
//                Console.WriteLine("Performing Left Rotation (RR Case)");
//                return LeftRotate(node);
//            }
//            // RL Case: Right child is left-heavy
//            else
//            {
//                Console.WriteLine("Performing Right-Left Rotation (RL Case)");
//                node.Right = RightRotate(node.Right);
//                return LeftRotate(node);
//            }
//        }

//        // Node is balanced, no rotation needed
//        return node;
//    }

//    // Performs a right rotation on the given node
//    private AVLNode RightRotate(AVLNode originalRoot)
//    {
//        Console.WriteLine($"Right Rotation on node {originalRoot.Value}");
//        AVLNode newRoot = originalRoot.Left;
//        AVLNode originalRightChild = newRoot.Right;

//        newRoot.Right = originalRoot;
//        originalRoot.Left = originalRightChild;

//        UpdateHeight(originalRoot);
//        UpdateHeight(newRoot);

//        return newRoot;
//    }

//    // Performs a left rotation on the given node
//    private AVLNode LeftRotate(AVLNode originalRoot)
//    {
//        Console.WriteLine($"Left Rotation on node {originalRoot.Value}");
//        AVLNode newRoot = originalRoot.Right;
//        AVLNode originalLeftChild = newRoot.Left;

//        newRoot.Left = originalRoot;
//        originalRoot.Right = originalLeftChild;

//        UpdateHeight(originalRoot);
//        UpdateHeight(newRoot);

//        return newRoot;
//    }

//    // Prints the tree structure
//    public void PrintTree()
//    {
//        PrintTree(root, "", true);
//    }

//    private void PrintTree(AVLNode node, string indent, bool last)
//    {
//        if (node != null)
//        {
//            Console.Write(indent);
//            if (last)
//            {
//                Console.Write("R----");
//                indent += "     ";
//            }
//            else
//            {
//                Console.Write("L----");
//                indent += "|    ";
//            }
//            Console.WriteLine($"{node.Value} (Height: {node.Height}, BF: {GetBalanceFactor(node)})");
//            PrintTree(node.Left, indent, false);
//            PrintTree(node.Right, indent, true);
//        }
//    }

//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        AVLTree tree = new AVLTree();

//        // Test case: Insert values to trigger different rotation cases
//        //int[] values = { 30, 20, 10 }; // Triggers LL rotation
//        //int[] values = { 10, 20, 30 }; // Triggers RR rotation
//        //int[] values = { 30, 10, 20 }; // Triggers LR rotation
//        int[] values = { 10, 30, 20 }; // Triggers RL rotation

//        foreach (var value in values)
//        {
//            tree.Insert(value);
//            Console.WriteLine("\n-------------------------------------------------\n");
//        }

//        Console.WriteLine("Final AVL Tree:");
//        tree.PrintTree();
//        Console.ReadKey();
//    }
//}