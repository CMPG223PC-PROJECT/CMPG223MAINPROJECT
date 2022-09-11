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
    public class User
    {
        public string firstName { set; get; }
        public string lastName { set; get; }
        public string contactNumber { set; get; }
        public string email { set; get; }

        static Regex ValidEmailRegex = CreateValidEmailRegex();
        public string connection = "server=localhost;user id=root;password=Bhek!!522;database=cmpg223";
        public MySqlConnection con;
        public MySqlCommand cmd;
        public MySqlDataReader readData;
        public DataTable table;
        public MySqlDataAdapter adapter;
        public DataSet ds;
        public string emailNeededToUpdate;
        public static Regex CreateValidEmailRegex()
        {
            string validEmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(validEmailPattern, RegexOptions.IgnoreCase);
        }

       
        public string isvalid()
        {
            string massage = "";
            int contact;
            bool successcontact = int.TryParse(contactNumber, out contact);
            bool isValid = ValidEmailRegex.IsMatch(email);
            if (firstName == "" || firstName == null)
            {
                massage = "incorrect first name";
               
            }
            else if (lastName == "")
            {
                massage = "incorrect lastname";
              
            }
            else if (contactNumber == "")
            {
                massage = "incorrect contact number";
            }
            else if (email == "")
            {
                massage = "email empty";
                
            }
            else if (successcontact == false)
            {
                massage = "please enter a valid number";

            }

            else if (isValid == false)
            {
                massage = "email address must be valid email address format.\n" +
                       "For example 'someone@example.com' ";
               
            }

            return massage;
        }
        public virtual void insertUser()
        {
           if (isvalid() == "")
            {
                con = new MySqlConnection(connection);
                con.Open();
                cmd = new MySqlCommand("INSERT INTO  User (firstName, lastName, contactNumber, email) VALUES('" + firstName + "', '" + lastName + "', '" + contactNumber + "', '" + email + "')", con);
                readData = cmd.ExecuteReader();     // Here our query will be executed and data saved into the database.
                MessageBox.Show("Save Data");
                while (readData.Read())
                {

                }

                con.Close();
            }
            else if(isvalid() != "")
            {
                MessageBox.Show(isvalid());
            }
        }

        public virtual string viewDetails(string mail)
        {
            con = new MySqlConnection(connection);
            con.Open();
            cmd = new MySqlCommand("SELECT *FROM  User WHERE email='"+ mail +"'", con);
            readData = cmd.ExecuteReader();     
            MessageBox.Show("Save Data");
            if (readData.HasRows)
            {
                while (readData.Read())
                {
                    
                }
            }
            else
            {
                MessageBox.Show("no such data exist for the given email");
            }
            con.Close();
            return "bb";
        }
        public virtual void delete()
        {
            con = new MySqlConnection(connection);
            con.Open();
            cmd = new MySqlCommand("DELETE patientID FROM Patient WHERE email='" + email + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public virtual int update()
        {
            if (isvalid() == "")
            {
                con = new MySqlConnection(connection);
                con.Open();
                cmd = new MySqlCommand("UPDATE Patient SET firstName='" + firstName + "',lastName='" + lastName + "',contactNumber='" + contactNumber + "',email='" + email + "' WHERE email='" + emailNeededToUpdate + "'", con);
                MessageBox.Show("");
                cmd.ExecuteNonQuery();
                con.Close();
                return 0; //true done
            }
            else if (isvalid() != "")
            {
                MessageBox.Show(isvalid());
            }

            return 1;
        }


    }

}
