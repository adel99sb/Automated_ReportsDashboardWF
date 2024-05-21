using Automated_ReportsDashboard.Data;
using Automated_ReportsDashboard.Forms.DailayTasksMGR;
using Automated_ReportsDashboard.Forms.InstuitMGR;
using Automated_ReportsDashboard.Forms.StudentMGR;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace Automated_ReportsDashboard.Forms
{
    public partial class Main : MaterialForm
    {
        public Main()
        {
            InitializeComponent();
            this.SetThemFullWindow();
        }

        private void materialButton1_Click(object sender, System.EventArgs e)
        {
            InstuitMGR.InstuitMGR mGR = new InstuitMGR.InstuitMGR();
            mGR.Show();
            this.Hide();
        }

        private void materialButton2_Click(object sender, System.EventArgs e)
        {
            Students mGR = new Students();
            mGR.Show();
            this.Hide();
        }

        private void Main_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            DialogResult dialog =
                MaterialMessageBox.Show("هل انت متاكد  من رغبتك باغلاق التطبيق ؟؟"
                , "تأكيد الخروج",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (dialog == DialogResult.Cancel)
            {
               e.Cancel = true;
            }
        }

        private void materialButton4_Click(object sender, System.EventArgs e)
        {
            DailyTasks dailyTasks = new DailyTasks();
            dailyTasks.Show();
            this.Hide();
        }
    }
}
