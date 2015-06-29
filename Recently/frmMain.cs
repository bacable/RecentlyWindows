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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listDecisions_Enter(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SetManager.Instance.UnitTest_InitDecisionSets();

            foreach (var decisionSet in SetManager.Instance.DecisionSets)
            {
                listDecisions.Items.Add(decisionSet.Name);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addDecisionSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addDecisionSetForm = new frmAddDecisionSet();
            addDecisionSetForm.Show(this);
            addDecisionSetForm.FormClosing += new FormClosingEventHandler(RefreshList);
        }

        private void RefreshList(object sender, EventArgs ea)
        {
            listDecisions.Items.Clear();

            foreach(var set in SetManager.Instance.DecisionSets)
            {
                listDecisions.Items.Add(set.Name);
            }
        }
    }
}
