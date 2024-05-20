﻿using Automated_ReportsDashboard.Data;
using MaterialSkin.Controls;

namespace Automated_ReportsDashboard.Forms.InstuitMGR
{
    public partial class AddEditeTest : MaterialForm
    {
        public AddEditeTest()
        {
            InitializeComponent();
            this.SetThemSmallWindow();
        }
        public string ActionLable
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        public string placeHolder
        {
            get { return materialMaskedTextBox1.Text; }
            set { materialMaskedTextBox1.Text = value; }
        }
    }
}
