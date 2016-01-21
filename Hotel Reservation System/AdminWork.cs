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
    public partial class AdminWork : Form
    {
        public AdminWork()
        {
            InitializeComponent();
            ShowTransactionCheckIn();
            ShowTransactionCheckOut();
            ShowEmployee();
            ShowRoom();
        }

        string Designation;
        string RoomStatus;

        private void AdminTextFildClear()
        {
            textBoxEmployeeId.Text = "";
            textBoxEmployeeName.Text = "";
            Designation = "";
            radioButtonEmployeeAsAdmin.Checked = false;
            radioButtonEmployeeAsEmployee.Checked = false;
            textBoxEmployeePassword.Text = "";
            textBoxEmployeeEmail.Text = "";
            textBoxEmployeePhone.Text = "";
            textBoxEmployeeSalary.Text = "";
            dateTimePickerEmployeeJoiningDate.Text = "";

            textBoxEmployeeSearchId.Text= "";
            textBoxEmployeeSearchName.Text = "";

            textBoxRoomNo.Text = "";
            comboBoxRoomType.Text = "";
            comboBoxFloorNo.Text = "";
            textBoxRoomCharge.Text = "";
            radioButtonAvailable.Checked = false;
            radioButtonUnavailable.Checked = false;

            textBoxSearchRoomNo.Text = "";
            textBoxSearchFloorNo.Text = "";

        }

        private void ShowTransactionCheckIn()
        {
            try
            {
                string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True;Pooling=False";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string commandString = "SELECT checkinno AS 'Check-In No.',cname AS 'Customer Name',cage AS 'Age',cgender AS 'Gender',caddress AS 'Address',cemail AS 'Email',cphone AS 'Phone No.',adult AS 'No. of Adult',children AS 'No. of Children',datein AS 'Check-In Date' FROM checkin";
                SqlCommand command = new SqlCommand(commandString, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = command;
                DataTable obj = new DataTable();
                dataAdapter.Fill(obj);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = obj;
                dataGridViewTransaction1.DataSource = bsource;
                dataAdapter.Update(obj);
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowTransactionCheckOut()
        {
            try
            {
                string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True;Pooling=False";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string commandString = "SELECT checkoutno AS 'Check-Out No.',servedby AS 'Served by',roomno AS 'Room No',dateout AS 'Check-Out Date',duration AS 'Duration',totalroomcharge AS 'Room Charge (Total)',othercharge AS 'Other Charges',totalcharge AS 'Total Charge',payment AS 'Customer Paid',returncharge AS 'Return to Customer' FROM checkout";
                SqlCommand command = new SqlCommand(commandString, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = command;
                DataTable obj = new DataTable();
                dataAdapter.Fill(obj);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = obj;
                dataGridViewTransaction2.DataSource = bsource;
                dataAdapter.Update(obj);
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowEmployee()
        {
            try
            {
                string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True;Pooling=False";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string commandString = "SELECT eid AS 'Employee Id',ename AS 'Name',epass AS 'Password',edesignation AS 'Designation',eemail AS 'Email',ephone AS 'Phone No',esalary AS 'Salary',edate AS 'Joning-date' FROM employee";
                SqlCommand command = new SqlCommand(commandString, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = command;
                DataTable obj = new DataTable();
                dataAdapter.Fill(obj);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = obj;
                dataGridViewEmployee.DataSource = bsource;
                dataAdapter.Update(obj);
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchEmployee()
        {
            try
            {
                string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True;Pooling=False";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string commandString = "SELECT * FROM employee WHERE eid LIKE '" + textBoxEmployeeSearchId.Text + "%' AND ename LIKE '%" + textBoxEmployeeSearchName.Text + "%'";
                SqlCommand command = new SqlCommand(commandString, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = command;
                DataTable obj = new DataTable();
                dataAdapter.Fill(obj);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = obj;
                dataGridViewEmployee.DataSource = bsource;
                dataAdapter.Update(obj);
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddEmployee()
        {
            try
            {
                string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True;Pooling=False";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string commandString = "INSERT INTO employee(eid,ename,edesignation,epass,eemail,ephone,esalary,edate) VALUES('" + textBoxEmployeeId.Text + "','" + textBoxEmployeeName.Text + "','" + Designation + "','" + textBoxEmployeePassword.Text + "','" + textBoxEmployeeEmail.Text + "','" + textBoxEmployeePhone.Text + "','" + textBoxEmployeeSalary.Text + "','" + dateTimePickerEmployeeJoiningDate.Text + "')";
                SqlCommand InsertCommand = new SqlCommand(commandString, connection);
                InsertCommand.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Employee successfully added to the database.", "Congratulations");
                AdminTextFildClear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                AdminTextFildClear();
            }
        }

        private void RemoveEmployee()
        {
            try
            {
                string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True;Pooling=False";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string commandString = "DELETE FROM employee WHERE eid='" + textBoxEmployeeId.Text + "'";
                SqlCommand InsertCommand = new SqlCommand(commandString, connection);
                InsertCommand.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Employee successfully deleted from database.", "Congratulations");
                AdminTextFildClear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                AdminTextFildClear();
            }
        }

        private void UpdateEmployee()
        {
            try
            {
                string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True;Pooling=False";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string commandString = "UPDATE employee SET ename='" + textBoxEmployeeName.Text + "',edesignation='" + Designation + "',epass='" + textBoxEmployeePassword.Text + "',eemail='" + textBoxEmployeeEmail.Text + "',ephone='" + textBoxEmployeePhone.Text + "',esalary='" + textBoxEmployeeSalary.Text + "',edate='" + dateTimePickerEmployeeJoiningDate.Text + "' WHERE eid='" + textBoxEmployeeId.Text + "'";
                SqlCommand InsertCommand = new SqlCommand(commandString, connection);
                InsertCommand.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Employee successfully updated into the database.", "Congratulations");
                AdminTextFildClear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                AdminTextFildClear();
            }
        }


        private void ShowRoom()
        {
            try
            {
                string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True;Pooling=False";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string commandString = "SELECT roomno AS 'Room No',floor As 'Floor',type As 'Type',charge As 'Charge',status As 'Status' FROM room";
                SqlCommand command = new SqlCommand(commandString, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = command;
                DataTable obj = new DataTable();
                dataAdapter.Fill(obj);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = obj;
                dataGridViewRoom.DataSource = bsource;
                dataAdapter.Update(obj);
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchRoom()
        {
            try
            {
                string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True;Pooling=False";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string commandString = "SELECT * FROM room WHERE roomno LIKE '%" + textBoxSearchRoomNo.Text + "%' AND floor LIKE '%" + textBoxSearchFloorNo.Text + "%'";
                SqlCommand command = new SqlCommand(commandString, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = command;
                DataTable obj = new DataTable();
                dataAdapter.Fill(obj);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = obj;
                dataGridViewRoom.DataSource = bsource;
                dataAdapter.Update(obj);
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddRoom()
        {
            try
            {
                string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True;Pooling=False";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string commandString = "INSERT INTO room(roomno,type,floor,charge,status) VALUES('" + textBoxRoomNo.Text + "','" + comboBoxRoomType.Text + "','" + comboBoxFloorNo.Text + "','" + textBoxRoomCharge.Text + "','" + RoomStatus + "')";
                SqlCommand InsertCommand = new SqlCommand(commandString, connection);
                InsertCommand.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Room successfully added to the database.", "Congratulations");
                AdminTextFildClear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                AdminTextFildClear();
            }
        }

        private void RemoveRoom()
        {
            try
            {
                string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True;Pooling=False";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string commandString = "DELETE FROM room WHERE roomno='" + textBoxRoomNo.Text + "'";
                SqlCommand InsertCommand = new SqlCommand(commandString, connection);
                InsertCommand.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Room successfully deleted from database.", "Congratulations");
                AdminTextFildClear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                AdminTextFildClear();
            }
        }

        private void UpdateRoom()
        {
            try
            {
                string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True;Pooling=False";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string commandString = "UPDATE room SET type='" + comboBoxRoomType.Text + "',floor='" + comboBoxFloorNo.Text + "',charge='" + textBoxRoomCharge.Text + "',status='" + RoomStatus + "' WHERE roomno='" + textBoxRoomNo.Text + "' ";
                SqlCommand InsertCommand = new SqlCommand(commandString, connection);
                InsertCommand.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Room successfully updated into the database.", "Congratulations");
                AdminTextFildClear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                AdminTextFildClear();
            }
        }

        private void buttonEmployeeLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Log out?", "Warning",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question,
           MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Hide();
                FormFrontPage go = new FormFrontPage();
                go.ShowDialog();
            }
        }

        private void buttonRoomLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Log out?", "Warning",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question,
           MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Hide();
                FormFrontPage go = new FormFrontPage();
                go.ShowDialog();
            }
        }

        private void buttonRoomExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Warning",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                       MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonEmployeeExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Warning",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                       MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonEmployeeAdd_Click(object sender, EventArgs e)
        {
            AddEmployee();
            ShowEmployee();
        }

        private void buttonEmployeeDelete_Click(object sender, EventArgs e)
        {
            RemoveEmployee();
            ShowEmployee();
        }

        private void buttonEmployeeUpdate_Click(object sender, EventArgs e)
        {
            UpdateEmployee();
            ShowEmployee();
        }

        private void dataGridViewEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridViewEmployee.Rows[e.RowIndex];

                    textBoxEmployeeId.Text = row.Cells["Employee Id"].Value.ToString();
                    textBoxEmployeeName.Text = row.Cells["Name"].Value.ToString();
                    Designation = row.Cells["Designation"].Value.ToString();
                    if (Designation == "Admin")
                    {
                        radioButtonEmployeeAsAdmin.Checked = true;
                    }
                    else if (Designation == "Employee")
                    {
                        radioButtonEmployeeAsEmployee.Checked = true;
                    }
                    textBoxEmployeePassword.Text = row.Cells["Password"].Value.ToString();
                    textBoxEmployeeEmail.Text = row.Cells["Email"].Value.ToString();
                    textBoxEmployeePhone.Text = row.Cells["Phone No"].Value.ToString();
                    textBoxEmployeeSalary.Text = row.Cells["Salary"].Value.ToString();
                    dateTimePickerEmployeeJoiningDate.Text = row.Cells["Joning-date"].Value.ToString();
                }
            }
            catch(Exception ex)
            {
            MessageBox.Show(ex.Message);
            }
        }

        private void buttonRoomAdd_Click(object sender, EventArgs e)
        {
            AddRoom();
            ShowRoom();
        }

        private void buttonRoomDelete_Click(object sender, EventArgs e)
        {
            RemoveRoom();
            ShowRoom();
        }

        private void buttonRoomUpdate_Click(object sender, EventArgs e)
        {
            UpdateRoom();
            ShowRoom();
        }

        private void radioButtonEmployeeAsAdmin_CheckedChanged(object sender, EventArgs e)
        {
            Designation = "Admin";
        }

        private void radioButtonEmployeeAsEmployee_CheckedChanged(object sender, EventArgs e)
        {
            Designation = "Employee";
        }

        private void radioButtonAvailable_CheckedChanged(object sender, EventArgs e)
        {
            RoomStatus = "Available";
        }

        private void radioButtonUnavailable_CheckedChanged(object sender, EventArgs e)
        {
            RoomStatus = "Unavailable";
        }

        private void dataGridViewRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridViewRoom.Rows[e.RowIndex];

                    textBoxRoomNo.Text = row.Cells["Room No"].Value.ToString();
                    comboBoxRoomType.Text = row.Cells["Type"].Value.ToString();
                    comboBoxFloorNo.Text = row.Cells["Floor"].Value.ToString();
                    textBoxRoomCharge.Text = row.Cells["Charge"].Value.ToString();
                    RoomStatus = row.Cells["Status"].Value.ToString();
                    if (RoomStatus == "Available")
                    {
                        radioButtonAvailable.Checked = true;
                    }
                    else if (RoomStatus == "Unavailable")
                    {
                        radioButtonUnavailable.Checked = true;
                    }
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonEmployeeSearch_Click(object sender, EventArgs e)
        {
            SearchEmployee();
        }

        private void buttonRoomSearch_Click(object sender, EventArgs e)
        {
            SearchRoom();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void buttonTransactionExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Warning",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                       MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonTransactionLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Log out?", "Warning",
          MessageBoxButtons.YesNo, MessageBoxIcon.Question,
          MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Hide();
                FormFrontPage go = new FormFrontPage();
                go.ShowDialog();
            }
        }

        private void AdminWork_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
