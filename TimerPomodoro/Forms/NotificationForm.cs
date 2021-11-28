using MaterialSkin;
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

namespace TimerPomodoro.Forms
{
    public enum IconNotification
    {
        Rest,
        Work
    }

    public partial class NotificationForm : MaterialForm
    {
        public NotificationForm(string message, IconNotification icon)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            ShowNotification(message, icon);
            FormLocation();
        }

        #region Method of positioning the form in the lower right corner of the screen
        private void FormLocation()
        {
            StartPosition = FormStartPosition.Manual;
            Point point = Screen.PrimaryScreen.WorkingArea.Location;
            point.Offset(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            point.Offset(-Width, -Height);
            Location = point;

            TopMost = true;
        }
        #endregion

        #region Method for displaying text and notification icons
        private void ShowNotification(string message, IconNotification icon)
        {
            MessageLabel.Text = message;

            switch (icon)
            {
                case IconNotification.Rest:
                    WorkRestImage.Image = Properties.Resources.rest;
                    break;
                case IconNotification.Work:
                    WorkRestImage.Image = Properties.Resources.work;
                    break;
            }
        }
        #endregion

        #region Close the notification window
        private void CloseNotificationButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
