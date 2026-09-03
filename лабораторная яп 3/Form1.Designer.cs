namespace лабораторная_яп_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            contextMenuStrip1 = new ContextMenuStrip(components);
            созданиеToolStripMenuItem = new ToolStripMenuItem();
            обработкаToolStripMenuItem = new ToolStripMenuItem();
            разрушениеToolStripMenuItem = new ToolStripMenuItem();
            button_task = new Button();
            button_info = new Button();
            button_exit = new Button();
            treeView1 = new TreeView();
            treeView2 = new TreeView();
            label1 = new Label();
            label2 = new Label();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Segoe UI", 10F);
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { созданиеToolStripMenuItem, обработкаToolStripMenuItem, разрушениеToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(178, 88);
            // 
            // созданиеToolStripMenuItem
            // 
            созданиеToolStripMenuItem.Name = "созданиеToolStripMenuItem";
            созданиеToolStripMenuItem.Size = new Size(177, 28);
            созданиеToolStripMenuItem.Text = "Создание";
            созданиеToolStripMenuItem.Click += создание_CMS_Click;
            // 
            // обработкаToolStripMenuItem
            // 
            обработкаToolStripMenuItem.Enabled = false;
            обработкаToolStripMenuItem.Name = "обработкаToolStripMenuItem";
            обработкаToolStripMenuItem.Size = new Size(177, 28);
            обработкаToolStripMenuItem.Text = "Обработка";
            обработкаToolStripMenuItem.Click += обработка_CMS_Click;
            // 
            // разрушениеToolStripMenuItem
            // 
            разрушениеToolStripMenuItem.Enabled = false;
            разрушениеToolStripMenuItem.Name = "разрушениеToolStripMenuItem";
            разрушениеToolStripMenuItem.Size = new Size(177, 28);
            разрушениеToolStripMenuItem.Text = "Разрушение";
            разрушениеToolStripMenuItem.Click += разрушение_CMS_Click;
            // 
            // button_task
            // 
            button_task.BackColor = SystemColors.ControlLight;
            button_task.FlatAppearance.BorderSize = 0;
            button_task.FlatAppearance.MouseOverBackColor = Color.Silver;
            button_task.FlatStyle = FlatStyle.Flat;
            button_task.Font = new Font("Segoe UI", 10F);
            button_task.Location = new Point(0, 0);
            button_task.Name = "button_task";
            button_task.Size = new Size(170, 47);
            button_task.TabIndex = 1;
            button_task.Text = "Задание";
            button_task.UseVisualStyleBackColor = false;
            button_task.Click += button_task_Click;
            // 
            // button_info
            // 
            button_info.BackColor = SystemColors.ControlLight;
            button_info.FlatAppearance.BorderSize = 0;
            button_info.FlatAppearance.MouseOverBackColor = Color.Silver;
            button_info.FlatStyle = FlatStyle.Flat;
            button_info.Font = new Font("Segoe UI", 10F);
            button_info.Location = new Point(170, 0);
            button_info.Name = "button_info";
            button_info.Size = new Size(170, 47);
            button_info.TabIndex = 2;
            button_info.Text = "О программе";
            button_info.UseVisualStyleBackColor = false;
            button_info.Click += button_info_Click;
            // 
            // button_exit
            // 
            button_exit.BackColor = SystemColors.ControlLight;
            button_exit.FlatAppearance.BorderSize = 0;
            button_exit.FlatAppearance.MouseOverBackColor = Color.Silver;
            button_exit.FlatStyle = FlatStyle.Flat;
            button_exit.Font = new Font("Segoe UI", 10F);
            button_exit.Location = new Point(340, 0);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(170, 47);
            button_exit.TabIndex = 3;
            button_exit.Text = "Выход";
            button_exit.UseVisualStyleBackColor = false;
            button_exit.Click += button_exit_Click;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(21, 146);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(319, 313);
            treeView1.TabIndex = 4;
            // 
            // treeView2
            // 
            treeView2.Location = new Point(642, 146);
            treeView2.Name = "treeView2";
            treeView2.Size = new Size(319, 313);
            treeView2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(118, 488);
            label1.Name = "label1";
            label1.Size = new Size(102, 23);
            label1.TabIndex = 6;
            label1.Text = "Дерево №1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(757, 488);
            label2.Name = "label2";
            label2.Size = new Size(102, 23);
            label2.TabIndex = 7;
            label2.Text = "Дерево №2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 603);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(treeView2);
            Controls.Add(treeView1);
            Controls.Add(button_exit);
            Controls.Add(button_info);
            Controls.Add(button_task);
            Name = "Form1";
            Text = "Menu";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private Button button_task;
        private Button button_info;
        private Button button_exit;
        private ToolStripMenuItem созданиеToolStripMenuItem;
        private ToolStripMenuItem обработкаToolStripMenuItem;
        private ToolStripMenuItem разрушениеToolStripMenuItem;
        private Label label1;
        private Label label2;
        public TreeView treeView1;
        public TreeView treeView2;
    }
}
