using Automated_ReportsDashboard.Data;
using Automated_ReportsDashboard.Forms.InstuitMGR;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automated_ReportsDashboard.Forms.StudentMGR
{
    public partial class Students : MaterialForm
    {
        public Students()
        {
            InitializeComponent();
            this.SetThemFullWindow();
        }

        private void Students_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void materialFloatingActionButton3_Click(object sender, EventArgs e)
        {
            AddEditeStudent form2 = new AddEditeStudent();
            form2.Text = "add";
            form2.ActionLable = "add";
            form2.ShowDialog();
        }

        private void materialFloatingActionButton2_Click(object sender, EventArgs e)
        {
            AddEditeStudent form2 = new AddEditeStudent();
            form2.Text = "edite";
            form2.ActionLable = "edite";
            form2.placeHolder = "S1";
            form2.ShowDialog();
        }

        private void materialFloatingActionButton4_Click(object sender, EventArgs e)
        {
            Payments payments = new Payments();
            payments.Show();
            this.Hide();
        }
    }
}
