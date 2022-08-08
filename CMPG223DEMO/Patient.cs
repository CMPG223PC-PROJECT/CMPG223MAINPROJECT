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

        public bool isValidEmail(string email22)
        {
            con = new MySqlConnection(connection);
            con.Open();
            cmd = new MySqlCommand("SELECT email FROM Patient", con);
            readData = cmd.ExecuteReader();     // Here our query will be executed and data saved into the database.
            while (readData.Read())
            {
                if (readData[0].ToString() == email22)
                {
                    return false; //if the email alreay exist then it is not a valid email to be used
                }
            }

            con.Close();
            return true; //default bool value
        }

        public string validateAdditionalInfo()
        {
            string message = "";
            int isAgeValid;
            bool ageIsValid = int.TryParse(age, out isAgeValid);
            if (age == "")
            {
                message = " the Age box is empty";
            }
            else if (ageIsValid == false)
            {
                message = "Age box must contain numbers only";

            }
            else if (isValidEmail(email) == false)
            {
                message = "email already exist in our database, try using a different email";
            }
            return message;
        }

        public override void insertUser()
        {
            if(validateAdditionalInfo() != "")
            {
                MessageBox.Show(validateAdditionalInfo());
            }
            else if (isvalid() == "")
            {
                con = new MySqlConnection(connection);
                con.Open();
                cmd = new MySqlCommand("INSERT INTO  Patient (firstName, lastName, contactNumber, email, age) VALUES('" + firstName + "', '" + lastName + "', '" + contactNumber + "', '" + email + "', '" + age + "')", con);
                readData = cmd.ExecuteReader();     // Here our query will be executed and data saved into the database.
                MessageBox.Show("Data has been saved successfully");
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

        public override void delete()
        {
            con = new MySqlConnection(connection);
            con.Open();
            cmd = new MySqlCommand("DELETE FROM Patient WHERE email='" + email + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("data has been deleted successfully");
            con.Close();
            
            
        }
        public override int update()
        {
            if (validateAdditionalInfo() != "")
            {
                MessageBox.Show(validateAdditionalInfo());
            }
            else if (isvalid() == "")
            {
                con = new MySqlConnection(connection);
                con.Open();
                cmd = new MySqlCommand("UPDATE Patient SET firstName='" + firstName + "',lastName='" + lastName + "',contactNumber='" + contactNumber + "',email='" + email + "', age='" + age + "' WHERE email='"+emailNeededToUpdate+"'", con);
                MessageBox.Show("Data has been updated successfully");
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
