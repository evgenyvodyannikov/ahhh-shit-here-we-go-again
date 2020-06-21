using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urok_9_Vodyannikov_24._04
{
    public partial class Form1 : Form
    {
        int i = 0;
        int k = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public TreeNode FindNode(TreeView tv, string name)
        {
            foreach(TreeNode tn in tv.Nodes)
            {
                if(tn.Text == name)
                {
                    return tn;
                }
            }
            TreeNode node;
            foreach (TreeNode tn in tv.Nodes)
            {
                node = FindNode(tn, name);
                if(node!= null)
                {
                    return node;
                }
            }
            return null;
        }
        public TreeNode FindNode(TreeNode tv, string name)
        {
            foreach (TreeNode tn in tv.Nodes)
            {
                if (tn.Text == name)
                {
                    return tn;
                }
            }
            TreeNode node;
            foreach (TreeNode tn in tv.Nodes)
            {
                node = FindNode(tn, name);
                if (node != null)
                {
                    return node;
                }
            }
            return null;
        }

        private void add_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            if (node == null)
            {
                if (addnode.Text != "")
                {
                    treeView1.Nodes.Add(addnode.Text);
                }
                else
                {
                    treeView1.Nodes.Add(i.ToString());
                    i++;
                }
            }
            else
            {
                if (addnode.Text != "")
                {
                    node.Nodes.Add(addnode.Text);
                }
                else
                {
                    node.Nodes.Add(k.ToString());
                    k++;
                }
            }
            addnode.Text = "";
            addnode.Focus();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            if (node != null)
            {
                treeView1.Nodes.Remove(node);
            }
            else
            {
                MessageBox.Show("Выделите узел для удаления!!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void removeAll_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
        }

        private void find_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode = null;
            TreeNode fn = FindNode(treeView1, findNode.Text);
            if (fn != null)
            {
                treeView1.SelectedNode = fn;
                treeView1.Focus();
            }
        }
    }
}
