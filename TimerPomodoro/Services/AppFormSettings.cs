using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace TimerPomodoro.Services
{
    public static class AppFormSettings
    {
        #region Global variables
        static MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;

        static ColorScheme colorSchemePurple = new ColorScheme(Primary.Purple800, Primary.Purple900, Primary.Purple800, Accent.Purple400, TextShade.WHITE);
        static ColorScheme colorSchemeGreen = new ColorScheme(Primary.Green700, Primary.Green900, Primary.Green500, Accent.Green400, TextShade.WHITE);
        static ColorScheme colorSchemeBlue = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.Blue400, TextShade.WHITE);
        static ColorScheme colorSchemeOrange = new ColorScheme(Primary.Orange800, Primary.Orange900, Primary.Orange500, Accent.Orange200, TextShade.WHITE);
        #endregion

        #region Default theme installation method
        public static void InstallingDefaultTheme(MainForm mainForm, MaterialSwitch DarkThemeSwitch, 
            MaterialRadioButton PurpleRadioButton, MaterialRadioButton GreenRadioButton, 
            MaterialRadioButton BlueRadioButton, MaterialRadioButton OrangeRadioButton)
        {
            string theme = Properties.Settings.Default.DarkTheme;

            materialSkinManager.AddFormToManage(mainForm);

            if ((theme == "0") || (theme == "") || (theme == " "))
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;             
            }
            if (theme == "1")
            {
                DarkThemeSwitch.Checked = true;
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;               
            }

            string color = Properties.Settings.Default.ColorScheme;

            if ((color == "0") || (color == "") || (color == " "))
            {
                materialSkinManager.ColorScheme = colorSchemePurple;
                PurpleRadioButton.Checked = true;
            }
            if (color == "1")
            {
                materialSkinManager.ColorScheme = colorSchemeGreen;
                GreenRadioButton.Checked = true;
            }
            if (color == "2")
            {
                materialSkinManager.ColorScheme = colorSchemeBlue;
                BlueRadioButton.Checked = true;
            }
            if (color == "3")
            {
                materialSkinManager.ColorScheme = colorSchemeOrange;
                OrangeRadioButton.Checked = true;
            }
        }
        #endregion

        #region Dark Theme Selection Method
        public static void ChoosingDarkTheme(MaterialSwitch DarkThemeSwitch)
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

        #region Method for choosing a color scheme for an application
        public static void ChoosingColorScheme(RadioButton PurpleRadioButton, RadioButton GreenRadioButton,
            RadioButton BlueRadioButton, RadioButton OrangeRadioButton)
        {
            if (PurpleRadioButton.Checked == true)
            {
                materialSkinManager.ColorScheme = colorSchemePurple;
                Properties.Settings.Default.ColorScheme = "0";
                Properties.Settings.Default.Save();
            }

            if (GreenRadioButton.Checked == true)
            {
                materialSkinManager.ColorScheme = colorSchemeGreen;
                Properties.Settings.Default.ColorScheme = "1";
                Properties.Settings.Default.Save();
            }

            if (BlueRadioButton.Checked == true)
            {
                materialSkinManager.ColorScheme = colorSchemeBlue;
                Properties.Settings.Default.ColorScheme = "2";
                Properties.Settings.Default.Save();
            }

            if (OrangeRadioButton.Checked == true)
            {
                materialSkinManager.ColorScheme = colorSchemeOrange;
                Properties.Settings.Default.ColorScheme = "3";
                Properties.Settings.Default.Save();
            }
        }
        #endregion
    }
}
