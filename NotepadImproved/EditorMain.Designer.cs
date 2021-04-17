
namespace QTextEditor
{
    partial class EditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorForm));
            this.EditorMenuBar = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.printMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.copyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formattingMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fontMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.foregroundColorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.wordWrapMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditorStatusBar = new System.Windows.Forms.StatusStrip();
            this.EditorStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Editor = new System.Windows.Forms.TextBox();
            this.EditorMenuBar.SuspendLayout();
            this.EditorStatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditorMenuBar
            // 
            this.EditorMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.editMenu,
            this.formattingMenu,
            this.viewMenu});
            resources.ApplyResources(this.EditorMenuBar, "EditorMenuBar");
            this.EditorMenuBar.Name = "EditorMenuBar";
            this.EditorMenuBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.EditorMenuBar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1ItemClicked);
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetMenuItem,
            this.toolStripMenuItem1,
            this.saveMenuItem,
            this.saveAsMenuItem,
            this.toolStripMenuItem5,
            this.printMenuItem,
            this.toolStripMenuItem2,
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            resources.ApplyResources(this.fileMenuItem, "fileMenuItem");
            // 
            // resetMenuItem
            // 
            this.resetMenuItem.Name = "resetMenuItem";
            resources.ApplyResources(this.resetMenuItem, "resetMenuItem");
            this.resetMenuItem.Click += new System.EventHandler(this.New);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Name = "saveMenuItem";
            resources.ApplyResources(this.saveMenuItem, "saveMenuItem");
            this.saveMenuItem.Click += new System.EventHandler(this.Save);
            // 
            // saveAsMenuItem
            // 
            this.saveAsMenuItem.Name = "saveAsMenuItem";
            resources.ApplyResources(this.saveAsMenuItem, "saveAsMenuItem");
            this.saveAsMenuItem.Click += new System.EventHandler(this.SaveAs);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            resources.ApplyResources(this.toolStripMenuItem5, "toolStripMenuItem5");
            // 
            // printMenuItem
            // 
            this.printMenuItem.Name = "printMenuItem";
            resources.ApplyResources(this.printMenuItem, "printMenuItem");
            this.printMenuItem.Click += new System.EventHandler(this.PrintMenuItemClick);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            resources.ApplyResources(this.exitMenuItem, "exitMenuItem");
            this.exitMenuItem.Click += new System.EventHandler(this.ExitClick);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyMenuItem,
            this.cutMenuItem,
            this.pasteMenuItem,
            this.toolStripMenuItem3,
            this.settingsMenuItem,
            this.toolStripMenuItem4,
            this.selectAllMenuItem});
            this.editMenu.Name = "editMenu";
            resources.ApplyResources(this.editMenu, "editMenu");
            // 
            // copyMenuItem
            // 
            this.copyMenuItem.Name = "copyMenuItem";
            resources.ApplyResources(this.copyMenuItem, "copyMenuItem");
            this.copyMenuItem.Click += new System.EventHandler(this.CopyText);
            // 
            // cutMenuItem
            // 
            this.cutMenuItem.Name = "cutMenuItem";
            resources.ApplyResources(this.cutMenuItem, "cutMenuItem");
            this.cutMenuItem.Click += new System.EventHandler(this.CutText);
            // 
            // pasteMenuItem
            // 
            this.pasteMenuItem.Name = "pasteMenuItem";
            resources.ApplyResources(this.pasteMenuItem, "pasteMenuItem");
            this.pasteMenuItem.Click += new System.EventHandler(this.PasteText);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.Name = "settingsMenuItem";
            resources.ApplyResources(this.settingsMenuItem, "settingsMenuItem");
            this.settingsMenuItem.Click += new System.EventHandler(this.SettingsWindow);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            // 
            // selectAllMenuItem
            // 
            this.selectAllMenuItem.Name = "selectAllMenuItem";
            resources.ApplyResources(this.selectAllMenuItem, "selectAllMenuItem");
            this.selectAllMenuItem.Click += new System.EventHandler(this.SelectAllMenuItemClick);
            // 
            // formattingMenu
            // 
            this.formattingMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontMenuItem,
            this.toolStripMenuItem6,
            this.foregroundColorMenuItem,
            this.backgroundColorMenuItem});
            this.formattingMenu.Name = "formattingMenu";
            resources.ApplyResources(this.formattingMenu, "formattingMenu");
            this.formattingMenu.Click += new System.EventHandler(this.FormattingToolStripMenuItem_Click);
            // 
            // fontMenuItem
            // 
            this.fontMenuItem.Name = "fontMenuItem";
            resources.ApplyResources(this.fontMenuItem, "fontMenuItem");
            this.fontMenuItem.Click += new System.EventHandler(this.ChangeFont);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            resources.ApplyResources(this.toolStripMenuItem6, "toolStripMenuItem6");
            // 
            // foregroundColorMenuItem
            // 
            this.foregroundColorMenuItem.Name = "foregroundColorMenuItem";
            resources.ApplyResources(this.foregroundColorMenuItem, "foregroundColorMenuItem");
            this.foregroundColorMenuItem.Click += new System.EventHandler(this.ChangeForegroundColorMenuItemClick);
            // 
            // backgroundColorMenuItem
            // 
            this.backgroundColorMenuItem.Name = "backgroundColorMenuItem";
            resources.ApplyResources(this.backgroundColorMenuItem, "backgroundColorMenuItem");
            this.backgroundColorMenuItem.Click += new System.EventHandler(this.ChangeBackgroundColorMenuItemClick);
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordWrapMenuItem});
            this.viewMenu.Name = "viewMenu";
            resources.ApplyResources(this.viewMenu, "viewMenu");
            // 
            // wordWrapMenuItem
            // 
            this.wordWrapMenuItem.CheckOnClick = true;
            this.wordWrapMenuItem.Name = "wordWrapMenuItem";
            resources.ApplyResources(this.wordWrapMenuItem, "wordWrapMenuItem");
            this.wordWrapMenuItem.CheckedChanged += new System.EventHandler(this.SetWordWrap);
            // 
            // EditorStatusBar
            // 
            this.EditorStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditorStatusLabel});
            resources.ApplyResources(this.EditorStatusBar, "EditorStatusBar");
            this.EditorStatusBar.Name = "EditorStatusBar";
            // 
            // EditorStatusLabel
            // 
            this.EditorStatusLabel.Name = "EditorStatusLabel";
            resources.ApplyResources(this.EditorStatusLabel, "EditorStatusLabel");
            // 
            // Editor
            // 
            this.Editor.AcceptsReturn = true;
            this.Editor.AcceptsTab = true;
            resources.ApplyResources(this.Editor, "Editor");
            this.Editor.HideSelection = false;
            this.Editor.Name = "Editor";
            this.Editor.TextChanged += new System.EventHandler(this.TextBoxChanged);
            // 
            // EditorForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Editor);
            this.Controls.Add(this.EditorStatusBar);
            this.Controls.Add(this.EditorMenuBar);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.MainMenuStrip = this.EditorMenuBar;
            this.Name = "EditorForm";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.EditorMain_Load);
            this.EditorMenuBar.ResumeLayout(false);
            this.EditorMenuBar.PerformLayout();
            this.EditorStatusBar.ResumeLayout(false);
            this.EditorStatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip EditorMenuBar;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.StatusStrip EditorStatusBar;
        private System.Windows.Forms.ToolStripStatusLabel EditorStatusLabel;
        private System.Windows.Forms.TextBox Editor;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem wordWrapMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem copyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem settingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formattingMenu;
        private System.Windows.Forms.ToolStripMenuItem fontMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem selectAllMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem printMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem foregroundColorMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorMenuItem;
        private string unsavedChangesString;
        private string changesSavedString;
    }
}

