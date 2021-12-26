
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
            this.SecondsLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ColonLabel = new MaterialSkin.Controls.MaterialLabel();
            this.StopButton = new MaterialSkin.Controls.MaterialButton();
            this.StartButton = new MaterialSkin.Controls.MaterialButton();
            this.MinutesLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SettingsTabPage = new System.Windows.Forms.TabPage();
            this.RestMinutesMaterialCard = new MaterialSkin.Controls.MaterialCard();
            this.RestMinutesLabel = new MaterialSkin.Controls.MaterialLabel();
            this.RestNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.RestTitleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.WorkTitleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.WorkMinutesMaterialCard = new MaterialSkin.Controls.MaterialCard();
            this.WorkMinutesLabel = new MaterialSkin.Controls.MaterialLabel();
            this.WorkNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ColorThemeMaterialCard = new MaterialSkin.Controls.MaterialCard();
            this.OrangeRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.PurpleRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.BlueRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.GreenRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.ThemeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.DarkThemeMaterialCard = new MaterialSkin.Controls.MaterialCard();
            this.DarkThemeSwitch = new MaterialSkin.Controls.MaterialSwitch();
            this.ColorThemeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.TimerSettingsTitleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.DelimiterPanel = new System.Windows.Forms.Panel();
            this.DesignTitleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.AboutTabPage = new System.Windows.Forms.TabPage();
            this.InformationTitleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.InformationMaterialCard = new MaterialSkin.Controls.MaterialCard();
            this.GitHubProfileButton = new MaterialSkin.Controls.MaterialButton();
            this.DocumentationButton = new MaterialSkin.Controls.MaterialButton();
            this.EmailDeveloperButton = new MaterialSkin.Controls.MaterialButton();
            this.AboutAppMaterialCard = new MaterialSkin.Controls.MaterialCard();
            this.DetailedInformationButton = new MaterialSkin.Controls.MaterialButton();
            this.DescriptionAppLabel = new MaterialSkin.Controls.MaterialLabel();
            this.AboutTitleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SideMenuImageList = new System.Windows.Forms.ImageList(this.components);
            this.Countdown = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.LanguageTitleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.LanguageSelectionComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.SideMenuTabControl.SuspendLayout();
            this.HomeTabPage.SuspendLayout();
            this.SettingsTabPage.SuspendLayout();
            this.RestMinutesMaterialCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RestNumericUpDown)).BeginInit();
            this.WorkMinutesMaterialCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkNumericUpDown)).BeginInit();
            this.ColorThemeMaterialCard.SuspendLayout();
            this.DarkThemeMaterialCard.SuspendLayout();
            this.AboutTabPage.SuspendLayout();
            this.InformationMaterialCard.SuspendLayout();
            this.AboutAppMaterialCard.SuspendLayout();
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
            this.HomeTabPage.Controls.Add(this.SecondsLabel);
            this.HomeTabPage.Controls.Add(this.ColonLabel);
            this.HomeTabPage.Controls.Add(this.StopButton);
            this.HomeTabPage.Controls.Add(this.StartButton);
            this.HomeTabPage.Controls.Add(this.MinutesLabel);
            this.HomeTabPage.ImageKey = "home.png";
            this.HomeTabPage.Location = new System.Drawing.Point(4, 39);
            this.HomeTabPage.Name = "HomeTabPage";
            this.HomeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.HomeTabPage.Size = new System.Drawing.Size(586, 340);
            this.HomeTabPage.TabIndex = 0;
            this.HomeTabPage.Text = "Home";
            // 
            // SecondsLabel
            // 
            this.SecondsLabel.AutoSize = true;
            this.SecondsLabel.Depth = 0;
            this.SecondsLabel.Font = new System.Drawing.Font("Roboto Light", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SecondsLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H1;
            this.SecondsLabel.Location = new System.Drawing.Point(286, 86);
            this.SecondsLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.SecondsLabel.Name = "SecondsLabel";
            this.SecondsLabel.Size = new System.Drawing.Size(107, 115);
            this.SecondsLabel.TabIndex = 4;
            this.SecondsLabel.Text = "00";
            // 
            // ColonLabel
            // 
            this.ColonLabel.AutoSize = true;
            this.ColonLabel.Depth = 0;
            this.ColonLabel.Font = new System.Drawing.Font("Roboto Light", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ColonLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H1;
            this.ColonLabel.Location = new System.Drawing.Point(259, 86);
            this.ColonLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ColonLabel.Name = "ColonLabel";
            this.ColonLabel.Size = new System.Drawing.Size(21, 115);
            this.ColonLabel.TabIndex = 3;
            this.ColonLabel.Text = ":";
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
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
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
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // MinutesLabel
            // 
            this.MinutesLabel.AutoSize = true;
            this.MinutesLabel.Depth = 0;
            this.MinutesLabel.Font = new System.Drawing.Font("Roboto Light", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MinutesLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H1;
            this.MinutesLabel.Location = new System.Drawing.Point(152, 86);
            this.MinutesLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.MinutesLabel.Name = "MinutesLabel";
            this.MinutesLabel.Size = new System.Drawing.Size(107, 115);
            this.MinutesLabel.TabIndex = 0;
            this.MinutesLabel.Text = "25";
            // 
            // SettingsTabPage
            // 
            this.SettingsTabPage.BackColor = System.Drawing.Color.White;
            this.SettingsTabPage.Controls.Add(this.LanguageSelectionComboBox);
            this.SettingsTabPage.Controls.Add(this.LanguageTitleLabel);
            this.SettingsTabPage.Controls.Add(this.panel1);
            this.SettingsTabPage.Controls.Add(this.RestMinutesMaterialCard);
            this.SettingsTabPage.Controls.Add(this.RestTitleLabel);
            this.SettingsTabPage.Controls.Add(this.WorkTitleLabel);
            this.SettingsTabPage.Controls.Add(this.WorkMinutesMaterialCard);
            this.SettingsTabPage.Controls.Add(this.ColorThemeMaterialCard);
            this.SettingsTabPage.Controls.Add(this.ThemeLabel);
            this.SettingsTabPage.Controls.Add(this.DarkThemeMaterialCard);
            this.SettingsTabPage.Controls.Add(this.ColorThemeLabel);
            this.SettingsTabPage.Controls.Add(this.TimerSettingsTitleLabel);
            this.SettingsTabPage.Controls.Add(this.DelimiterPanel);
            this.SettingsTabPage.Controls.Add(this.DesignTitleLabel);
            this.SettingsTabPage.ImageKey = "settings.png";
            this.SettingsTabPage.Location = new System.Drawing.Point(4, 39);
            this.SettingsTabPage.Name = "SettingsTabPage";
            this.SettingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsTabPage.Size = new System.Drawing.Size(586, 340);
            this.SettingsTabPage.TabIndex = 1;
            this.SettingsTabPage.Text = "Settings";
            // 
            // RestMinutesMaterialCard
            // 
            this.RestMinutesMaterialCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RestMinutesMaterialCard.Controls.Add(this.RestMinutesLabel);
            this.RestMinutesMaterialCard.Controls.Add(this.RestNumericUpDown);
            this.RestMinutesMaterialCard.Depth = 0;
            this.RestMinutesMaterialCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RestMinutesMaterialCard.Location = new System.Drawing.Point(169, 203);
            this.RestMinutesMaterialCard.Margin = new System.Windows.Forms.Padding(14);
            this.RestMinutesMaterialCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.RestMinutesMaterialCard.Name = "RestMinutesMaterialCard";
            this.RestMinutesMaterialCard.Padding = new System.Windows.Forms.Padding(14);
            this.RestMinutesMaterialCard.Size = new System.Drawing.Size(140, 50);
            this.RestMinutesMaterialCard.TabIndex = 13;
            // 
            // RestMinutesLabel
            // 
            this.RestMinutesLabel.AutoSize = true;
            this.RestMinutesLabel.Depth = 0;
            this.RestMinutesLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.RestMinutesLabel.Location = new System.Drawing.Point(12, 15);
            this.RestMinutesLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.RestMinutesLabel.Name = "RestMinutesLabel";
            this.RestMinutesLabel.Size = new System.Drawing.Size(62, 19);
            this.RestMinutesLabel.TabIndex = 6;
            this.RestMinutesLabel.Text = "Minutes:";
            // 
            // RestNumericUpDown
            // 
            this.RestNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RestNumericUpDown.Location = new System.Drawing.Point(80, 13);
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
            // RestTitleLabel
            // 
            this.RestTitleLabel.AutoSize = true;
            this.RestTitleLabel.Depth = 0;
            this.RestTitleLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.RestTitleLabel.Location = new System.Drawing.Point(168, 182);
            this.RestTitleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.RestTitleLabel.Name = "RestTitleLabel";
            this.RestTitleLabel.Size = new System.Drawing.Size(32, 19);
            this.RestTitleLabel.TabIndex = 1;
            this.RestTitleLabel.Text = "Rest";
            // 
            // WorkTitleLabel
            // 
            this.WorkTitleLabel.AutoSize = true;
            this.WorkTitleLabel.Depth = 0;
            this.WorkTitleLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.WorkTitleLabel.Location = new System.Drawing.Point(14, 182);
            this.WorkTitleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.WorkTitleLabel.Name = "WorkTitleLabel";
            this.WorkTitleLabel.Size = new System.Drawing.Size(37, 19);
            this.WorkTitleLabel.TabIndex = 1;
            this.WorkTitleLabel.Text = "Work";
            // 
            // WorkMinutesMaterialCard
            // 
            this.WorkMinutesMaterialCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.WorkMinutesMaterialCard.Controls.Add(this.WorkMinutesLabel);
            this.WorkMinutesMaterialCard.Controls.Add(this.WorkNumericUpDown);
            this.WorkMinutesMaterialCard.Depth = 0;
            this.WorkMinutesMaterialCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WorkMinutesMaterialCard.Location = new System.Drawing.Point(12, 203);
            this.WorkMinutesMaterialCard.Margin = new System.Windows.Forms.Padding(14);
            this.WorkMinutesMaterialCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.WorkMinutesMaterialCard.Name = "WorkMinutesMaterialCard";
            this.WorkMinutesMaterialCard.Padding = new System.Windows.Forms.Padding(14);
            this.WorkMinutesMaterialCard.Size = new System.Drawing.Size(140, 50);
            this.WorkMinutesMaterialCard.TabIndex = 12;
            // 
            // WorkMinutesLabel
            // 
            this.WorkMinutesLabel.AutoSize = true;
            this.WorkMinutesLabel.Depth = 0;
            this.WorkMinutesLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.WorkMinutesLabel.Location = new System.Drawing.Point(12, 15);
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
            this.WorkNumericUpDown.Location = new System.Drawing.Point(80, 13);
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
            this.WorkNumericUpDown.ValueChanged += new System.EventHandler(this.WorkNumericUpDown_ValueChanged);
            // 
            // ColorThemeMaterialCard
            // 
            this.ColorThemeMaterialCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ColorThemeMaterialCard.Controls.Add(this.OrangeRadioButton);
            this.ColorThemeMaterialCard.Controls.Add(this.PurpleRadioButton);
            this.ColorThemeMaterialCard.Controls.Add(this.BlueRadioButton);
            this.ColorThemeMaterialCard.Controls.Add(this.GreenRadioButton);
            this.ColorThemeMaterialCard.Depth = 0;
            this.ColorThemeMaterialCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ColorThemeMaterialCard.Location = new System.Drawing.Point(159, 70);
            this.ColorThemeMaterialCard.Margin = new System.Windows.Forms.Padding(14);
            this.ColorThemeMaterialCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.ColorThemeMaterialCard.Name = "ColorThemeMaterialCard";
            this.ColorThemeMaterialCard.Padding = new System.Windows.Forms.Padding(14);
            this.ColorThemeMaterialCard.Size = new System.Drawing.Size(323, 50);
            this.ColorThemeMaterialCard.TabIndex = 11;
            // 
            // OrangeRadioButton
            // 
            this.OrangeRadioButton.AutoSize = true;
            this.OrangeRadioButton.Depth = 0;
            this.OrangeRadioButton.Location = new System.Drawing.Point(228, 6);
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
            this.OrangeRadioButton.CheckedChanged += new System.EventHandler(this.ChoosingColorScheme);
            // 
            // PurpleRadioButton
            // 
            this.PurpleRadioButton.AutoSize = true;
            this.PurpleRadioButton.Checked = true;
            this.PurpleRadioButton.Depth = 0;
            this.PurpleRadioButton.Location = new System.Drawing.Point(1, 6);
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
            this.PurpleRadioButton.CheckedChanged += new System.EventHandler(this.ChoosingColorScheme);
            // 
            // BlueRadioButton
            // 
            this.BlueRadioButton.AutoSize = true;
            this.BlueRadioButton.Depth = 0;
            this.BlueRadioButton.Location = new System.Drawing.Point(160, 6);
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
            this.BlueRadioButton.CheckedChanged += new System.EventHandler(this.ChoosingColorScheme);
            // 
            // GreenRadioButton
            // 
            this.GreenRadioButton.AutoSize = true;
            this.GreenRadioButton.Depth = 0;
            this.GreenRadioButton.Location = new System.Drawing.Point(83, 6);
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
            this.GreenRadioButton.CheckedChanged += new System.EventHandler(this.ChoosingColorScheme);
            // 
            // ThemeLabel
            // 
            this.ThemeLabel.AutoSize = true;
            this.ThemeLabel.Depth = 0;
            this.ThemeLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ThemeLabel.Location = new System.Drawing.Point(12, 47);
            this.ThemeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ThemeLabel.Name = "ThemeLabel";
            this.ThemeLabel.Size = new System.Drawing.Size(50, 19);
            this.ThemeLabel.TabIndex = 1;
            this.ThemeLabel.Text = "Theme";
            // 
            // DarkThemeMaterialCard
            // 
            this.DarkThemeMaterialCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DarkThemeMaterialCard.Controls.Add(this.DarkThemeSwitch);
            this.DarkThemeMaterialCard.Depth = 0;
            this.DarkThemeMaterialCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DarkThemeMaterialCard.Location = new System.Drawing.Point(12, 70);
            this.DarkThemeMaterialCard.Margin = new System.Windows.Forms.Padding(14);
            this.DarkThemeMaterialCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.DarkThemeMaterialCard.Name = "DarkThemeMaterialCard";
            this.DarkThemeMaterialCard.Padding = new System.Windows.Forms.Padding(14);
            this.DarkThemeMaterialCard.Size = new System.Drawing.Size(130, 50);
            this.DarkThemeMaterialCard.TabIndex = 10;
            // 
            // DarkThemeSwitch
            // 
            this.DarkThemeSwitch.AutoSize = true;
            this.DarkThemeSwitch.Depth = 0;
            this.DarkThemeSwitch.Location = new System.Drawing.Point(18, 6);
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
            // ColorThemeLabel
            // 
            this.ColorThemeLabel.AutoSize = true;
            this.ColorThemeLabel.Depth = 0;
            this.ColorThemeLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ColorThemeLabel.Location = new System.Drawing.Point(157, 47);
            this.ColorThemeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ColorThemeLabel.Name = "ColorThemeLabel";
            this.ColorThemeLabel.Size = new System.Drawing.Size(97, 19);
            this.ColorThemeLabel.TabIndex = 1;
            this.ColorThemeLabel.Text = "Color scheme";
            // 
            // TimerSettingsTitleLabel
            // 
            this.TimerSettingsTitleLabel.AutoSize = true;
            this.TimerSettingsTitleLabel.Depth = 0;
            this.TimerSettingsTitleLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.TimerSettingsTitleLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.TimerSettingsTitleLabel.Location = new System.Drawing.Point(13, 148);
            this.TimerSettingsTitleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.TimerSettingsTitleLabel.Name = "TimerSettingsTitleLabel";
            this.TimerSettingsTitleLabel.Size = new System.Drawing.Size(130, 24);
            this.TimerSettingsTitleLabel.TabIndex = 5;
            this.TimerSettingsTitleLabel.Text = "Timer settings";
            // 
            // DelimiterPanel
            // 
            this.DelimiterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DelimiterPanel.Location = new System.Drawing.Point(6, 136);
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
            // AboutTabPage
            // 
            this.AboutTabPage.BackColor = System.Drawing.Color.White;
            this.AboutTabPage.Controls.Add(this.InformationTitleLabel);
            this.AboutTabPage.Controls.Add(this.InformationMaterialCard);
            this.AboutTabPage.Controls.Add(this.AboutAppMaterialCard);
            this.AboutTabPage.Controls.Add(this.AboutTitleLabel);
            this.AboutTabPage.ImageKey = "info.png";
            this.AboutTabPage.Location = new System.Drawing.Point(4, 39);
            this.AboutTabPage.Name = "AboutTabPage";
            this.AboutTabPage.Size = new System.Drawing.Size(586, 340);
            this.AboutTabPage.TabIndex = 2;
            this.AboutTabPage.Text = "About";
            // 
            // InformationTitleLabel
            // 
            this.InformationTitleLabel.AutoSize = true;
            this.InformationTitleLabel.Depth = 0;
            this.InformationTitleLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.InformationTitleLabel.Location = new System.Drawing.Point(10, 224);
            this.InformationTitleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.InformationTitleLabel.Name = "InformationTitleLabel";
            this.InformationTitleLabel.Size = new System.Drawing.Size(84, 19);
            this.InformationTitleLabel.TabIndex = 1;
            this.InformationTitleLabel.Text = "Information";
            // 
            // InformationMaterialCard
            // 
            this.InformationMaterialCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.InformationMaterialCard.Controls.Add(this.GitHubProfileButton);
            this.InformationMaterialCard.Controls.Add(this.DocumentationButton);
            this.InformationMaterialCard.Controls.Add(this.EmailDeveloperButton);
            this.InformationMaterialCard.Depth = 0;
            this.InformationMaterialCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.InformationMaterialCard.Location = new System.Drawing.Point(6, 248);
            this.InformationMaterialCard.Margin = new System.Windows.Forms.Padding(14);
            this.InformationMaterialCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.InformationMaterialCard.Name = "InformationMaterialCard";
            this.InformationMaterialCard.Padding = new System.Windows.Forms.Padding(14);
            this.InformationMaterialCard.Size = new System.Drawing.Size(450, 75);
            this.InformationMaterialCard.TabIndex = 5;
            // 
            // GitHubProfileButton
            // 
            this.GitHubProfileButton.AutoSize = false;
            this.GitHubProfileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GitHubProfileButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.GitHubProfileButton.Depth = 0;
            this.GitHubProfileButton.HighEmphasis = true;
            this.GitHubProfileButton.Icon = null;
            this.GitHubProfileButton.Location = new System.Drawing.Point(7, 17);
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
            // DocumentationButton
            // 
            this.DocumentationButton.AutoSize = false;
            this.DocumentationButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DocumentationButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.DocumentationButton.Depth = 0;
            this.DocumentationButton.HighEmphasis = true;
            this.DocumentationButton.Icon = null;
            this.DocumentationButton.Location = new System.Drawing.Point(303, 17);
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
            // EmailDeveloperButton
            // 
            this.EmailDeveloperButton.AutoSize = false;
            this.EmailDeveloperButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EmailDeveloperButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.EmailDeveloperButton.Depth = 0;
            this.EmailDeveloperButton.HighEmphasis = true;
            this.EmailDeveloperButton.Icon = null;
            this.EmailDeveloperButton.Location = new System.Drawing.Point(155, 17);
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
            // AboutAppMaterialCard
            // 
            this.AboutAppMaterialCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AboutAppMaterialCard.Controls.Add(this.DetailedInformationButton);
            this.AboutAppMaterialCard.Controls.Add(this.DescriptionAppLabel);
            this.AboutAppMaterialCard.Depth = 0;
            this.AboutAppMaterialCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AboutAppMaterialCard.Location = new System.Drawing.Point(6, 36);
            this.AboutAppMaterialCard.Margin = new System.Windows.Forms.Padding(14);
            this.AboutAppMaterialCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.AboutAppMaterialCard.Name = "AboutAppMaterialCard";
            this.AboutAppMaterialCard.Padding = new System.Windows.Forms.Padding(14);
            this.AboutAppMaterialCard.Size = new System.Drawing.Size(525, 172);
            this.AboutAppMaterialCard.TabIndex = 4;
            // 
            // DetailedInformationButton
            // 
            this.DetailedInformationButton.AutoSize = false;
            this.DetailedInformationButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DetailedInformationButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.DetailedInformationButton.Depth = 0;
            this.DetailedInformationButton.HighEmphasis = true;
            this.DetailedInformationButton.Icon = null;
            this.DetailedInformationButton.Location = new System.Drawing.Point(7, 120);
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
            this.DescriptionAppLabel.Location = new System.Drawing.Point(8, 14);
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
            this.AboutTitleLabel.Location = new System.Drawing.Point(10, 13);
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
            // Countdown
            // 
            this.Countdown.Interval = 1000;
            this.Countdown.Tick += new System.EventHandler(this.Countdown_Tick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(6, 270);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 1);
            this.panel1.TabIndex = 5;
            // 
            // LanguageTitleLabel
            // 
            this.LanguageTitleLabel.AutoSize = true;
            this.LanguageTitleLabel.Depth = 0;
            this.LanguageTitleLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LanguageTitleLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.LanguageTitleLabel.Location = new System.Drawing.Point(13, 284);
            this.LanguageTitleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.LanguageTitleLabel.Name = "LanguageTitleLabel";
            this.LanguageTitleLabel.Size = new System.Drawing.Size(89, 24);
            this.LanguageTitleLabel.TabIndex = 14;
            this.LanguageTitleLabel.Text = "Language";
            // 
            // LanguageSelectionComboBox
            // 
            this.LanguageSelectionComboBox.AutoResize = false;
            this.LanguageSelectionComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LanguageSelectionComboBox.Depth = 0;
            this.LanguageSelectionComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.LanguageSelectionComboBox.DropDownHeight = 118;
            this.LanguageSelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LanguageSelectionComboBox.DropDownWidth = 121;
            this.LanguageSelectionComboBox.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LanguageSelectionComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LanguageSelectionComboBox.FormattingEnabled = true;
            this.LanguageSelectionComboBox.IntegralHeight = false;
            this.LanguageSelectionComboBox.ItemHeight = 29;
            this.LanguageSelectionComboBox.Location = new System.Drawing.Point(12, 316);
            this.LanguageSelectionComboBox.MaxDropDownItems = 4;
            this.LanguageSelectionComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.LanguageSelectionComboBox.Name = "LanguageSelectionComboBox";
            this.LanguageSelectionComboBox.Size = new System.Drawing.Size(297, 35);
            this.LanguageSelectionComboBox.StartIndex = 0;
            this.LanguageSelectionComboBox.TabIndex = 15;
            this.LanguageSelectionComboBox.UseAccent = false;
            this.LanguageSelectionComboBox.UseTallSize = false;
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
            this.RestMinutesMaterialCard.ResumeLayout(false);
            this.RestMinutesMaterialCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RestNumericUpDown)).EndInit();
            this.WorkMinutesMaterialCard.ResumeLayout(false);
            this.WorkMinutesMaterialCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkNumericUpDown)).EndInit();
            this.ColorThemeMaterialCard.ResumeLayout(false);
            this.ColorThemeMaterialCard.PerformLayout();
            this.DarkThemeMaterialCard.ResumeLayout(false);
            this.DarkThemeMaterialCard.PerformLayout();
            this.AboutTabPage.ResumeLayout(false);
            this.AboutTabPage.PerformLayout();
            this.InformationMaterialCard.ResumeLayout(false);
            this.AboutAppMaterialCard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl SideMenuTabControl;
        private System.Windows.Forms.TabPage HomeTabPage;
        private System.Windows.Forms.TabPage SettingsTabPage;
        private System.Windows.Forms.ImageList SideMenuImageList;
        private System.Windows.Forms.TabPage AboutTabPage;
        private MaterialSkin.Controls.MaterialLabel MinutesLabel;
        private MaterialSkin.Controls.MaterialButton StartButton;
        private MaterialSkin.Controls.MaterialButton StopButton;
        private MaterialSkin.Controls.MaterialLabel ThemeLabel;
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
        private MaterialSkin.Controls.MaterialLabel WorkTitleLabel;
        private MaterialSkin.Controls.MaterialLabel RestTitleLabel;
        private MaterialSkin.Controls.MaterialLabel RestMinutesLabel;
        private System.Windows.Forms.NumericUpDown RestNumericUpDown;
        private MaterialSkin.Controls.MaterialLabel AboutTitleLabel;
        private MaterialSkin.Controls.MaterialLabel DescriptionAppLabel;
        private MaterialSkin.Controls.MaterialButton DetailedInformationButton;
        private MaterialSkin.Controls.MaterialLabel InformationTitleLabel;
        private MaterialSkin.Controls.MaterialButton GitHubProfileButton;
        private MaterialSkin.Controls.MaterialButton EmailDeveloperButton;
        private MaterialSkin.Controls.MaterialButton DocumentationButton;
        private MaterialSkin.Controls.MaterialCard DarkThemeMaterialCard;
        private MaterialSkin.Controls.MaterialSwitch DarkThemeSwitch;
        private MaterialSkin.Controls.MaterialCard ColorThemeMaterialCard;
        private MaterialSkin.Controls.MaterialCard WorkMinutesMaterialCard;
        private MaterialSkin.Controls.MaterialCard RestMinutesMaterialCard;
        private MaterialSkin.Controls.MaterialCard AboutAppMaterialCard;
        private MaterialSkin.Controls.MaterialCard InformationMaterialCard;
        private System.Windows.Forms.Timer Countdown;
        private MaterialSkin.Controls.MaterialLabel SecondsLabel;
        private MaterialSkin.Controls.MaterialLabel ColonLabel;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel LanguageTitleLabel;
        private MaterialSkin.Controls.MaterialComboBox LanguageSelectionComboBox;
    }
}

