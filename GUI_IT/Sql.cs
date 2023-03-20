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

        public static void Register(string user, string name, string pass, string email, string role)
        {
            SqlConnection con = Connect();
            String query = "INSERT INTO Registration(Username, Name, Password, Email, Role) VALUES('" + user.ToString() + "', '" + name.ToString() + "', '" + pass.ToString() + "', '" + email.ToString() + "', '" + role.ToString() + "');";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static int Login(string user, string password)
        {
            SqlConnection con = Connect();
            String query = "SELECT 1 FROM Registration WHERE Username = '" + user.ToString() + "' AND Password = '" + password.ToString() + "';";
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
            String query = "SELECT Role FROM Registration WHERE Username = '" + user.ToString() + "';";
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
            String query = "SELECT * FROM Registration WHERE Username = '" + user.ToString() + "';";
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
            String query = "SELECT name FROM Registration WHERE Username = '" + user.ToString() + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            string name = (string)cmd.ExecuteScalar();
            return name;
        }
        public static string getEmail(string user)
        {
            SqlConnection con = Connect();
            String query = "SELECT email FROM Registration WHERE Username = '" + user.ToString() + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            string email = (string)cmd.ExecuteScalar();
            return email;
        }
        public static string getPass(string user)
        {
            SqlConnection con = Connect();
            String query = "SELECT password FROM Registration WHERE Username = '" + user.ToString() + "';";
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

        public static void RaiseTicket(int id, string Category, string Description, string Priority)
        {
            SqlConnection con = Connect();
            string x = "Pending";
            String query = "INSERT INTO Tickets(id, Category, Description, Status, Priority) VALUES('" + id + "', '" + Category.ToString() + "', '" + Description.ToString() + "', '" +x+ "', '" + Priority.ToString() + "');";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
