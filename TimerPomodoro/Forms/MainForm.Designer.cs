
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
            this.RestMinutesGroupBox = new System.Windows.Forms.GroupBox();
            this.RestTitleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.RestMinutesLabel = new MaterialSkin.Controls.MaterialLabel();
            this.RestNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.WorkMinutesGroupBox = new System.Windows.Forms.GroupBox();
            this.WorkTitleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.WorkMinutesLabel = new MaterialSkin.Controls.MaterialLabel();
            this.WorkNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TimerSettingsTitleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.DelimiterPanel = new System.Windows.Forms.Panel();
            this.DesignTitleLabel = new MaterialSkin.Controls.MaterialLabel();
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
            this.InformationGroupBox = new System.Windows.Forms.GroupBox();
            this.EmailDeveloperButton = new MaterialSkin.Controls.MaterialButton();
            this.DocumentationButton = new MaterialSkin.Controls.MaterialButton();
            this.GitHubProfileButton = new MaterialSkin.Controls.MaterialButton();
            this.InformationTitleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.AboutAppGroupBox = new System.Windows.Forms.GroupBox();
            this.DetailedInformationButton = new MaterialSkin.Controls.MaterialButton();
            this.DescriptionAppLabel = new MaterialSkin.Controls.MaterialLabel();
            this.AboutTitleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SideMenuImageList = new System.Windows.Forms.ImageList(this.components);
            this.SideMenuTabControl.SuspendLayout();
            this.HomeTabPage.SuspendLayout();
            this.SettingsTabPage.SuspendLayout();
            this.RestMinutesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RestNumericUpDown)).BeginInit();
            this.WorkMinutesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkNumericUpDown)).BeginInit();
            this.ColorThemeGroupBox.SuspendLayout();
            this.ThemeGroupBox.SuspendLayout();
            this.AboutTabPage.SuspendLayout();
            this.InformationGroupBox.SuspendLayout();
            this.AboutAppGroupBox.SuspendLayout();
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
            this.SettingsTabPage.Controls.Add(this.RestMinutesGroupBox);
            this.SettingsTabPage.Controls.Add(this.WorkMinutesGroupBox);
            this.SettingsTabPage.Controls.Add(this.TimerSettingsTitleLabel);
            this.SettingsTabPage.Controls.Add(this.DelimiterPanel);
            this.SettingsTabPage.Controls.Add(this.DesignTitleLabel);
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
            // RestMinutesGroupBox
            // 
            this.RestMinutesGroupBox.Controls.Add(this.RestTitleLabel);
            this.RestMinutesGroupBox.Controls.Add(this.RestMinutesLabel);
            this.RestMinutesGroupBox.Controls.Add(this.RestNumericUpDown);
            this.RestMinutesGroupBox.Location = new System.Drawing.Point(153, 169);
            this.RestMinutesGroupBox.Name = "RestMinutesGroupBox";
            this.RestMinutesGroupBox.Size = new System.Drawing.Size(140, 60);
            this.RestMinutesGroupBox.TabIndex = 9;
            this.RestMinutesGroupBox.TabStop = false;
            // 
            // RestTitleLabel
            // 
            this.RestTitleLabel.AutoSize = true;
            this.RestTitleLabel.Depth = 0;
            this.RestTitleLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.RestTitleLabel.Location = new System.Drawing.Point(8, -2);
            this.RestTitleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.RestTitleLabel.Name = "RestTitleLabel";
            this.RestTitleLabel.Size = new System.Drawing.Size(32, 19);
            this.RestTitleLabel.TabIndex = 1;
            this.RestTitleLabel.Text = "Rest";
            // 
            // RestMinutesLabel
            // 
            this.RestMinutesLabel.AutoSize = true;
            this.RestMinutesLabel.Depth = 0;
            this.RestMinutesLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.RestMinutesLabel.Location = new System.Drawing.Point(8, 28);
            this.RestMinutesLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.RestMinutesLabel.Name = "RestMinutesLabel";
            this.RestMinutesLabel.Size = new System.Drawing.Size(62, 19);
            this.RestMinutesLabel.TabIndex = 6;
            this.RestMinutesLabel.Text = "Minutes:";
            // 
            // RestNumericUpDown
            // 
            this.RestNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RestNumericUpDown.Location = new System.Drawing.Point(76, 25);
            this.RestNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.RestNumericUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.RestNumericUpDown.Name = "RestNumericUpDown";
            this.RestNumericUpDown.Size = new System.Drawing.Size(50, 22);
            this.RestNumericUpDown.TabIndex = 8;
            this.RestNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // WorkMinutesGroupBox
            // 
            this.WorkMinutesGroupBox.Controls.Add(this.WorkTitleLabel);
            this.WorkMinutesGroupBox.Controls.Add(this.WorkMinutesLabel);
            this.WorkMinutesGroupBox.Controls.Add(this.WorkNumericUpDown);
            this.WorkMinutesGroupBox.Location = new System.Drawing.Point(6, 169);
            this.WorkMinutesGroupBox.Name = "WorkMinutesGroupBox";
            this.WorkMinutesGroupBox.Size = new System.Drawing.Size(140, 60);
            this.WorkMinutesGroupBox.TabIndex = 2;
            this.WorkMinutesGroupBox.TabStop = false;
            // 
            // WorkTitleLabel
            // 
            this.WorkTitleLabel.AutoSize = true;
            this.WorkTitleLabel.Depth = 0;
            this.WorkTitleLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.WorkTitleLabel.Location = new System.Drawing.Point(8, -2);
            this.WorkTitleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.WorkTitleLabel.Name = "WorkTitleLabel";
            this.WorkTitleLabel.Size = new System.Drawing.Size(37, 19);
            this.WorkTitleLabel.TabIndex = 1;
            this.WorkTitleLabel.Text = "Work";
            // 
            // WorkMinutesLabel
            // 
            this.WorkMinutesLabel.AutoSize = true;
            this.WorkMinutesLabel.Depth = 0;
            this.WorkMinutesLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.WorkMinutesLabel.Location = new System.Drawing.Point(8, 28);
            this.WorkMinutesLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.WorkMinutesLabel.Name = "WorkMinutesLabel";
            this.WorkMinutesLabel.Size = new System.Drawing.Size(62, 19);
            this.WorkMinutesLabel.TabIndex = 6;
            this.WorkMinutesLabel.Text = "Minutes:";
            // 
            // WorkNumericUpDown
            // 
            this.WorkNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorkNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.WorkNumericUpDown.Location = new System.Drawing.Point(76, 25);
            this.WorkNumericUpDown.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.WorkNumericUpDown.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.WorkNumericUpDown.Name = "WorkNumericUpDown";
            this.WorkNumericUpDown.Size = new System.Drawing.Size(50, 22);
            this.WorkNumericUpDown.TabIndex = 8;
            this.WorkNumericUpDown.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // TimerSettingsTitleLabel
            // 
            this.TimerSettingsTitleLabel.AutoSize = true;
            this.TimerSettingsTitleLabel.Depth = 0;
            this.TimerSettingsTitleLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.TimerSettingsTitleLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.TimerSettingsTitleLabel.Location = new System.Drawing.Point(13, 132);
            this.TimerSettingsTitleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.TimerSettingsTitleLabel.Name = "TimerSettingsTitleLabel";
            this.TimerSettingsTitleLabel.Size = new System.Drawing.Size(130, 24);
            this.TimerSettingsTitleLabel.TabIndex = 5;
            this.TimerSettingsTitleLabel.Text = "Timer settings";
            // 
            // DelimiterPanel
            // 
            this.DelimiterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DelimiterPanel.Location = new System.Drawing.Point(6, 120);
            this.DelimiterPanel.Name = "DelimiterPanel";
            this.DelimiterPanel.Size = new System.Drawing.Size(525, 1);
            this.DelimiterPanel.TabIndex = 4;
            // 
            // DesignTitleLabel
            // 
            this.DesignTitleLabel.AutoSize = true;
            this.DesignTitleLabel.Depth = 0;
            this.DesignTitleLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.DesignTitleLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.DesignTitleLabel.Location = new System.Drawing.Point(13, 13);
            this.DesignTitleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.DesignTitleLabel.Name = "DesignTitleLabel";
            this.DesignTitleLabel.Size = new System.Drawing.Size(165, 24);
            this.DesignTitleLabel.TabIndex = 3;
            this.DesignTitleLabel.Text = "Application design";
            // 
            // ColorThemeGroupBox
            // 
            this.ColorThemeGroupBox.Controls.Add(this.OrangeRadioButton);
            this.ColorThemeGroupBox.Controls.Add(this.BlueRadioButton);
            this.ColorThemeGroupBox.Controls.Add(this.GreenRadioButton);
            this.ColorThemeGroupBox.Controls.Add(this.PurpleRadioButton);
            this.ColorThemeGroupBox.Controls.Add(this.ColorThemeLabel);
            this.ColorThemeGroupBox.Location = new System.Drawing.Point(142, 50);
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
            this.ColorThemeLabel.Size = new System.Drawing.Size(97, 19);
            this.ColorThemeLabel.TabIndex = 1;
            this.ColorThemeLabel.Text = "Color scheme";
            // 
            // ThemeGroupBox
            // 
            this.ThemeGroupBox.Controls.Add(this.DarkThemeSwitch);
            this.ThemeGroupBox.Controls.Add(this.ThemeLabel);
            this.ThemeGroupBox.Location = new System.Drawing.Point(6, 50);
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
            this.DarkThemeSwitch.CheckedChanged += new System.EventHandler(this.DarkThemeSwitch_CheckedChanged);
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
            this.AboutTabPage.Controls.Add(this.InformationGroupBox);
            this.AboutTabPage.Controls.Add(this.AboutAppGroupBox);
            this.AboutTabPage.ImageKey = "info.png";
            this.AboutTabPage.Location = new System.Drawing.Point(4, 39);
            this.AboutTabPage.Name = "AboutTabPage";
            this.AboutTabPage.Size = new System.Drawing.Size(586, 340);
            this.AboutTabPage.TabIndex = 2;
            this.AboutTabPage.Text = "About";
            // 
            // InformationGroupBox
            // 
            this.InformationGroupBox.Controls.Add(this.EmailDeveloperButton);
            this.InformationGroupBox.Controls.Add(this.DocumentationButton);
            this.InformationGroupBox.Controls.Add(this.GitHubProfileButton);
            this.InformationGroupBox.Controls.Add(this.InformationTitleLabel);
            this.InformationGroupBox.Location = new System.Drawing.Point(6, 199);
            this.InformationGroupBox.Name = "InformationGroupBox";
            this.InformationGroupBox.Size = new System.Drawing.Size(450, 75);
            this.InformationGroupBox.TabIndex = 3;
            this.InformationGroupBox.TabStop = false;
            // 
            // EmailDeveloperButton
            // 
            this.EmailDeveloperButton.AutoSize = false;
            this.EmailDeveloperButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EmailDeveloperButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.EmailDeveloperButton.Depth = 0;
            this.EmailDeveloperButton.HighEmphasis = true;
            this.EmailDeveloperButton.Icon = null;
            this.EmailDeveloperButton.Location = new System.Drawing.Point(155, 23);
            this.EmailDeveloperButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.EmailDeveloperButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.EmailDeveloperButton.Name = "EmailDeveloperButton";
            this.EmailDeveloperButton.Size = new System.Drawing.Size(140, 40);
            this.EmailDeveloperButton.TabIndex = 3;
            this.EmailDeveloperButton.Text = "Email";
            this.EmailDeveloperButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.EmailDeveloperButton.UseAccentColor = false;
            this.EmailDeveloperButton.UseVisualStyleBackColor = true;
            this.EmailDeveloperButton.Click += new System.EventHandler(this.ButtonClickHandler);
            // 
            // DocumentationButton
            // 
            this.DocumentationButton.AutoSize = false;
            this.DocumentationButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DocumentationButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.DocumentationButton.Depth = 0;
            this.DocumentationButton.HighEmphasis = true;
            this.DocumentationButton.Icon = null;
            this.DocumentationButton.Location = new System.Drawing.Point(303, 23);
            this.DocumentationButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DocumentationButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DocumentationButton.Name = "DocumentationButton";
            this.DocumentationButton.Size = new System.Drawing.Size(140, 40);
            this.DocumentationButton.TabIndex = 4;
            this.DocumentationButton.Text = "Documentation";
            this.DocumentationButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DocumentationButton.UseAccentColor = false;
            this.DocumentationButton.UseVisualStyleBackColor = true;
            this.DocumentationButton.Click += new System.EventHandler(this.ButtonClickHandler);
            // 
            // GitHubProfileButton
            // 
            this.GitHubProfileButton.AutoSize = false;
            this.GitHubProfileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GitHubProfileButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.GitHubProfileButton.Depth = 0;
            this.GitHubProfileButton.HighEmphasis = true;
            this.GitHubProfileButton.Icon = null;
            this.GitHubProfileButton.Location = new System.Drawing.Point(7, 23);
            this.GitHubProfileButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.GitHubProfileButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.GitHubProfileButton.Name = "GitHubProfileButton";
            this.GitHubProfileButton.Size = new System.Drawing.Size(140, 40);
            this.GitHubProfileButton.TabIndex = 2;
            this.GitHubProfileButton.Text = "GitHub";
            this.GitHubProfileButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.GitHubProfileButton.UseAccentColor = false;
            this.GitHubProfileButton.UseVisualStyleBackColor = true;
            this.GitHubProfileButton.Click += new System.EventHandler(this.ButtonClickHandler);
            // 
            // InformationTitleLabel
            // 
            this.InformationTitleLabel.AutoSize = true;
            this.InformationTitleLabel.Depth = 0;
            this.InformationTitleLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.InformationTitleLabel.Location = new System.Drawing.Point(8, -2);
            this.InformationTitleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.InformationTitleLabel.Name = "InformationTitleLabel";
            this.InformationTitleLabel.Size = new System.Drawing.Size(84, 19);
            this.InformationTitleLabel.TabIndex = 1;
            this.InformationTitleLabel.Text = "Information";
            // 
            // AboutAppGroupBox
            // 
            this.AboutAppGroupBox.Controls.Add(this.DetailedInformationButton);
            this.AboutAppGroupBox.Controls.Add(this.DescriptionAppLabel);
            this.AboutAppGroupBox.Controls.Add(this.AboutTitleLabel);
            this.AboutAppGroupBox.Location = new System.Drawing.Point(6, 13);
            this.AboutAppGroupBox.Name = "AboutAppGroupBox";
            this.AboutAppGroupBox.Size = new System.Drawing.Size(525, 172);
            this.AboutAppGroupBox.TabIndex = 1;
            this.AboutAppGroupBox.TabStop = false;
            // 
            // DetailedInformationButton
            // 
            this.DetailedInformationButton.AutoSize = false;
            this.DetailedInformationButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DetailedInformationButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.DetailedInformationButton.Depth = 0;
            this.DetailedInformationButton.HighEmphasis = true;
            this.DetailedInformationButton.Icon = null;
            this.DetailedInformationButton.Location = new System.Drawing.Point(7, 121);
            this.DetailedInformationButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DetailedInformationButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DetailedInformationButton.Name = "DetailedInformationButton";
            this.DetailedInformationButton.Size = new System.Drawing.Size(180, 40);
            this.DetailedInformationButton.TabIndex = 3;
            this.DetailedInformationButton.Text = "Detailed information";
            this.DetailedInformationButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DetailedInformationButton.UseAccentColor = false;
            this.DetailedInformationButton.UseVisualStyleBackColor = true;
            this.DetailedInformationButton.Click += new System.EventHandler(this.ButtonClickHandler);
            // 
            // DescriptionAppLabel
            // 
            this.DescriptionAppLabel.Depth = 0;
            this.DescriptionAppLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DescriptionAppLabel.Location = new System.Drawing.Point(8, 20);
            this.DescriptionAppLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.DescriptionAppLabel.Name = "DescriptionAppLabel";
            this.DescriptionAppLabel.Size = new System.Drawing.Size(511, 100);
            this.DescriptionAppLabel.TabIndex = 2;
            this.DescriptionAppLabel.Text = resources.GetString("DescriptionAppLabel.Text");
            // 
            // AboutTitleLabel
            // 
            this.AboutTitleLabel.AutoSize = true;
            this.AboutTitleLabel.Depth = 0;
            this.AboutTitleLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AboutTitleLabel.Location = new System.Drawing.Point(8, -2);
            this.AboutTitleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.AboutTitleLabel.Name = "AboutTitleLabel";
            this.AboutTitleLabel.Size = new System.Drawing.Size(100, 19);
            this.AboutTitleLabel.TabIndex = 1;
            this.AboutTitleLabel.Text = "About the app";
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
            this.SettingsTabPage.PerformLayout();
            this.RestMinutesGroupBox.ResumeLayout(false);
            this.RestMinutesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RestNumericUpDown)).EndInit();
            this.WorkMinutesGroupBox.ResumeLayout(false);
            this.WorkMinutesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkNumericUpDown)).EndInit();
            this.ColorThemeGroupBox.ResumeLayout(false);
            this.ColorThemeGroupBox.PerformLayout();
            this.ThemeGroupBox.ResumeLayout(false);
            this.ThemeGroupBox.PerformLayout();
            this.AboutTabPage.ResumeLayout(false);
            this.InformationGroupBox.ResumeLayout(false);
            this.InformationGroupBox.PerformLayout();
            this.AboutAppGroupBox.ResumeLayout(false);
            this.AboutAppGroupBox.PerformLayout();
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
        private MaterialSkin.Controls.MaterialLabel DesignTitleLabel;
        private System.Windows.Forms.Panel DelimiterPanel;
        private MaterialSkin.Controls.MaterialLabel TimerSettingsTitleLabel;
        private MaterialSkin.Controls.MaterialLabel WorkMinutesLabel;
        private System.Windows.Forms.NumericUpDown WorkNumericUpDown;
        private System.Windows.Forms.GroupBox WorkMinutesGroupBox;
        private MaterialSkin.Controls.MaterialLabel WorkTitleLabel;
        private System.Windows.Forms.GroupBox RestMinutesGroupBox;
        private MaterialSkin.Controls.MaterialLabel RestTitleLabel;
        private MaterialSkin.Controls.MaterialLabel RestMinutesLabel;
        private System.Windows.Forms.NumericUpDown RestNumericUpDown;
        private System.Windows.Forms.GroupBox AboutAppGroupBox;
        private MaterialSkin.Controls.MaterialLabel AboutTitleLabel;
        private MaterialSkin.Controls.MaterialLabel DescriptionAppLabel;
        private MaterialSkin.Controls.MaterialButton DetailedInformationButton;
        private System.Windows.Forms.GroupBox InformationGroupBox;
        private MaterialSkin.Controls.MaterialLabel InformationTitleLabel;
        private MaterialSkin.Controls.MaterialButton GitHubProfileButton;
        private MaterialSkin.Controls.MaterialButton EmailDeveloperButton;
        private MaterialSkin.Controls.MaterialButton DocumentationButton;
    }
}

