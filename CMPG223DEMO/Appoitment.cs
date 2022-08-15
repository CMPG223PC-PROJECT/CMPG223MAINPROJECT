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
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace CMPG223DEMO
{
    public partial class Appoitment : Form
    {
        public Appoitment()
        {
            InitializeComponent();
        }

        public Patient patient = new Patient();
        public Physician Physician = new Physician();
        
        public string connection = "server=localhost;user id=root;password=Bhek!!522;database=cmpg223";
        public MySqlConnection con;
        public MySqlCommand cmd;
        public MySqlDataReader readData;
        public DataTable table;
        public MySqlDataAdapter adapter;
        public DataSet ds;

        private void Appoitment_Load(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            dayy.Text = dateTime.AddDays(2).ToString("yyyy-MM-dd");
            timee.Text = dateTime.ToString("12:30:00");

            Physician.con = new MySqlConnection(Physician.connection);
            Physician.con.Open();
            Physician.cmd = new MySqlCommand("SELECT firstName FROM Physician", Physician.con);
            Physician.readData = Physician.cmd.ExecuteReader();
            Physician.table = new DataTable();
            Physician.table.Columns.Add("firstName", typeof(string));
            Physician.table.Load(Physician.readData);// Here our query will be executed and data saved into the database.
            comboBox1.ValueMember = "firstName";
            comboBox1.DataSource = Physician.table;
            Physician.con.Close();


        }

       
        
        private void insert_Click(object sender, EventArgs e)
        {
           
            Physician.physicianID(comboBox1.Text);
            patient.patientID(emailTocheck.Text);
            if (timee.Text == "")
            {
                MessageBox.Show("Please enter valid time");
            }else if (dayy.Text == "")
            {
                MessageBox.Show("Please enter valid date");
            }
            else if (descr.Text == "")
            {
                MessageBox.Show("Please enter valid describtion");
            }
            else if (patient.isValidEmail(emailTocheck.Text) == true)
            {
                MessageBox.Show("");
            }else if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please choose any Physician");
            }
         
            else
            {
                con = new MySqlConnection(connection);
                con.Open();
                cmd = new MySqlCommand("INSERT INTO  Appointment (physicianID, patientID, date, time, descr) VALUES('" + Physician.physicianID(comboBox1.Text) + "', '" + patient.patientID(emailTocheck.Text) + "', '" + dayy.Text + "', '" + timee.Text + "', '"+descr.Text+"')", con);
                //tient.readData =patient.cmd.ExecuteReader();
                
                readData = cmd.ExecuteReader();
                MessageBox.Show("Data has been saved successfully");
                while (readData.Read())
                {
                }

                con.Close();
                MessageBox.Show("Please choose any Physician");
                
            }
        }

        public string checkEmailAppointment()
        {
            string check = "";
            patient.patientID(emailView.Text);
            patient.email = emailView.Text;
            if (patient.email == "" || patient.email == null)
            {
                check = "please enter a valid email address";
            }
            else
            {
                patient.con = new MySqlConnection(patient.connection);
                patient.con.Open();
                patient.table = new DataTable();
                patient.adapter = new MySqlDataAdapter("SELECT date, time, descr FROM Appointment WHERE patientID='" + patient.patientID(emailView.Text) + "'", patient.con);
                patient.adapter.Fill(patient.table);
                dataGridView1.DataSource = patient.table;
                //MessageBox.Show("Save Data");
                patient.con.Close();
            }
            if (patient.email != "")
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    check = "No appointment exist for the given email below";
                }
            }

            return check;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            patient.patientID(emailView.Text);
            if (checkEmailAppointment() != "")
            {
                MessageBox.Show(checkEmailAppointment());
            }
            else
            {
                checkEmailAppointment();
            }
           
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (checkEmailAppointment() != "")
            {
                MessageBox.Show(checkEmailAppointment());
            }
            else
            {
                con = new MySqlConnection(connection);
                con.Open();
                cmd = new MySqlCommand("DELETE FROM Appointment WHERE patientID='" + patient.patientID(emailView.Text) + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("data has been deleted successfully");
                con.Close();
                this.Hide();
                SignUpForm signUpForm = new SignUpForm();
                signUpForm.ShowDialog();
            }
        }

        private void PatientF_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();
        }
    }
}
