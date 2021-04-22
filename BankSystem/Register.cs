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
         SqlCommand cmd = new SqlCommand("INSERT INTO RegistrationDb VALUES (@FirstName, @LastName, @Username, @Age, @Password, @Gender, @Address, @MobileNUmber, @Email)", con);
         cmd.CommandType = CommandType.Text;
         cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
         cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
         cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
         cmd.Parameters.AddWithValue("@Age", txtAge.Text);
         cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
         cmd.Parameters.AddWithValue("@Gender", rbtnGenderMale.Checked); //return 1
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
         //GENDER
         txtAddress.Clear();
         txtEmail.Clear();
      }
   }
}
