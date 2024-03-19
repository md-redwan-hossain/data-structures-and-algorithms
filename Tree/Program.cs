using Tree;

/*
       2
      / \
     7   9
    / \   \
   1   6   8
      / \ / \
     5  10 3 4
 */


var bTree = new BinaryTree<int>();

// level zero (root)
var two = bTree.CreateNode(2);

// level one
var seven = bTree.CreateNode(7);
var nine = bTree.CreateNode(9);
bTree.AddLeftChild(two, seven);
bTree.AddRightChild(two, nine);


// level two
var one = bTree.CreateNode(1);
var six = bTree.CreateNode(6);
var eight = bTree.CreateNode(8);
bTree.AddLeftChild(seven, one);
bTree.AddRightChild(seven, six);
bTree.AddRightChild(nine, eight);


// level three (leaf)
var three = bTree.CreateNode(3);
var four = bTree.CreateNode(4);
var five = bTree.CreateNode(5);
var ten = bTree.CreateNode(10);
bTree.AddLeftChild(six, five);
bTree.AddRightChild(six, ten);
bTree.AddLeftChild(eight, three);
bTree.AddRightChild(eight, four);

foreach (var data in bTree.PreOrderTraverse(two, []))
{
    Console.Write($"{data} ");
}

Console.WriteLine();

foreach (var data in bTree.PostOrderTraverse(two, []))
{
    Console.Write($"{data} ");
}

Console.WriteLine();

foreach (var data in bTree.InOrderTraverse(two, []))
{
    Console.Write($"{data} ");
}

Console.WriteLine();