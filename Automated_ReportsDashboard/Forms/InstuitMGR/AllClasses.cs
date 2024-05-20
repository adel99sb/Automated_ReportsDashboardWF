using Automated_ReportsDashboard.Data;
using MaterialSkin.Controls;
using System.Data;
using System.Windows.Forms;

namespace Automated_ReportsDashboard.Forms.InstuitMGR
{
    public partial class AllClasses : MaterialForm
    {
        public AllClasses()
        {
            
            InitializeComponent();
            this.SetThemFullWindow();
        }

        private void groupBox2_Enter(object sender, System.EventArgs e)
        {

        }

        private void materialFloatingActionButton3_Click(object sender, System.EventArgs e)
        {
            AddEditeClass add = new AddEditeClass();
            add.ShowDialog();
        }

        private void AllClasses_FormClosed(object sender, FormClosedEventArgs e)
        {
            Classes classes = new Classes();
            classes.Show();
            this.Hide();
        }
    }
}
