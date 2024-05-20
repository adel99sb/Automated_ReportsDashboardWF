using Automated_ReportsDashboard.Data;
using MaterialSkin.Controls;

namespace Automated_ReportsDashboard.Forms.InstuitMGR
{
    public partial class AddEditeTeacher : MaterialForm
    {
        public AddEditeTeacher()
        {
            InitializeComponent();
            this.SetThemSmallWindow();
        }
        public string ActionLable
        {
            get { return label5.Text; }
            set { label5.Text = value; }
        }
        public string placeHolder
        {
            get { return materialMaskedTextBox1.Text; }
            set { materialMaskedTextBox1.Text = value; }
        }
    }
}
