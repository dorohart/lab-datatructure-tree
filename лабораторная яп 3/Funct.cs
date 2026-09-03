using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лабораторная_яп_3
{
    public class DTreeNode // Класс «Узел дихотомического дерева»
    {
        private string info; // информационное поле
        private int key; // поле ключа
        private DTreeNode left; // ссылка на левое поддерево
        private DTreeNode right; // ссылка на правое поддерево
        public string Info { get; set; } // свойства
        public int Key { get; set; }
        public DTreeNode Left { get; set; }
        public DTreeNode Right { get; set; }
        public DTreeNode() { } // конструкторы
        public DTreeNode(string info, int key)
        {
            Info = info; Key = key;
        }
        public DTreeNode(string info, int key, DTreeNode left, DTreeNode right)
        {
            Info = info; Key = key; Left = left; Right = right;
        }
    }
    public class DichotomyTree // класс «Дихотомическое дерево»
    {
        private DTreeNode root; // ссылка на корень дихотомического дерева
        public DTreeNode Root // свойство, открывающее доступ к корню дерева
        {
            get { return root; }
            set { root = value; }
        }
        public DichotomyTree() // инициалиазция пустого дерева
        {
            root = null;
        }
        public void Destruct()
        {
            if (root != null) root = null;
        }
        public void Add(string info, int key)
        {
            Root = AddNode(Root, info, key);
        }
        private DTreeNode AddNode(DTreeNode node, string info, int key)
        {
            if (node == null) node = new DTreeNode(info, key);
            else
            {
                if (key < node.Key) node.Left = AddNode(node.Left, info, key);
                else if (key > node.Key) node.Right = AddNode(node.Right, info, key);
                else MessageBox.Show("Узел с указанным ключом уже существует!");
            }
            return node;
        }
        public DTreeNode Del(DTreeNode root, int k)
        {
            if (root != null)
            {
                DTreeNode p, q;
                if (k < root.Key) root.Left = Del(root.Left, k); // поиск в левом поддереве
                else if (k > root.Key) root.Right = Del(root.Right, k); // поиск в правом поддереве
                else // узел для удаления найден
                {
                    if (root.Left == null) root = root.Right; // случай с одним потомком (правым)
                    else if (root.Right == null) root = root.Left; // случай с одним потомком (левым)
                    else // у узла два потомка
                    {
                        p = root;
                        q = root.Left;
                        // поиск самого правого узла в левом поддереве
                        while (q.Right != null)
                        {
                            p = q;
                            q = q.Right;
                        }
                        // копируем данные из q в root
                        root.Key = q.Key;
                        root.Info = q.Info;
                        // перестраиваем связи
                        if (p == root) root.Left = q.Left;
                        else p.Right = q.Left;
                    }
                }
            }
            return root;
        }
        public DTreeNode KLP(DTreeNode root, DichotomyTree otherTree)
        {
            if (root != null && otherTree != null && otherTree.Root != null )
            {
                root.Left = KLP(root.Left, otherTree);
                root.Right = KLP(root.Right, otherTree);
                DTreeNode dtn = otherTree.Root;
                bool flag = false;
                DTreeNode foundNode = Find(otherTree.Root, root.Key);
                if (foundNode != null) root = Del(root, root.Key);
            }
            return root;
        }
        public DTreeNode Find(DTreeNode n, int key)
        {
            DTreeNode dtn;
            if (n == null) dtn = null;
            else
            {
                if (key < n.Key) dtn = Find(n.Left, key);
                else if (key > n.Key) dtn = Find(n.Right, key);
                else dtn = n;
            }
            return dtn;
        }
        public void DisplayInTreeView(TreeView treeView)
        {
            treeView.Nodes.Clear();
            if (Root != null)
            {
                TreeNode rootNode = new TreeNode($"{Root.Info} (Key: {Root.Key})");
                treeView.Nodes.Add(rootNode);
                AddTreeNodes(Root, rootNode);
            }
        }
        private void AddTreeNodes(DTreeNode sourceNode, TreeNode targetNode)
        {
            if (sourceNode.Left != null)
            {
                TreeNode leftNode = new TreeNode($"{sourceNode.Left.Info} (Key: {sourceNode.Left.Key})");
                targetNode.Nodes.Add(leftNode);
                AddTreeNodes(sourceNode.Left, leftNode);
            }
            if (sourceNode.Right != null)
            {
                TreeNode rightNode = new TreeNode($"{sourceNode.Right.Info} (Key: {sourceNode.Right.Key})");
                targetNode.Nodes.Add(rightNode);
                AddTreeNodes(sourceNode.Right, rightNode);
            }
        }
    }
}
