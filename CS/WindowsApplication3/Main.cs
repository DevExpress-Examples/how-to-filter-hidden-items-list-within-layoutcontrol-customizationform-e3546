using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;


namespace DXSample {
    public partial class Main: XtraForm {
        public Main() {
            InitializeComponent();
        }

        private void OnFormLoad(object sender, EventArgs e) {
            layoutControl1.RegisterUserCustomizationForm(typeof(AdvancedCustomizationForm));
        }
    }
}
