using Automated_ReportsDashboard.Forms.DailayTasksMGR;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Text.Json;
using System.Windows.Forms;

namespace Automated_ReportsDashboard.Data
{
    public static class Helper
    {
        public static void SetThemSmallWindow(this MaterialForm form)
        {
            SetThem(form);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Size = new System.Drawing.Size(700, 500);
        }
        public static void SetThemFullWindow(this MaterialForm form)
        {
            SetThem(form);
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new System.Drawing.Point(60, 0);
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
            foreach (Control item in form.Controls)
            {
                item.Anchor = AnchorStyles.None;
                item.Dock = DockStyle.None;
            }
        }
        public static DialogResult ShowChooseDate(/*string message,*/ string caption, MessageBoxButtons buttons)
        {
            DialogResult result = DialogResult.None;
            switch (buttons)
            {
                case MessageBoxButtons.OKCancel:
                    using (ChoosDate ok = new ChoosDate())
                    {
                        ok.Text = caption;
                        //ok.message = message;
                        result = ok.ShowDialog();
                    }
                    break;
            }
            return result;
        }
        public static T ToObj<T>(this object data)
        {
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var Result = JsonSerializer.Deserialize<T>(data.ToString(), options);
            return Result;
        }
    }
}
