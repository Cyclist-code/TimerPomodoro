
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
            this.LanguageSelectionComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.LanguageTitleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
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
            resources.ApplyResources(this.SideMenuTabControl, "SideMenuTabControl");
            this.SideMenuTabControl.Controls.Add(this.HomeTabPage);
            this.SideMenuTabControl.Controls.Add(this.SettingsTabPage);
            this.SideMenuTabControl.Controls.Add(this.AboutTabPage);
            this.SideMenuTabControl.Depth = 0;
            this.SideMenuTabControl.ImageList = this.SideMenuImageList;
            this.SideMenuTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.SideMenuTabControl.Multiline = true;
            this.SideMenuTabControl.Name = "SideMenuTabControl";
            this.SideMenuTabControl.SelectedIndex = 0;
            // 
            // HomeTabPage
            // 
            resources.ApplyResources(this.HomeTabPage, "HomeTabPage");
            this.HomeTabPage.BackColor = System.Drawing.Color.White;
            this.HomeTabPage.Controls.Add(this.SecondsLabel);
            this.HomeTabPage.Controls.Add(this.ColonLabel);
            this.HomeTabPage.Controls.Add(this.StopButton);
            this.HomeTabPage.Controls.Add(this.StartButton);
            this.HomeTabPage.Controls.Add(this.MinutesLabel);
            this.HomeTabPage.Name = "HomeTabPage";
            // 
            // SecondsLabel
            // 
            resources.ApplyResources(this.SecondsLabel, "SecondsLabel");
            this.SecondsLabel.Depth = 0;
            this.SecondsLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H1;
            this.SecondsLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.SecondsLabel.Name = "SecondsLabel";
            // 
            // ColonLabel
            // 
            resources.ApplyResources(this.ColonLabel, "ColonLabel");
            this.ColonLabel.Depth = 0;
            this.ColonLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H1;
            this.ColonLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ColonLabel.Name = "ColonLabel";
            // 
            // StopButton
            // 
            resources.ApplyResources(this.StopButton, "StopButton");
            this.StopButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.StopButton.Depth = 0;
            this.StopButton.HighEmphasis = true;
            this.StopButton.Icon = null;
            this.StopButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.StopButton.Name = "StopButton";
            this.StopButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.StopButton.UseAccentColor = false;
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // StartButton
            // 
            resources.ApplyResources(this.StartButton, "StartButton");
            this.StartButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.StartButton.Depth = 0;
            this.StartButton.HighEmphasis = true;
            this.StartButton.Icon = null;
            this.StartButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.StartButton.Name = "StartButton";
            this.StartButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.StartButton.UseAccentColor = false;
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // MinutesLabel
            // 
            resources.ApplyResources(this.MinutesLabel, "MinutesLabel");
            this.MinutesLabel.Depth = 0;
            this.MinutesLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H1;
            this.MinutesLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.MinutesLabel.Name = "MinutesLabel";
            // 
            // SettingsTabPage
            // 
            resources.ApplyResources(this.SettingsTabPage, "SettingsTabPage");
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
            this.SettingsTabPage.Name = "SettingsTabPage";
            // 
            // LanguageSelectionComboBox
            // 
            resources.ApplyResources(this.LanguageSelectionComboBox, "LanguageSelectionComboBox");
            this.LanguageSelectionComboBox.AutoResize = false;
            this.LanguageSelectionComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LanguageSelectionComboBox.Depth = 0;
            this.LanguageSelectionComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.LanguageSelectionComboBox.DropDownHeight = 118;
            this.LanguageSelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LanguageSelectionComboBox.DropDownWidth = 121;
            this.LanguageSelectionComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LanguageSelectionComboBox.FormattingEnabled = true;
            this.LanguageSelectionComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.LanguageSelectionComboBox.Name = "LanguageSelectionComboBox";
            this.LanguageSelectionComboBox.StartIndex = 0;
            this.LanguageSelectionComboBox.UseAccent = false;
            this.LanguageSelectionComboBox.UseTallSize = false;
            // 
            // LanguageTitleLabel
            // 
            resources.ApplyResources(this.LanguageTitleLabel, "LanguageTitleLabel");
            this.LanguageTitleLabel.Depth = 0;
            this.LanguageTitleLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.LanguageTitleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.LanguageTitleLabel.Name = "LanguageTitleLabel";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Name = "panel1";
            // 
            // RestMinutesMaterialCard
            // 
            resources.ApplyResources(this.RestMinutesMaterialCard, "RestMinutesMaterialCard");
            this.RestMinutesMaterialCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RestMinutesMaterialCard.Controls.Add(this.RestMinutesLabel);
            this.RestMinutesMaterialCard.Controls.Add(this.RestNumericUpDown);
            this.RestMinutesMaterialCard.Depth = 0;
            this.RestMinutesMaterialCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RestMinutesMaterialCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.RestMinutesMaterialCard.Name = "RestMinutesMaterialCard";
            // 
            // RestMinutesLabel
            // 
            resources.ApplyResources(this.RestMinutesLabel, "RestMinutesLabel");
            this.RestMinutesLabel.Depth = 0;
            this.RestMinutesLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.RestMinutesLabel.Name = "RestMinutesLabel";
            // 
            // RestNumericUpDown
            // 
            resources.ApplyResources(this.RestNumericUpDown, "RestNumericUpDown");
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
            this.RestNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // RestTitleLabel
            // 
            resources.ApplyResources(this.RestTitleLabel, "RestTitleLabel");
            this.RestTitleLabel.Depth = 0;
            this.RestTitleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.RestTitleLabel.Name = "RestTitleLabel";
            // 
            // WorkTitleLabel
            // 
            resources.ApplyResources(this.WorkTitleLabel, "WorkTitleLabel");
            this.WorkTitleLabel.Depth = 0;
            this.WorkTitleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.WorkTitleLabel.Name = "WorkTitleLabel";
            // 
            // WorkMinutesMaterialCard
            // 
            resources.ApplyResources(this.WorkMinutesMaterialCard, "WorkMinutesMaterialCard");
            this.WorkMinutesMaterialCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.WorkMinutesMaterialCard.Controls.Add(this.WorkMinutesLabel);
            this.WorkMinutesMaterialCard.Controls.Add(this.WorkNumericUpDown);
            this.WorkMinutesMaterialCard.Depth = 0;
            this.WorkMinutesMaterialCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WorkMinutesMaterialCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.WorkMinutesMaterialCard.Name = "WorkMinutesMaterialCard";
            // 
            // WorkMinutesLabel
            // 
            resources.ApplyResources(this.WorkMinutesLabel, "WorkMinutesLabel");
            this.WorkMinutesLabel.Depth = 0;
            this.WorkMinutesLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.WorkMinutesLabel.Name = "WorkMinutesLabel";
            // 
            // WorkNumericUpDown
            // 
            resources.ApplyResources(this.WorkNumericUpDown, "WorkNumericUpDown");
            this.WorkNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
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
            this.WorkNumericUpDown.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.WorkNumericUpDown.ValueChanged += new System.EventHandler(this.WorkNumericUpDown_ValueChanged);
            // 
            // ColorThemeMaterialCard
            // 
            resources.ApplyResources(this.ColorThemeMaterialCard, "ColorThemeMaterialCard");
            this.ColorThemeMaterialCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ColorThemeMaterialCard.Controls.Add(this.OrangeRadioButton);
            this.ColorThemeMaterialCard.Controls.Add(this.PurpleRadioButton);
            this.ColorThemeMaterialCard.Controls.Add(this.BlueRadioButton);
            this.ColorThemeMaterialCard.Controls.Add(this.GreenRadioButton);
            this.ColorThemeMaterialCard.Depth = 0;
            this.ColorThemeMaterialCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ColorThemeMaterialCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.ColorThemeMaterialCard.Name = "ColorThemeMaterialCard";
            // 
            // OrangeRadioButton
            // 
            resources.ApplyResources(this.OrangeRadioButton, "OrangeRadioButton");
            this.OrangeRadioButton.Depth = 0;
            this.OrangeRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.OrangeRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.OrangeRadioButton.Name = "OrangeRadioButton";
            this.OrangeRadioButton.Ripple = true;
            this.OrangeRadioButton.TabStop = true;
            this.OrangeRadioButton.UseVisualStyleBackColor = true;
            this.OrangeRadioButton.CheckedChanged += new System.EventHandler(this.ChoosingColorScheme);
            // 
            // PurpleRadioButton
            // 
            resources.ApplyResources(this.PurpleRadioButton, "PurpleRadioButton");
            this.PurpleRadioButton.Checked = true;
            this.PurpleRadioButton.Depth = 0;
            this.PurpleRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.PurpleRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.PurpleRadioButton.Name = "PurpleRadioButton";
            this.PurpleRadioButton.Ripple = true;
            this.PurpleRadioButton.TabStop = true;
            this.PurpleRadioButton.UseVisualStyleBackColor = true;
            this.PurpleRadioButton.CheckedChanged += new System.EventHandler(this.ChoosingColorScheme);
            // 
            // BlueRadioButton
            // 
            resources.ApplyResources(this.BlueRadioButton, "BlueRadioButton");
            this.BlueRadioButton.Depth = 0;
            this.BlueRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.BlueRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.BlueRadioButton.Name = "BlueRadioButton";
            this.BlueRadioButton.Ripple = true;
            this.BlueRadioButton.TabStop = true;
            this.BlueRadioButton.UseVisualStyleBackColor = true;
            this.BlueRadioButton.CheckedChanged += new System.EventHandler(this.ChoosingColorScheme);
            // 
            // GreenRadioButton
            // 
            resources.ApplyResources(this.GreenRadioButton, "GreenRadioButton");
            this.GreenRadioButton.Depth = 0;
            this.GreenRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.GreenRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.GreenRadioButton.Name = "GreenRadioButton";
            this.GreenRadioButton.Ripple = true;
            this.GreenRadioButton.TabStop = true;
            this.GreenRadioButton.UseVisualStyleBackColor = true;
            this.GreenRadioButton.CheckedChanged += new System.EventHandler(this.ChoosingColorScheme);
            // 
            // ThemeLabel
            // 
            resources.ApplyResources(this.ThemeLabel, "ThemeLabel");
            this.ThemeLabel.Depth = 0;
            this.ThemeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ThemeLabel.Name = "ThemeLabel";
            // 
            // DarkThemeMaterialCard
            // 
            resources.ApplyResources(this.DarkThemeMaterialCard, "DarkThemeMaterialCard");
            this.DarkThemeMaterialCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DarkThemeMaterialCard.Controls.Add(this.DarkThemeSwitch);
            this.DarkThemeMaterialCard.Depth = 0;
            this.DarkThemeMaterialCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DarkThemeMaterialCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.DarkThemeMaterialCard.Name = "DarkThemeMaterialCard";
            // 
            // DarkThemeSwitch
            // 
            resources.ApplyResources(this.DarkThemeSwitch, "DarkThemeSwitch");
            this.DarkThemeSwitch.Depth = 0;
            this.DarkThemeSwitch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.DarkThemeSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            this.DarkThemeSwitch.Name = "DarkThemeSwitch";
            this.DarkThemeSwitch.Ripple = true;
            this.DarkThemeSwitch.UseVisualStyleBackColor = true;
            this.DarkThemeSwitch.CheckedChanged += new System.EventHandler(this.DarkThemeSwitch_CheckedChanged);
            // 
            // ColorThemeLabel
            // 
            resources.ApplyResources(this.ColorThemeLabel, "ColorThemeLabel");
            this.ColorThemeLabel.Depth = 0;
            this.ColorThemeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ColorThemeLabel.Name = "ColorThemeLabel";
            // 
            // TimerSettingsTitleLabel
            // 
            resources.ApplyResources(this.TimerSettingsTitleLabel, "TimerSettingsTitleLabel");
            this.TimerSettingsTitleLabel.Depth = 0;
            this.TimerSettingsTitleLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.TimerSettingsTitleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.TimerSettingsTitleLabel.Name = "TimerSettingsTitleLabel";
            // 
            // DelimiterPanel
            // 
            resources.ApplyResources(this.DelimiterPanel, "DelimiterPanel");
            this.DelimiterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DelimiterPanel.Name = "DelimiterPanel";
            // 
            // DesignTitleLabel
            // 
            resources.ApplyResources(this.DesignTitleLabel, "DesignTitleLabel");
            this.DesignTitleLabel.Depth = 0;
            this.DesignTitleLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.DesignTitleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.DesignTitleLabel.Name = "DesignTitleLabel";
            // 
            // AboutTabPage
            // 
            resources.ApplyResources(this.AboutTabPage, "AboutTabPage");
            this.AboutTabPage.BackColor = System.Drawing.Color.White;
            this.AboutTabPage.Controls.Add(this.InformationTitleLabel);
            this.AboutTabPage.Controls.Add(this.InformationMaterialCard);
            this.AboutTabPage.Controls.Add(this.AboutAppMaterialCard);
            this.AboutTabPage.Controls.Add(this.AboutTitleLabel);
            this.AboutTabPage.Name = "AboutTabPage";
            // 
            // InformationTitleLabel
            // 
            resources.ApplyResources(this.InformationTitleLabel, "InformationTitleLabel");
            this.InformationTitleLabel.Depth = 0;
            this.InformationTitleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.InformationTitleLabel.Name = "InformationTitleLabel";
            // 
            // InformationMaterialCard
            // 
            resources.ApplyResources(this.InformationMaterialCard, "InformationMaterialCard");
            this.InformationMaterialCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.InformationMaterialCard.Controls.Add(this.GitHubProfileButton);
            this.InformationMaterialCard.Controls.Add(this.DocumentationButton);
            this.InformationMaterialCard.Controls.Add(this.EmailDeveloperButton);
            this.InformationMaterialCard.Depth = 0;
            this.InformationMaterialCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.InformationMaterialCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.InformationMaterialCard.Name = "InformationMaterialCard";
            // 
            // GitHubProfileButton
            // 
            resources.ApplyResources(this.GitHubProfileButton, "GitHubProfileButton");
            this.GitHubProfileButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.GitHubProfileButton.Depth = 0;
            this.GitHubProfileButton.HighEmphasis = true;
            this.GitHubProfileButton.Icon = null;
            this.GitHubProfileButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.GitHubProfileButton.Name = "GitHubProfileButton";
            this.GitHubProfileButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.GitHubProfileButton.UseAccentColor = false;
            this.GitHubProfileButton.UseVisualStyleBackColor = true;
            this.GitHubProfileButton.Click += new System.EventHandler(this.ButtonClickHandler);
            // 
            // DocumentationButton
            // 
            resources.ApplyResources(this.DocumentationButton, "DocumentationButton");
            this.DocumentationButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.DocumentationButton.Depth = 0;
            this.DocumentationButton.HighEmphasis = true;
            this.DocumentationButton.Icon = null;
            this.DocumentationButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DocumentationButton.Name = "DocumentationButton";
            this.DocumentationButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DocumentationButton.UseAccentColor = false;
            this.DocumentationButton.UseVisualStyleBackColor = true;
            this.DocumentationButton.Click += new System.EventHandler(this.ButtonClickHandler);
            // 
            // EmailDeveloperButton
            // 
            resources.ApplyResources(this.EmailDeveloperButton, "EmailDeveloperButton");
            this.EmailDeveloperButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.EmailDeveloperButton.Depth = 0;
            this.EmailDeveloperButton.HighEmphasis = true;
            this.EmailDeveloperButton.Icon = null;
            this.EmailDeveloperButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.EmailDeveloperButton.Name = "EmailDeveloperButton";
            this.EmailDeveloperButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.EmailDeveloperButton.UseAccentColor = false;
            this.EmailDeveloperButton.UseVisualStyleBackColor = true;
            this.EmailDeveloperButton.Click += new System.EventHandler(this.ButtonClickHandler);
            // 
            // AboutAppMaterialCard
            // 
            resources.ApplyResources(this.AboutAppMaterialCard, "AboutAppMaterialCard");
            this.AboutAppMaterialCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AboutAppMaterialCard.Controls.Add(this.DetailedInformationButton);
            this.AboutAppMaterialCard.Controls.Add(this.DescriptionAppLabel);
            this.AboutAppMaterialCard.Depth = 0;
            this.AboutAppMaterialCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AboutAppMaterialCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.AboutAppMaterialCard.Name = "AboutAppMaterialCard";
            // 
            // DetailedInformationButton
            // 
            resources.ApplyResources(this.DetailedInformationButton, "DetailedInformationButton");
            this.DetailedInformationButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.DetailedInformationButton.Depth = 0;
            this.DetailedInformationButton.HighEmphasis = true;
            this.DetailedInformationButton.Icon = null;
            this.DetailedInformationButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DetailedInformationButton.Name = "DetailedInformationButton";
            this.DetailedInformationButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DetailedInformationButton.UseAccentColor = false;
            this.DetailedInformationButton.UseVisualStyleBackColor = true;
            this.DetailedInformationButton.Click += new System.EventHandler(this.ButtonClickHandler);
            // 
            // DescriptionAppLabel
            // 
            resources.ApplyResources(this.DescriptionAppLabel, "DescriptionAppLabel");
            this.DescriptionAppLabel.Depth = 0;
            this.DescriptionAppLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.DescriptionAppLabel.Name = "DescriptionAppLabel";
            // 
            // AboutTitleLabel
            // 
            resources.ApplyResources(this.AboutTitleLabel, "AboutTitleLabel");
            this.AboutTitleLabel.Depth = 0;
            this.AboutTitleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.AboutTitleLabel.Name = "AboutTitleLabel";
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
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SideMenuTabControl);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.SideMenuTabControl;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Sizable = false;
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

