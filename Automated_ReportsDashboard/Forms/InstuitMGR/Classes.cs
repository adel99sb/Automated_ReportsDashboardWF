using Automated_ReportsDashboard.Data;
using MaterialSkin.Controls;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Automated_ReportsDashboard.Forms.InstuitMGR
{
    public partial class Classes : MaterialForm
    {
        public Classes()
        {
            InitializeComponent();
            this.SetThemFullWindow();
            List<string> classes = new List<string>();
            List<string> days = new List<string>();
            for (int i = 1; i < 7; i++)
            {
                days.Add("D"+i.ToString());
            }
            for (int i = 1; i <3; i++)
            {
                classes.Add("C"+i.ToString());
            }
            label1.Location = new System.Drawing.Point(4, 75);
            Panel Container = new Panel();
            TableLayoutPanel panel = new TableLayoutPanel();
            Container.Size = new System.Drawing.Size(this.Width - 10, 200);
            Container.Location = new System.Drawing.Point(6, 120);
            Container.BorderStyle = BorderStyle.FixedSingle;
            panel.ColumnCount = 1;
            panel.RowCount = 1;
            panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150));
            panel.Controls.Add(new Label() { Text = "   الموعد  /   اليوم"
            ,Anchor = AnchorStyles.None}, 0, 0);

            panel.ColumnCount = panel.ColumnCount + classes.Count;
            panel.RowCount = panel.RowCount + days.Count;
            for (int i = 1; i < panel.RowCount - 1; i++)
            {
                panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25));
            }
            for (int i = 1;i < panel.ColumnCount - 1; i++)
            {

                panel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250));
            }
            for (int i = 0; i < days.Count; i++)
            {
                panel.Controls.Add(new Label() { Text = $"Day {days[i]}"
            ,Anchor = AnchorStyles.None},0, i + 1);
            }
            for (int j = 0; j < classes.Count; j++)
            {
                panel.Controls.Add(new Label() { Text = $"Class {classes[j]}"
            ,Anchor = AnchorStyles.None},j + 1, 0);                
            }
            panel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;                        
            //fill            
            panel.Anchor = AnchorStyles.None;
            panel.Dock = DockStyle.Fill;            
            panel.AutoSize = true;
            panel.AutoScroll = true;
            Container.Controls.Add(panel);
            this.Controls.Add(Container);
            for (int i = 0; i < days.Count; i++)
            {
                for (int j = 0; j < classes.Count; j++)
                {
                    panel.Controls.Add(
                        new Label() { Text = $"م:رياضيات/ق:الاولى"
                        ,
                            Anchor = AnchorStyles.None
                        }, j + 1, i + 1);
                }
            }

        }

        private void materialFloatingActionButton3_Click(object sender, System.EventArgs e)
        {
            AllClasses all = new AllClasses();
            all.Show();
            this.Hide();
        }

        private void materialFloatingActionButton1_Click(object sender, System.EventArgs e)
        {
            AddEditeClass add = new AddEditeClass();
            add.ShowDialog();
        }

        private void Classes_FormClosed(object sender, FormClosedEventArgs e)
        {
            InstuitMGR instuitMGR = new InstuitMGR();
            instuitMGR.Show();
            this.Hide();            
        }
    }
}
