//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linear_Search_Implementation_In_C_.Trees_Problems__12_
//{
//    internal class Category_Hierarchy
//    {
//        public class Category_Hierarchytree
//        {
        
//        public string Name;
//        public List<Category_Hierarchytree> Children;
//        public Category_Hierarchytree Parent;

//            public Category_Hierarchytree(string name)
//            {
//                Name = name;
//                Children = new List<Category_Hierarchytree>();
//                Parent = null;
//            }
//            public void AddChild(Category_Hierarchytree child)
//            {
//                Children.Add(child);
//                child.Parent = this;
        
//            }
//            public void RemoveChild(Category_Hierarchytree child)
//            {
//                Children.Remove(child);
//                child.Parent = null;
//            }
//            public void PrintTree(int level = 0)
//            {
//                Console.WriteLine(new string('-', level) + Name);
//                foreach (var child in Children)
//                {
//                    child.PrintTree(level + 1);
//                }
//            }
           


//        }




//        public static void Main(string[] args)
//        { 
//            var tree = new Category_Hierarchytree("Electronics");
//            var phone12 = new Category_Hierarchytree("phone12");
//            var phone = new Category_Hierarchytree("phone");
//            var laptop = new Category_Hierarchytree("laptop");
//            var pc = new Category_Hierarchytree("pc");
//            tree.AddChild(phone12);
//            tree.AddChild(phone);
//            tree.AddChild(laptop);
//            tree.AddChild(pc);

//            var carsroot = new Category_Hierarchytree("Cars");
//            var Bmw12 = new Category_Hierarchytree("Bmw12");
//            var ccv = new Category_Hierarchytree("ccv");
//            var vw = new Category_Hierarchytree("vw");
//            var c200 = new Category_Hierarchytree("c200");
//            carsroot.AddChild(Bmw12);
//            carsroot.AddChild(ccv);
//            carsroot.AddChild(vw);
//            carsroot.AddChild(c200);

//            carsroot.PrintTree();

//            tree.PrintTree();



//        }
//    }
//}
