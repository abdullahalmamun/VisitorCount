namespace VisitorCountApp.UI
{
    partial class ZoneSpecificVisitorInformationReportUI
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
            this.totalZoneSpecificTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.zoneSpecificVisitorInformationListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.showButton = new System.Windows.Forms.Button();
            this.selectZoneComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // totalZoneSpecificTextBox
            // 
            this.totalZoneSpecificTextBox.Location = new System.Drawing.Point(440, 356);
            this.totalZoneSpecificTextBox.Name = "totalZoneSpecificTextBox";
            this.totalZoneSpecificTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalZoneSpecificTextBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Total";
            // 
            // zoneSpecificVisitorInformationListView
            // 
            this.zoneSpecificVisitorInformationListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.zoneSpecificVisitorInformationListView.GridLines = true;
            this.zoneSpecificVisitorInformationListView.Location = new System.Drawing.Point(22, 109);
            this.zoneSpecificVisitorInformationListView.Name = "zoneSpecificVisitorInformationListView";
            this.zoneSpecificVisitorInformationListView.Size = new System.Drawing.Size(578, 231);
            this.zoneSpecificVisitorInformationListView.TabIndex = 9;
            this.zoneSpecificVisitorInformationListView.UseCompatibleStateImageBehavior = false;
            this.zoneSpecificVisitorInformationListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 39;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 199;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Email";
            this.columnHeader3.Width = 202;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Contact Number";
            this.columnHeader4.Width = 134;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(376, 32);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 8;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // selectZoneComboBox
            // 
            this.selectZoneComboBox.FormattingEnabled = true;
            this.selectZoneComboBox.Location = new System.Drawing.Point(143, 32);
            this.selectZoneComboBox.Name = "selectZoneComboBox";
            this.selectZoneComboBox.Size = new System.Drawing.Size(201, 21);
            this.selectZoneComboBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select Zone";
            // 
            // ZoneSpecificVisitorInformationReportUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 420);
            this.Controls.Add(this.totalZoneSpecificTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.zoneSpecificVisitorInformationListView);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.selectZoneComboBox);
            this.Controls.Add(this.label1);
            this.Name = "ZoneSpecificVisitorInformationReportUI";
            this.Text = "ZoneSpecificVisitorInformationReportUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox totalZoneSpecificTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView zoneSpecificVisitorInformationListView;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.ComboBox selectZoneComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}