﻿using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
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

        public static void Register(string user, string name, string email, string role)
        {
            SqlConnection con = Connect();
            String query = "INSERT INTO Registration(Username, Name, Password, Email, Role) VALUES('" + user.ToString() + "', '" + name.ToString() + "', '12345', '" + email.ToString() + "', '" + role.ToString() + "');";
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
    }
}
