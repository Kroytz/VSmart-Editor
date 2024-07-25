﻿namespace VSmart_Editor
{
    partial class FormMenu
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            //recentFilesToolStripMenuItem = new ToolStripMenuItem();
            //reloadToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            exportAsVsmartToolStripMenuItem = new ToolStripMenuItem();
            debugToolStripMenuItem = new ToolStripMenuItem();
            showDebugInfoToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            documentationToolStripMenuItem = new ToolStripMenuItem();
            //toolStripMenuItem1 = new ToolStripMenuItem();     //TODO:What is this todo for?
            reExportToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, exportToolStripMenuItem, debugToolStripMenuItem, helpToolStripMenuItem, /*toolStripMenuItem1*/ });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(244, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, /*recentFilesToolStripMenuItem, reloadToolStripMenuItem,*/ saveToolStripMenuItem, saveAsToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // recentFilesToolStripMenuItem
            // 
            // recentFilesToolStripMenuItem.Name = "recentFilesToolStripMenuItem";
            // recentFilesToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            // recentFilesToolStripMenuItem.Text = "Recent files";
            // 
            // reloadToolStripMenuItem
            // 
            // reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            // reloadToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            // reloadToolStripMenuItem.Text = "Reload";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            saveAsToolStripMenuItem.Text = "Save as";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportAsVsmartToolStripMenuItem, reExportToolStripMenuItem });
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            exportToolStripMenuItem.Text = "Export";
            // 
            // exportAsVsmartToolStripMenuItem
            // 
            exportAsVsmartToolStripMenuItem.Name = "exportAsVsmartToolStripMenuItem";
            exportAsVsmartToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            exportAsVsmartToolStripMenuItem.Text = "Export as vsmart";
            exportAsVsmartToolStripMenuItem.Click += exportAsVsmartToolStripMenuItem_Click;
            // 
            // debugToolStripMenuItem
            // 
            debugToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { showDebugInfoToolStripMenuItem });
            debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            debugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            debugToolStripMenuItem.Text = "Debug";
            // 
            // showDebugInfoToolStripMenuItem
            // 
            showDebugInfoToolStripMenuItem.CheckOnClick = true;
            showDebugInfoToolStripMenuItem.Name = "showDebugInfoToolStripMenuItem";
            showDebugInfoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            showDebugInfoToolStripMenuItem.Text = "Show debug info";
            showDebugInfoToolStripMenuItem.Click += showDebugInfoToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { documentationToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // documentationToolStripMenuItem
            // 
            documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            documentationToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            documentationToolStripMenuItem.Text = "Documentation";
            documentationToolStripMenuItem.Click += documentationToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            //toolStripMenuItem1.Name = "toolStripMenuItem1";
            //toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // reExportToolStripMenuItem
            // 
            reExportToolStripMenuItem.Name = "reExportToolStripMenuItem";
            reExportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            reExportToolStripMenuItem.Text = "Re-export";
            reExportToolStripMenuItem.Click += reExportToolStripMenuItem_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(244, 42);
            ControlBox = false;
            Controls.Add(menuStrip1);
            ForeColor = System.Drawing.Color.DarkGray;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimumSize = new System.Drawing.Size(240, 60); //TODO:How to display auto-filling
            Name = "FormMenu";
            ShowIcon = false;
            Text = "File Manager";
            Load += FormMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        //private ToolStripMenuItem reloadToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem exportAsVsmartToolStripMenuItem;
        private ToolStripMenuItem debugToolStripMenuItem;
        private ToolStripMenuItem showDebugInfoToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem documentationToolStripMenuItem;
        //private ToolStripMenuItem recentFilesToolStripMenuItem;
        //private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem reExportToolStripMenuItem;
    }
}