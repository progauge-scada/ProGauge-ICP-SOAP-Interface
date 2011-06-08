namespace ICP_Soap_Interface_Tester {
    partial class TagValueDemoForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.equipmentListButton = new System.Windows.Forms.Button();
            this.equipmentList = new System.Windows.Forms.ComboBox();
            this.equipmentListGroupBox = new System.Windows.Forms.GroupBox();
            this.tagListGroupBox = new System.Windows.Forms.GroupBox();
            this.tagList = new System.Windows.Forms.ComboBox();
            this.tagListButton = new System.Windows.Forms.Button();
            this.tagValueGroupBox = new System.Windows.Forms.GroupBox();
            this.tagValueLabel = new System.Windows.Forms.Label();
            this.tagValueDatePicker = new System.Windows.Forms.DateTimePicker();
            this.tagValueTextBox = new System.Windows.Forms.TextBox();
            this.tagValueButton = new System.Windows.Forms.Button();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.equipmentListGroupBox.SuspendLayout();
            this.tagListGroupBox.SuspendLayout();
            this.tagValueGroupBox.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // equipmentListButton
            // 
            this.equipmentListButton.Location = new System.Drawing.Point(6, 19);
            this.equipmentListButton.Name = "equipmentListButton";
            this.equipmentListButton.Size = new System.Drawing.Size(139, 23);
            this.equipmentListButton.TabIndex = 0;
            this.equipmentListButton.Text = "Get Equipment List";
            this.equipmentListButton.UseVisualStyleBackColor = true;
            this.equipmentListButton.Click += new System.EventHandler(this.equipmentListButton_Click);
            // 
            // equipmentList
            // 
            this.equipmentList.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.equipmentList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.equipmentList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.equipmentList.FormattingEnabled = true;
            this.equipmentList.Location = new System.Drawing.Point(155, 21);
            this.equipmentList.Name = "equipmentList";
            this.equipmentList.Size = new System.Drawing.Size(233, 21);
            this.equipmentList.TabIndex = 1;
            this.equipmentList.SelectedIndexChanged += new System.EventHandler(this.equipmentList_SomethingChanged);
            this.equipmentList.TextChanged += new System.EventHandler(this.equipmentList_SomethingChanged);
            // 
            // equipmentListGroupBox
            // 
            this.equipmentListGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.equipmentListGroupBox.Controls.Add(this.equipmentListButton);
            this.equipmentListGroupBox.Controls.Add(this.equipmentList);
            this.equipmentListGroupBox.Location = new System.Drawing.Point(12, 12);
            this.equipmentListGroupBox.Name = "equipmentListGroupBox";
            this.equipmentListGroupBox.Size = new System.Drawing.Size(394, 52);
            this.equipmentListGroupBox.TabIndex = 2;
            this.equipmentListGroupBox.TabStop = false;
            this.equipmentListGroupBox.Text = "Equipment List";
            // 
            // tagListGroupBox
            // 
            this.tagListGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tagListGroupBox.Controls.Add(this.tagList);
            this.tagListGroupBox.Controls.Add(this.tagListButton);
            this.tagListGroupBox.Location = new System.Drawing.Point(12, 70);
            this.tagListGroupBox.Name = "tagListGroupBox";
            this.tagListGroupBox.Size = new System.Drawing.Size(394, 51);
            this.tagListGroupBox.TabIndex = 3;
            this.tagListGroupBox.TabStop = false;
            this.tagListGroupBox.Text = "Tag List";
            // 
            // tagList
            // 
            this.tagList.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tagList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tagList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tagList.FormattingEnabled = true;
            this.tagList.Location = new System.Drawing.Point(155, 21);
            this.tagList.Name = "tagList";
            this.tagList.Size = new System.Drawing.Size(233, 21);
            this.tagList.TabIndex = 2;
            this.tagList.SelectedIndexChanged += new System.EventHandler(this.tagList_SomethingChanged);
            this.tagList.TextChanged += new System.EventHandler(this.tagList_SomethingChanged);
            // 
            // tagListButton
            // 
            this.tagListButton.Location = new System.Drawing.Point(6, 19);
            this.tagListButton.Name = "tagListButton";
            this.tagListButton.Size = new System.Drawing.Size(139, 23);
            this.tagListButton.TabIndex = 1;
            this.tagListButton.Text = "Get Tag List";
            this.tagListButton.UseVisualStyleBackColor = true;
            this.tagListButton.Click += new System.EventHandler(this.tagListButton_Click);
            // 
            // tagValueGroupBox
            // 
            this.tagValueGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tagValueGroupBox.Controls.Add(this.tagValueLabel);
            this.tagValueGroupBox.Controls.Add(this.tagValueDatePicker);
            this.tagValueGroupBox.Controls.Add(this.tagValueTextBox);
            this.tagValueGroupBox.Controls.Add(this.tagValueButton);
            this.tagValueGroupBox.Location = new System.Drawing.Point(12, 127);
            this.tagValueGroupBox.Name = "tagValueGroupBox";
            this.tagValueGroupBox.Size = new System.Drawing.Size(394, 74);
            this.tagValueGroupBox.TabIndex = 4;
            this.tagValueGroupBox.TabStop = false;
            this.tagValueGroupBox.Text = "Tag Value";
            // 
            // tagValueLabel
            // 
            this.tagValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tagValueLabel.AutoSize = true;
            this.tagValueLabel.Location = new System.Drawing.Point(152, 47);
            this.tagValueLabel.Name = "tagValueLabel";
            this.tagValueLabel.Size = new System.Drawing.Size(59, 13);
            this.tagValueLabel.TabIndex = 5;
            this.tagValueLabel.Text = "Tag Value:";
            // 
            // tagValueDatePicker
            // 
            this.tagValueDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tagValueDatePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.tagValueDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tagValueDatePicker.Location = new System.Drawing.Point(155, 19);
            this.tagValueDatePicker.Name = "tagValueDatePicker";
            this.tagValueDatePicker.Size = new System.Drawing.Size(233, 20);
            this.tagValueDatePicker.TabIndex = 4;
            // 
            // tagValueTextBox
            // 
            this.tagValueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tagValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tagValueTextBox.Location = new System.Drawing.Point(217, 45);
            this.tagValueTextBox.Name = "tagValueTextBox";
            this.tagValueTextBox.ReadOnly = true;
            this.tagValueTextBox.Size = new System.Drawing.Size(171, 20);
            this.tagValueTextBox.TabIndex = 3;
            // 
            // tagValueButton
            // 
            this.tagValueButton.Location = new System.Drawing.Point(6, 19);
            this.tagValueButton.Name = "tagValueButton";
            this.tagValueButton.Size = new System.Drawing.Size(139, 23);
            this.tagValueButton.TabIndex = 2;
            this.tagValueButton.Text = "Get Tag Value";
            this.tagValueButton.UseVisualStyleBackColor = true;
            this.tagValueButton.Click += new System.EventHandler(this.tagValueButton_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.progressBar});
            this.statusBar.Location = new System.Drawing.Point(0, 204);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(418, 22);
            this.statusBar.TabIndex = 5;
            this.statusBar.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(39, 17);
            this.statusLabel.Text = "Ready";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // TagValueDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 226);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.tagValueGroupBox);
            this.Controls.Add(this.tagListGroupBox);
            this.Controls.Add(this.equipmentListGroupBox);
            this.MinimumSize = new System.Drawing.Size(434, 264);
            this.Name = "TagValueDemoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tag Value Demo";
            this.equipmentListGroupBox.ResumeLayout(false);
            this.tagListGroupBox.ResumeLayout(false);
            this.tagValueGroupBox.ResumeLayout(false);
            this.tagValueGroupBox.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button equipmentListButton;
        private System.Windows.Forms.ComboBox equipmentList;
        private System.Windows.Forms.GroupBox equipmentListGroupBox;
        private System.Windows.Forms.GroupBox tagListGroupBox;
        private System.Windows.Forms.Button tagListButton;
        private System.Windows.Forms.ComboBox tagList;
        private System.Windows.Forms.GroupBox tagValueGroupBox;
        private System.Windows.Forms.TextBox tagValueTextBox;
        private System.Windows.Forms.Button tagValueButton;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.DateTimePicker tagValueDatePicker;
        private System.Windows.Forms.Label tagValueLabel;
    }
}

