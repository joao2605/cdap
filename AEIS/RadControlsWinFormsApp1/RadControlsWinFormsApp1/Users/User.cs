using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace AEIS
{
    class User
    {
        //global variables
        public string userId;
        public string firstName;
        public string lastName;
        public string title;
        public string userLevel;
        public string username;
        public string password;
        public string email;
        public DateTime createdDate;
        public string createdTime;
        public byte[] photo;

        public SqlConnection connection;

        //constructor
        public User()
        {
            //empty constructor
        }

        public User(string USER_ID, string FIRST_NAME, string LAST_NAME, string TITLE, string USER_LEVEL, string USERNAME, string PASSWORD, string EMAIL, DateTime CREATED_DATE, string CREATED_TIME,byte[] IMAGE)
        {
            this.userId=USER_ID;
            this.firstName=FIRST_NAME;
            this.lastName=LAST_NAME;
            this.title=TITLE;
            this.userLevel=USER_LEVEL;
            this.username=USERNAME;
            this.password=PASSWORD;
            this.email=EMAIL;
            this.createdDate=CREATED_DATE;
            this.createdTime=CREATED_TIME;
            this.photo = IMAGE;
        }

        //Inset new User
        public bool InsertUser(User newUser)
        {
            try
            {             
                this.connection = DBHandler.getConnection();
            }
             catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }

            bool status = false;

            if (connection.State.ToString() == "Closed")
            {
                connection.Open();
            }

            SqlCommand newCmd = connection.CreateCommand();

            newCmd.Connection = connection;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into Users values('" + newUser.userId + "','" + newUser.firstName + "','" + newUser.lastName + "','" + newUser.title + "','" + newUser.userLevel + "','" + newUser.username + "','" + newUser.password + "','" + newUser.email + "','" + newUser.createdDate + "','" + newUser.createdTime + "','" + newUser.photo + "')";
            try
            {
                newCmd.ExecuteNonQuery();
                status = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();
            return status;
        }

        //Get user list
        public DataSet getUserList(string userID)
        {
            try
            {
                this.connection = DBHandler.getConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            
            if (connection.State.ToString() == "Closed")
            {
                connection.Open();
            }

            SqlCommand newCmd = connection.CreateCommand();
            newCmd.Connection = connection;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select user_id,title,first_name,last_name,email,user_level,user_name,created_date,created_time from Users where user_id like '%" + userID + "%';";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Users");

            connection.Close();

            return ds;
        }

        //Delete User
        public bool DeleteUser(string user_ID)
        {
            try
            {
                this.connection = DBHandler.getConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }

            bool status = false;

            if (connection.State.ToString() == "Closed")
            {
                connection.Open();
            }

            SqlCommand newCmd = connection.CreateCommand();

            newCmd.Connection = connection;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "DELETE FROM Users WHERE user_id='"+user_ID+"';";
            try
            {
                newCmd.ExecuteNonQuery();
                status = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();
            return status;
        }

        //Reset User
        public bool ResetUser(string user_ID,string user_name,string password)
        {
            try
            {
                this.connection = DBHandler.getConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }

            bool status = false;

            if (connection.State.ToString() == "Closed")
            {
                connection.Open();
            }

            SqlCommand newCmd = connection.CreateCommand();

            newCmd.Connection = connection;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "UPDATE Users SET user_name='"+user_name+"',password='"+password+"' WHERE user_id='"+user_ID+"';";
            try
            {
                newCmd.ExecuteNonQuery();
                status = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();
            return status;
        }

        //update User
        public bool UpdateUser(User editedUser)
        {
            try
            {
                this.connection = DBHandler.getConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }

            bool status = false;

            if (connection.State.ToString() == "Closed")
            {
                connection.Open();
            }

            SqlCommand newCmd = connection.CreateCommand();

            newCmd.Connection = connection;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "UPDATE Users SET user_id='" + editedUser.userId + "',first_name='" + editedUser.firstName + "',last_name='" + editedUser.lastName + "',title='" + editedUser.title + "',user_level='" + editedUser.userLevel + "',user_name='" + editedUser.username + "',password='" + editedUser.password + "',email='" + editedUser.email + "',photograph='" + editedUser.photo + "' where user_id='" + editedUser.userId + "';";
            try
            {
                newCmd.ExecuteNonQuery();
                status = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();
            return status;
        }

        public bool sendMail(string mailAddress, string subj, string username, string password)
        {
            bool status = true;

            var fromAddress = new MailAddress("gsr.shyamike@gmail.com", "Shyamike");
            var toAddress = new MailAddress("gsr.shyamike@gmail.com", "Gayan");
            const string fromPassword = "xxxx";
            string subject = subj;
            string body = "Username is :"+username+" Password is :"+password;

            try
            {
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
            }
            catch (Exception ex)
            {
                status = false;
                MessageBox.Show(ex.Message.ToString());
            }

            return status;
        }

        //take the password according to the user name
        public DataSet getPassword(string userId)
        {
            try
            {
                this.connection = DBHandler.getConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }

            if (connection.State.ToString() == "Closed")
            {
                connection.Open();
            }

            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("select user_level,password,user_name from Users where user_id='" + userId + "' ", connection);
            adapter.Fill(ds);

            connection.Close();
            return ds;
        }

        
        //Insert log tracker
        public bool InsertLogRecord(string ID, DateTime Date)
        {
            try
            {
                this.connection = DBHandler.getConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }

            bool status = false;

            if (connection.State.ToString() == "Closed")
            {
                connection.Open();
            }

            SqlCommand newCmd = connection.CreateCommand();

            newCmd.Connection = connection;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "INSERT INTO User_Tracker VALUES('" + ID + "','" + Date + "','" + Date + "',0,'No')";
            try
            {
                newCmd.ExecuteNonQuery();
                status = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();
            return status;
        }

        //Update log tracker
        public bool UpdateLogRecord(string ID, DateTime Login_Time, DateTime Logout_Time)
        {
            try
            {
                this.connection = DBHandler.getConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }

            bool status = false;

            if (connection.State.ToString() == "Closed")
            {
                connection.Open();
            }

            SqlCommand cmd = new SqlCommand("updateUserTrack", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@UserID", SqlDbType.VarChar).Value = ID;
            cmd.Parameters.Add("@loginTime", SqlDbType.DateTime).Value = Login_Time;
            cmd.Parameters.Add("@logoutTime", SqlDbType.DateTime).Value = Logout_Time;

            try
            {
                cmd.ExecuteNonQuery();
                status = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();
            return status;
        }

        //get full detailed user login tracks
        public DataSet getLogInfo()
        {
            try
            {
                this.connection = DBHandler.getConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }

            if (connection.State.ToString() == "Closed")
            {
                connection.Open();
            }

            SqlCommand newCmd = connection.CreateCommand();
            newCmd.Connection = connection;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "SELECT user_id AS User_ID, SUM(time_spent) AS Time_Count,COUNT(user_id) AS Interaction_Count FROM User_Tracker GROUP BY user_id;";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Info");

            connection.Close();
            return ds;
        }

        //get user login tracks
        public DataSet getLogTrack()
        {
            try
            {
                this.connection = DBHandler.getConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }

            if (connection.State.ToString() == "Closed")
            {
                connection.Open();
            }

            SqlCommand newCmd = connection.CreateCommand();
            newCmd.Connection = connection;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "SELECT user_id AS User_ID, SUM(time_spent) AS Time_Count FROM User_Tracker GROUP BY user_id;";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Tracks");

            connection.Close();
            return ds;
        }
    }
}
