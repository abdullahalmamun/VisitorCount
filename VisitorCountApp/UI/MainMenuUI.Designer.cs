﻿namespace VisitorCountApp
{
    partial class MainMenuUI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.visitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitorEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoneSpecificVisitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoneSpecificVisitorNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visitorToolStripMenuItem,
            this.setupToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(452, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // visitorToolStripMenuItem
            // 
            this.visitorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visitorEntryToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.visitorToolStripMenuItem.Name = "visitorToolStripMenuItem";
            this.visitorToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.visitorToolStripMenuItem.Text = "Visitor";
            // 
            // visitorEntryToolStripMenuItem
            // 
            this.visitorEntryToolStripMenuItem.Name = "visitorEntryToolStripMenuItem";
            this.visitorEntryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.visitorEntryToolStripMenuItem.Text = "Visitor Entry";
            this.visitorEntryToolStripMenuItem.Click += new System.EventHandler(this.visitorEntryToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zToolStripMenuItem});
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.setupToolStripMenuItem.Text = "Setup";
            // 
            // zToolStripMenuItem
            // 
            this.zToolStripMenuItem.Name = "zToolStripMenuItem";
            this.zToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.zToolStripMenuItem.Text = "Zone type";
            this.zToolStripMenuItem.Click += new System.EventHandler(this.zToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoneSpecificVisitorToolStripMenuItem,
            this.zoneSpecificVisitorNumberToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // zoneSpecificVisitorToolStripMenuItem
            // 
            this.zoneSpecificVisitorToolStripMenuItem.Name = "zoneSpecificVisitorToolStripMenuItem";
            this.zoneSpecificVisitorToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.zoneSpecificVisitorToolStripMenuItem.Text = "Zone Specific Visitor Details";
            this.zoneSpecificVisitorToolStripMenuItem.Click += new System.EventHandler(this.zoneSpecificVisitorToolStripMenuItem_Click);
            // 
            // zoneSpecificVisitorNumberToolStripMenuItem
            // 
            this.zoneSpecificVisitorNumberToolStripMenuItem.Name = "zoneSpecificVisitorNumberToolStripMenuItem";
            this.zoneSpecificVisitorNumberToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.zoneSpecificVisitorNumberToolStripMenuItem.Text = "Zone Specific Visitor Number";
            this.zoneSpecificVisitorNumberToolStripMenuItem.Click += new System.EventHandler(this.zoneSpecificVisitorNumberToolStripMenuItem_Click);
            // 
            // MainMenuUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 308);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainMenuUI";
            this.Text = "Main Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem visitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitorEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoneSpecificVisitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoneSpecificVisitorNumberToolStripMenuItem;
    }
}

