using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CMPG223DEMO
{
    public partial class updateMedication : Form
    {
        public updateMedication()
        {
            InitializeComponent();
        }

        Medication medication = new Medication();
        Physician physician = new Physician();
       
        private void updateMedication_Load(object sender, EventArgs e)
        {
           
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isValid = int.TryParse(idBox.Text, out int id);
            if (idBox.Text == String.Empty)
            {
                MessageBox.Show("input box is empty");
            }
            else if (isValid == false)
            {
                MessageBox.Show("Please entera number");
            }
            else if (medication.isId(id) == false)
            {
                MessageBox.Show("Id does not exist in our database");
            }
            else
            {
                physician.con = new MySqlConnection(physician.connection);
                physician.con.Open();
                physician.cmd = new MySqlCommand("UPDATE Medication SET name='" + nameBox.Text + "', brand='" + brandBox.Text + "',descr='" + descrBox.Text + "' WHERE medicationID='"+id+"'", physician.con);
                MessageBox.Show("Data has been updated successfully");
                physician.cmd.ExecuteNonQuery();
                physician.con.Close();
                this.Close();
            }
        }
    }
}
