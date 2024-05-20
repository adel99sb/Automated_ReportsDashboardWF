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

        private void materialButton2_Click(object sender, EventArgs e)
        {
            AddEditeHall form2 = new AddEditeHall();
            form2.Text = "add";
            form2.ActionLable = "add";
            form2.ShowDialog();
        }

        private void materialFloatingActionButton5_Click(object sender, EventArgs e)
        {

            AddEditeHall form2 = new AddEditeHall();
            form2.Text = "edite";
            form2.ActionLable = "edite";
            form2.placeHolder = "H1";
            form2.ShowDialog();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            AddEditeTeacher form2 = new AddEditeTeacher();
            form2.Text = "add";
            form2.ActionLable = "add";
            form2.ShowDialog();
        }

        private void materialFloatingActionButton9_Click(object sender, EventArgs e)
        {
            AddEditeTeacher form2 = new AddEditeTeacher();
            form2.Text = "edite";
            form2.ActionLable = "edite";
            form2.placeHolder = "Te1";
            form2.ShowDialog();
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            AddEditeTime form2 = new AddEditeTime();
            form2.Text = "add";
            form2.ActionLable = "add";
            form2.ShowDialog();
        }

        private void materialFloatingActionButton13_Click(object sender, EventArgs e)
        {
            AddEditeTime form2 = new AddEditeTime();
            form2.Text = "edite";
            form2.ActionLable = "edite";
            form2.placeHolder = "T1";
            form2.ShowDialog();
        }
    }
}
