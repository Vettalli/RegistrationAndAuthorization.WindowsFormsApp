
namespace WindowsFormsApp
{
    partial class RegisterForm
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
            this.regPasBox = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.regLogBox = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.closeRegButton = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.RegistrationLabel = new System.Windows.Forms.Label();
            this.AlreadyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // regPasBox
            // 
            this.regPasBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regPasBox.Location = new System.Drawing.Point(934, 478);
            this.regPasBox.Multiline = true;
            this.regPasBox.Name = "regPasBox";
            this.regPasBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.regPasBox.Size = new System.Drawing.Size(290, 57);
            this.regPasBox.TabIndex = 24;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(934, 478);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox3.Size = new System.Drawing.Size(290, 57);
            this.textBox3.TabIndex = 23;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp.Properties.Resources.iconfinder_icon_locked_211855;
            this.pictureBox3.Location = new System.Drawing.Point(811, 478);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(117, 93);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // regLogBox
            // 
            this.regLogBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regLogBox.Location = new System.Drawing.Point(378, 478);
            this.regLogBox.Multiline = true;
            this.regLogBox.Name = "regLogBox";
            this.regLogBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.regLogBox.Size = new System.Drawing.Size(290, 57);
            this.regLogBox.TabIndex = 21;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp.Properties.Resources.iconfinder_Pioneer_2927566;
            this.pictureBox4.Location = new System.Drawing.Point(255, 478);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(117, 93);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameBox.Location = new System.Drawing.Point(392, 302);
            this.nameBox.Multiline = true;
            this.nameBox.Name = "nameBox";
            this.nameBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nameBox.Size = new System.Drawing.Size(290, 57);
            this.nameBox.TabIndex = 19;
            this.nameBox.Enter += new System.EventHandler(this.nameBox_Enter);
            this.nameBox.Leave += new System.EventHandler(this.nameBox_Leave);
            // 
            // closeRegButton
            // 
            this.closeRegButton.BackColor = System.Drawing.Color.White;
            this.closeRegButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeRegButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeRegButton.Image = global::WindowsFormsApp.Properties.Resources.interstellar_3840x2160_stars_4k_8k_9355;
            this.closeRegButton.Location = new System.Drawing.Point(1486, 0);
            this.closeRegButton.Name = "closeRegButton";
            this.closeRegButton.Size = new System.Drawing.Size(29, 31);
            this.closeRegButton.TabIndex = 18;
            this.closeRegButton.Text = "X";
            this.closeRegButton.Click += new System.EventHandler(this.closeRegButton_Click);
            this.closeRegButton.MouseEnter += new System.EventHandler(this.closeRegButton_MouseEnter);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterButton.FlatAppearance.BorderSize = 0;
            this.RegisterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.RegisterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterButton.Image = global::WindowsFormsApp.Properties.Resources.interstellar_3840x2160_stars_4k_8k_9355;
            this.RegisterButton.Location = new System.Drawing.Point(624, 618);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(239, 78);
            this.RegisterButton.TabIndex = 17;
            this.RegisterButton.Text = "Sing up";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            this.RegisterButton.MouseEnter += new System.EventHandler(this.RegisterButton_MouseEnter);
            // 
            // surnameBox
            // 
            this.surnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameBox.Location = new System.Drawing.Point(934, 302);
            this.surnameBox.Multiline = true;
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.surnameBox.Size = new System.Drawing.Size(290, 57);
            this.surnameBox.TabIndex = 15;
            this.surnameBox.Enter += new System.EventHandler(this.surnameBox_Enter);
            this.surnameBox.Leave += new System.EventHandler(this.surnameBox_Leave);
            // 
            // RegistrationLabel
            // 
            this.RegistrationLabel.Font = new System.Drawing.Font("Ebrima", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrationLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.RegistrationLabel.Image = global::WindowsFormsApp.Properties.Resources.interstellar_3840x2160_stars_4k_8k_9355;
            this.RegistrationLabel.Location = new System.Drawing.Point(578, 96);
            this.RegistrationLabel.Name = "RegistrationLabel";
            this.RegistrationLabel.Size = new System.Drawing.Size(364, 97);
            this.RegistrationLabel.TabIndex = 14;
            this.RegistrationLabel.Text = "Registration";
            // 
            // AlreadyButton
            // 
            this.AlreadyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AlreadyButton.FlatAppearance.BorderSize = 0;
            this.AlreadyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.AlreadyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AlreadyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AlreadyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AlreadyButton.Image = global::WindowsFormsApp.Properties.Resources.interstellar_3840x2160_stars_4k_8k_9355;
            this.AlreadyButton.Location = new System.Drawing.Point(568, 724);
            this.AlreadyButton.Name = "AlreadyButton";
            this.AlreadyButton.Size = new System.Drawing.Size(360, 45);
            this.AlreadyButton.TabIndex = 25;
            this.AlreadyButton.Text = "Already have account?";
            this.AlreadyButton.UseVisualStyleBackColor = true;
            this.AlreadyButton.Click += new System.EventHandler(this.AlreadyButton_Click);
            this.AlreadyButton.MouseEnter += new System.EventHandler(this.AlreadyButton_MouseEnter);
            this.AlreadyButton.MouseLeave += new System.EventHandler(this.AlreadyButton_MouseLeave);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp.Properties.Resources.interstellar_3840x2160_stars_4k_8k_9355;
            this.ClientSize = new System.Drawing.Size(1515, 781);
            this.Controls.Add(this.AlreadyButton);
            this.Controls.Add(this.regPasBox);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.regLogBox);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.closeRegButton);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.RegistrationLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox regPasBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox regLogBox;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label closeRegButton;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.Label RegistrationLabel;
        private System.Windows.Forms.Button AlreadyButton;
    }
}