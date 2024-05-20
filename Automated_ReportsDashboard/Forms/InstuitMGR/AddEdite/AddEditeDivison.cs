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
    public partial class AddEditeDivison : MaterialForm
    {
        public AddEditeDivison()
        {
            InitializeComponent();
            this.SetThemSmallWindow(); 
        }
        public string ActionLable
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        public string placeHolder
        {
            get { return materialMaskedTextBox1.Text; }
            set { materialMaskedTextBox1.Text = value; }
        }
    }
}
