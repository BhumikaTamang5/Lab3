using System;
using System.Xml.Linq;

namespace Bhumika_Unit4
{
    public partial class Bhumika_register : System.Web.UI.Page
    {
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string name = txtName.Text;
                string email = txtEmail.Text;
                string password = txtPassword.Text;
                string phone = txtPhone.Text;
                lblMessage.Text = "Registration successful!";
                lblMessage.ForeColor = System.Drawing.Color.Green;
                txtName.Text = "";
                txtEmail.Text = "";
                txtPassword.Text = "";
                txtPhone.Text = "";
            }
        }
    }
}
