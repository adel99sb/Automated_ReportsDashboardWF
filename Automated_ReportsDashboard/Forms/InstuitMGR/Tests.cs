using Automated_ReportsDashboard.Data;
using MaterialSkin.Controls;

namespace Automated_ReportsDashboard.Forms.InstuitMGR
{
    public partial class Tests : MaterialForm
    {
        public Tests()
        {
            InitializeComponent();
            this.SetThemFullWindow();
        }

        private void materialButton1_Click(object sender, System.EventArgs e)
        {
            AddEditeTest form2 = new AddEditeTest();
            form2.Text = "add";
            form2.ActionLable = "add";
            form2.ShowDialog();
        }

        private void materialFloatingActionButton3_Click(object sender, System.EventArgs e)
        {
            AddEditeTest form2 = new AddEditeTest();
            form2.Text = "edite";
            form2.ActionLable = "edite";
            form2.placeHolder = "T1";
            form2.ShowDialog();
        }

        private void Tests_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            InstuitMGR instuit = new InstuitMGR();
            instuit.Show();
            this.Hide();
        }
    }
}
