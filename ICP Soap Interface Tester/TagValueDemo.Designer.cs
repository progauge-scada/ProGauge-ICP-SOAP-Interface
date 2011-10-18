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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TagValueDemoForm));
            this.equipmentListButton = new System.Windows.Forms.Button();
            this.equipmentList = new System.Windows.Forms.ComboBox();
            this.equipmentListGroupBox = new System.Windows.Forms.GroupBox();
            this.tagListGroupBox = new System.Windows.Forms.GroupBox();
            this.tagList = new System.Windows.Forms.ComboBox();
            this.tagListButton = new System.Windows.Forms.Button();
            this.tagValueGroupBox = new System.Windows.Forms.GroupBox();
            this.tagValueLatestButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tagTimestampTextBox = new System.Windows.Forms.TextBox();
            this.tagDataTypeLabel = new System.Windows.Forms.Label();
            this.tagDataTypeTextBox = new System.Windows.Forms.TextBox();
            this.tagValueLabel = new System.Windows.Forms.Label();
            this.tagValueDatePicker = new System.Windows.Forms.DateTimePicker();
            this.tagValueTextBox = new System.Windows.Forms.TextBox();
            this.tagValueAsOfButton = new System.Windows.Forms.Button();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.tagAggregateGroupBox = new System.Windows.Forms.GroupBox();
            this.tagAggregateValuesButton = new System.Windows.Forms.Button();
            this.performSlowScanCheckBox = new System.Windows.Forms.CheckBox();
            this.resolutionLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.tagAggregateResolutionComboBox = new System.Windows.Forms.ComboBox();
            this.tagAggregateEndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.tagAggregateStartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.serviceURLGroupBox = new System.Windows.Forms.GroupBox();
            this.pingButton = new System.Windows.Forms.Button();
            this.soapURLTextBox = new System.Windows.Forms.TextBox();
            this.equipmentListGroupBox.SuspendLayout();
            this.tagListGroupBox.SuspendLayout();
            this.tagValueGroupBox.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.tagAggregateGroupBox.SuspendLayout();
            this.serviceURLGroupBox.SuspendLayout();
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
            this.equipmentList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.equipmentListGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.equipmentListGroupBox.Controls.Add(this.equipmentListButton);
            this.equipmentListGroupBox.Controls.Add(this.equipmentList);
            this.equipmentListGroupBox.Location = new System.Drawing.Point(12, 92);
            this.equipmentListGroupBox.Name = "equipmentListGroupBox";
            this.equipmentListGroupBox.Size = new System.Drawing.Size(394, 52);
            this.equipmentListGroupBox.TabIndex = 2;
            this.equipmentListGroupBox.TabStop = false;
            this.equipmentListGroupBox.Text = "Equipment List";
            this.toolTip.SetToolTip(this.equipmentListGroupBox, "ProGauge Prime™ and the ProGauge ICP™ are backed by relational database models.\r\n" +
                    "This means every tag value is associated with one or many pieces of equipment.");
            // 
            // tagListGroupBox
            // 
            this.tagListGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tagListGroupBox.Controls.Add(this.tagList);
            this.tagListGroupBox.Controls.Add(this.tagListButton);
            this.tagListGroupBox.Location = new System.Drawing.Point(12, 150);
            this.tagListGroupBox.Name = "tagListGroupBox";
            this.tagListGroupBox.Size = new System.Drawing.Size(394, 51);
            this.tagListGroupBox.TabIndex = 3;
            this.tagListGroupBox.TabStop = false;
            this.tagListGroupBox.Text = "Tag List";
            this.toolTip.SetToolTip(this.tagListGroupBox, "Every piece of equipment may have any number of tags.");
            // 
            // tagList
            // 
            this.tagList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.tagValueGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tagValueGroupBox.Controls.Add(this.tagValueLatestButton);
            this.tagValueGroupBox.Controls.Add(this.label1);
            this.tagValueGroupBox.Controls.Add(this.tagTimestampTextBox);
            this.tagValueGroupBox.Controls.Add(this.tagDataTypeLabel);
            this.tagValueGroupBox.Controls.Add(this.tagDataTypeTextBox);
            this.tagValueGroupBox.Controls.Add(this.tagValueLabel);
            this.tagValueGroupBox.Controls.Add(this.tagValueDatePicker);
            this.tagValueGroupBox.Controls.Add(this.tagValueTextBox);
            this.tagValueGroupBox.Controls.Add(this.tagValueAsOfButton);
            this.tagValueGroupBox.Location = new System.Drawing.Point(12, 205);
            this.tagValueGroupBox.Name = "tagValueGroupBox";
            this.tagValueGroupBox.Size = new System.Drawing.Size(394, 153);
            this.tagValueGroupBox.TabIndex = 4;
            this.tagValueGroupBox.TabStop = false;
            this.tagValueGroupBox.Text = "Tag Value";
            this.toolTip.SetToolTip(this.tagValueGroupBox, resources.GetString("tagValueGroupBox.ToolTip"));
            // 
            // tagValueLatestButton
            // 
            this.tagValueLatestButton.Location = new System.Drawing.Point(6, 19);
            this.tagValueLatestButton.Name = "tagValueLatestButton";
            this.tagValueLatestButton.Size = new System.Drawing.Size(139, 23);
            this.tagValueLatestButton.TabIndex = 10;
            this.tagValueLatestButton.Text = "Get Tag Value Latest";
            this.tagValueLatestButton.UseVisualStyleBackColor = true;
            this.tagValueLatestButton.Click += new System.EventHandler(this.tagValueLatestButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tag Timestamp:";
            // 
            // tagTimestampTextBox
            // 
            this.tagTimestampTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tagTimestampTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tagTimestampTextBox.Location = new System.Drawing.Point(217, 75);
            this.tagTimestampTextBox.Name = "tagTimestampTextBox";
            this.tagTimestampTextBox.ReadOnly = true;
            this.tagTimestampTextBox.Size = new System.Drawing.Size(171, 20);
            this.tagTimestampTextBox.TabIndex = 8;
            // 
            // tagDataTypeLabel
            // 
            this.tagDataTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tagDataTypeLabel.AutoSize = true;
            this.tagDataTypeLabel.Location = new System.Drawing.Point(132, 103);
            this.tagDataTypeLabel.Name = "tagDataTypeLabel";
            this.tagDataTypeLabel.Size = new System.Drawing.Size(79, 13);
            this.tagDataTypeLabel.TabIndex = 7;
            this.tagDataTypeLabel.Text = "Tag DataType:";
            // 
            // tagDataTypeTextBox
            // 
            this.tagDataTypeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tagDataTypeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tagDataTypeTextBox.Location = new System.Drawing.Point(217, 101);
            this.tagDataTypeTextBox.Name = "tagDataTypeTextBox";
            this.tagDataTypeTextBox.ReadOnly = true;
            this.tagDataTypeTextBox.Size = new System.Drawing.Size(171, 20);
            this.tagDataTypeTextBox.TabIndex = 6;
            // 
            // tagValueLabel
            // 
            this.tagValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tagValueLabel.AutoSize = true;
            this.tagValueLabel.Location = new System.Drawing.Point(152, 129);
            this.tagValueLabel.Name = "tagValueLabel";
            this.tagValueLabel.Size = new System.Drawing.Size(59, 13);
            this.tagValueLabel.TabIndex = 5;
            this.tagValueLabel.Text = "Tag Value:";
            // 
            // tagValueDatePicker
            // 
            this.tagValueDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tagValueDatePicker.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.tagValueDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tagValueDatePicker.Location = new System.Drawing.Point(155, 49);
            this.tagValueDatePicker.Name = "tagValueDatePicker";
            this.tagValueDatePicker.Size = new System.Drawing.Size(233, 20);
            this.tagValueDatePicker.TabIndex = 4;
            // 
            // tagValueTextBox
            // 
            this.tagValueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tagValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tagValueTextBox.Location = new System.Drawing.Point(217, 127);
            this.tagValueTextBox.Name = "tagValueTextBox";
            this.tagValueTextBox.ReadOnly = true;
            this.tagValueTextBox.Size = new System.Drawing.Size(171, 20);
            this.tagValueTextBox.TabIndex = 3;
            // 
            // tagValueAsOfButton
            // 
            this.tagValueAsOfButton.Location = new System.Drawing.Point(6, 48);
            this.tagValueAsOfButton.Name = "tagValueAsOfButton";
            this.tagValueAsOfButton.Size = new System.Drawing.Size(139, 23);
            this.tagValueAsOfButton.TabIndex = 2;
            this.tagValueAsOfButton.Text = "Get Tag Value As Of...";
            this.tagValueAsOfButton.UseVisualStyleBackColor = true;
            this.tagValueAsOfButton.Click += new System.EventHandler(this.tagValueAsOfButton_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.progressBar});
            this.statusBar.Location = new System.Drawing.Point(0, 488);
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
            // tagAggregateGroupBox
            // 
            this.tagAggregateGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tagAggregateGroupBox.Controls.Add(this.tagAggregateValuesButton);
            this.tagAggregateGroupBox.Controls.Add(this.performSlowScanCheckBox);
            this.tagAggregateGroupBox.Controls.Add(this.resolutionLabel);
            this.tagAggregateGroupBox.Controls.Add(this.endDateLabel);
            this.tagAggregateGroupBox.Controls.Add(this.startDateLabel);
            this.tagAggregateGroupBox.Controls.Add(this.tagAggregateResolutionComboBox);
            this.tagAggregateGroupBox.Controls.Add(this.tagAggregateEndDatePicker);
            this.tagAggregateGroupBox.Controls.Add(this.tagAggregateStartDatePicker);
            this.tagAggregateGroupBox.Location = new System.Drawing.Point(12, 364);
            this.tagAggregateGroupBox.Name = "tagAggregateGroupBox";
            this.tagAggregateGroupBox.Size = new System.Drawing.Size(394, 121);
            this.tagAggregateGroupBox.TabIndex = 6;
            this.tagAggregateGroupBox.TabStop = false;
            this.tagAggregateGroupBox.Text = "Tag Aggregate Values";
            this.toolTip.SetToolTip(this.tagAggregateGroupBox, resources.GetString("tagAggregateGroupBox.ToolTip"));
            // 
            // tagAggregateValuesButton
            // 
            this.tagAggregateValuesButton.Location = new System.Drawing.Point(6, 19);
            this.tagAggregateValuesButton.Name = "tagAggregateValuesButton";
            this.tagAggregateValuesButton.Size = new System.Drawing.Size(139, 23);
            this.tagAggregateValuesButton.TabIndex = 14;
            this.tagAggregateValuesButton.Text = "Get Aggregate Values";
            this.tagAggregateValuesButton.UseVisualStyleBackColor = true;
            this.tagAggregateValuesButton.Click += new System.EventHandler(this.tagAggregateValuesButton_Click);
            // 
            // performSlowScanCheckBox
            // 
            this.performSlowScanCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.performSlowScanCheckBox.AutoSize = true;
            this.performSlowScanCheckBox.Location = new System.Drawing.Point(217, 98);
            this.performSlowScanCheckBox.Name = "performSlowScanCheckBox";
            this.performSlowScanCheckBox.Size = new System.Drawing.Size(116, 17);
            this.performSlowScanCheckBox.TabIndex = 13;
            this.performSlowScanCheckBox.Text = "Perform Slow Scan";
            this.performSlowScanCheckBox.UseVisualStyleBackColor = true;
            // 
            // resolutionLabel
            // 
            this.resolutionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resolutionLabel.AutoSize = true;
            this.resolutionLabel.Location = new System.Drawing.Point(125, 74);
            this.resolutionLabel.Name = "resolutionLabel";
            this.resolutionLabel.Size = new System.Drawing.Size(86, 13);
            this.resolutionLabel.TabIndex = 12;
            this.resolutionLabel.Text = "Time Resolution:";
            // 
            // endDateLabel
            // 
            this.endDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(156, 49);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(55, 13);
            this.endDateLabel.TabIndex = 11;
            this.endDateLabel.Text = "End Date:";
            // 
            // startDateLabel
            // 
            this.startDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(156, 23);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(58, 13);
            this.startDateLabel.TabIndex = 10;
            this.startDateLabel.Text = "Start Date:";
            // 
            // tagAggregateResolutionComboBox
            // 
            this.tagAggregateResolutionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tagAggregateResolutionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tagAggregateResolutionComboBox.FormattingEnabled = true;
            this.tagAggregateResolutionComboBox.Location = new System.Drawing.Point(217, 71);
            this.tagAggregateResolutionComboBox.Name = "tagAggregateResolutionComboBox";
            this.tagAggregateResolutionComboBox.Size = new System.Drawing.Size(171, 21);
            this.tagAggregateResolutionComboBox.TabIndex = 7;
            // 
            // tagAggregateEndDatePicker
            // 
            this.tagAggregateEndDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tagAggregateEndDatePicker.CustomFormat = "yyyy-MM-dd";
            this.tagAggregateEndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tagAggregateEndDatePicker.Location = new System.Drawing.Point(217, 45);
            this.tagAggregateEndDatePicker.Name = "tagAggregateEndDatePicker";
            this.tagAggregateEndDatePicker.Size = new System.Drawing.Size(171, 20);
            this.tagAggregateEndDatePicker.TabIndex = 6;
            this.toolTip.SetToolTip(this.tagAggregateEndDatePicker, "Automatically rounds up to 23:59:59.999");
            // 
            // tagAggregateStartDatePicker
            // 
            this.tagAggregateStartDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tagAggregateStartDatePicker.CustomFormat = "yyyy-MM-dd";
            this.tagAggregateStartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tagAggregateStartDatePicker.Location = new System.Drawing.Point(217, 19);
            this.tagAggregateStartDatePicker.Name = "tagAggregateStartDatePicker";
            this.tagAggregateStartDatePicker.Size = new System.Drawing.Size(171, 20);
            this.tagAggregateStartDatePicker.TabIndex = 5;
            this.toolTip.SetToolTip(this.tagAggregateStartDatePicker, "Automatically rounds down to 00:00:00.000");
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            // 
            // serviceURLGroupBox
            // 
            this.serviceURLGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.serviceURLGroupBox.Controls.Add(this.pingButton);
            this.serviceURLGroupBox.Controls.Add(this.soapURLTextBox);
            this.serviceURLGroupBox.Location = new System.Drawing.Point(12, 12);
            this.serviceURLGroupBox.Name = "serviceURLGroupBox";
            this.serviceURLGroupBox.Size = new System.Drawing.Size(394, 74);
            this.serviceURLGroupBox.TabIndex = 7;
            this.serviceURLGroupBox.TabStop = false;
            this.serviceURLGroupBox.Text = "ICP SOAP URL";
            // 
            // pingButton
            // 
            this.pingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pingButton.Location = new System.Drawing.Point(313, 45);
            this.pingButton.Name = "pingButton";
            this.pingButton.Size = new System.Drawing.Size(75, 23);
            this.pingButton.TabIndex = 1;
            this.pingButton.Text = "Ping";
            this.pingButton.UseVisualStyleBackColor = true;
            this.pingButton.Click += new System.EventHandler(this.pingButton_Click);
            // 
            // soapURLTextBox
            // 
            this.soapURLTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.soapURLTextBox.Location = new System.Drawing.Point(6, 19);
            this.soapURLTextBox.Name = "soapURLTextBox";
            this.soapURLTextBox.Size = new System.Drawing.Size(382, 20);
            this.soapURLTextBox.TabIndex = 0;
            // 
            // TagValueDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 510);
            this.Controls.Add(this.serviceURLGroupBox);
            this.Controls.Add(this.tagAggregateGroupBox);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.tagValueGroupBox);
            this.Controls.Add(this.tagListGroupBox);
            this.Controls.Add(this.equipmentListGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(434, 548);
            this.Name = "TagValueDemoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProGauge ICP™ SOAP Interface Demo";
            this.equipmentListGroupBox.ResumeLayout(false);
            this.tagListGroupBox.ResumeLayout(false);
            this.tagValueGroupBox.ResumeLayout(false);
            this.tagValueGroupBox.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.tagAggregateGroupBox.ResumeLayout(false);
            this.tagAggregateGroupBox.PerformLayout();
            this.serviceURLGroupBox.ResumeLayout(false);
            this.serviceURLGroupBox.PerformLayout();
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
        private System.Windows.Forms.Button tagValueAsOfButton;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.DateTimePicker tagValueDatePicker;
        private System.Windows.Forms.Label tagValueLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tagTimestampTextBox;
        private System.Windows.Forms.Label tagDataTypeLabel;
        private System.Windows.Forms.TextBox tagDataTypeTextBox;
        private System.Windows.Forms.GroupBox tagAggregateGroupBox;
        private System.Windows.Forms.Label resolutionLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.ComboBox tagAggregateResolutionComboBox;
        private System.Windows.Forms.DateTimePicker tagAggregateEndDatePicker;
        private System.Windows.Forms.DateTimePicker tagAggregateStartDatePicker;
        private System.Windows.Forms.CheckBox performSlowScanCheckBox;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button tagAggregateValuesButton;
        private System.Windows.Forms.GroupBox serviceURLGroupBox;
        private System.Windows.Forms.TextBox soapURLTextBox;
        private System.Windows.Forms.Button pingButton;
        private System.Windows.Forms.Button tagValueLatestButton;
    }
}

