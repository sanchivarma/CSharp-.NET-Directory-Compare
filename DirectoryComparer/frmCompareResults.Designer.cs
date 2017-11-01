using System.Windows.Forms;
using System.Drawing;
using DirectoryComparer.Services;
namespace DirectoryComparer
{
    partial class frmCompareResults
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompareResults));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compareFoldersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bothResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.leftSideOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightSideOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.showMatchesOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMismatchesOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLeftFilesOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showRightFilesOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openLeftFilewNotepa0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openRightFilewNotepa0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyLeftPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyRightPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.openLeftFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openRightFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.compare = new System.Windows.Forms.TabControl();
            this.asXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.compare.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.filterToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(976, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compareFoldersToolStripMenuItem,
            this.preferencesToolStripMenuItem,
            this.saveResultsToolStripMenuItem,
            this.toolStripMenuItem3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // compareFoldersToolStripMenuItem
            // 
            this.compareFoldersToolStripMenuItem.Name = "compareFoldersToolStripMenuItem";
            this.compareFoldersToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.compareFoldersToolStripMenuItem.Text = "&Compare Folders";
            this.compareFoldersToolStripMenuItem.Click += new System.EventHandler(this.compareFoldersToolStripMenuItem_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.preferencesToolStripMenuItem.Text = "P&references";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(161, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bothResultsToolStripMenuItem,
            this.toolStripMenuItem4,
            this.leftSideOnlyToolStripMenuItem,
            this.rightSideOnlyToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // bothResultsToolStripMenuItem
            // 
            this.bothResultsToolStripMenuItem.Checked = true;
            this.bothResultsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bothResultsToolStripMenuItem.Name = "bothResultsToolStripMenuItem";
            this.bothResultsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.bothResultsToolStripMenuItem.Text = "&Both Results";
            this.bothResultsToolStripMenuItem.Click += new System.EventHandler(this.bothResultsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(152, 6);
            // 
            // leftSideOnlyToolStripMenuItem
            // 
            this.leftSideOnlyToolStripMenuItem.Name = "leftSideOnlyToolStripMenuItem";
            this.leftSideOnlyToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.leftSideOnlyToolStripMenuItem.Text = "&Left Side Only";
            this.leftSideOnlyToolStripMenuItem.Click += new System.EventHandler(this.leftSideOnlyToolStripMenuItem_Click);
            // 
            // rightSideOnlyToolStripMenuItem
            // 
            this.rightSideOnlyToolStripMenuItem.Name = "rightSideOnlyToolStripMenuItem";
            this.rightSideOnlyToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.rightSideOnlyToolStripMenuItem.Text = "&Right Side Only";
            this.rightSideOnlyToolStripMenuItem.Click += new System.EventHandler(this.rightSideOnlyToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllToolStripMenuItem,
            this.toolStripMenuItem1,
            this.showMatchesOnlyToolStripMenuItem,
            this.showMismatchesOnlyToolStripMenuItem,
            this.showLeftFilesOnlyToolStripMenuItem,
            this.showRightFilesOnlyToolStripMenuItem});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.filterToolStripMenuItem.Text = "F&ilter";
            // 
            // showAllToolStripMenuItem
            // 
            this.showAllToolStripMenuItem.Checked = true;
            this.showAllToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showAllToolStripMenuItem.Name = "showAllToolStripMenuItem";
            this.showAllToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.showAllToolStripMenuItem.Text = "Show A&ll";
            this.showAllToolStripMenuItem.Click += new System.EventHandler(this.showAllToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(195, 6);
            // 
            // showMatchesOnlyToolStripMenuItem
            // 
            this.showMatchesOnlyToolStripMenuItem.Name = "showMatchesOnlyToolStripMenuItem";
            this.showMatchesOnlyToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.showMatchesOnlyToolStripMenuItem.Text = "Show &Matches Only";
            this.showMatchesOnlyToolStripMenuItem.Click += new System.EventHandler(this.showMatchesOnlyToolStripMenuItem_Click);
            // 
            // showMismatchesOnlyToolStripMenuItem
            // 
            this.showMismatchesOnlyToolStripMenuItem.Name = "showMismatchesOnlyToolStripMenuItem";
            this.showMismatchesOnlyToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.showMismatchesOnlyToolStripMenuItem.Text = "Show Mismatches &Only";
            this.showMismatchesOnlyToolStripMenuItem.Click += new System.EventHandler(this.showMismatchesOnlyToolStripMenuItem_Click);
            // 
            // showLeftFilesOnlyToolStripMenuItem
            // 
            this.showLeftFilesOnlyToolStripMenuItem.Name = "showLeftFilesOnlyToolStripMenuItem";
            this.showLeftFilesOnlyToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.showLeftFilesOnlyToolStripMenuItem.Text = "Show Left Files Onl&y";
            this.showLeftFilesOnlyToolStripMenuItem.Click += new System.EventHandler(this.showLeftFilesOnlyToolStripMenuItem_Click);
            // 
            // showRightFilesOnlyToolStripMenuItem
            // 
            this.showRightFilesOnlyToolStripMenuItem.Name = "showRightFilesOnlyToolStripMenuItem";
            this.showRightFilesOnlyToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.showRightFilesOnlyToolStripMenuItem.Text = "Show Right Files O&nly";
            this.showRightFilesOnlyToolStripMenuItem.Click += new System.EventHandler(this.showRightFilesOnlyToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openLeftFilewNotepa0ToolStripMenuItem,
            this.openRightFilewNotepa0ToolStripMenuItem,
            this.copyLeftPathToolStripMenuItem,
            this.copyRightPathToolStripMenuItem,
            this.toolStripMenuItem2,
            this.openLeftFolderToolStripMenuItem,
            this.openRightFolderToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(230, 142);
            // 
            // openLeftFilewNotepa0ToolStripMenuItem
            // 
            this.openLeftFilewNotepa0ToolStripMenuItem.Name = "openLeftFilewNotepa0ToolStripMenuItem";
            this.openLeftFilewNotepa0ToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.openLeftFilewNotepa0ToolStripMenuItem.Text = "Open &Left File (w/ Notepad)";
            this.openLeftFilewNotepa0ToolStripMenuItem.Click += new System.EventHandler(this.openLeftFilewNotepa0ToolStripMenuItem_Click);
            // 
            // openRightFilewNotepa0ToolStripMenuItem
            // 
            this.openRightFilewNotepa0ToolStripMenuItem.Name = "openRightFilewNotepa0ToolStripMenuItem";
            this.openRightFilewNotepa0ToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.openRightFilewNotepa0ToolStripMenuItem.Text = "Open &Right File (w/ Notepad)";
            this.openRightFilewNotepa0ToolStripMenuItem.Click += new System.EventHandler(this.openRightFilewNotepa0ToolStripMenuItem_Click);
            // 
            // copyLeftPathToolStripMenuItem
            // 
            this.copyLeftPathToolStripMenuItem.Name = "copyLeftPathToolStripMenuItem";
            this.copyLeftPathToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.copyLeftPathToolStripMenuItem.Text = "Copy Left &Path";
            this.copyLeftPathToolStripMenuItem.Click += new System.EventHandler(this.copyLeftPathToolStripMenuItem_Click_1);
            // 
            // copyRightPathToolStripMenuItem
            // 
            this.copyRightPathToolStripMenuItem.Name = "copyRightPathToolStripMenuItem";
            this.copyRightPathToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.copyRightPathToolStripMenuItem.Text = "Copy Right P&ath";
            this.copyRightPathToolStripMenuItem.Click += new System.EventHandler(this.copyRightPathToolStripMenuItem_Click_1);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(226, 6);
            // 
            // openLeftFolderToolStripMenuItem
            // 
            this.openLeftFolderToolStripMenuItem.Name = "openLeftFolderToolStripMenuItem";
            this.openLeftFolderToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.openLeftFolderToolStripMenuItem.Text = "Open L&eft Folder";
            this.openLeftFolderToolStripMenuItem.Click += new System.EventHandler(this.openLeftFolderToolStripMenuItem_Click_1);
            // 
            // openRightFolderToolStripMenuItem
            // 
            this.openRightFolderToolStripMenuItem.Name = "openRightFolderToolStripMenuItem";
            this.openRightFolderToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.openRightFolderToolStripMenuItem.Text = "Open R&ight Folder";
            this.openRightFolderToolStripMenuItem.Click += new System.EventHandler(this.openRightFolderToolStripMenuItem_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(968, 417);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Directory Sync Output";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gridView
            // 
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridView.Location = new System.Drawing.Point(3, 3);
            this.gridView.Name = "gridView";
            this.gridView.Size = new System.Drawing.Size(962, 411);
            this.gridView.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(968, 417);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Directory Compare Results";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(962, 411);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tableLayoutPanel1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(968, 417);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Directory View";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.treeView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.treeView2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.839416F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.16058F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(962, 411);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(484, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(475, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Folder 2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.Control;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(3, 26);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(475, 382);
            this.treeView1.TabIndex = 0;
            // 
            // treeView2
            // 
            this.treeView2.BackColor = System.Drawing.SystemColors.Control;
            this.treeView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView2.Location = new System.Drawing.Point(484, 26);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(475, 382);
            this.treeView2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Folder 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // compare
            // 
            this.compare.Controls.Add(this.tabPage4);
            this.compare.Controls.Add(this.tabPage1);
            this.compare.Controls.Add(this.tabPage2);
            this.compare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compare.Location = new System.Drawing.Point(0, 24);
            this.compare.Name = "compare";
            this.compare.SelectedIndex = 0;
            this.compare.Size = new System.Drawing.Size(976, 443);
            this.compare.TabIndex = 1;
            this.compare.Tag = "";
            // 
            // asXMLToolStripMenuItem
            // 
            this.asXMLToolStripMenuItem.Name = "asXMLToolStripMenuItem";
            this.asXMLToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.asXMLToolStripMenuItem.Text = "As XM&L";
            this.asXMLToolStripMenuItem.Click += new System.EventHandler(this.asXMLToolStripMenuItem_Click);
            // 
            // asCSVToolStripMenuItem
            // 
            this.asCSVToolStripMenuItem.Name = "asCSVToolStripMenuItem";
            this.asCSVToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.asCSVToolStripMenuItem.Text = "&As CSV";
            this.asCSVToolStripMenuItem.Click += new System.EventHandler(this.asCSVToolStripMenuItem_Click);
            // 
            // saveResultsToolStripMenuItem
            // 
            this.saveResultsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asXMLToolStripMenuItem,
            this.asCSVToolStripMenuItem});
            this.saveResultsToolStripMenuItem.Name = "saveResultsToolStripMenuItem";
            this.saveResultsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.saveResultsToolStripMenuItem.Text = "&Save Results";
            // 
            // frmCompareResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 467);
            this.Controls.Add(this.compare);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCompareResults";
            this.Text = "Directory Comparer - Result";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCompareResults_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.compare.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bothResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leftSideOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightSideOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compareFoldersToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem filterToolStripMenuItem;
        private ToolStripMenuItem showAllToolStripMenuItem;
        private ToolStripMenuItem showMatchesOnlyToolStripMenuItem;
        private ToolStripMenuItem showMismatchesOnlyToolStripMenuItem;
        private ToolStripMenuItem showLeftFilesOnlyToolStripMenuItem;
        private ToolStripMenuItem showRightFilesOnlyToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem openLeftFilewNotepa0ToolStripMenuItem;
        private ToolStripMenuItem openRightFilewNotepa0ToolStripMenuItem;
        private ToolStripMenuItem copyLeftPathToolStripMenuItem;
        private ToolStripMenuItem copyRightPathToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem openLeftFolderToolStripMenuItem;
        private ToolStripMenuItem openRightFolderToolStripMenuItem;
        private ToolStripMenuItem preferencesToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem aboutToolStripMenuItem1;
        private TabPage tabPage2;
        private DataGridView gridView;
        private TabPage tabPage1;
        private ListView listView1;
        private TabPage tabPage4;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private TreeView treeView1;
        private TreeView treeView2;
        private Label label1;
        private TabControl compare;
        private ToolStripMenuItem saveResultsToolStripMenuItem;
        private ToolStripMenuItem asXMLToolStripMenuItem;
        private ToolStripMenuItem asCSVToolStripMenuItem;
    }
}