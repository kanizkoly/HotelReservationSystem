using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel_Reservation_System
{
    public partial class FormFrontPage : Form
    {
        public FormFrontPage()
        {
            InitializeComponent();
            textBoxAdminPass.PasswordChar = '●';
            textBoxEmpPass.PasswordChar = '●';
            textBoxAdminPass.MaxLength = 8;
            textBoxEmpPass.MaxLength = 8;
            timerFront.Start();
        }

        private void loginTextClear()
        {
            textBoxAdminName.Text = "";
            textBoxAdminPass.Text = "";
            textBoxEmpName.Text = "";
            textBoxEmpPass.Text = "";
        }

        private void EmployeeEnter_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeWork go = new EmployeeWork();
            go.ShowDialog();
            //try
            //{
            //    string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True;Pooling=False";
            //    SqlConnection connection = new SqlConnection(connectionString);
            //    string commandString = "SELECT * FROM employee where ename='" + textBoxEmpName.Text + "'and epass='" + textBoxEmpPass.Text + "'";
            //    SqlCommand SelectCommand = new SqlCommand(commandString, connection);
            //    SqlDataReader sqlReader;
            //    connection.Open();
            //    sqlReader = SelectCommand.ExecuteReader();
            //    int count = 0;
            //    while (sqlReader.Read())
            //    {
            //        count = count + 1;
            //    }
            //    if (count == 1)
            //    {
            //        loginTextClear();
            //        MessageBox.Show("Username and password is Correct");
            //        this.Hide();
            //        EmployeeWork go = new EmployeeWork();
            //        go.ShowDialog();
            //    }
            //    else if (count > 1)
            //    {
            //        MessageBox.Show("Duplicate username and password exists", "Error");
            //        loginTextClear();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Username and password is not correct", "Error");
            //        loginTextClear();
            //    }
            //    connection.Close();
            //}
            //catch (SqlException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

        }

        private void buttonExitApplication_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to exit?", "Warning",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                       MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        
        private void buttonAdminEnter_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminWork go = new AdminWork();
            go.ShowDialog();
            //try
            //{
            //    string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True;Pooling=False";
            //    SqlConnection connection = new SqlConnection(connectionString);
            //    string commandString = "SELECT * FROM employee where edesignation='admin' and ename='" + textBoxAdminName.Text + "'and epass='" + textBoxAdminPass.Text + "'";
            //    SqlCommand SelectCommand = new SqlCommand(commandString, connection);
            //    SqlDataReader sqlReader;
            //    connection.Open();
            //    sqlReader = SelectCommand.ExecuteReader();
            //    int count = 0;
            //    while (sqlReader.Read())
            //    {
            //        count = count + 1;
            //    }
            //    if (count == 1)
            //    {
            //        loginTextClear();
            //        MessageBox.Show("Username and password is Correct");
            //        this.Hide();
            //        AdminWork go = new AdminWork();
            //        go.ShowDialog();
            //    }
            //    else if (count > 1)
            //    {
            //        MessageBox.Show("Duplicate username and password exists", "Error");
            //        loginTextClear();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Username and password is not correct", "Error");
            //        loginTextClear();
            //    }
            //    connection.Close();
            //}
            //catch (SqlException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void FormFrontPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void timerFront_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            labelFrontTime.Text =Convert.ToString (dateTime);
        }
    }
}
