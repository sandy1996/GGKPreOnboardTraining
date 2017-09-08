using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
        public int item;
        public Node left;
        public Node right;
       
    }
    class Tree
    {
        public Node root;
        public Tree()
        {
            root = null;
        }
        public Node ReturnRoot()
        {
            return root;
        }
        public void Insert(int id)
        {
            Node newNode = new Node();
            newNode.item = id;
            if (root == null)
                root = newNode;
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (id < current.item)
                    {
                        current = current.left;
                        if (current == null)
                        {
                            parent.left = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.right;
                        if (current == null)
                        {
                            parent.right = newNode;
                            return;
                        }
                    }
                }
            }
        }
        public void Inorder(Node Root, List<int> l)
        {
            if (Root != null)
            {
                Inorder(Root.left, l);
                l.Add(Root.item);
                Inorder(Root.right, l);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            List<int> list1 = new List<int>();
            Tree BST = new Tree();
             int choice = 0;
           
            bool result;
            int search_node,insert_node;
            while (choice <=4 )
            {
                Console.WriteLine("enter your option: \n 1.isert \n 2.ascending order \n 3.descending order \n 4.search ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1://insertion;
                        Console.WriteLine("enter no.of nodes:");
                        int no_of_nodes = int.Parse(Console.ReadLine());
                        for (int i = 0; i < no_of_nodes; i++)
                        {
                            Console.WriteLine("insert node:");
                            insert_node = int.Parse(Console.ReadLine());
                            BST.Inorder(BST.ReturnRoot(), list);
                            result = list.Contains(insert_node);//duplicate nodes
                            if (result == true)
                                Console.WriteLine("already present :" + insert_node);
                            else
                            BST.Insert(insert_node);
                        }
                        break;
                    case 2:
                        //ascending order
                        list.Clear();
                        BST.Inorder(BST.ReturnRoot(), list);
                        for (int j = 0; j < list.Count; ++j)
                        {
                            Console.Write(list[j]+ "\t");
                        }
                        Console.WriteLine();
                        break;
                    case 3:
                        //descending order
                        list.Clear();
                        BST.Inorder(BST.ReturnRoot(), list);
                        list1 = list;
                        list1.Reverse();
                        for (int j = 0; j < list1.Count; ++j)
                        {
                            Console.Write(list1[j] + "\t");
                        }
                        Console.WriteLine();
                        break;
                    case 4:
                        //search node

                        Console.WriteLine("enter the node to be searched");
                        search_node = int.Parse(Console.ReadLine());
                        BST.Inorder(BST.ReturnRoot(), list);
                        result = list.Contains(search_node);
                        if (result == true)
                            Console.WriteLine("found" + search_node);
                        else
                            Console.WriteLine("not found");
                        break;

                    default:
                        Console.WriteLine("invalid choice");
                        break;
                }
            }
           
            Console.ReadKey();

        }


    }
}