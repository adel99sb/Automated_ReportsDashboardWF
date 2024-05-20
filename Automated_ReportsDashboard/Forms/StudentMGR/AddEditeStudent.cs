using Automated_ReportsDashboard.Data;
using MaterialSkin.Controls;
using System;

namespace Automated_ReportsDashboard.Forms.StudentMGR
{
    public partial class AddEditeStudent : MaterialForm
    {
        public AddEditeStudent()
        {
            InitializeComponent();
            this.SetThemFullWindow();
        }
        public string ActionLable
        {
            get { return label13.Text; }
            set { label13.Text = value; }
        }
        public string placeHolder
        {
            get { return materialMaskedTextBox2.Text; }
            set { materialMaskedTextBox2.Text = value; }
        }

        private void materialFloatingActionButton1_Click(object sender, EventArgs e)
        {
        }
    }
}
