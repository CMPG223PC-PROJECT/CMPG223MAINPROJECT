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
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System.Net.Mail;


namespace CMPG223DEMO
{
    public class Physician : User
    {
        public string descr { set; get; }

        public override void insertUser()
        {
            if (descr == "")
            {
                MessageBox.Show("Describtion box is invalid");
            }
            else if (isvalid() == "")
            {
                MySqlConnection con = new MySqlConnection(connection);
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO  Physician (firstName, lastName, contactNumber, email, descr) VALUES('" + firstName + "', '" + lastName + "', '" + contactNumber + "', '" + email + "', '" + descr + "')", con);
                MySqlDataReader MyReader2;
                MyReader2 = cmd.ExecuteReader();     // Here our query will be executed and data saved into the database.
                MessageBox.Show("Save Data");
                while (MyReader2.Read())
                {
                }

                con.Close();
            }
            else if (isvalid() != "")
            {
                MessageBox.Show(isvalid());
            }
        }

    }
}
