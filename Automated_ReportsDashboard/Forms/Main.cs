using Automated_ReportsDashboard.Data;
using Automated_ReportsDashboard.Forms.InstuitMGR;
using MaterialSkin;
using MaterialSkin.Controls;

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
    }
}
