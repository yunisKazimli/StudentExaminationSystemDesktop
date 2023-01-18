﻿using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentExaminationSystemDesktop.Admin
{
    public partial class AdminForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private MainForm _mainForm;

        private string _token;

        public AdminForm(MainForm mainForm, string token)
        {
            InitializeComponent();

            _mainForm = mainForm;
            _token = token;
        }

        private void logoutBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            Logout();
        }
    }
}