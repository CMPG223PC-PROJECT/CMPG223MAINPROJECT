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
    public class Patient : User
    {
        public string age { set; get; }

        public override void insertUser()
        {
            int isAgeValid;
            bool ageIsValid = int.TryParse(age, out isAgeValid);
            if (age == "")
            {
                MessageBox.Show("äge box is empty");
            }
            else if (ageIsValid == false)
            {
                MessageBox.Show("äge box must contain numbers only");

            }
            else if (isvalid() == "")
            {
                con = new MySqlConnection(connection);
                con.Open();
                cmd = new MySqlCommand("INSERT INTO  Patient (firstName, lastName, contactNumber, email, age) VALUES('" + firstName + "', '" + lastName + "', '" + contactNumber + "', '" + email + "', '" + age + "')", con);
                readData = cmd.ExecuteReader();     // Here our query will be executed and data saved into the database.
                MessageBox.Show("Save Data");
                while (readData.Read())
                {
                }

                con.Close();
            }
            else if (isvalid() != "")
            {
                MessageBox.Show(isvalid());
            }
        }

        public string age1;
        public override string viewDetails(string mail)
        {
            
            con = new MySqlConnection(connection);
            con.Open();
            cmd = new MySqlCommand("SELECT * FROM  Patient WHERE email='" + mail + "'", con);
            readData = cmd.ExecuteReader();
            MessageBox.Show("Save Data");
            while (readData.Read())
            {
               
            }

            con.Close();
            return "bb";
        }

        public override void delete()
        {
            con = new MySqlConnection(connection);
            con.Open();
            cmd = new MySqlCommand("DELETE FROM Patient WHERE email='" + email + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("data has been deleted");
            con.Close();
            
            
        }
        public override int update()
        {
            int isAgeValid;
            bool ageIsValid = int.TryParse(age, out isAgeValid);
            if (age == "")
            {
                MessageBox.Show("äge box is empty");
            }
            else if (ageIsValid == false)
            {
                MessageBox.Show("äge box must contain numbers only");

            }
            else if (isvalid() == "")
            {
                con = new MySqlConnection(connection);
                con.Open();
                cmd = new MySqlCommand("UPDATE Patient SET firstName='" + firstName + "',lastName='" + lastName + "',contactNumber='" + contactNumber + "',email='" + email + "', age='" + age + "' WHERE email='"+emailNeededToUpdate+"'", con);
                MessageBox.Show("Data has been updated");
                cmd.ExecuteNonQuery();
                con.Close();
                return 0;
            }
            else if (isvalid() != "")
            {
                MessageBox.Show(isvalid());
            }
            return 1;
            
        }




    }
}
