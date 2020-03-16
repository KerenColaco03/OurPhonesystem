using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOffice
{
    public partial class frmChangePassword : Form
    {
        //create a copy of the security object with form level scope
        private clsSecurity mSec = new clsSecurity();

        public frmChangePassword()
        {
            InitializeComponent();
        }

        public clsSecurity Sec
        {
            get
            {
                return mSec;
            }
        }

        public void SetMode(clsSecurity Sec, string EMail)
        {
            ///sets the mode of the form
            ///if an email is supplied then it is a user wanting to change their password
            ///if no email is suplied then it is an admin re-setting somebodys password
            ///
            //record the security object in the data member 
            mSec = Sec;
            //if the email is blank
            if (EMail != "")
            {
                //display the email address of the user and make it read only
                txtEMail.Text = EMail;
                txtEMail.Enabled = false;
            }
            else
            {
                //hide the controls for the current user - we don't need them as this admin
                txtPassword.Visible = false;
                lblPassword.Visible = false;
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            //change the password and record the outcome
            string Outcome = mSec.ChangePassword(txtEMail.Text, txtPassword.Text, txtPassword1.Text, txtPassword2.Text);
            //display the outcome
            lblError.Text = Outcome;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            //close the current form
            this.Close();
        }
    }
}
