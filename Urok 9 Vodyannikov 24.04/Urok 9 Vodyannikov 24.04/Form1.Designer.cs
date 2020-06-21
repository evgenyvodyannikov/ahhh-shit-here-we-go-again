namespace Urok_9_Vodyannikov_24._04
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.add = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.removeAll = new System.Windows.Forms.Button();
            this.addnode = new System.Windows.Forms.TextBox();
            this.findNode = new System.Windows.Forms.TextBox();
            this.find = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.treeView1.LineColor = System.Drawing.Color.Maroon;
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(206, 273);
            this.treeView1.TabIndex = 0;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.SkyBlue;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.add.Location = new System.Drawing.Point(224, 12);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(102, 43);
            this.add.TabIndex = 1;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // remove
            // 
            this.remove.BackColor = System.Drawing.Color.SkyBlue;
            this.remove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.remove.ForeColor = System.Drawing.SystemColors.ControlText;
            this.remove.Location = new System.Drawing.Point(224, 86);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(102, 43);
            this.remove.TabIndex = 1;
            this.remove.Text = "Удалить";
            this.remove.UseVisualStyleBackColor = false;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // removeAll
            // 
            this.removeAll.BackColor = System.Drawing.Color.SkyBlue;
            this.removeAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.removeAll.Location = new System.Drawing.Point(224, 168);
            this.removeAll.Name = "removeAll";
            this.removeAll.Size = new System.Drawing.Size(102, 43);
            this.removeAll.TabIndex = 1;
            this.removeAll.Text = "Удалить ВСЕ";
            this.removeAll.UseVisualStyleBackColor = false;
            this.removeAll.Click += new System.EventHandler(this.removeAll_Click);
            // 
            // addnode
            // 
            this.addnode.Location = new System.Drawing.Point(350, 24);
            this.addnode.Name = "addnode";
            this.addnode.Size = new System.Drawing.Size(132, 20);
            this.addnode.TabIndex = 2;
            // 
            // findNode
            // 
            this.findNode.Location = new System.Drawing.Point(350, 254);
            this.findNode.Name = "findNode";
            this.findNode.Size = new System.Drawing.Size(132, 20);
            this.findNode.TabIndex = 2;
            // 
            // find
            // 
            this.find.BackColor = System.Drawing.Color.SkyBlue;
            this.find.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.find.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.find.ForeColor = System.Drawing.SystemColors.ControlText;
            this.find.Location = new System.Drawing.Point(224, 242);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(102, 43);
            this.find.TabIndex = 1;
            this.find.Text = "Поиск";
            this.find.UseVisualStyleBackColor = false;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(508, 297);
            this.Controls.Add(this.findNode);
            this.Controls.Add(this.addnode);
            this.Controls.Add(this.find);
            this.Controls.Add(this.removeAll);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.add);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Водянников";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button removeAll;
        private System.Windows.Forms.TextBox addnode;
        private System.Windows.Forms.TextBox findNode;
        private System.Windows.Forms.Button find;
    }
}

