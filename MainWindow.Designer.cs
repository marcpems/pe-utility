﻿namespace PEUtility
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.infoTab = new System.Windows.Forms.TabPage();
            this.typeValueLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.importsTab = new System.Windows.Forms.TabPage();
            this.importsList = new System.Windows.Forms.TreeView();
            this.filterLabel2 = new System.Windows.Forms.Label();
            this.importSearchBox = new System.Windows.Forms.TextBox();
            this.exportsTab = new System.Windows.Forms.TabPage();
            this.functionInfoPanel = new System.Windows.Forms.Panel();
            this.filterLabel1 = new System.Windows.Forms.Label();
            this.exportSearchBox = new System.Windows.Forms.TextBox();
            this.exportsList = new System.Windows.Forms.ListView();
            this.tabControlImageList = new System.Windows.Forms.ImageList(this.components);
            this.treeContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyFunctionAddressMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionNameLabel = new System.Windows.Forms.Label();
            this.functionAddressLabel = new System.Windows.Forms.Label();
            this.functionNameTextBox = new System.Windows.Forms.TextBox();
            this.functionAddressTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.infoTab.SuspendLayout();
            this.importsTab.SuspendLayout();
            this.exportsTab.SuspendLayout();
            this.functionInfoPanel.SuspendLayout();
            this.treeContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.recentToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // recentToolStripMenuItem
            // 
            this.recentToolStripMenuItem.Enabled = false;
            this.recentToolStripMenuItem.Name = "recentToolStripMenuItem";
            this.recentToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.recentToolStripMenuItem.Text = "Open recent";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(136, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.infoTab);
            this.tabControl.Controls.Add(this.importsTab);
            this.tabControl.Controls.Add(this.exportsTab);
            this.tabControl.ImageList = this.tabControlImageList;
            this.tabControl.Location = new System.Drawing.Point(0, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(626, 435);
            this.tabControl.TabIndex = 1;
            // 
            // infoTab
            // 
            this.infoTab.Controls.Add(this.typeValueLabel);
            this.infoTab.Controls.Add(this.typeLabel);
            this.infoTab.ImageKey = "info.png";
            this.infoTab.Location = new System.Drawing.Point(4, 27);
            this.infoTab.Name = "infoTab";
            this.infoTab.Padding = new System.Windows.Forms.Padding(3);
            this.infoTab.Size = new System.Drawing.Size(618, 404);
            this.infoTab.TabIndex = 2;
            this.infoTab.Text = "Info";
            this.infoTab.UseVisualStyleBackColor = true;
            // 
            // typeValueLabel
            // 
            this.typeValueLabel.AutoSize = true;
            this.typeValueLabel.Location = new System.Drawing.Point(189, 7);
            this.typeValueLabel.Name = "typeValueLabel";
            this.typeValueLabel.Size = new System.Drawing.Size(0, 13);
            this.typeValueLabel.TabIndex = 1;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(6, 10);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(31, 13);
            this.typeLabel.TabIndex = 0;
            this.typeLabel.Text = "Type";
            // 
            // importsTab
            // 
            this.importsTab.Controls.Add(this.importsList);
            this.importsTab.Controls.Add(this.filterLabel2);
            this.importsTab.Controls.Add(this.importSearchBox);
            this.importsTab.ImageKey = "imports.png";
            this.importsTab.Location = new System.Drawing.Point(4, 27);
            this.importsTab.Name = "importsTab";
            this.importsTab.Padding = new System.Windows.Forms.Padding(3);
            this.importsTab.Size = new System.Drawing.Size(618, 404);
            this.importsTab.TabIndex = 0;
            this.importsTab.Text = "Imports";
            this.importsTab.UseVisualStyleBackColor = true;
            // 
            // importsList
            // 
            this.importsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.importsList.Location = new System.Drawing.Point(7, 33);
            this.importsList.Name = "importsList";
            this.importsList.Size = new System.Drawing.Size(603, 365);
            this.importsList.TabIndex = 6;
            // 
            // filterLabel2
            // 
            this.filterLabel2.AutoSize = true;
            this.filterLabel2.Location = new System.Drawing.Point(6, 10);
            this.filterLabel2.Name = "filterLabel2";
            this.filterLabel2.Size = new System.Drawing.Size(32, 13);
            this.filterLabel2.TabIndex = 5;
            this.filterLabel2.Text = "Filter:";
            // 
            // importSearchBox
            // 
            this.importSearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.importSearchBox.Enabled = false;
            this.importSearchBox.Location = new System.Drawing.Point(41, 7);
            this.importSearchBox.Name = "importSearchBox";
            this.importSearchBox.Size = new System.Drawing.Size(569, 20);
            this.importSearchBox.TabIndex = 4;
            // 
            // exportsTab
            // 
            this.exportsTab.Controls.Add(this.functionInfoPanel);
            this.exportsTab.Controls.Add(this.filterLabel1);
            this.exportsTab.Controls.Add(this.exportSearchBox);
            this.exportsTab.Controls.Add(this.exportsList);
            this.exportsTab.ImageKey = "exports.png";
            this.exportsTab.Location = new System.Drawing.Point(4, 27);
            this.exportsTab.Name = "exportsTab";
            this.exportsTab.Padding = new System.Windows.Forms.Padding(3);
            this.exportsTab.Size = new System.Drawing.Size(618, 404);
            this.exportsTab.TabIndex = 1;
            this.exportsTab.Text = "Exports";
            this.exportsTab.UseVisualStyleBackColor = true;
            // 
            // functionInfoPanel
            // 
            this.functionInfoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.functionInfoPanel.Controls.Add(this.functionAddressTextBox);
            this.functionInfoPanel.Controls.Add(this.functionNameTextBox);
            this.functionInfoPanel.Controls.Add(this.functionAddressLabel);
            this.functionInfoPanel.Controls.Add(this.functionNameLabel);
            this.functionInfoPanel.Location = new System.Drawing.Point(7, 340);
            this.functionInfoPanel.Name = "functionInfoPanel";
            this.functionInfoPanel.Size = new System.Drawing.Size(603, 58);
            this.functionInfoPanel.TabIndex = 3;
            // 
            // filterLabel1
            // 
            this.filterLabel1.AutoSize = true;
            this.filterLabel1.Location = new System.Drawing.Point(6, 10);
            this.filterLabel1.Name = "filterLabel1";
            this.filterLabel1.Size = new System.Drawing.Size(32, 13);
            this.filterLabel1.TabIndex = 2;
            this.filterLabel1.Text = "Filter:";
            // 
            // exportSearchBox
            // 
            this.exportSearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exportSearchBox.Enabled = false;
            this.exportSearchBox.Location = new System.Drawing.Point(41, 7);
            this.exportSearchBox.Name = "exportSearchBox";
            this.exportSearchBox.Size = new System.Drawing.Size(569, 20);
            this.exportSearchBox.TabIndex = 1;
            // 
            // exportsList
            // 
            this.exportsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exportsList.Location = new System.Drawing.Point(7, 33);
            this.exportsList.Name = "exportsList";
            this.exportsList.Size = new System.Drawing.Size(603, 300);
            this.exportsList.TabIndex = 0;
            this.exportsList.UseCompatibleStateImageBehavior = false;
            this.exportsList.View = System.Windows.Forms.View.List;
            // 
            // tabControlImageList
            // 
            this.tabControlImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("tabControlImageList.ImageStream")));
            this.tabControlImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.tabControlImageList.Images.SetKeyName(0, "info.png");
            this.tabControlImageList.Images.SetKeyName(1, "imports.png");
            this.tabControlImageList.Images.SetKeyName(2, "exports.png");
            // 
            // treeContextMenu
            // 
            this.treeContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyNameToolStripMenuItem,
            this.copyFunctionAddressMenuItem});
            this.treeContextMenu.Name = "importsContextMenu";
            this.treeContextMenu.Size = new System.Drawing.Size(194, 48);
            // 
            // copyNameToolStripMenuItem
            // 
            this.copyNameToolStripMenuItem.Name = "copyNameToolStripMenuItem";
            this.copyNameToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.copyNameToolStripMenuItem.Text = "Copy name";
            this.copyNameToolStripMenuItem.Click += new System.EventHandler(this.copyNameToolStripMenuItem_Click);
            // 
            // copyFunctionAddressMenuItem
            // 
            this.copyFunctionAddressMenuItem.Name = "copyFunctionAddressMenuItem";
            this.copyFunctionAddressMenuItem.Size = new System.Drawing.Size(193, 22);
            this.copyFunctionAddressMenuItem.Text = "Copy function address";
            this.copyFunctionAddressMenuItem.Click += new System.EventHandler(this.copyFunctionAddressMenuItem_Click);
            // 
            // functionNameLabel
            // 
            this.functionNameLabel.AutoSize = true;
            this.functionNameLabel.Location = new System.Drawing.Point(3, 7);
            this.functionNameLabel.Name = "functionNameLabel";
            this.functionNameLabel.Size = new System.Drawing.Size(38, 13);
            this.functionNameLabel.TabIndex = 0;
            this.functionNameLabel.Text = "Name:";
            // 
            // functionAddressLabel
            // 
            this.functionAddressLabel.AutoSize = true;
            this.functionAddressLabel.Location = new System.Drawing.Point(3, 33);
            this.functionAddressLabel.Name = "functionAddressLabel";
            this.functionAddressLabel.Size = new System.Drawing.Size(48, 13);
            this.functionAddressLabel.TabIndex = 1;
            this.functionAddressLabel.Text = "Address:";
            // 
            // functionNameTextBox
            // 
            this.functionNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.functionNameTextBox.Location = new System.Drawing.Point(59, 4);
            this.functionNameTextBox.Name = "functionNameTextBox";
            this.functionNameTextBox.ReadOnly = true;
            this.functionNameTextBox.Size = new System.Drawing.Size(541, 20);
            this.functionNameTextBox.TabIndex = 2;
            // 
            // functionAddressTextBox
            // 
            this.functionAddressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.functionAddressTextBox.Location = new System.Drawing.Point(59, 30);
            this.functionAddressTextBox.Name = "functionAddressTextBox";
            this.functionAddressTextBox.ReadOnly = true;
            this.functionAddressTextBox.Size = new System.Drawing.Size(541, 20);
            this.functionAddressTextBox.TabIndex = 3;
            // 
            // MainWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 461);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "PE Disassembler";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.infoTab.ResumeLayout(false);
            this.infoTab.PerformLayout();
            this.importsTab.ResumeLayout(false);
            this.importsTab.PerformLayout();
            this.exportsTab.ResumeLayout(false);
            this.exportsTab.PerformLayout();
            this.functionInfoPanel.ResumeLayout(false);
            this.functionInfoPanel.PerformLayout();
            this.treeContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage importsTab;
        private System.Windows.Forms.TabPage exportsTab;
        private System.Windows.Forms.ImageList tabControlImageList;
        private System.Windows.Forms.ListView exportsList;
        private System.Windows.Forms.TextBox exportSearchBox;
        private System.Windows.Forms.Label filterLabel1;
        private System.Windows.Forms.ToolStripMenuItem recentToolStripMenuItem;
        private System.Windows.Forms.Label filterLabel2;
        private System.Windows.Forms.TextBox importSearchBox;
        private System.Windows.Forms.TreeView importsList;
        private System.Windows.Forms.ContextMenuStrip treeContextMenu;
        private System.Windows.Forms.ToolStripMenuItem copyNameToolStripMenuItem;
        private System.Windows.Forms.TabPage infoTab;
        private System.Windows.Forms.Label typeValueLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.ToolStripMenuItem copyFunctionAddressMenuItem;
        private System.Windows.Forms.Panel functionInfoPanel;
        private System.Windows.Forms.Label functionAddressLabel;
        private System.Windows.Forms.Label functionNameLabel;
        private System.Windows.Forms.TextBox functionAddressTextBox;
        private System.Windows.Forms.TextBox functionNameTextBox;
    }
}

