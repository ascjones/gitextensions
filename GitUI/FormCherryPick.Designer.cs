﻿namespace GitUI
{
    partial class FormCherryPick
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.RevisionGrid = new GitUI.RevisionGrid();
            this.checkAddReference = new System.Windows.Forms.CheckBox();
            this.autoParent = new System.Windows.Forms.CheckBox();
            this.AutoCommit = new System.Windows.Forms.CheckBox();
            this.CherryPick = new System.Windows.Forms.Button();
#if Mono212Released //waiting for mono 2.12					
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
#endif
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
#if Mono212Released //waiting for mono 2.12					
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
#endif
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.checkAddReference);
            this.splitContainer1.Panel2.Controls.Add(this.autoParent);
            this.splitContainer1.Panel2.Controls.Add(this.AutoCommit);
            this.splitContainer1.Panel2.Controls.Add(this.CherryPick);
            this.splitContainer1.Size = new System.Drawing.Size(638, 387);
            this.splitContainer1.SplitterDistance = 303;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.RevisionGrid);
            this.splitContainer2.Size = new System.Drawing.Size(638, 303);
            this.splitContainer2.SplitterDistance = 25;
            this.splitContainer2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a commit you want to cherry pick. The commit will be recommitted on top of" +
    " the current head.";
            // 
            // RevisionGrid
            // 
            this.RevisionGrid.BranchFilter = "";
            this.RevisionGrid.CurrentCheckout = "";
            this.RevisionGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RevisionGrid.Filter = "";
            this.RevisionGrid.FixedFilter = "";
            this.RevisionGrid.InMemAuthorFilter = "";
            this.RevisionGrid.InMemCommitterFilter = "";
            this.RevisionGrid.InMemMessageFilter = "";
            this.RevisionGrid.LastRow = 0;
            this.RevisionGrid.Location = new System.Drawing.Point(0, 0);
            this.RevisionGrid.Name = "RevisionGrid";
            this.RevisionGrid.NormalFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RevisionGrid.Size = new System.Drawing.Size(638, 274);
            this.RevisionGrid.SuperprojectCurrentCheckout = null;
            this.RevisionGrid.TabIndex = 0;
            // 
            // checkAddReference
            // 
            this.checkAddReference.AutoSize = true;
            this.checkAddReference.Location = new System.Drawing.Point(12, 57);
            this.checkAddReference.Name = "checkAddReference";
            this.checkAddReference.Size = new System.Drawing.Size(122, 16);
            this.checkAddReference.TabIndex = 3;
            this.checkAddReference.Text = "Add commit reference";
            this.checkAddReference.UseVisualStyleBackColor = true;
            // 
            // autoParent
            // 
            this.autoParent.AutoSize = true;
            this.autoParent.Checked = true;
            this.autoParent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoParent.Location = new System.Drawing.Point(12, 32);
            this.autoParent.Name = "autoParent";
            this.autoParent.Size = new System.Drawing.Size(261, 16);
            this.autoParent.TabIndex = 2;
            this.autoParent.Text = "Automatically set parent to 1 when commit is a merge";
            this.autoParent.UseVisualStyleBackColor = true;
            // 
            // AutoCommit
            // 
            this.AutoCommit.AutoSize = true;
            this.AutoCommit.Checked = true;
            this.AutoCommit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoCommit.Location = new System.Drawing.Point(12, 7);
            this.AutoCommit.Name = "AutoCommit";
            this.AutoCommit.Size = new System.Drawing.Size(313, 16);
            this.AutoCommit.TabIndex = 1;
            this.AutoCommit.Text = "Automatically create a commit  when there are no merge conflicts";
            this.AutoCommit.UseVisualStyleBackColor = true;
            // 
            // CherryPick
            // 
            this.CherryPick.Location = new System.Drawing.Point(516, 51);
            this.CherryPick.Name = "CherryPick";
            this.CherryPick.Size = new System.Drawing.Size(110, 25);
            this.CherryPick.TabIndex = 0;
            this.CherryPick.Text = "Cherry pick";
            this.CherryPick.UseVisualStyleBackColor = true;
            this.CherryPick.Click += new System.EventHandler(this.CherryPick_Click);
            // 
            // FormCherryPick
            // 
            
            
            this.ClientSize = new System.Drawing.Size(638, 387);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "FormCherryPick";
            this.Text = "Cherry pick";
            this.Load += new System.EventHandler(this.FormCherryPick_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
#if Mono212Released //waiting for mono 2.12					
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
#endif
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
#if Mono212Released //waiting for mono 2.12					
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
#endif
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label1;
        private RevisionGrid RevisionGrid;
        private System.Windows.Forms.Button CherryPick;
        private System.Windows.Forms.CheckBox AutoCommit;
        private System.Windows.Forms.CheckBox autoParent;
        private System.Windows.Forms.CheckBox checkAddReference;
    }
}