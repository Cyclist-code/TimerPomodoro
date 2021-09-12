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
using TimerPomodoro.Services;

namespace TimerPomodoro
{
    public partial class MainForm : MaterialForm
    {
        #region Global variables
        MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
        #endregion


        public MainForm()
        {
            InitializeComponent();

            #region Installing the default theme
            string theme = Properties.Settings.Default.DarkTheme;

            materialSkinManager.AddFormToManage(this);

            if ((theme == "0") || (theme == "") || (theme == " "))
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple800, Primary.Purple900, Primary.Purple800, Accent.Purple400, TextShade.WHITE);
            }
            if (theme == "1")
            {
                DarkThemeSwitch.Checked = true;
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple800, Primary.Purple900, Primary.Purple800, Accent.Purple400, TextShade.WHITE);
            }
            #endregion

        }

        #region Choosing a color scheme for the application
        private void ChoosingColorScheme(object sender, EventArgs e)
        {
            AppFormSettings.ChoosingColorScheme(PurpleRadioButton, GreenRadioButton, BlueRadioButton, OrangeRadioButton);
        }
        #endregion

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
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                Properties.Settings.Default.DarkTheme = "1";
                Properties.Settings.Default.Save();
            }
            else
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                Properties.Settings.Default.DarkTheme = "0";
                Properties.Settings.Default.Save();
            }
        }
        #endregion

    }
}
