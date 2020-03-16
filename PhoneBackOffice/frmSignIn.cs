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
    public partial class frmSignIn : Form
    {
        private clsSecurity mSec;

        public frmSignIn()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            mSec = new clsSecurity();
        }

        public clsSecurity Sec
        {
            get
            {
                return mSec;
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            //try to sign in and record any errors
            string Error = mSec.SignIn(txtEMail.Text, txtPassword.Text);
            //if there were no errors
            if (Error == "")
            {
                //close this form
                this.Close();
            }
            else
            {
                //otherwise show any errors
                lblError.Text = Error;
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }
    }
}
