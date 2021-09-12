using MaterialSkin;
using MaterialSkin.Controls;
using System.Drawing;
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
