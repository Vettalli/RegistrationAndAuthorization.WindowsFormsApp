
namespace WindowsFormsApp
{
    partial class MainForm
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
            this.autorizationLabel = new System.Windows.Forms.Label();
            this.RegistrationLabel = new System.Windows.Forms.Label();
            this.AuthorizationLabel = new System.Windows.Forms.Label();
            this.closeRegButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // autorizationLabel
            // 
            this.autorizationLabel.Font = new System.Drawing.Font("Ebrima", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autorizationLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.autorizationLabel.Image = global::WindowsFormsApp.Properties.Resources.interstellar_3840x2160_stars_4k_8k_9355;
            this.autorizationLabel.Location = new System.Drawing.Point(564, 175);
            this.autorizationLabel.Name = "autorizationLabel";
            this.autorizationLabel.Size = new System.Drawing.Size(338, 103);
            this.autorizationLabel.TabIndex = 1;
            this.autorizationLabel.Text = "Main lobby";
            // 
            // RegistrationLabel
            // 
            this.RegistrationLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegistrationLabel.Font = new System.Drawing.Font("Ebrima", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrationLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.RegistrationLabel.Image = global::WindowsFormsApp.Properties.Resources.interstellar_3840x2160_stars_4k_8k_9355;
            this.RegistrationLabel.Location = new System.Drawing.Point(843, 377);
            this.RegistrationLabel.Name = "RegistrationLabel";
            this.RegistrationLabel.Size = new System.Drawing.Size(399, 103);
            this.RegistrationLabel.TabIndex = 2;
            this.RegistrationLabel.Text = "Registration";
            this.RegistrationLabel.Click += new System.EventHandler(this.RegistrationLabel_Click);
            this.RegistrationLabel.MouseEnter += new System.EventHandler(this.RegistrationLabel_MouseEnter);
            this.RegistrationLabel.MouseLeave += new System.EventHandler(this.RegistrationLabel_MouseLeave);
            // 
            // AuthorizationLabel
            // 
            this.AuthorizationLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AuthorizationLabel.Font = new System.Drawing.Font("Ebrima", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorizationLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.AuthorizationLabel.Image = global::WindowsFormsApp.Properties.Resources.interstellar_3840x2160_stars_4k_8k_9355;
            this.AuthorizationLabel.Location = new System.Drawing.Point(277, 377);
            this.AuthorizationLabel.Name = "AuthorizationLabel";
            this.AuthorizationLabel.Size = new System.Drawing.Size(399, 103);
            this.AuthorizationLabel.TabIndex = 3;
            this.AuthorizationLabel.Text = "Authorization";
            this.AuthorizationLabel.Click += new System.EventHandler(this.AuthorizationLabel_Click);
            this.AuthorizationLabel.MouseEnter += new System.EventHandler(this.AuthorizationLabel_MouseEnter);
            this.AuthorizationLabel.MouseLeave += new System.EventHandler(this.AuthorizationLabel_MouseLeave);
            // 
            // closeRegButton
            // 
            this.closeRegButton.BackColor = System.Drawing.Color.White;
            this.closeRegButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeRegButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeRegButton.Image = global::WindowsFormsApp.Properties.Resources.interstellar_3840x2160_stars_4k_8k_9355;
            this.closeRegButton.Location = new System.Drawing.Point(1442, 0);
            this.closeRegButton.Name = "closeRegButton";
            this.closeRegButton.Size = new System.Drawing.Size(29, 31);
            this.closeRegButton.TabIndex = 19;
            this.closeRegButton.Text = "X";
            this.closeRegButton.Click += new System.EventHandler(this.closeRegButton_Click);
            this.closeRegButton.MouseEnter += new System.EventHandler(this.closeRegButton_MouseEnter);
            this.closeRegButton.MouseLeave += new System.EventHandler(this.closeRegButton_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp.Properties.Resources.interstellar_3840x2160_stars_4k_8k_9355;
            this.ClientSize = new System.Drawing.Size(1471, 787);
            this.Controls.Add(this.closeRegButton);
            this.Controls.Add(this.AuthorizationLabel);
            this.Controls.Add(this.RegistrationLabel);
            this.Controls.Add(this.autorizationLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label autorizationLabel;
        private System.Windows.Forms.Label RegistrationLabel;
        private System.Windows.Forms.Label AuthorizationLabel;
        private System.Windows.Forms.Label closeRegButton;
    }
}