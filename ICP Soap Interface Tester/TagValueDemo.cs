using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ICP_Soap_Interface_Tester.ScadaSoapService;
using System.Web.Services.Protocols;
using System.Threading;
using System.Diagnostics;
using System.Net;

namespace ICP_Soap_Interface_Tester {
    public partial class TagValueDemoForm : Form {
        private SCADASoapService service;
        private double serviceVersion = 0.0;
        private const double EXPECTED_VERSION = 1.02;

        /**
         * Constructor
         */
        public TagValueDemoForm() {
            InitializeComponent();
            
            this.service = new SCADASoapService();
            this.soapURLTextBox.Text = this.service.Url;
            this.soapURLTextBox.TextChanged += soapURLTextBox_TextChanged;

            this.toggleEquipmentWidgets(false);
            this.toggleTagListWidgets(false);
            this.toggleTagDataWidgets(false);

            // Populate the tag aggregate resolution combo box
            this.tagAggregateResolutionComboBox.Items.Add(tagAggregateResolution.HOURLY);
            this.tagAggregateResolutionComboBox.Items.Add(tagAggregateResolution.DAILY);
            this.tagAggregateResolutionComboBox.SelectedIndex = 0;
        }

        /**
         * Called when the user changes the SOAP URL
         */
        private void soapURLTextBox_TextChanged(object sender, EventArgs e) {
            this.toggleEquipmentWidgets(false);
            this.toggleTagListWidgets(false);
            this.toggleTagDataWidgets(false);
        }

        /**
         * Called when the user clicks the Ping button
         */
        private void pingButton_Click(object sender, EventArgs e) {
            this.service.Url = this.soapURLTextBox.Text;
            try {
                this.serviceVersion = double.Parse(this.service.getVersion());
                if (serviceVersion < EXPECTED_VERSION) {
                    MessageBox.Show(
                        String.Format(
                            "This sample client expects the specified ProGauge ICP™ to implement version {0} of the SOAP interface.\n" +
                            "Some functionality may not be available.\n\n" +
                            "Expected Version: {1}\n" +
                            "ICP Version: {2}",
                            EXPECTED_VERSION, EXPECTED_VERSION, serviceVersion
                        ),
                        "Outdated SOAP Interface", MessageBoxButtons.OK, MessageBoxIcon.Warning
                    );
                }
                this.toggleEquipmentWidgets(true);
            } catch (WebException) {
                MessageBox.Show("The specified URL appears to be invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /**
         * Toggle the state widgets
         */
        private void toggleState(bool querying) {
            Action toggleAction = new Action(delegate {
                if (querying) {
                    this.progressBar.Visible = true;
                    this.statusLabel.Text = "Querying ICP...";
                } else {
                    this.progressBar.Visible = false;
                    this.statusLabel.Text = "Ready";
                }
            });

            if (this.InvokeRequired) {
                this.Invoke(toggleAction);
            } else {
                toggleAction.Invoke();
            }
        }

        /**
         * Toggle the enabled/disabled state of the equipment widgets
         */
        private void toggleEquipmentWidgets(bool enabled) {
            Action toggleAction = new Action(delegate {
                // Toggle the equipment list widgets
                if (!enabled)
                    this.equipmentList.Items.Clear();
                this.equipmentListButton.Enabled = enabled;
                this.equipmentList.Enabled = enabled;
            });

            if (this.InvokeRequired) {
                this.Invoke(toggleAction);
            } else {
                toggleAction.Invoke();
            }
        }

        /**
         * Toggle the enabled/disabled state of the tag list widgets
         */
        private void toggleTagListWidgets(bool enabled) {
            Action toggleAction = new Action(delegate {
                // Toggle the tag list widgets
                if (!enabled)
                    this.tagList.Items.Clear();
                this.tagListButton.Enabled = enabled;
                this.tagList.Enabled = enabled;
            });

            if (this.InvokeRequired) {
                this.Invoke(toggleAction);
            } else {
                toggleAction.Invoke();
            }
        }

        /**
         * Toggle the enabled/disabled state of the tag data widgets
         */
        private void toggleTagDataWidgets(bool enabled) {
            Action toggleAction = new Action(delegate {
                // Toggle the tag value widgets
                this.tagValueLatestButton.Enabled = enabled;
                this.tagValueAsOfButton.Enabled = enabled;
                this.tagValueDatePicker.Enabled = enabled;

                // Toggle the tag aggregate values widgets
                this.tagAggregateValuesButton.Enabled = enabled;
                this.tagAggregateStartDatePicker.Enabled = enabled;
                this.tagAggregateEndDatePicker.Enabled = enabled;
                this.tagAggregateResolutionComboBox.Enabled = enabled;
                this.performSlowScanCheckBox.Enabled = enabled;
            });

            if (this.InvokeRequired) {
                this.Invoke(toggleAction);
            } else {
                toggleAction.Invoke();
            }
        }

        /**
         * Called when the user clicks the "Get Equipment" button
         */
        private void equipmentListButton_Click(object sender, EventArgs e) {
            this.toggleState(true); 
            this.equipmentList.Items.Clear();
            this.tagList.Items.Clear();
            this.toggleTagListWidgets(false);
            this.toggleTagDataWidgets(false);

            new Thread(new ThreadStart(delegate {
                try {
                    string[] equipmentList = service.getEquipmentList();
                    if (equipmentList != null) {
                        this.Invoke(new ThreadStart(delegate {
                            foreach (string equipmentName in equipmentList) {
                                if (equipmentName.Trim().Length == 0)
                                    continue;
                                this.equipmentList.Items.Add(equipmentName);
                            }
                            if (equipmentList.Length > 0) {
                                this.equipmentList.SelectedIndex = 0;
                                this.toggleTagListWidgets(true);
                            }
                        }));
                    }
                } catch (WebException ex) {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.toggleState(false);
            })).Start();
        }

        /**
         * Called when the equipment list is populated, or the user changes the selected equipment
         */
        private void equipmentList_SomethingChanged(object sender, EventArgs e) {
            // Enable the tag list widgets
            this.tagList.Items.Clear();
            this.toggleTagListWidgets(true);
        }

        /**
         * Called when the tag list is populated, or the user changes the selected tag
         */
        private void tagList_SomethingChanged(object sender, EventArgs e) {
            this.toggleTagDataWidgets(true);
        }

        /**
         * Called when the user clicks the "Get Tag List" button
         */
        private void tagListButton_Click(object sender, EventArgs e) {
            string equipmentName = this.equipmentList.Text;

            if (equipmentName.Trim().Length == 0) {
                MessageBox.Show("An equipment name must be specified!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.toggleState(true);
            this.tagList.Items.Clear();
            this.toggleTagDataWidgets(false);
            new Thread(new ThreadStart(delegate {
                try {
                    string[] tagList = service.getTagList(equipmentName);
                    if (tagList != null) {
                        this.Invoke(new ThreadStart(delegate {
                            foreach (string tagName in tagList) {
                                if (tagName.Trim().Length == 0)
                                    continue;
                                this.tagList.Items.Add(tagName);
                            }
                            if (tagList.Length > 0) {
                                this.tagList.SelectedIndex = 0;
                                this.toggleTagDataWidgets(true);
                            }
                        }));
                    }
                } catch (SoapException ex) {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.toggleState(false);
            })).Start();
        }

        /**
         * Called when the user clicks the "Get Tag Value Latest..." button
         */
        private void tagValueLatestButton_Click(object sender, EventArgs e) {
            string equipmentName = this.equipmentList.Text;
            string tagName = this.tagList.Text;

            if (equipmentName.Trim().Length == 0) {
                MessageBox.Show("An equipment name must be specified!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else if (tagName.Trim().Length == 0) {
                MessageBox.Show("A tag name must be specified!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.tagTimestampTextBox.Clear();
            this.tagDataTypeTextBox.Clear();
            this.tagValueTextBox.Clear();
            this.toggleState(true);
            new Thread(new ThreadStart(delegate {
                try {
                    tagItem item = service.getTagValueLatest(equipmentName, tagName);
                    if (item != null) {
                        this.Invoke(new ThreadStart(delegate {
                            this.tagTimestampTextBox.Text = item.timestamp.ToString("yyyy-MM-dd hh:mm:ss");
                            this.tagDataTypeTextBox.Text = item.dataType.ToString();
                            this.tagValueTextBox.Text = item.value.ToString();
                        }));
                    }
                } catch (SoapException ex) {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.toggleState(false);
            })).Start();
        }

        /**
         * Called when the user clicks the "Get Tag Value As Of..." button
         */
        private void tagValueAsOfButton_Click(object sender, EventArgs e) {
            string equipmentName = this.equipmentList.Text;
            string tagName = this.tagList.Text;
            DateTime dateTime = this.tagValueDatePicker.Value;

            if (equipmentName.Trim().Length == 0) {
                MessageBox.Show("An equipment name must be specified!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else if (tagName.Trim().Length == 0) {
                MessageBox.Show("A tag name must be specified!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.tagTimestampTextBox.Clear();
            this.tagDataTypeTextBox.Clear();
            this.tagValueTextBox.Clear();
            this.toggleState(true);
            new Thread(new ThreadStart(delegate {
                try {
                    tagItem item = service.getTagValueAsOf(equipmentName, tagName, dateTime, true);
                    if (item != null) {
                        this.Invoke(new ThreadStart(delegate {
                            this.tagTimestampTextBox.Text = item.timestamp.ToString("yyyy-MM-dd hh:mm:ss");
                            this.tagDataTypeTextBox.Text = item.dataType.ToString();
                            this.tagValueTextBox.Text = item.value.ToString();
                        }));
                    }
                } catch (SoapException ex) {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.toggleState(false);
            })).Start();
        }

        /**
         * Called when the user clicks the "Get Aggregate Values" button
         */
        private void tagAggregateValuesButton_Click(object sender, EventArgs e) {
            if (this.serviceVersion < 1.02) {
                MessageBox.Show("Aggregate querying requires SOAP Interface version 1.02 or later", "SOAP Interface Outdated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string equipmentName = this.equipmentList.Text;
            string tagName = this.tagList.Text;
            DateTime startDate = this.tagAggregateStartDatePicker.Value;
            DateTime endDate = this.tagAggregateEndDatePicker.Value;
            tagAggregateResolution resolution = (tagAggregateResolution) this.tagAggregateResolutionComboBox.SelectedItem;
            bool performSlowScan = this.performSlowScanCheckBox.Checked;

            if (equipmentName.Trim().Length == 0) {
                MessageBox.Show("An equipment name must be specified!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else if (tagName.Trim().Length == 0) {
                MessageBox.Show("A tag name must be specified!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.toggleState(true);
            new Thread(new ThreadStart(delegate {
                try {
                    tagAggregateItem[] items = service.getTagAggregateValues(equipmentName, tagName, startDate, true, endDate, true, resolution, true, performSlowScan);
                    this.Invoke(new ThreadStart(delegate {
                        if (items != null && items.Length > 0) {
                            new AggregateTagValuesDialog(items).ShowDialog(this);
                        } else if (!performSlowScan) {
                            MessageBox.Show("No data points were returned. Try using the \"Perform Slow Scan\" option.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }));
                } catch (SoapException ex) {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.toggleState(false);
            })).Start();
        }

    }
}
