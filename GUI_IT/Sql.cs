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

        public static string getUser(string user)
        {
            SqlConnection con = Connect();
            String query = "SELECT Username FROM RegisteredUsers WHERE Name = '" + user.ToString() + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            string name = (string)cmd.ExecuteScalar();
            return name;
        }

        public static string getNamee(string user)
        {
            SqlConnection con = Connect();
            String query = "SELECT First_Name FROM Registration WHERE Username = '" + user.ToString() + "';";
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

        public static string getEmaill(string user)
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
            String query = "SELECT password FROM RegisteredUsers WHERE Username = '" + user.ToString() + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            string pass = (string)cmd.ExecuteScalar();
            return pass;
        }

        public static string getPasss(string user)
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

        public static string getTicketSolution(int tID)
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
            string x = "Unsolved";
            int y = 0;
            string z = "NONE";
            String query = "INSERT INTO Tickets(id, Name, Username, Category, Description, Status, Email, Priority, Collaborators, Num_Of_Coll) VALUES('" + id + "',  '" + name.ToString() + "', '" + username.ToString() + "', '" + Category.ToString() + "', '" + Description.ToString() + "', '" +x+ "',  '" + email.ToString() + "', '" + Priority.ToString() + "', '" +z+ "', '" +y+ "');";
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

        public static int countC(int id)
        {
            SqlConnection con = Connect();
            String query = "SELECT Num_Of_Coll FROM Tickets where ID = '" + id + "' ;";
            SqlCommand cmd = new SqlCommand(query, con);
            int pass = (int)cmd.ExecuteScalar();
            return pass;
        }

        public static string getColl(int id)
        {
            SqlConnection con = Connect();
            String query = "SELECT Collaborators FROM Tickets where ID = '" + id + "' ;";
            SqlCommand cmd = new SqlCommand(query, con);
            string pass = (string)cmd.ExecuteScalar();
            return pass;
        }

        public static void Addcoll(string user, int id)
        {
            int x = countC(id) + 1;
            string y = getColl(id) +" " +user.ToString();
            SqlConnection con = Connect();
           if((x-1) == 0)
           {
                String query = "UPDATE Tickets SET AssignedTo = '" + user + "' where ID = '" + id + "';";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                String query1 = "UPDATE Tickets SET Num_Of_Coll = '" + x + "' where ID = '" + id + "';";
                SqlCommand cmd1 = new SqlCommand(query1, con);
                cmd1.ExecuteNonQuery();
           }
           else if((x-1) == 1)
           {
                String query = "UPDATE Tickets SET Collaborators = '" + user + "' where ID = '" + id + "';";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                String query1 = "UPDATE Tickets SET Num_Of_Coll = '" + x + "' where ID = '" + id + "';";
                SqlCommand cmd1 = new SqlCommand(query1, con);
                cmd1.ExecuteNonQuery();
           }
            else
            {
                String query = "UPDATE Tickets SET Collaborators = '" + y + "' where ID = '" + id + "';";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                String query1 = "UPDATE Tickets SET Num_Of_Coll = '" + x + "' where ID = '" + id + "';";
                SqlCommand cmd1 = new SqlCommand(query1, con);
                cmd1.ExecuteNonQuery();
            }
            con.Close();
        }
        
        public static void add2(string user, int id, string email)
        {
            string x = tickuser(id);
            int y = countraise();
            SqlConnection con = Connect();
            String query2 = "INSERT INTO SharedTickets(Id, RaisedBy, SharedWith, Email, Count) VALUES('"+ id + "', '" +x+ "','" + user.ToString() + "', '" + email.ToString() + "', '" +y+ "');";
            SqlCommand cmd2 = new SqlCommand(query2, con);
            cmd2.ExecuteNonQuery();
            con.Close();
        }

        public static int countraise()
        {
            SqlConnection con = Connect();
            String query = "SELECT Count(Id) FROM SharedTickets;";
            SqlCommand cmd = new SqlCommand(query, con);
            int pass = (int)cmd.ExecuteScalar();
            return pass;
        }

        public static string tickuser(int id)
        {
            SqlConnection con = Connect();
            String query = "SELECT Username FROM Tickets where Id = '" + id + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            string pass = (string)cmd.ExecuteScalar();
            return pass;
        }

        public static string tickemail(int id)
        {
            SqlConnection con = Connect();
            String query = "SELECT Email FROM Tickets where Id = '" + id + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            string pass = (string)cmd.ExecuteScalar();
            return pass;
        }

        public static void solve(int id, string user, string raised, string email, string solution)
        {
            string y = "Solved";
            SqlConnection con = Connect();
            String query2 = "INSERT INTO Solved_Tickets(Id, UsernameIT, UsernamePM, Email, Solution) VALUES('" + id + "', '" + user.ToString() + "','" + raised.ToString() + "', '" + email.ToString() + "', '" + solution.ToString() + "');";
            SqlCommand cmd2 = new SqlCommand(query2, con);
            String query = "UPDATE Tickets SET Status = '" + y + "' where ID = '" + id + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            con.Close();
        }

        public static void report(int id, string urg, string email1, string email2, string category, string summary, string solution, string username, string status) 
        {
            int x = countrep();
            SqlConnection con = Connect();
            String query2 = "INSERT INTO Report(Id, TicketID, Urgency, NameA, NameR, Category, Summary, Solution, Username, Status) VALUES('"+x+"', '" + id + "', '" + urg.ToString() + "','" + email1.ToString() + "', '" + email2.ToString() + "', '" + category.ToString() + "', ' " +summary.ToString()+ "', '" +solution.ToString()+ "', '" + username.ToString() + "', '" + status.ToString() + "' );";
            SqlCommand cmd2 = new SqlCommand(query2, con);
            cmd2.ExecuteNonQuery();
            con.Close();
        }

        public static int countrep()
        {
            SqlConnection con = Connect();
            String query = "SELECT Count(Id) FROM Report;";
            SqlCommand cmd = new SqlCommand(query, con);
            int pass = (int)cmd.ExecuteScalar();
            return pass;
        }

        public static DataTable ITname()
        {
            string x = "IT Support Team";
            SqlConnection con = Connect();
            string query = "Select * from RegisteredUsers where Role = '" + x + "'; ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);

            DataRow item = dt.NewRow();
            item[1] = "Select Name";
            dt.Rows.InsertAt(item, 0);

            return dt;
        }

        public static DataTable PMname()
        {
            string x = "Project Member";
            SqlConnection con = Connect();
            string query = "Select * from RegisteredUsers where Role = '" + x + "'; ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);

            DataRow item = dt.NewRow();
            item[1] = "Select Name";
            dt.Rows.InsertAt(item, 0);

            return dt;
        }
    }
}
