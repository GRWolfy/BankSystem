using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BankSystem
{
   public partial class Login : Form
   {
      public Login()
      {
         InitializeComponent();
      }

      private SqlConnection con = new SqlConnection(@"Data Source=WOLF;Initial Catalog=BankSystem;Integrated Security=True");

      private void linklRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
      {
         Register register = new Register();
         register.Show();
         Hide();
      }

      private void btnBack_Click(object sender, EventArgs e)
      {
         Home home = new Home();
         home.Show();
         Hide();
      }

      private void btnLoginOK_Click(object sender, EventArgs e)
      {
         SqlCommand cmd = new SqlCommand("SELECT count (*) as cnt FROM RegistrationDb WHERE username=@Username and password=@Password", con);
         cmd.Parameters.Clear();
         cmd.Parameters.AddWithValue("@Username", txtLoginUsername.Text);
         cmd.Parameters.AddWithValue("@Password", txtLoginPassword.Text);
         con.Open();

         if (cmd.ExecuteScalar().ToString() == "1")
         {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            Hide();
         }
         else
         {
            MessageBox.Show("Username or password is incorrect", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
         }

         con.Close();
      }
   }
}