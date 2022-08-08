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

        public bool isValidEmail(string email222)
        {
            con = new MySqlConnection(connection);
            con.Open();
            cmd = new MySqlCommand("SELECT email FROM Physician", con);
            readData = cmd.ExecuteReader();     // Here our query will be executed and data saved into the database.
            while (readData.Read())
            {
                if (readData[0].ToString() == email222)
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
            if (descr == "")
            {
                message = "Describtion box is empty";
            }
            else if (isValidEmail(email) == false)
            {
                message = "email already exist in our database, try using a different email";
            }
            return message;
        }


        public override void insertUser()
        {
            if (validateAdditionalInfo() != "")
            {
                MessageBox.Show(validateAdditionalInfo());
            }
            else if (isvalid() == "")
            {
                MySqlConnection con = new MySqlConnection(connection);
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO  Physician (firstName, lastName, contactNumber, email, descr) VALUES('" + firstName + "', '" + lastName + "', '" + contactNumber + "', '" + email + "', '" + descr + "')", con);
                MySqlDataReader MyReader2;
                MyReader2 = cmd.ExecuteReader();     // Here our query will be executed and data saved into the database.
                MessageBox.Show("details have been saved successfully");
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
        public override void delete()
        {
            con = new MySqlConnection(connection);
            con.Open();
            cmd = new MySqlCommand("DELETE FROM Physician WHERE email='" + email + "'", con);
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
                cmd = new MySqlCommand("UPDATE Physician SET firstName='" + firstName + "',lastName='" + lastName + "',contactNumber='" + contactNumber + "',email='" + email + "', descr='" + descr + "' WHERE email='" + emailNeededToUpdate + "'", con);
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
