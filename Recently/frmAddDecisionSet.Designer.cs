namespace Recently
{
    partial class frmAddDecisionSet
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
            this.label1 = new System.Windows.Forms.Label();
            this.textDecisionSetName = new System.Windows.Forms.TextBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.listAddChoices = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSortAZ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textDecisionSetName
            // 
            this.textDecisionSetName.Location = new System.Drawing.Point(57, 10);
            this.textDecisionSetName.Name = "textDecisionSetName";
            this.textDecisionSetName.Size = new System.Drawing.Size(132, 20);
            this.textDecisionSetName.TabIndex = 1;
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(350, 205);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(75, 23);
            this.buttonDone.TabIndex = 3;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(12, 204);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // listAddChoices
            // 
            this.listAddChoices.GridLines = true;
            this.listAddChoices.LabelEdit = true;
            this.listAddChoices.Location = new System.Drawing.Point(12, 60);
            this.listAddChoices.Name = "listAddChoices";
            this.listAddChoices.Size = new System.Drawing.Size(413, 139);
            this.listAddChoices.TabIndex = 2;
            this.listAddChoices.UseCompatibleStateImageBehavior = false;
            this.listAddChoices.View = System.Windows.Forms.View.List;
            this.listAddChoices.Enter += new System.EventHandler(this.listAddChoices_Enter);
            this.listAddChoices.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listAddChoices_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Choices:";
            // 
            // buttonSortAZ
            // 
            this.buttonSortAZ.Location = new System.Drawing.Point(350, 34);
            this.buttonSortAZ.Name = "buttonSortAZ";
            this.buttonSortAZ.Size = new System.Drawing.Size(75, 23);
            this.buttonSortAZ.TabIndex = 6;
            this.buttonSortAZ.Text = "Sort A-Z";
            this.buttonSortAZ.UseVisualStyleBackColor = true;
            this.buttonSortAZ.Click += new System.EventHandler(this.buttonSortAZ_Click);
            // 
            // frmAddDecisionSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 237);
            this.Controls.Add(this.buttonSortAZ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.textDecisionSetName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listAddChoices);
            this.Name = "frmAddDecisionSet";
            this.Text = "Add Decision Set";
            this.Load += new System.EventHandler(this.frmAddDecisionSet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textDecisionSetName;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ListView listAddChoices;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSortAZ;
    }
}