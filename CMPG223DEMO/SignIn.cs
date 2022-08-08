using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPG223DEMO
{
    public partial class updateSignIn : Form
    {
        public updateSignIn()
        {
            InitializeComponent();
        }

        public Patient patient = new Patient();
        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            patient.emailNeededToUpdate = emailNeededToUpdate.Text;
            patient.firstName = firstNameButton.Text;
            patient.lastName = lastNameButton.Text;
            patient.contactNumber = contactNumberButton.Text;
            patient.email = emailButtom.Text;
            patient.age = ageButton.Text;
            if(patient.update() ==0)
            {
                this.Close();
                
            }
           
        }
    }
}
