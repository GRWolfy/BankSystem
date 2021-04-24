using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace BankSystem
{
   public partial class Register : Form
   {
      public Register()
      {
         InitializeComponent();
      }

      SqlConnection con = new SqlConnection(@"Data Source=WOLF;Initial Catalog=BankSystem;Integrated Security=True");

      private void btnBack_Click(object sender, EventArgs e)
      {
         Home home = new Home();
         home.Show();
         Hide();
      }

      private void btnRegisterOK_Click(object sender, EventArgs e)
      {
         string gender = "";
         if (rbtnGenderMale.Checked) { gender = "Male"; }
         else if (rbtnGenderFemale.Checked) { gender = "Female"; }
         else { gender = "Other"; }

         SqlCommand cmd = new SqlCommand("INSERT INTO RegistrationDb VALUES (@FirstName, @LastName, @Username, @Age, @Password, @Gender, @Address, @MobileNUmber, @Email)", con);
         cmd.CommandType = CommandType.Text;
         cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
         cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
         cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
         cmd.Parameters.AddWithValue("@Age", txtAge.Text);
         cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
         cmd.Parameters.AddWithValue("@Gender", gender);
         cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
         cmd.Parameters.AddWithValue("@MobileNumber", txtMobileNo.Text);
         cmd.Parameters.AddWithValue("@Email", txtEmail.Text);

         con.Open();
         cmd.ExecuteNonQuery();
         con.Close();

         MessageBox.Show("Registratioin success.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

         ResetFormControls();
      }

      private void ResetFormControls()
      {
         txtFirstName.Clear();
         txtLastName.Clear();
         txtUsername.Clear();
         txtAge.Clear();
         txtPassword.Clear();
         txtConfirmPassword.Clear();
         txtAddress.Clear();
         txtEmail.Clear();
      }

      private void txtConfirmPassword_KeyUp(object sender, KeyEventArgs e)
      {
         if(txtPassword.Text.Equals(txtConfirmPassword.Text))
         {
            btnRegisterOK.Enabled = true;
            labelConfirmPassword.Text = "Matched";
         }
         else
         {
            btnRegisterOK.Enabled = false;
            labelConfirmPassword.Text = "Invalid password";
         }
      }

      private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
      {
         char ch = e.KeyChar;

         if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
         {
            e.Handled = true;
            btnRegisterOK.Enabled = false;
         }
         else
         {
            
            btnRegisterOK.Enabled = true;
         }
      }

      private void txtMobileNo_KeyPress(object sender, KeyPressEventArgs e)
      {
         char ch = e.KeyChar;

         if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
         {
            e.Handled = true;
            btnRegisterOK.Enabled = false;
         }
         else
         {

            btnRegisterOK.Enabled = true;
         }
      }

      public bool IsValidEmail(string email)
      {
         try
         {
            var addr = new System.Net.Mail.MailAddress(email);
            return addr.Address == email;
         }
         catch
         {
            return false;
         }
      }

      private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (IsValidEmail(txtEmail.Text))
         {
            btnRegisterOK.Enabled = true;
            labelEmail.Text = "OK";
         }
         else
         {
            btnRegisterOK.Enabled = false;
            labelEmail.Text = "Invalid email";
         }
      }
   }
}