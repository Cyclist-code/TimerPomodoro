
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
            this.StopButton = new MaterialSkin.Controls.MaterialButton();
            this.StartButton = new MaterialSkin.Controls.MaterialButton();
            this.TimerLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SettingsTabPage = new System.Windows.Forms.TabPage();
            this.ColorThemeGroupBox = new System.Windows.Forms.GroupBox();
            this.OrangeRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.BlueRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.GreenRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.PurpleRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.ColorThemeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ThemeGroupBox = new System.Windows.Forms.GroupBox();
            this.DarkThemeSwitch = new MaterialSkin.Controls.MaterialSwitch();
            this.ThemeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.AboutTabPage = new System.Windows.Forms.TabPage();
            this.SideMenuImageList = new System.Windows.Forms.ImageList(this.components);
            this.SideMenuTabControl.SuspendLayout();
            this.HomeTabPage.SuspendLayout();
            this.SettingsTabPage.SuspendLayout();
            this.ColorThemeGroupBox.SuspendLayout();
            this.ThemeGroupBox.SuspendLayout();
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
            this.HomeTabPage.BackColor = System.Drawing.Color.White;
            this.HomeTabPage.Controls.Add(this.StopButton);
            this.HomeTabPage.Controls.Add(this.StartButton);
            this.HomeTabPage.Controls.Add(this.TimerLabel);
            this.HomeTabPage.ImageKey = "home.png";
            this.HomeTabPage.Location = new System.Drawing.Point(4, 39);
            this.HomeTabPage.Name = "HomeTabPage";
            this.HomeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.HomeTabPage.Size = new System.Drawing.Size(586, 340);
            this.HomeTabPage.TabIndex = 0;
            this.HomeTabPage.Text = "Home";
            // 
            // StopButton
            // 
            this.StopButton.AutoSize = false;
            this.StopButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StopButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.StopButton.Depth = 0;
            this.StopButton.HighEmphasis = true;
            this.StopButton.Icon = null;
            this.StopButton.Location = new System.Drawing.Point(279, 234);
            this.StopButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.StopButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(140, 40);
            this.StopButton.TabIndex = 2;
            this.StopButton.Text = "Stop";
            this.StopButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.StopButton.UseAccentColor = false;
            this.StopButton.UseVisualStyleBackColor = true;
            // 
            // StartButton
            // 
            this.StartButton.AutoSize = false;
            this.StartButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StartButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.StartButton.Depth = 0;
            this.StartButton.HighEmphasis = true;
            this.StartButton.Icon = null;
            this.StartButton.Location = new System.Drawing.Point(121, 234);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.StartButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(140, 40);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.StartButton.UseAccentColor = false;
            this.StartButton.UseVisualStyleBackColor = true;
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Depth = 0;
            this.TimerLabel.Font = new System.Drawing.Font("Roboto Light", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TimerLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H1;
            this.TimerLabel.Location = new System.Drawing.Point(152, 86);
            this.TimerLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(233, 115);
            this.TimerLabel.TabIndex = 0;
            this.TimerLabel.Text = "25:00";
            // 
            // SettingsTabPage
            // 
            this.SettingsTabPage.BackColor = System.Drawing.Color.White;
            this.SettingsTabPage.Controls.Add(this.ColorThemeGroupBox);
            this.SettingsTabPage.Controls.Add(this.ThemeGroupBox);
            this.SettingsTabPage.ImageKey = "settings.png";
            this.SettingsTabPage.Location = new System.Drawing.Point(4, 39);
            this.SettingsTabPage.Name = "SettingsTabPage";
            this.SettingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsTabPage.Size = new System.Drawing.Size(586, 340);
            this.SettingsTabPage.TabIndex = 1;
            this.SettingsTabPage.Text = "Settings";
            // 
            // ColorThemeGroupBox
            // 
            this.ColorThemeGroupBox.Controls.Add(this.OrangeRadioButton);
            this.ColorThemeGroupBox.Controls.Add(this.BlueRadioButton);
            this.ColorThemeGroupBox.Controls.Add(this.GreenRadioButton);
            this.ColorThemeGroupBox.Controls.Add(this.PurpleRadioButton);
            this.ColorThemeGroupBox.Controls.Add(this.ColorThemeLabel);
            this.ColorThemeGroupBox.Location = new System.Drawing.Point(142, 10);
            this.ColorThemeGroupBox.Name = "ColorThemeGroupBox";
            this.ColorThemeGroupBox.Size = new System.Drawing.Size(323, 60);
            this.ColorThemeGroupBox.TabIndex = 2;
            this.ColorThemeGroupBox.TabStop = false;
            // 
            // OrangeRadioButton
            // 
            this.OrangeRadioButton.AutoSize = true;
            this.OrangeRadioButton.Depth = 0;
            this.OrangeRadioButton.Location = new System.Drawing.Point(225, 15);
            this.OrangeRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.OrangeRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.OrangeRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.OrangeRadioButton.Name = "OrangeRadioButton";
            this.OrangeRadioButton.Ripple = true;
            this.OrangeRadioButton.Size = new System.Drawing.Size(86, 37);
            this.OrangeRadioButton.TabIndex = 5;
            this.OrangeRadioButton.TabStop = true;
            this.OrangeRadioButton.Text = "Orange";
            this.OrangeRadioButton.UseVisualStyleBackColor = true;
            // 
            // BlueRadioButton
            // 
            this.BlueRadioButton.AutoSize = true;
            this.BlueRadioButton.Depth = 0;
            this.BlueRadioButton.Location = new System.Drawing.Point(159, 15);
            this.BlueRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.BlueRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.BlueRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.BlueRadioButton.Name = "BlueRadioButton";
            this.BlueRadioButton.Ripple = true;
            this.BlueRadioButton.Size = new System.Drawing.Size(66, 37);
            this.BlueRadioButton.TabIndex = 4;
            this.BlueRadioButton.TabStop = true;
            this.BlueRadioButton.Text = "Blue";
            this.BlueRadioButton.UseVisualStyleBackColor = true;
            // 
            // GreenRadioButton
            // 
            this.GreenRadioButton.AutoSize = true;
            this.GreenRadioButton.Depth = 0;
            this.GreenRadioButton.Location = new System.Drawing.Point(83, 15);
            this.GreenRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.GreenRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.GreenRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.GreenRadioButton.Name = "GreenRadioButton";
            this.GreenRadioButton.Ripple = true;
            this.GreenRadioButton.Size = new System.Drawing.Size(76, 37);
            this.GreenRadioButton.TabIndex = 4;
            this.GreenRadioButton.TabStop = true;
            this.GreenRadioButton.Text = "Green";
            this.GreenRadioButton.UseVisualStyleBackColor = true;
            // 
            // PurpleRadioButton
            // 
            this.PurpleRadioButton.AutoSize = true;
            this.PurpleRadioButton.Checked = true;
            this.PurpleRadioButton.Depth = 0;
            this.PurpleRadioButton.Location = new System.Drawing.Point(3, 15);
            this.PurpleRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.PurpleRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.PurpleRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.PurpleRadioButton.Name = "PurpleRadioButton";
            this.PurpleRadioButton.Ripple = true;
            this.PurpleRadioButton.Size = new System.Drawing.Size(80, 37);
            this.PurpleRadioButton.TabIndex = 3;
            this.PurpleRadioButton.TabStop = true;
            this.PurpleRadioButton.Text = "Purple";
            this.PurpleRadioButton.UseVisualStyleBackColor = true;
            // 
            // ColorThemeLabel
            // 
            this.ColorThemeLabel.AutoSize = true;
            this.ColorThemeLabel.Depth = 0;
            this.ColorThemeLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ColorThemeLabel.Location = new System.Drawing.Point(8, -2);
            this.ColorThemeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ColorThemeLabel.Name = "ColorThemeLabel";
            this.ColorThemeLabel.Size = new System.Drawing.Size(86, 19);
            this.ColorThemeLabel.TabIndex = 1;
            this.ColorThemeLabel.Text = "Color theme";
            // 
            // ThemeGroupBox
            // 
            this.ThemeGroupBox.Controls.Add(this.DarkThemeSwitch);
            this.ThemeGroupBox.Controls.Add(this.ThemeLabel);
            this.ThemeGroupBox.Location = new System.Drawing.Point(6, 10);
            this.ThemeGroupBox.Name = "ThemeGroupBox";
            this.ThemeGroupBox.Size = new System.Drawing.Size(130, 60);
            this.ThemeGroupBox.TabIndex = 0;
            this.ThemeGroupBox.TabStop = false;
            // 
            // DarkThemeSwitch
            // 
            this.DarkThemeSwitch.AutoSize = true;
            this.DarkThemeSwitch.Depth = 0;
            this.DarkThemeSwitch.Location = new System.Drawing.Point(11, 16);
            this.DarkThemeSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.DarkThemeSwitch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.DarkThemeSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            this.DarkThemeSwitch.Name = "DarkThemeSwitch";
            this.DarkThemeSwitch.Ripple = true;
            this.DarkThemeSwitch.Size = new System.Drawing.Size(91, 37);
            this.DarkThemeSwitch.TabIndex = 1;
            this.DarkThemeSwitch.Text = "Dark";
            this.DarkThemeSwitch.UseVisualStyleBackColor = true;
            // 
            // ThemeLabel
            // 
            this.ThemeLabel.AutoSize = true;
            this.ThemeLabel.Depth = 0;
            this.ThemeLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ThemeLabel.Location = new System.Drawing.Point(8, -2);
            this.ThemeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ThemeLabel.Name = "ThemeLabel";
            this.ThemeLabel.Size = new System.Drawing.Size(50, 19);
            this.ThemeLabel.TabIndex = 1;
            this.ThemeLabel.Text = "Theme";
            // 
            // AboutTabPage
            // 
            this.AboutTabPage.BackColor = System.Drawing.Color.White;
            this.AboutTabPage.ImageKey = "info.png";
            this.AboutTabPage.Location = new System.Drawing.Point(4, 39);
            this.AboutTabPage.Name = "AboutTabPage";
            this.AboutTabPage.Size = new System.Drawing.Size(586, 340);
            this.AboutTabPage.TabIndex = 2;
            this.AboutTabPage.Text = "About";
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
            this.HomeTabPage.ResumeLayout(false);
            this.HomeTabPage.PerformLayout();
            this.SettingsTabPage.ResumeLayout(false);
            this.ColorThemeGroupBox.ResumeLayout(false);
            this.ColorThemeGroupBox.PerformLayout();
            this.ThemeGroupBox.ResumeLayout(false);
            this.ThemeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl SideMenuTabControl;
        private System.Windows.Forms.TabPage HomeTabPage;
        private System.Windows.Forms.TabPage SettingsTabPage;
        private System.Windows.Forms.ImageList SideMenuImageList;
        private System.Windows.Forms.TabPage AboutTabPage;
        private MaterialSkin.Controls.MaterialLabel TimerLabel;
        private MaterialSkin.Controls.MaterialButton StartButton;
        private MaterialSkin.Controls.MaterialButton StopButton;
        private System.Windows.Forms.GroupBox ThemeGroupBox;
        private MaterialSkin.Controls.MaterialLabel ThemeLabel;
        private MaterialSkin.Controls.MaterialSwitch DarkThemeSwitch;
        private System.Windows.Forms.GroupBox ColorThemeGroupBox;
        private MaterialSkin.Controls.MaterialLabel ColorThemeLabel;
        private MaterialSkin.Controls.MaterialRadioButton BlueRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton GreenRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton PurpleRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton OrangeRadioButton;
    }
}

