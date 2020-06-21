namespace Vodyannikov_07._05_Zadanie_1_3
{
    partial class Zadanie2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.CausesValidation = false;
            this.listBox1.Enabled = false;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(552, 412);
            this.listBox1.TabIndex = 0;
            this.listBox1.TabStop = false;
            this.listBox1.UseTabStops = false;
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Zadanie2_MouseClick);
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Zadanie2_KeyDown);
            this.listBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Zadanie2_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(153, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Завершить работу";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Zadanie2_KeyDown);
            this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Zadanie2_KeyPress);
            // 
            // Zadanie2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(576, 488);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "Zadanie2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zadanie2";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Zadanie2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Zadanie2_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Zadanie2_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Zadanie2_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
    }
}