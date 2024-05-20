    using MaterialSkin;
using MaterialSkin.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Windows.Forms;
using Automated_ReportsDashboard.Forms.InstuitMGR;
using System.Runtime.CompilerServices;

namespace Automated_ReportsDashboard.Data
{
    public static class Helper
    {
        public static void SetThemSmallWindow(this MaterialForm form)
        {
            SetThem(form);
            form.Size = new System.Drawing.Size(700, 500);
        }
        public static void SetThemFullWindow(this MaterialForm form)
        {
            SetThem(form);
            form.Size = new System.Drawing.Size(1300, 800);
        }
        private static void SetThem(this MaterialForm form)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(form);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue500,
                Primary.Yellow400, Primary.Blue500, Accent.Blue400, TextShade.BLACK);
            form.MaximizeBox = false;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.Sizable = false;
            form.StartPosition = FormStartPosition.CenterScreen;
            foreach (Control item in form.Controls)
            {
                item.Anchor = AnchorStyles.None;
                item.Dock = DockStyle.None;
            }
        }
    }
}
