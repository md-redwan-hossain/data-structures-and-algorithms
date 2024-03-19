namespace Tree;

public class BinaryTreeNode<T>
{
    public T? Data { get; set; }
    public BinaryTreeNode<T>? Left { get; set; }
    public BinaryTreeNode<T>? Right { get; set; }
}

public class BinaryTree<T>
{
    public BinaryTreeNode<T> CreateNode(T data)
    {
        return new BinaryTreeNode<T> { Data = data };
    }

    public void AddLeftChild(BinaryTreeNode<T> parent, BinaryTreeNode<T> child)
    {
        parent.Left = child;
    }

    public void AddRightChild(BinaryTreeNode<T> parent, BinaryTreeNode<T> child)
    {
        parent.Right = child;
    }

    public IList<T> PreOrderTraverse(BinaryTreeNode<T>? node, IList<T> storage)
    {
        if (node is null) return storage;
        if (node.Data is not null) storage.Add(node.Data);
        if (node.Left is not null) PreOrderTraverse(node.Left, storage);
        if (node.Right is not null) PreOrderTraverse(node.Right, storage);
        return storage;
    }


    public IList<T> PostOrderTraverse(BinaryTreeNode<T>? node, IList<T> storage)
    {
        if (node is null) return storage;
        if (node.Left is not null) PostOrderTraverse(node.Left, storage);
        if (node.Right is not null) PostOrderTraverse(node.Right, storage);
        if (node.Data is not null) storage.Add(node.Data);
        return storage;
    }

    public IList<T> InOrderTraverse(BinaryTreeNode<T>? node, IList<T> storage)
    {
        if (node is null) return storage;
        if (node.Left is not null) InOrderTraverse(node.Left, storage);
        if (node.Data is not null) storage.Add(node.Data);
        if (node.Right is not null) InOrderTraverse(node.Right, storage);
        return storage;
    }
}