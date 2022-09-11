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
using MySql.Data.MySqlClient;

namespace CMPG223DEMO
{
    public partial class Medication : Form
    {
        public Medication()
        {
            InitializeComponent();
        }

        Physician physician = new Physician();
        Patient patient = new Patient();
        private void button1_Click(object sender, EventArgs e)
        {
            if (nameBox.Text == String.Empty || brandBox.Text == string.Empty || descrBox.Text == string.Empty)
            {
                MessageBox.Show("Please enter all fields");
            }
            else
            {
                physician.con = new MySqlConnection(physician.connection);
                physician.con.Open();
                physician.cmd = new MySqlCommand("INSERT INTO  Medication (name, brand, descr) VALUES('" + nameBox.Text + "', '" + brandBox.Text + "', '" + descrBox.Text + "')", physician.con);
                physician.readData = physician.cmd.ExecuteReader();     
                while (physician.readData.Read())
                {
                }

                physician.con.Close();
            }
           
        }

        public bool isId(int id) //this method checks if there exist  medicationID in the medicine table
        {
            physician.con = new MySqlConnection(physician.connection);
            physician.con.Open();
            physician.cmd = new MySqlCommand("SELECT medicationID FROM Medication", physician.con);
            physician.readData = physician.cmd.ExecuteReader();
            while (physician.readData.Read())
            {
                if (physician.readData[0].ToString() == id.ToString())
                {
                    return true; //if the id already exist then it is a valid medication id to be used
                }
            }

            physician.con.Close();
            return false; //default bool value
        }
       
        public bool isTherePatientRecord(int id) // this method is used to maintain the referencial integrity of the medication and patient record tables
        {
            physician.con = new MySqlConnection(physician.connection);
            physician.con.Open();
            physician.cmd = new MySqlCommand("SELECT medicationID FROM Patient_Record", physician.con);
            physician.readData = physician.cmd.ExecuteReader();     // Here our query will be executed and data saved into the database.
            while (physician.readData.Read())
            {
                if (physician.readData[0].ToString() == id.ToString())
                {
                    return true; //if the email alreay exist then it is not a valid email to be used
                }
            }

            physician.con.Close();
            return false; //sdefault bool value
        }
        public string validate()
        {
            string message = "";
            int output;
            bool isvalid = int.TryParse(idToValidate.Text, out output);
            if (idToValidate.Text == String.Empty)
            {
                message= "Please enter a correct value";
            }
            else if (isvalid == false)
            {
                message="Please enter a correct value";
            }else if (isId(output) == false)
            {
                message = "id does not exist in ourdatabase";
            }
            return message;
        }

        private void select_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                physician.con = new MySqlConnection(physician.connection);
                physician.con.Open();
                physician.table = new DataTable();
                physician.adapter = new MySqlDataAdapter("SELECT *FROM Medication", physician.con);
                physician.adapter.Fill(physician.table);
                dataGridView1.DataSource = physician.table;
                physician.con.Close();
            }
            else if (validate() != string.Empty)
            {
                MessageBox.Show(validate());
            }
            else
            {
                if (radioButton2.Checked == false)
                {
                    MessageBox.Show("Please choose oneof the 2 radio boxes");
                }
                else
                {
                    physician.con = new MySqlConnection(physician.connection);
                    physician.con.Open();
                    physician.table = new DataTable();
                    physician.adapter = new MySqlDataAdapter("SELECT *FROM Medication WHERE medicationID='" + idToValidate.Text + "'", physician.con);
                    physician.adapter.Fill(physician.table);
                    dataGridView1.DataSource = physician.table;
                    physician.con.Close();
                }
               
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (validate() != string.Empty)
            {
                MessageBox.Show(validate());
            }
            else if (isTherePatientRecord(int.Parse(idToValidate.Text)) == true)
            {
                MessageBox.Show("There is data in the patient_record that is associated with this id number, please delete that field first before proceeding");
            }
            else
            {
                physician.con = new MySqlConnection(physician.connection);
                physician.con.Open();
                physician.cmd = new MySqlCommand("DELETE FROM Medication WHERE medicationID='" + idToValidate.Text + "'", physician.con);
                physician.cmd.ExecuteNonQuery();
                MessageBox.Show("data has been deleted successfully");
                physician.con.Close();
            }
            
        }

        private void update_Click(object sender, EventArgs e)
        {
            //this.Hide();
            updateMedication update = new updateMedication();
            update.ShowDialog();
        }
        
    }
}
