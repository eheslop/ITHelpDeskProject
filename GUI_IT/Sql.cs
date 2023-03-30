using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using Org.BouncyCastle.Crmf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI_IT
{
    internal class Sql
    {

        public static SqlConnection Connect()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "redagents.database.windows.net";
            builder.UserID = "kwekwe";
            builder.Password = "Password1!";
            builder.InitialCatalog = "red_Agents";
            SqlConnection con = new SqlConnection(builder.ConnectionString);
            con.Open();
            return con;
        }

        public static void Register(string user, string name, string first, string last, string pass, string email, string role, DateTime time)
        {
            string x = "Pending";
            SqlConnection con = Connect();
            String query = "INSERT INTO Registration(Username, Name, First_Name, Last_Name, Password, Email, Role, Status, Time) VALUES('" + user.ToString() + "', '" + name.ToString() + "', '" + first.ToString() + "', '" + last.ToString() + "','" + pass.ToString() + "', '" + email.ToString() + "', '" + role.ToString() + "', '" + x + "', '" + time + "');";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static int Login(string user, string password)
        {
            SqlConnection con = Connect();
            String query = "SELECT 1 FROM RegisteredUsers WHERE Username = '" + user.ToString() + "' AND Password = '" + password.ToString() + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            object exists = cmd.ExecuteScalar();
            con.Close();
            if (exists == null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
            // 1 == Does Not Exist
            // 0 == Exists
        }

        public static string Role(string user)
        {
            SqlConnection con = Connect();
            String query = "SELECT Role FROM RegisteredUsers WHERE Username = '" + user.ToString() + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            object role = cmd.ExecuteScalar();
            if (role == null)
                return "error";
            else
                return (string)role;
        }

        public static Boolean Exists(string user)
        {
            SqlConnection con = Connect();
            String query = "SELECT * FROM RegisteredUsers WHERE Username = '" + user.ToString() + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            object role = cmd.ExecuteScalar();
            if (role == null)
                return false;
            else
                return true;
        }

        public static string getName(string user)
        {
            SqlConnection con = Connect();
            String query = "SELECT First_Name FROM RegisteredUsers WHERE Username = '" + user.ToString() + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            string name = (string)cmd.ExecuteScalar();
            return name;
        }

        public static string getfullName(string user)
        {
            SqlConnection con = Connect();
            String query = "SELECT Name FROM RegisteredUsers WHERE Username = '" + user.ToString() + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            string name = (string)cmd.ExecuteScalar();
            return name;
        }
        public static string getRole(string user)
        {
            SqlConnection con = Connect();
            String query = "SELECT Role FROM RegisteredUsers WHERE Username = '" + user.ToString() + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            string name = (string)cmd.ExecuteScalar();
            return name;
        }
        public static string getEmail(string user)
        {
            SqlConnection con = Connect();
            String query = "SELECT email FROM RegisteredUsers WHERE Username = '" + user.ToString() + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            string email = (string)cmd.ExecuteScalar();
            return email;
        }
        public static string getPass(string user)
        {
            SqlConnection con = Connect();
            String query = "SELECT password FROM RegisteredUsers WHERE Username = '" + user.ToString() + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            string pass = (string)cmd.ExecuteScalar();
            return pass;
        }

        public static string getTicketCategory(int tID)
        {
            SqlConnection con = Connect();
            String query = "SELECT Category FROM Tickets WHERE Id = '" + tID.ToString() + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            string category = (string)cmd.ExecuteScalar();
            return category;
        }

        public static string getTicketPriority(int tID)
        {
            SqlConnection con = Connect();
            String query = "SELECT Priority FROM Tickets WHERE Id = '" + tID.ToString() + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            string priority = (string)cmd.ExecuteScalar();
            return priority;
        }
        public static string getTicketUser(int tID)
        {
            SqlConnection con = Connect();
            String query = "SELECT Username FROM Tickets WHERE Id = '" + tID.ToString() + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            string user = (string)cmd.ExecuteScalar();
            return user;
        }

        public static string getTicketDescription(int tID)
        {
            SqlConnection con = Connect();
            String query = "SELECT Description FROM Tickets WHERE Id = '" + tID.ToString() + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            string description = (string)cmd.ExecuteScalar();
            return description;
        }

        public static DataTable FILL()
        {
            SqlConnection con = Connect();
            con.Open();
            string query = "Select * from Registration";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public static void RaiseTicket(int id, string name, string username, string Category, string Description, string email, string Priority)
        {
            SqlConnection con = Connect();
            string x = "Pending";
            String query = "INSERT INTO Tickets(id, Name, Username, Category, Description, Status, Email, Priority) VALUES('" + id + "',  '" + name.ToString() + "', '" + username.ToString() + "', '" + Category.ToString() + "', '" + Description.ToString() + "', '" +x+ "',  '" + email.ToString() + "', '" + Priority.ToString() + "');";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static string retName()
        {
            SqlConnection con = Connect();
            String query = "SELECT top 1 Name FROM Registration;";
            SqlCommand cmd = new SqlCommand(query, con);
            string name = (string)cmd.ExecuteScalar();
            return name;
        }

        public static string retFirst()
        {
            SqlConnection con = Connect();
            String query = "SELECT top 1 First_Name FROM Registration;";
            SqlCommand cmd = new SqlCommand(query, con);
            string name = (string)cmd.ExecuteScalar();
            return name;
        }

        public static string retLast()
        {
            SqlConnection con = Connect();
            String query = "SELECT top 1 Last_Name FROM Registration;";
            SqlCommand cmd = new SqlCommand(query, con);
            string name = (string)cmd.ExecuteScalar();
            return name;
        }

        public static string retEmail()
        {
            SqlConnection con = Connect();
            String query = "SELECT top 1 Email FROM Registration;";
            SqlCommand cmd = new SqlCommand(query, con);
            string email = (string)cmd.ExecuteScalar();
            return email;
        }

        public static string retUser()
        {
            SqlConnection con = Connect();
            String query = "SELECT top 1 Username FROM Registration;";
            SqlCommand cmd = new SqlCommand(query, con);
            string user = (string)cmd.ExecuteScalar();
            return user;
        }

        public static string rerole()
        {
            SqlConnection con = Connect();
            String query = "SELECT top 1 Role FROM Registration;";
            SqlCommand cmd = new SqlCommand(query, con);
            string role = (string)cmd.ExecuteScalar();
            return role;
        }

        public static void Regis(string user, string name, string first, string last, string pass, string email, string role)
        {
            SqlConnection con = Connect();
            String query = "INSERT INTO RegisteredUsers(Username, Name, First_Name, Last_Name, Password, Email, Role) VALUES('" + user.ToString() + "', '" + name.ToString() + "', '" + first.ToString() + "', '" + last.ToString() + "','" + pass.ToString() + "', '" + email.ToString() + "', '" + role.ToString() + "');";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static string repass()
        {
            SqlConnection con = Connect();
            String query = "SELECT top 1 Password FROM Registration;";
            SqlCommand cmd = new SqlCommand(query, con);
            string pass = (string)cmd.ExecuteScalar();
            return pass;
        }

        public static void delete(string user)
        {
            SqlConnection con = Connect();
            String query = "DELETE FROM Registration where Username = '" + user + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void cngpass(string user, string newpass)
        {
            SqlConnection con = Connect();
            String query = "UPDATE RegisteredUsers SET Password = '" + newpass + "' where Username = '" + user + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static int count()
        {
            SqlConnection con = Connect();
            String query = "SELECT Count(Id) FROM Tickets;";
            SqlCommand cmd = new SqlCommand(query, con);
            int pass = (int)cmd.ExecuteScalar();
            return pass;
        }

        public static void log(string user)
        {
            SqlConnection con = Connect();
            String query = "INSERT INTO Login(Username) VALUES('" + user.ToString() + "');";
            SqlCommand cmd = new SqlCommand(query, con);
            int pass = (int)cmd.ExecuteScalar();
        }


    }
}
