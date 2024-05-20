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
    public partial class Payments : MaterialForm
    {
        public Payments()
        {
            InitializeComponent();
            this.SetThemFullWindow();
        }

        private void materialFloatingActionButton3_Click(object sender, EventArgs e)
        {
            AddPayment add = new AddPayment();
            add.ShowDialog();
        }

        private void Payments_FormClosed(object sender, FormClosedEventArgs e)
        {
            Students students = new Students();
            students.Show();
            this.Hide();
        }
    }
}
