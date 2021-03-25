using MySql.Data.MySqlClient;
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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

          //  nameBox.Text = "Name";
           // surnameBox.Text = "Surname";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closeRegButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeRegButton_MouseEnter(object sender, EventArgs e)
        {
            closeRegButton.ForeColor = Color.White;
        }

        private void RegisterButton_MouseEnter(object sender, EventArgs e)
        {
            RegisterButton.ForeColor = Color.White;
        }

        Point lastpoint;
        private void RegisterForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void RegisterForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void nameBox_Enter(object sender, EventArgs e)
        {
            if (nameBox.Text == "Name")
            {
                nameBox.Text = "";
            }
        }

        private void nameBox_Leave(object sender, EventArgs e)
        {
            if (nameBox.Text == "")
            {
                nameBox.Text = "Name";
            }
        }

        private void surnameBox_Enter(object sender, EventArgs e)
        {
            if (surnameBox.Text == "Surname")
            {
                surnameBox.Text = "";
            }
        }

        private void surnameBox_Leave(object sender, EventArgs e)
        {
            if (surnameBox.Text == "")
            {
                surnameBox.Text = "Surname";
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (regLogBox.Text == "")
            {
                MessageBox.Show("Please, write your login");
                return;
            }

            if (regPasBox.Text == "")
            {
                MessageBox.Show("Please, write your password");
                return;
            }

            if (nameBox.Text == "Name")
            {
                MessageBox.Show("Please, write your name");
                return;
            }

            if (surnameBox.Text == "Surname")
            {
                MessageBox.Show("Please, write your surname");
                return;
            }

            if (isLoginExists())
            {
                return;
            }

            DB db = new DB();

            MySqlCommand command = new MySqlCommand("INSERT INTO `users`(`login`,`password`,`name`,`surname`) VALUES (@L,@P,@N,@S)", db.GetConnection());

            //MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `name`, `surname`) VALUES (@L, @P, @N, @S)",db.GetConnection());

            command.Parameters.Add("@L", MySqlDbType.VarChar).Value = regLogBox.Text;
            command.Parameters.Add("@P", MySqlDbType.VarChar).Value = regPasBox.Text;
            command.Parameters.Add("@N", MySqlDbType.VarChar).Value = nameBox.Text;
            command.Parameters.Add("@S", MySqlDbType.VarChar).Value = surnameBox.Text;

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Account has been created");
            }
            else
            {
                MessageBox.Show("Acccount has not been created");
            }

            db.CloseConnection();
        }

        public Boolean isLoginExists()
        {
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login`=@L", db.GetConnection());
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            command.Parameters.Add("@L", MySqlDbType.VarChar).Value = regLogBox.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("This login is already used by another user.\nPlease create new.");
                return true;
            }
            else
            {
                return false;
            }

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void AlreadyButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void AlreadyButton_MouseEnter(object sender, EventArgs e)
        {
            AlreadyButton.ForeColor = Color.White;
        }

        private void AlreadyButton_MouseLeave(object sender, EventArgs e)
        {
            AlreadyButton.ForeColor = Color.Black;
        }
    }
}
