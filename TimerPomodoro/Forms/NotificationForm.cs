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
        public NotificationForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
        }

        #region Close the notification window
        private void CloseNotificationButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
