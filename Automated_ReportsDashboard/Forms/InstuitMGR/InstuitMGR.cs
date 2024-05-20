using Automated_ReportsDashboard.Data;
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

namespace Automated_ReportsDashboard.Forms.InstuitMGR
{
    public partial class InstuitMGR : MaterialForm
    {
        public InstuitMGR()
        {
            InitializeComponent();
            this.SetThemFullWindow();
            
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            AddEditeDivison form2 = new AddEditeDivison();
            form2.Text = "add";
            form2.ActionLable = "add";
            form2.ShowDialog(); 
        }

        private void materialFloatingActionButton2_Click(object sender, EventArgs e)
        {
            AddEditeDivison form2 = new AddEditeDivison();
            form2.Text = "edite";
            form2.ActionLable = "edite";
            form2.placeHolder = "D1";
            form2.ShowDialog();
        }

        private void materialFloatingActionButton1_Click(object sender, EventArgs e)
        {
                      
        }

        private void materialFloatingActionButton4_Click(object sender, EventArgs e)
        {
            Tests tests = new Tests();
            tests.Show();
            this.Hide();
        }

        private void materialFloatingActionButton3_Click(object sender, EventArgs e)
        {
            Classes tests = new Classes();
            tests.Show();
            this.Hide();
        }

        private void InstuitMGR_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
