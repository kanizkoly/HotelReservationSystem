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
    public partial class EmployeeWork : Form
    {
        public EmployeeWork()
        {
            InitializeComponent();
            ShowRoomAll();
            ShowRoomAvailable();
            FillCombo();
            countAvailable();
            countUnavailable();
            AutoCompleteEmployeeName();
            ShowRoomUnavailable();
            bookingShow();
            this.WindowState = FormWindowState.Maximized;
        }

        string Gender;
        int checkinCount;
        int checkoutCount;

         private void EmployeeTextFildClear()
         {
             textBoxCustomerName.Text = "";
             numericUpDownCustomerAge.Text = "18";
             radioButtonCustomerMale.Checked=false;
             radioButtonCustomerFemale.Checked=false;
             textBoxCustomerAddress.Text = "";
             textBoxCustomerEmail.Text = "";
             textBoxCustomerPhone.Text = "";
             numericUpDownNoOfAdult.Text = "1";
             numericUpDownNoOfChildren.Text = "0";

             textBoxCustomerRoomNo.Text = "";
             textBoxCustomerFloorNo.Text = "";
             comboBoxCustomerRoomType.Text = "";
             textBoxCustomerChargePerDay.Text = "";
             textBoxCustomerFloorNo.Text = "";
             comboFloor.Text = "";

             textBoxCheckOutServedBy.Text = "";
             textBoxCheckOutCustomerName.Text  = "";
             textBoxCheckOutRoom.Text = "";
             textBoxCheckOutId.Text = "";
             textBoxCheckOutFloor.Text = "";
             textBoxDuration.Text = "";
             textBoxRoomCharge.Text = "";
             textBoxOtherCharge.Text = "0";
             textBoxTotalCharge.Text = "";
             textBoxPayment.Text = "0";
             textBoxReturn.Text = "";
             textBoxTotalRoomCharge.Text = "";
         }

        void FillCombo()
        {
            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True;Pooling=False";
            SqlConnection connection = new SqlConnection(connectionString);
            string commandString = "SELECT DISTINCT floor FROM room";
            SqlCommand command = new SqlCommand(commandString, connection);
            SqlDataReader myReader;
            try
            {
                connection.Open();
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    string value = myReader["floor"].ToString();
                    comboFloor.Items.Add(value);
                }
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void countAvailable()
        {
            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True;Pooling=False";
            SqlConnection connection = new SqlConnection(connectionString);
            string commandString = "SELECT COUNT(status) AS CountResult FROM room WHERE status='Available'";
            SqlCommand command = new SqlCommand(commandString, connection);
            SqlDataReader myReader;
            try
            {
                connection.Open();
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    int value =Convert.ToInt16( myReader["CountResult"]);
                    labelAvailable.Text = Convert.ToString(value);
                }
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void countUnavailable()
        {
            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True;Pooling=False";
            SqlConnection connection = new SqlConnection(connectionString);
            string commandString = "SELECT COUNT(status) AS CountResult FROM room WHERE status='Unavailable'";
            SqlCommand command = new SqlCommand(commandString, connection);
            SqlDataReader myReader;
            try
            {
                connection.Open();
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    int value = Convert.ToInt16(myReader["CountResult"]);
                    labelUnavailable.Text = Convert.ToString(value);
                }
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void colorRoom()
        {
            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True;Pooling=False";
            SqlConnection connection = new SqlConnection(connectionString);
            string commandString = "SELECT * FROM room where floor = '" + comboFloor.Text + "'";
            SqlCommand command = new SqlCommand(commandString, connection);
            SqlDataReader myReader;
            try
            {
                connection.Open();
                myReader = command.ExecuteReader();

                button1.BackColor = Color.White;
                button2.BackColor = Color.White;
                button3.BackColor = Color.White;
                button4.BackColor = Color.White;
                button5.BackColor = Color.White;
                button6.BackColor = Color.White;
                button7.BackColor = Color.White;
                button8.BackColor = Color.White;
                button9.BackColor = Color.White;
                button10.BackColor = Color.White;
                button11.BackColor = Color.White;
                button12.BackColor = Color.White;
                button13.BackColor = Color.White;
                button14.BackColor = Color.White;
                button15.BackColor = Color.White;
                button16.BackColor = Color.White;

                while (myReader.Read())
                {
                    string status = myReader["status"].ToString();
                    int roomno = Convert.ToInt16(myReader["roomno"]);
                    int floorno = Convert.ToInt16(myReader["floor"]);

                    if (roomno % 100 == 1)
                    {
                        if (status == "Available")
                        {
                            button1.Text = roomno + "\nAvailable";
                            button1.BackColor = Color.DarkGreen;
                        }
                        else
                        {
                            button1.Text = roomno + "\nUnavailable";
                            button1.BackColor = Color.DarkRed;
                        }
                    }
                    else if (roomno % 100 == 2)
                    {
                        if (status == "Available")
                        {
                            button2.Text = roomno + "\nAvailable";
                            button2.BackColor = Color.DarkGreen;
                        }
                        else
                        {
                            button2.Text = roomno + "\nUnavaiable";
                            button2.BackColor = Color.DarkRed;
                        }
                    }
                    else if (roomno % 100 == 3)
                    {
                        if (status == "Available")
                        {
                            button3.Text = roomno + "\nAvailable";
                            button3.BackColor = Color.DarkGreen;
                        }
                        else
                        {
                            button3.Text = roomno + "\nUnavaiable";
                            button3.BackColor = Color.DarkRed;
                        }
                    }
                    else if (roomno % 100 == 4)
                    {
                        if (status == "Available")
                        {
                            button4.Text = roomno + "\nAvailable";
                            button4.BackColor = Color.DarkGreen;
                        }
                        else
                        {
                            button4.Text = roomno + "\nUnavaiable";
                            button4.BackColor = Color.DarkRed;
                        }
                    }
                    else if (roomno % 100 == 5)
                    {
                        if (status == "Available")
                        {
                            button5.Text = roomno + "\nAvailable";
                            button5.BackColor = Color.DarkGreen;
                        }
                        else
                        {
                            button5.Text = roomno + "\nUnavaiable";
                            button5.BackColor = Color.DarkRed;
                        }
                    }
                    else if (roomno % 100 == 6)
                    {
                        if (status == "Available")
                        {
                            button6.Text = roomno + "\nAvailable";
                            button6.BackColor = Color.DarkGreen;
                        }
                        else
                        {
                            button6.Text = roomno + "\nUnavaiable";
                            button6.BackColor = Color.DarkRed;
                        }
                    }
                    else if (roomno % 100 == 7)
                    {
                        if (status == "Available")
                        {
                            button7.Text = roomno + "\nAvailable";
                            button7.BackColor = Color.DarkGreen;
                        }
                        else
                        {
                            button7.Text = roomno + "\nUnavaiable";
                            button7.BackColor = Color.DarkRed;
                        }
                    }
                    else if (roomno % 100 == 8)
                    {
                        if (status == "Available")
                        {
                            button8.Text = roomno + "\nAvailable";
                            button8.BackColor = Color.DarkGreen;
                        }
                        else
                        {
                            button8.Text = roomno + "\nUnavaiable";
                            button8.BackColor = Color.DarkRed;
                        }
                    }
                    else if (roomno % 100 == 9)
                    {
                        if (status == "Available")
                        {
                            button9.Text = roomno + "\nAvailable";
                            button9.BackColor = Color.DarkGreen;
                        }
                        else
                        {
                            button9.Text = roomno + "\nUnavaiable";
                            button9.BackColor = Color.DarkRed;
                        }
                    }
                    else if (roomno % 100 == 10)
                    {
                        if (status == "Available")
                        {
                            button10.Text = roomno + "\nAvailable";
                            button10.BackColor = Color.DarkGreen;
                        }
                        else
                        {
                            button10.Text = roomno + "\nUnavaiable";
                            button10.BackColor = Color.DarkRed;
                        }
                    }
                    else if (roomno % 100 == 11)
                    {
                        if (status == "Available")
                        {
                            button11.Text = roomno + "\nAvailable";
                            button11.BackColor = Color.DarkGreen;
                        }
                        else
                        {
                            button11.Text = roomno + "\nUnavaiable";
                            button11.BackColor = Color.DarkRed;
                        }
                    }
                    else if (roomno % 100 == 12)
                    {
                        if (status == "Available")
                        {
                            button12.Text = roomno + "\nAvailable";
                            button12.BackColor = Color.DarkGreen;
                        }
                        else
                        {
                            button12.Text = roomno + "\nUnavaiable";
                            button12.BackColor = Color.DarkRed;
                        }
                    }
                    else if (roomno % 100 == 13)
                    {
                        if (status == "Available")
                        {
                            button13.Text = roomno + "\nAvailable";
                            button13.BackColor = Color.DarkGreen;
                        }
                        else
                        {
                            button13.Text = roomno + "\nUnavaiable";
                            button13.BackColor = Color.DarkRed;
                        }
                    }
                    else if (roomno % 100 == 14)
                    {
                        if (status == "Available")
                        {
                            button14.Text = roomno + "\nAvailable";
                            button14.BackColor = Color.DarkGreen;
                        }
                        else
                        {
                            button14.Text = roomno + "\nUnavaiable";
                            button14.BackColor = Color.DarkRed;
                        }
                    }
                    else if (roomno % 100 == 15)
                    {
                        if (status == "Available")
                        {
                            button15.Text = roomno + "\nAvailable";
                            button15.BackColor = Color.DarkGreen;
                        }
                        else
                        {
                            button15.Text = roomno + "\nUnavaiable";
                            button15.BackColor = Color.DarkRed;
                        }
                    }
                    else
                    {
                        if (status == "Available")
                        {
                            button16.Text = roomno + "\nAvailable";
                            button16.BackColor = Color.DarkGreen;
                        }
                        else
                        {
                            button16.Text = roomno + "\nUnavaiable";
                            button16.BackColor = Color.DarkRed;
                        }
                    }
                }
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            ShowRoomAll();
        }

        private void ShowRoomAll()
        {
            try
            {
                string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True;Pooling=False";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string commandString = "SELECT roomno AS 'Room No.',floor AS 'Floor No.',type AS 'Room Type',charge AS 'Room Charge',status AS 'Current Status' FROM room";
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

        private void ShowRoomAvailable()
        {
            try
            {
                string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True;Pooling=False";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string commandString = "SELECT roomno AS 'Room No.',floor AS 'Floor No.',type AS 'Room Type',charge AS 'Room Charge',status AS 'Current Status' FROM room WHERE status='Available'";
                SqlCommand command = new SqlCommand(commandString, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = command;
                DataTable obj = new DataTable();
                dataAdapter.Fill(obj);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = obj;
                dataGridViewCheckIn.DataSource = bsource;
                dataAdapter.Update(obj);
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowRoomUnavailable()
        {
            try
            {
                string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True;Pooling=False";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string commandString = "SELECT roomno AS 'Room No.',floor AS 'Floor No.',type AS 'Room Type',charge AS 'Room Charge',status AS 'Current Status' FROM room WHERE status='Unavailable'";
                SqlCommand command = new SqlCommand(commandString, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = command;
                DataTable obj = new DataTable();
                dataAdapter.Fill(obj);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = obj;
                dataGridViewCheckOut.DataSource = bsource;
                dataAdapter.Update(obj);
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckIn()
        {
            //insert customer information in checkin table
            try
            {
                string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True;Pooling=False";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string commandString = "INSERT INTO checkin(cname,cage,cgender,caddress,cemail,cphone,adult,children,datein) VALUES('" + textBoxCustomerName.Text + "','" + numericUpDownCustomerAge.Text + "','" + Gender + "','" + textBoxCustomerAddress.Text + "','" + textBoxCustomerEmail.Text + "','" + textBoxCustomerPhone.Text + "','" + numericUpDownNoOfAdult.Text + "','" + numericUpDownNoOfChildren.Text + "','" + dateTimePickerCustomerDateIn.Text + "') ";
                SqlCommand InsertCommand = new SqlCommand(commandString, connection);
                InsertCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                EmployeeTextFildClear();
            }
            // count customer number or checkin number from checkin table
            try
            {
                string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True;Pooling=False";
                SqlConnection connection = new SqlConnection(connectionString);
                string commandString = "SELECT COUNT(checkinno) AS CountResult FROM checkin";
                SqlCommand command = new SqlCommand(commandString, connection);
                SqlDataReader myReader;
                connection.Open();
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    checkinCount = Convert.ToInt16(myReader["CountResult"]);
                }
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            //relate customer and room by reservation table with the help of checkinno and roomno 
            try
            {
                int Count = 1020; //checkinno auto incremented eith seed 1020
                Count = checkinCount + Count;
                string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True;Pooling=False";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string commandString = "INSERT INTO reservation(checkinno,roomno) VALUES('" + Count + "','" + textBoxCustomerRoomNo.Text + "') ";

                SqlCommand InsertCommand = new SqlCommand(commandString, connection);
                InsertCommand.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Customer successfully Checked In.", "Congratulations");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                EmployeeTextFildClear();
            }
            //update room status as Unavailable
            try
            {
                string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True;Pooling=False";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string commandString = "UPDATE room SET status='Unavailable' Where roomno='" + textBoxCustomerRoomNo.Text + "'";
                SqlCommand InsertCommand = new SqlCommand(commandString, connection);
                InsertCommand.ExecuteNonQuery();
                connection.Close();
                EmployeeTextFildClear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                EmployeeTextFildClear();
            }  
        }

        private void AutoCompleteEmployeeName() 
        {   
            //auto completes Employee name in check out page.
            textBoxCheckOutServedBy.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxCheckOutServedBy.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True;Pooling=False";
            SqlConnection connection = new SqlConnection(connectionString);
            string commandString = "SELECT ename FROM employee";
            SqlCommand command = new SqlCommand(commandString, connection);
            SqlDataReader myReader;
            try
            {
                connection.Open();
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    string value = myReader["ename"].ToString();
                    collection.Add(value);
                }
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBoxCheckOutServedBy.AutoCompleteCustomSource = collection;
        }

        private void CheckOut() 
        {
            try
            {
                //enter information about checkout (insert) and modify room status as 'Available' (update)
                string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True;Pooling=False";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string commandString1 = "INSERT INTO checkout(servedby,roomno,dateout,duration,totalroomcharge,othercharge,totalcharge,payment,returncharge) VALUES('" + textBoxCheckOutServedBy.Text + "','" + textBoxCheckOutRoom.Text + "','" + dateTimePickerDateOut.Text + "','" + textBoxDuration.Text + "','" + textBoxTotalRoomCharge.Text + "','" + textBoxOtherCharge.Text + "','" + textBoxTotalCharge.Text + "','" + textBoxPayment.Text + "','" + textBoxReturn.Text + "')";
                string commandString2 = "UPDATE room SET status='Available' WHERE roomno='" + textBoxCheckOutRoom.Text + "' ";
                string commandString3 = "UPDATE reservation SET checkoutno='' WHERE checkinno='" + textBoxCheckOutId.Text + "'";
                SqlCommand InsertCommand = new SqlCommand(commandString1, connection);
                SqlCommand UpdateCommand = new SqlCommand(commandString2, connection);
                InsertCommand.ExecuteNonQuery();
                UpdateCommand.ExecuteNonQuery();
                connection.Close();

                //MessageBox.Show("Guest successfully checked out.", "Congratulations");
                EmployeeTextFildClear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                EmployeeTextFildClear();
            }

            try
            {
                //count number of checkouts bt counting checkoutno in table checkout 
                string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True;Pooling=False";
                SqlConnection connection = new SqlConnection(connectionString);
                string commandString = "SELECT COUNT(checkoutno) AS CountResult FROM checkout";
                SqlCommand command = new SqlCommand(commandString, connection);
                SqlDataReader myReader;
                connection.Open();
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    checkoutCount = Convert.ToInt16(myReader["CountResult"]);
                }
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                //update reservation table accroding to checkin number(checkinno) with corrosponding checkout number(checkoutno)
                int count;
                count = checkoutCount + 100000;
                count--;
                string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True;Pooling=False";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string commandString = "UPDATE reservation SET checkoutno= '"+count+"' WHERE checkinno='" + textBoxCheckOutId.Text + "'";
                SqlCommand UpdateCommand = new SqlCommand(commandString, connection);
                UpdateCommand.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Guest successfully checked out.", "Congratulations");
                EmployeeTextFildClear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                EmployeeTextFildClear();
            }
        }

        private void getNameId() 
        {
            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True;Pooling=False";
            SqlConnection connection = new SqlConnection(connectionString);
            string commandString = "SELECT checkin.cname, checkin.checkinno FROM checkin INNER JOIN reservation ON checkin.checkinno=reservation.checkinno WHERE reservation.roomno='" + textBoxCheckOutRoom.Text + "'";
            SqlCommand command = new SqlCommand(commandString, connection);
            SqlDataReader myReader;
            try
            {
                connection.Open();
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    string name = myReader["cname"].ToString();
                    string id = myReader["checkinno"].ToString();
                    textBoxCheckOutCustomerName.Text = name;
                    textBoxCheckOutId.Text = id;
                }
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bookingShow()
        {
            try
            {
                string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True;Pooling=False";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string commandString = "SELECT bid AS 'Booking No.',bname,baddress,bphone,bemail,broom,bfloor,btype,bstatus,bdate,bday FROM booking WHERE bstatus='Free'";
                SqlCommand command = new SqlCommand(commandString, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = command;
                DataTable obj = new DataTable();
                dataAdapter.Fill(obj);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = obj;
                dataGridViewBooking.DataSource = bsource;
                dataAdapter.Update(obj);
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Warning",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question,
           MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Warning",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question,
           MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Warning",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question,
           MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonCheckOutExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Warning",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question,
           MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonBookingLogOut_Click(object sender, EventArgs e)
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

        private void buttonBookingExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Warning",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question,
           MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonCheckOutLogOut_Click(object sender, EventArgs e)
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

        private void buttonCheckInLogOut_Click(object sender, EventArgs e)
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

        private void buttonRoomStatusLogOut_Click(object sender, EventArgs e)
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

        private void buttonCustomerImageLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            dlg.Title = "Select Customer Picture";
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                string picPath = dlg.FileName.ToString();
                textBoxCustomerImagePath.Text = picPath;
                pictureBoxCustomerImage.ImageLocation = picPath;
            
            }
        }

        private void dataGridViewRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //ShowRoom();
        }

        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            CheckIn();
            ShowRoomAvailable();
            ShowRoomAll();
            ShowRoomUnavailable();
            countAvailable();
            countUnavailable();
        }

        private void radioButtonCustomerFemale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void radioButtonCustomerMale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void dataGridViewCheckIn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridViewCheckIn.Rows[e.RowIndex];

                    textBoxCustomerRoomNo.Text = row.Cells["Room No."].Value.ToString();
                    textBoxCustomerFloorNo.Text = row.Cells["Floor No."].Value.ToString();
                    comboBoxCustomerRoomType.Text = row.Cells["Room Type"].Value.ToString();
                    textBoxCustomerChargePerDay.Text = row.Cells["Room Charge"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonRoomStatusSearch_Click(object sender, EventArgs e)
        {
            colorRoom();
            EmployeeTextFildClear();

        }

        private void dataGridViewCheckOut_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridViewCheckOut.Rows[e.RowIndex];

                    textBoxCheckOutRoom.Text = row.Cells["Room No."].Value.ToString();
                    textBoxCheckOutFloor.Text = row.Cells["Floor No."].Value.ToString();
                    textBoxRoomCharge.Text = row.Cells["Room Charge"].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            getNameId();
        }

        private void EmployeeWork_FormClosing(object sender, FormClosingEventArgs e)
        {
                Application.Exit();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=HMS_DB;Integrated Security=True;Pooling=False";
            SqlConnection connection = new SqlConnection(connectionString);
            string commandString = "SELECT checkin.datein FROM checkin INNER JOIN reservation ON checkin.checkinno=reservation.checkinno WHERE reservation.roomno='" + textBoxCheckOutRoom.Text + "'";
            SqlCommand command = new SqlCommand(commandString, connection);
            SqlDataReader myReader;
            try
            {
                connection.Open();
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    string dateA = Convert.ToString(myReader["datein"]);
                    string dateB = dateTimePickerDateOut.Text;

                    DateTime dt1 = Convert.ToDateTime(dateA);
                    DateTime dt2 = Convert.ToDateTime(dateB); 
                         
                    //System.TimeSpan result = dt2.Subtract(dt1);
                    int duration = (dt2 - dt1).Days;
                    //string result = Convert.ToString((dt2 - dt1).TotalDays); 
                    textBoxDuration.Text =Convert.ToString(duration);
                }
                connection.Close();
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            double totalRoomCharge = Convert.ToDouble(textBoxRoomCharge.Text) * Convert.ToDouble(textBoxDuration.Text);
            double totalCharge = Convert.ToDouble(textBoxOtherCharge.Text) + totalRoomCharge;
            double returnChage = Convert.ToDouble(textBoxPayment.Text) - totalCharge; 

            textBoxTotalRoomCharge.Text = Convert.ToString(totalRoomCharge);
            textBoxTotalCharge.Text = Convert.ToString(totalCharge);
            textBoxReturn.Text = Convert.ToString(returnChage);

        }

        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            CheckOut();
            ShowRoomAvailable();
            ShowRoomAll();
            ShowRoomUnavailable();
            countAvailable();
            countUnavailable();
        }

        private void dataGridViewBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

       