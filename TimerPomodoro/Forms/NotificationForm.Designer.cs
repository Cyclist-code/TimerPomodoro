
namespace TimerPomodoro.Forms
{
    partial class NotificationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationForm));
            this.WorkRestImage = new System.Windows.Forms.PictureBox();
            this.MessageLabel = new MaterialSkin.Controls.MaterialLabel();
            this.CloseNotificationButton = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.WorkRestImage)).BeginInit();
            this.SuspendLayout();
            // 
            // WorkRestImage
            // 
            this.WorkRestImage.Location = new System.Drawing.Point(16, 50);
            this.WorkRestImage.Name = "WorkRestImage";
            this.WorkRestImage.Size = new System.Drawing.Size(70, 70);
            this.WorkRestImage.TabIndex = 0;
            this.WorkRestImage.TabStop = false;
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Depth = 0;
            this.MessageLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MessageLabel.Location = new System.Drawing.Point(92, 75);
            this.MessageLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(252, 19);
            this.MessageLabel.TabIndex = 1;
            this.MessageLabel.Text = "Time is over! Time to get some rest.";
            // 
            // CloseNotificationButton
            // 
            this.CloseNotificationButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CloseNotificationButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.CloseNotificationButton.Depth = 0;
            this.CloseNotificationButton.HighEmphasis = true;
            this.CloseNotificationButton.Icon = null;
            this.CloseNotificationButton.Location = new System.Drawing.Point(279, 115);
            this.CloseNotificationButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CloseNotificationButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CloseNotificationButton.Name = "CloseNotificationButton";
            this.CloseNotificationButton.Size = new System.Drawing.Size(64, 36);
            this.CloseNotificationButton.TabIndex = 2;
            this.CloseNotificationButton.Text = "ок";
            this.CloseNotificationButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CloseNotificationButton.UseAccentColor = false;
            this.CloseNotificationButton.UseVisualStyleBackColor = true;
            // 
            // NotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 160);
            this.Controls.Add(this.CloseNotificationButton);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.WorkRestImage);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NotificationForm";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notification";
            ((System.ComponentModel.ISupportInitialize)(this.WorkRestImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox WorkRestImage;
        private MaterialSkin.Controls.MaterialLabel MessageLabel;
        private MaterialSkin.Controls.MaterialButton CloseNotificationButton;
    }
}