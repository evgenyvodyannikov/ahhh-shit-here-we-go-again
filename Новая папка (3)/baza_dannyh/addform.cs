using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baza_dannyh
{
    public partial class addform : Form
    {
        public addform()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                DataRow nRow = main.test2DataSet.Tables[0].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = tbname.Text;
                nRow[2] = tbphone.Text;
                nRow[3] = tbmail.Text;
                nRow[4] = tbPhoto.Text;
                main.test2DataSet.Tables[0].Rows.Add(nRow);
                main.contactsTableAdapter1.Update(main.test2DataSet.contacts);
                main.test2DataSet.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
                tbname.Text = "";
                tbphone.Text = "";
                tbmail.Text = "";
                tbPhoto.Text = "";
            }
        }
    }
}