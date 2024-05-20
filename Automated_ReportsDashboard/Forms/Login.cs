using Automated_ReportsDashboard.Data;
using Automated_ReportsDashboard.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Automated_ReportsDashboard
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();
            this.SetThemSmallWindow();
        }

        private void materialFloatingActionButton1_Click(object sender, System.EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
