﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.WinFormList
{
    public partial class NewBlandWF : DevExpress.XtraEditors.XtraForm
    {
        public NewBlandWF()
        {
            InitializeComponent();
        }

        private void SBCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }
    }
}