using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ICP_Soap_Interface_Tester.ScadaSoapService;

namespace ICP_Soap_Interface_Tester {
    public partial class AggregateTagValuesDialog : Form {

        /**
         * Constructor
         */
        public AggregateTagValuesDialog(tagAggregateItem[] tagAggregateItems) {
            InitializeComponent();
            foreach (tagAggregateItem item in tagAggregateItems) {
                this.aggregateDataGrid.Rows.Add(
                    new object[] { item.timestamp.ToString("yyyy-MM-dd HH:mm:ss"), item.pointCount, item.sum, item.average }
                );
            }
        }
    }
}
