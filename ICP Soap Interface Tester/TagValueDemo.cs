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

namespace ICP_Soap_Interface_Tester {
    public partial class TagValueDemoForm : Form {
        private SCADASoapService service;

        public TagValueDemoForm() {
            InitializeComponent();
            this.progressBar.Visible = false;
            this.statusLabel.Text = "Ready";
            this.service = new SCADASoapService();
            
            // Disable the tag list widgets
            this.tagListButton.Enabled = false;
            this.tagList.Enabled = false;

            // Disable the tag value widgets
            this.tagValueButton.Enabled = false;
            this.tagValueDatePicker.Enabled = false;
        }

        private void equipmentListButton_Click(object sender, EventArgs e) {
            this.equipmentList.Items.Clear();
            this.progressBar.Visible = true;
            this.statusLabel.Text = "Querying ICP...";

            // Disable the tag list widgets
            this.tagListButton.Enabled = false;
            this.tagList.Enabled = false;

            // Disable the tag value widgets
            this.tagValueButton.Enabled = false;
            this.tagValueDatePicker.Enabled = false;

            new Thread(new ThreadStart(delegate {
                try {
                    string[] equipmentList = service.getEquipmentList();
                    if (equipmentList != null) {
                        this.Invoke(new ThreadStart(delegate {
                            this.equipmentList.Items.AddRange(equipmentList);
                            if (equipmentList.Length > 0)
                                this.equipmentList.SelectedIndex = 0;
                        }));
                    }
                } catch (SoapException ex) {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Invoke(new ThreadStart(delegate {
                    this.progressBar.Visible = false;
                    this.statusLabel.Text = "Ready";
                }));
            })).Start();
        }

        private void equipmentList_SomethingChanged(object sender, EventArgs e) {
            // Enable the tag list widgets
            this.tagListButton.Enabled = true;
            this.tagList.Enabled = true;
        }

        private void tagListButton_Click(object sender, EventArgs e) {
            this.tagList.Items.Clear();
            this.progressBar.Visible = true;
            this.statusLabel.Text = "Querying ICP...";

            // Disable the tag value widgets
            this.tagValueButton.Enabled = false;
            this.tagValueDatePicker.Enabled = false;

            string equipmentName = this.equipmentList.Text;
            new Thread(new ThreadStart(delegate {
                try {
                    string[] tagList = service.getTagList(equipmentName);
                    if (tagList != null) {
                        this.Invoke(new ThreadStart(delegate {
                            this.tagList.Items.AddRange(tagList);
                            if (tagList.Length > 0)
                                this.tagList.SelectedIndex = 0;
                        }));
                    }
                } catch (SoapException ex) {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Invoke(new ThreadStart(delegate {
                    this.progressBar.Visible = false;
                    this.statusLabel.Text = "Ready";
                }));
            })).Start();
        }

        private void tagList_SomethingChanged(object sender, EventArgs e) {
            // Enable the tag value widgets
            this.tagValueButton.Enabled = true;
            this.tagValueDatePicker.Enabled = true;
        }

        private void tagValueButton_Click(object sender, EventArgs e) {
            this.progressBar.Visible = true;
            this.statusLabel.Text = "Querying ICP...";

            this.tagValueTextBox.Clear();

            string equipmentName = this.equipmentList.Text;
            string tagName = this.tagList.Text;
            DateTime dateTime = this.tagValueDatePicker.Value;
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
                this.Invoke(new ThreadStart(delegate {
                    this.progressBar.Visible = false;
                    this.statusLabel.Text = "Ready";
                }));
            })).Start();
        }

    }
}
