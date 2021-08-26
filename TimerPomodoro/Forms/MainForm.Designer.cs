
namespace TimerPomodoro
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SideMenuTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.HomeTabPage = new System.Windows.Forms.TabPage();
            this.SettingsTabPage = new System.Windows.Forms.TabPage();
            this.AboutTabPage = new System.Windows.Forms.TabPage();
            this.SideMenuImageList = new System.Windows.Forms.ImageList(this.components);
            this.SideMenuTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideMenuTabControl
            // 
            this.SideMenuTabControl.Controls.Add(this.HomeTabPage);
            this.SideMenuTabControl.Controls.Add(this.SettingsTabPage);
            this.SideMenuTabControl.Controls.Add(this.AboutTabPage);
            this.SideMenuTabControl.Depth = 0;
            this.SideMenuTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SideMenuTabControl.ImageList = this.SideMenuImageList;
            this.SideMenuTabControl.Location = new System.Drawing.Point(3, 64);
            this.SideMenuTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.SideMenuTabControl.Multiline = true;
            this.SideMenuTabControl.Name = "SideMenuTabControl";
            this.SideMenuTabControl.SelectedIndex = 0;
            this.SideMenuTabControl.Size = new System.Drawing.Size(594, 383);
            this.SideMenuTabControl.TabIndex = 0;
            // 
            // HomeTabPage
            // 
            this.HomeTabPage.ImageKey = "home.png";
            this.HomeTabPage.Location = new System.Drawing.Point(4, 39);
            this.HomeTabPage.Name = "HomeTabPage";
            this.HomeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.HomeTabPage.Size = new System.Drawing.Size(586, 340);
            this.HomeTabPage.TabIndex = 0;
            this.HomeTabPage.Text = "Home";
            this.HomeTabPage.UseVisualStyleBackColor = true;
            // 
            // SettingsTabPage
            // 
            this.SettingsTabPage.ImageKey = "settings.png";
            this.SettingsTabPage.Location = new System.Drawing.Point(4, 39);
            this.SettingsTabPage.Name = "SettingsTabPage";
            this.SettingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsTabPage.Size = new System.Drawing.Size(586, 340);
            this.SettingsTabPage.TabIndex = 1;
            this.SettingsTabPage.Text = "Settings";
            this.SettingsTabPage.UseVisualStyleBackColor = true;
            // 
            // AboutTabPage
            // 
            this.AboutTabPage.ImageKey = "info.png";
            this.AboutTabPage.Location = new System.Drawing.Point(4, 39);
            this.AboutTabPage.Name = "AboutTabPage";
            this.AboutTabPage.Size = new System.Drawing.Size(586, 340);
            this.AboutTabPage.TabIndex = 2;
            this.AboutTabPage.Text = "About";
            this.AboutTabPage.UseVisualStyleBackColor = true;
            // 
            // SideMenuImageList
            // 
            this.SideMenuImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("SideMenuImageList.ImageStream")));
            this.SideMenuImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.SideMenuImageList.Images.SetKeyName(0, "home.png");
            this.SideMenuImageList.Images.SetKeyName(1, "info.png");
            this.SideMenuImageList.Images.SetKeyName(2, "settings.png");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.SideMenuTabControl);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.SideMenuTabControl;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer Pomodoro";
            this.SideMenuTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl SideMenuTabControl;
        private System.Windows.Forms.TabPage HomeTabPage;
        private System.Windows.Forms.TabPage SettingsTabPage;
        private System.Windows.Forms.ImageList SideMenuImageList;
        private System.Windows.Forms.TabPage AboutTabPage;
    }
}

