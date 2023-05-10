using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Power2000.CommuCfg
{
    public partial class LableControl : UserControl
    {

        public LableControl()
        {
            InitializeComponent();
        }

        private Logiclinks logiclinks;
        public LableControl(Logiclinks logiclinks)
        {
            this.logiclinks = logiclinks;
            InitializeComponent();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            TerminalExportDlg termExportDlg = new TerminalExportDlg(logiclinks);
            termExportDlg.ShowDialog();
        }

      
    }
}
