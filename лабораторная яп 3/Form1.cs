namespace лабораторная_яп_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button_task.ContextMenuStrip = contextMenuStrip1;
            AppContext.MainForm = this;
        }
        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button_task_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(button_task, 30, button_task.Height);
        }
        private void button_info_Click(object sender, EventArgs e)
        {
            FormInfo info = new FormInfo();
            info.ShowDialog();
        }
        private void создание_CMS_Click(object sender, EventArgs e)
        {
            обработкаToolStripMenuItem.Enabled = true;
            разрушениеToolStripMenuItem.Enabled = true;
            созданиеToolStripMenuItem.Enabled = false;
            Create createForm = new Create();
            createForm.ShowDialog();
        }
        private void обработка_CMS_Click(object sender, EventArgs e)
        {
            AppContext.tree.KLP(AppContext.tree.Root, AppContext.tree_new);
            AppContext.tree.DisplayInTreeView(treeView1);
            AppContext.tree_new.DisplayInTreeView(treeView2);
            MessageBox.Show("Обработка по удалению из первого дерева узлов, поля ключей которых совпадают с полями ключей узлов второго дерева произведена!");
        }
        private void разрушение_CMS_Click(object sender, EventArgs e)
        {
            разрушениеToolStripMenuItem.Enabled = false;
            обработкаToolStripMenuItem.Enabled = false;
            созданиеToolStripMenuItem.Enabled = true;
            AppContext.tree_new.Destruct();
            AppContext.tree.Destruct();
            treeView1.Nodes.Clear();
            treeView2.Nodes.Clear();
            MessageBox.Show("Деревья успешно разрушены!");
        }
    }
}
