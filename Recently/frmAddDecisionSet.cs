using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recently
{
    public partial class frmAddDecisionSet : Form
    {
        public frmAddDecisionSet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textDecisionSetName.Text)) {
                MessageBox.Show("Please give the decision set a name.", "No name provided.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var choices = new List<String>();

                foreach (var item in listAddChoices.Items)
                {
                    choices.Add(item.ToString());
                }

                SetManager.Instance.NewDecisionSet(textDecisionSetName.Text, choices);

                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listAddChoices_Enter(object sender, EventArgs e)
        {
            if (listAddChoices.Items.Count == 0)
            {
                AddItemToListView();
            }
        }

        private void AddItemToListView()
        {
            // Add a new item to the ListView, with an empty label
            // (you can set any default properties that you want to here)
            ListViewItem item = listAddChoices.Items.Add("");
            // Place the newly-added item into edit mode immediately
            item.BeginEdit();
        }

        private void listAddChoices_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                AddItemToListView();
            }
        }

        private void frmAddDecisionSet_Load(object sender, EventArgs e)
        {
            textDecisionSetName.Focus();
        }

        private void buttonSortAZ_Click(object sender, EventArgs e)
        {
            listAddChoices.Sort();
        }
    }
}
