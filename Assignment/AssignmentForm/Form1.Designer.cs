namespace AssignmentForm
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            menuStrip1 = new MenuStrip();
            toolStripMenuFile = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            savToolStripMenuItem = new ToolStripMenuItem();
            xMLToolStripMenuItem = new ToolStripMenuItem();
            jSONToolStripMenuItem = new ToolStripMenuItem();
            xMLToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuIHelp = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            toolStripButtonNew = new ToolStripButton();
            toolStripButtonOpen = new ToolStripButton();
            toolStripButtonSave = new ToolStripButton();
            toolStripButtonExit = new ToolStripButton();
            byMarvinSoroToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuFile, toolStripMenuIHelp });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuFile
            // 
            toolStripMenuFile.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, savToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            toolStripMenuFile.Name = "toolStripMenuFile";
            toolStripMenuFile.Size = new Size(37, 20);
            toolStripMenuFile.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(180, 22);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(180, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(180, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // savToolStripMenuItem
            // 
            savToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { xMLToolStripMenuItem, jSONToolStripMenuItem, xMLToolStripMenuItem1 });
            savToolStripMenuItem.Name = "savToolStripMenuItem";
            savToolStripMenuItem.Size = new Size(180, 22);
            savToolStripMenuItem.Text = "Save As";
            savToolStripMenuItem.Click += savToolStripMenuItem_Click;
            // 
            // xMLToolStripMenuItem
            // 
            xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            xMLToolStripMenuItem.Size = new Size(102, 22);
            xMLToolStripMenuItem.Text = "JSON";
            // 
            // jSONToolStripMenuItem
            // 
            jSONToolStripMenuItem.Name = "jSONToolStripMenuItem";
            jSONToolStripMenuItem.Size = new Size(102, 22);
            jSONToolStripMenuItem.Text = "TEXT";
            // 
            // xMLToolStripMenuItem1
            // 
            xMLToolStripMenuItem1.Name = "xMLToolStripMenuItem1";
            xMLToolStripMenuItem1.Size = new Size(102, 22);
            xMLToolStripMenuItem1.Text = "XML";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // toolStripMenuIHelp
            // 
            toolStripMenuIHelp.DropDownItems.AddRange(new ToolStripItem[] { byMarvinSoroToolStripMenuItem });
            toolStripMenuIHelp.Name = "toolStripMenuIHelp";
            toolStripMenuIHelp.Size = new Size(44, 20);
            toolStripMenuIHelp.Text = "Help";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(0, 17);
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonNew, toolStripButtonOpen, toolStripButtonSave, toolStripButtonExit });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonNew
            // 
            toolStripButtonNew.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonNew.Image = (Image)resources.GetObject("toolStripButtonNew.Image");
            toolStripButtonNew.ImageTransparentColor = Color.Magenta;
            toolStripButtonNew.Name = "toolStripButtonNew";
            toolStripButtonNew.Size = new Size(23, 22);
            toolStripButtonNew.Text = "toolStripButton1";
            toolStripButtonNew.ToolTipText = "New File";
            toolStripButtonNew.Click += toolStripButtonNew_Click;
            // 
            // toolStripButtonOpen
            // 
            toolStripButtonOpen.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonOpen.Image = (Image)resources.GetObject("toolStripButtonOpen.Image");
            toolStripButtonOpen.ImageTransparentColor = Color.Magenta;
            toolStripButtonOpen.Name = "toolStripButtonOpen";
            toolStripButtonOpen.Size = new Size(23, 22);
            toolStripButtonOpen.Text = "toolStripButton2";
            toolStripButtonOpen.ToolTipText = "Open File";
            toolStripButtonOpen.Click += toolStripButtonOpen_Click;
            // 
            // toolStripButtonSave
            // 
            toolStripButtonSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonSave.Image = (Image)resources.GetObject("toolStripButtonSave.Image");
            toolStripButtonSave.ImageTransparentColor = Color.Magenta;
            toolStripButtonSave.Name = "toolStripButtonSave";
            toolStripButtonSave.Size = new Size(23, 22);
            toolStripButtonSave.Text = "toolStripButton1";
            toolStripButtonSave.ToolTipText = "Save File";
            toolStripButtonSave.Click += toolStripButtonSave_Click;
            // 
            // toolStripButtonExit
            // 
            toolStripButtonExit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonExit.Image = (Image)resources.GetObject("toolStripButtonExit.Image");
            toolStripButtonExit.ImageTransparentColor = Color.Magenta;
            toolStripButtonExit.Name = "toolStripButtonExit";
            toolStripButtonExit.Size = new Size(23, 22);
            toolStripButtonExit.Text = "toolStripButton1";
            toolStripButtonExit.ToolTipText = "Exit";
            toolStripButtonExit.Click += toolStripButtonExit_Click;
            // 
            // byMarvinSoroToolStripMenuItem
            // 
            byMarvinSoroToolStripMenuItem.Name = "byMarvinSoroToolStripMenuItem";
            byMarvinSoroToolStripMenuItem.Size = new Size(180, 22);
            byMarvinSoroToolStripMenuItem.Text = "By: Marvin Soro";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "Main";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuFile;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem savToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuIHelp;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel;
        private ToolStripMenuItem xMLToolStripMenuItem;
        private ToolStripMenuItem jSONToolStripMenuItem;
        private ToolStripMenuItem xMLToolStripMenuItem1;
        private ToolStrip toolStrip1;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripButton toolStripButtonNew;
        private ToolStripButton toolStripButtonOpen;
        private ToolStripButton toolStripButtonSave;
        private ToolStripButton toolStripButtonExit;
        private ToolStripMenuItem byMarvinSoroToolStripMenuItem;
    }
}
