using Automated_ReportsDashboard.Data;
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace Automated_ReportsDashboard.Forms.DailayTasksMGR
{
    public partial class DailyTasks : MaterialForm
    {
        public DailyTasks()
        {
            InitializeComponent();
            this.SetThemFullWindow();
        }

        private void DailyTasks_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
