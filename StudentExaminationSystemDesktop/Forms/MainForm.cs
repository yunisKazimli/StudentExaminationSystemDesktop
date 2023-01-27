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

namespace StudentExaminationSystemDesktop.Forms
{
    public partial class MainForm : XtraForm
    {
        public MainForm()
        {
            InitializeComponent();

            subFormCtrl = new Controllers.SubFormController(this, childrenFormContainerPanelControl);

            OpenEntrance();
        }
    }
}