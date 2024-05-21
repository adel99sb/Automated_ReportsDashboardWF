using Automated_ReportsDashboard.Data;
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace Automated_ReportsDashboard.Forms.DailayTasksMGR
{
    public partial class AddSessions : MaterialForm
    {
        public AddSessions()
        {
            InitializeComponent();
            this.SetThemFullWindow();
        }

        private void AddSessions_FormClosed(object sender, FormClosedEventArgs e)
        {
            DailyTasksMGR dailyTasksMGR = new DailyTasksMGR();
            dailyTasksMGR.Show();
            this.Hide();
        }

        private void materialFloatingActionButton1_Click(object sender, System.EventArgs e)
        {

        }
    }
}
