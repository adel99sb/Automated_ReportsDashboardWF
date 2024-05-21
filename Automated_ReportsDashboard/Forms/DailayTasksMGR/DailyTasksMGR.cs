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

namespace Automated_ReportsDashboard.Forms.DailayTasksMGR
{
    public partial class DailyTasksMGR : MaterialForm
    {
        public DailyTasksMGR()
        {
            InitializeComponent();
            this.SetThemFullWindow();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
           var result =  Helper.ShowChooseDate("PLZ Choose Date:", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                AddSessions addSessions = new AddSessions();
                addSessions.Show();
                this.Hide();
            }
        }

        private void DailyTasksMGR_FormClosed(object sender, FormClosedEventArgs e)
        {
            DailyTasks daily = new DailyTasks();
            daily.Show();
            this.Hide();
        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.materialTabControl1.SelectedIndex == 2)
            {
              var result = Helper.ShowChooseDate("PLZ Choose Date:", MessageBoxButtons.OKCancel);                
                if (result == DialogResult.OK)
                {                    
                    this.Hide();
                    var n = new DailyTasksMGR();                  
                    n.materialTabControl1.SelectTab(2);
                    n.Show();
                }
                else
                {
                    this.Hide();                    
                    var n = new DailyTasksMGR();
                    n.materialTabControl1.SelectTab(0);
                    n.Show();
                }   
            }
        }
    }
}
