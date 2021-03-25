using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void AuthorizationLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void AuthorizationLabel_MouseEnter(object sender, EventArgs e)
        {
            AuthorizationLabel.ForeColor = Color.White;
        }

        private void AuthorizationLabel_MouseLeave(object sender, EventArgs e)
        {
            AuthorizationLabel.ForeColor = Color.Black;
        }

        private void RegistrationLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void RegistrationLabel_MouseEnter(object sender, EventArgs e)
        {
            RegistrationLabel.ForeColor = Color.White;
        }

        private void RegistrationLabel_MouseLeave(object sender, EventArgs e)
        {
            RegistrationLabel.ForeColor = Color.Black;
        }

        private void closeRegButton_MouseEnter(object sender, EventArgs e)
        {
            closeRegButton.ForeColor = Color.White;
        }

        private void closeRegButton_MouseLeave(object sender, EventArgs e)
        {
            closeRegButton.ForeColor = Color.Black;
        }

        private void closeRegButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastpoint;

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }
    }
}
