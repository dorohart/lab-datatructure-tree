using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лабораторная_яп_3
{
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
            label1.Visible = false;
            label_exeption.Visible = false;
        }
        private void button_yes_Click(object sender, EventArgs e)
        {
            int key;
            if (!int.TryParse(textBox_key.Text, out key))
            {
                if (textBox_info.Text != string.Empty) label_exeption.Visible = true;
                else label1.Visible = true;
            }
            else
            {
                if (textBox_info.Text != string.Empty && textBox_key.Text != string.Empty)
                {
                    if (label_create.Text == "Создание дерева №1")
                    {
                        AppContext.tree.Add(textBox_info.Text, key);
                        AppContext.tree.DisplayInTreeView(AppContext.MainForm.treeView1);
                    }
                    else
                    {
                        AppContext.tree_new.Add(textBox_info.Text, key);
                        AppContext.tree_new.DisplayInTreeView(AppContext.MainForm.treeView2);
                    }
                    textBox_info.Text = string.Empty;
                    textBox_key.Text = string.Empty;
                }
                else label1.Visible = true;
            }
        }
        private void button_no_Click(object sender, EventArgs e)
        {
            int key;
            if (!int.TryParse(textBox_key.Text, out key))
            {
                if (textBox_info.Text != string.Empty) label_exeption.Visible = true;
                else label1.Visible = true;
            }
            else
            {
                if (textBox_info.Text != string.Empty && textBox_key.Text != string.Empty)
                {
                    if (label_create.Text == "Создание дерева №1")
                    {
                        AppContext.tree.Add(textBox_info.Text, key);
                        AppContext.tree.DisplayInTreeView(AppContext.MainForm.treeView1);
                        label_create.Text = "Создание дерева №2";
                        textBox_info.Text = string.Empty;
                        textBox_key.Text = string.Empty;
                    }
                    else
                    {
                        AppContext.tree_new.Add(textBox_info.Text, key);
                        AppContext.tree_new.DisplayInTreeView(AppContext.MainForm.treeView2);
                        Close();
                    }
                }
                else label1.Visible = true;
            }
        }
        private void textBox_info_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
        }
        private void textBox_key_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label_exeption.Visible = false;
            textBox_key.Text = string.Empty;
        }
    }
}
