using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct
{
    internal class program
    {
        static void Main(string[] args)
        {

            //  MyMapNode < string,string> myMapNode = new MyMapNode<string,string>(5);
            //  myMapNode.Add("0", "to");
            //  myMapNode.Add("1", "be");
            //  myMapNode.Add("2", "or");
            //  myMapNode.Add("3", "not");
            //  myMapNode.Add("4", "to");
            //  myMapNode.Add("5", "be");
            //  string hash5 = myMapNode.Get("5");
            // Console.WriteLine("5th hash value" + hash5);
            // string hash2 = myMapNode.Get("2");
            //Console.WriteLine("2nd hash value" + hash2);
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>(56);
            binarySearchTree.Insert(30);
            binarySearchTree.Insert(70);
            binarySearchTree.Insert(22);
            binarySearchTree.Insert(40);
            binarySearchTree.Insert(60);
            binarySearchTree.Insert(95);
            binarySearchTree.Insert(11);
            binarySearchTree.Insert(65);
            binarySearchTree.Insert(3);
            binarySearchTree.Insert(63);
            binarySearchTree.Insert(67);
            binarySearchTree.Display();
            binarySearchTree.GetSize();
            bool result = binarySearchTree.IfExits(67, binarySearchTree);
            Console.WriteLine(result);


        }
    }
}
