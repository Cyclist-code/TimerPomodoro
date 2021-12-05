using System;
using System.Diagnostics;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using TimerPomodoro.Services;
using TimerPomodoro.Forms;

namespace TimerPomodoro
{
    public partial class MainForm : MaterialForm
    {
        #region Global variables 
        int minutes, seconds;
        bool isRested = false;

        readonly NotificationForm notificationForm = new NotificationForm();
        #endregion

        public MainForm()
        {
            InitializeComponent();

            #region Installing the default theme
            AppFormSettings.InstallingDefaultTheme(this, DarkThemeSwitch, PurpleRadioButton, GreenRadioButton,
               BlueRadioButton, OrangeRadioButton);
            #endregion

            minutes = Convert.ToInt32(WorkNumericUpDown.Value);
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

        private void StartButton_Click(object sender, EventArgs e)
        {
            Countdown.Start();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            Countdown.Stop();
        }
        #endregion

        #region Method for displaying the countdown
        private void Countdown_Tick(object sender, EventArgs e)
        {
            seconds = seconds - 1;
            if (seconds == -1)
            {
                minutes = minutes - 1;
                seconds = 59;
            }

            if (minutes == 0 && seconds == 0)
            {
                Countdown.Stop();
                if (!isRested)
                {
                    notificationForm.ShowNotification("Time is over! Time to get some rest.", IconNotification.Rest);
                    minutes = Convert.ToInt32(WorkNumericUpDown.Value);
                    isRested = true;
                }
                else
                {
                    notificationForm.ShowNotification("It's time to get back to work.", IconNotification.Work);
                    minutes = Convert.ToInt32(RestNumericUpDown.Value);
                    isRested = false;
                }
            }

            MinutesLabel.Text = Convert.ToString(minutes);
            SecondsLabel.Text = Convert.ToString(seconds);
        }
        #endregion

        #region Choosing a dark theme
        private void DarkThemeSwitch_CheckedChanged(object sender, EventArgs e)
        {
            AppFormSettings.ChoosingDarkTheme(DarkThemeSwitch);
        }
        #endregion

    }
}
