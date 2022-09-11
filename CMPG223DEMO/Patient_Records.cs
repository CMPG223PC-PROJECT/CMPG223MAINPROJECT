using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CMPG223DEMO
{
    public partial class Patient_Records : Form
    {
        public Patient_Records()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        Patient patient = new Patient();
        Physician physician = new Physician();
        Medication medication = new Medication(); 
        public int appointmentID(string email)
        {
            patient.email = emailBox.Text;
            int id = patient.patientID();
            int idOfPatientApp = -1;
            patient.con = new MySqlConnection(patient.connection);
            patient.con.Open();
            patient.cmd = new MySqlCommand("SELECT * FROM Appointment WHERE patientID='" + id + "'", patient.con);
            patient.readData = patient.cmd.ExecuteReader();
            while (patient.readData.Read())
            {
                idOfPatientApp = int.Parse(patient.readData.GetValue(0).ToString()); //loop through the values in the uniform_cart cart and save it

            }

            patient.con.Close();
            return idOfPatientApp;
        }

        public string isValidInput()
        {
            bool isValidID = int.TryParse(medIDBox.Text, out int id);
            string message = "";
            if (emailBox.Text == string.Empty)
            {
                message = "email box is empty";

            }
            else if (medIDBox.Text == string.Empty)
            {
                message = "medicationid box is empty";
            }
            else if (diaBox.Text == string.Empty)
            {
                message = "diagnosis box is empty";
            }
            else if (preBox.Text == string.Empty)
            {
                message = "prescribtion box is empty";
            }
            else if (isValidID == false)
            {
                message = "please enter a valid id";
            }
            return message;
        }

        private void insert_Click(object sender, EventArgs e)
        {
            
            if (isValidInput() != String.Empty)
            {
                MessageBox.Show(isValidInput());
            }
            else if (appointmentID(emailBox.Text) == -1)
            {
                MessageBox.Show("appointment id does not exist");
            }else if (medication.isId(int.Parse(medIDBox.Text)) == false)
            {
                MessageBox.Show("Please enter a valid medication id");
            }
            else
            {
                physician.con = new MySqlConnection(physician.connection);
                physician.con.Open();
                physician.cmd = new MySqlCommand("INSERT INTO  Patient_Record (appointmentID, medicationID, diagnosis, prescribtion) VALUES('" + appointmentID(emailBox.Text) + "', '" + int.Parse(medIDBox.Text) + "', '" + diaBox.Text + "', '" + preBox.Text + "')", physician.con);
                physician.readData = physician.cmd.ExecuteReader();     // Here our query will be executed and data saved into the database.
                MessageBox.Show("details have been saved successfully");
                while (physician.readData.Read())
                {
                }

                physician.con.Close();
            }
           
        }

        public bool isTherePatientRecord(int id)
        {
            physician.con = new MySqlConnection(physician.connection);
            physician.con.Open();
            physician.cmd = new MySqlCommand("SELECT patient_recordID FROM Patient_Record", physician.con);
            physician.readData = physician.cmd.ExecuteReader();     // Here our query will be executed and data saved into the database.
            while (physician.readData.Read())
            {
                if (physician.readData[0].ToString() == id.ToString())
                {
                    return true; //if the email alreay exist then it is not a valid email to be used
                }
            }

            physician.con.Close();
            return false;
        }

        public string validateIsValidIdText()
        {
            string message = "";
            bool isValidID = int.TryParse(idToValidate.Text, out int id);
            if (idToValidate.Text == string.Empty)
            {
                message = "ID box is empty";
            }
            else if (isValidID == false)
            {
                message = "Please enter a valid ID";
            }
            else if (isTherePatientRecord(id) == false)
            {
                message = "there is no record for such id";
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
                physician.adapter = new MySqlDataAdapter("SELECT *FROM Patient_Record", physician.con);
                physician.adapter.Fill(physician.table);
                dataGridView1.DataSource = physician.table;
                physician.con.Close();
            }
            else if (validateIsValidIdText() != String.Empty)
            {
                MessageBox.Show(validateIsValidIdText());
            }
            else
            {
                if (radioButton2.Checked == false)
                {
                    MessageBox.Show("Please choose one option on the radio buttons");
                }
                else
                {
                    physician.con = new MySqlConnection(physician.connection);
                    physician.con.Open();
                    physician.table = new DataTable();
                    physician.adapter = new MySqlDataAdapter("SELECT *FROM Patient_Record WHERE patient_recordID='" + int.Parse(idToValidate.Text) + "'", physician.con);
                    physician.adapter.Fill(physician.table);
                    dataGridView1.DataSource = physician.table;
                    physician.con.Close();
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (validateIsValidIdText() != string.Empty)
            {
                MessageBox.Show(validateIsValidIdText());
            }
            else
            {
                physician.con = new MySqlConnection(physician.connection);
                physician.con.Open();
                physician.cmd = new MySqlCommand("DELETE FROM Patient_Record WHERE patient_recordID='" + int.Parse(idToValidate.Text) + "'", physician.con);
                physician.cmd.ExecuteNonQuery();
                MessageBox.Show("data has been deleted successfully");
                physician.con.Close();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            updatePatientRecord updatePatientRecord = new updatePatientRecord();
            updatePatientRecord.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Patient pat = new Patient();
            
        }
    }
}
