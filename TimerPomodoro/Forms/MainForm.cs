using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace TimerPomodoro
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple800, Primary.Purple900, Primary.Purple800, Accent.Purple400, TextShade.WHITE);
        }

        #region Handling button clicks
        private void ButtonClickHandler(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                switch (button.Name)
                {
                    case "DetailedInformationButton":
                        Process.Start("https://lifehacker.com/productivity-101-a-primer-to-the-pomodoro-technique-1598992730");
                        break;
                    case "GitHubProfileButton":
                        Process.Start("https://github.com/Cyclist-code/TimerPomodoro");
                        break;
                    case "EmailDeveloperButton":
                        Clipboard.SetText("cyclistcode@gmail.com");
                        break;
                    case "DocumentationButton":
                        Process.Start("https://github.com/Cyclist-code/TimerPomodoro/blob/main/README.md");
                        break;

                }
            }
        }
        #endregion

        #region Choosing a dark theme
        private void DarkThemeSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (DarkThemeSwitch.Checked == true)
            {
                var materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            }
            else
            {
                var materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            }
        }
        #endregion

    }
}
