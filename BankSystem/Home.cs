using System;
using System.Windows.Forms;

namespace BankSystem
{
   public partial class Home : Form
   {
      public Home()
      {
         InitializeComponent();
      }

      private void linklRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
      {
         Register register = new Register(); 
         register.Show();
         Hide();
      }

      private void btnExit_Click(object sender, EventArgs e)
      {
         Close();
      }

      private void btnLogin_Click(object sender, EventArgs e)
      {
         Login login = new Login();
         login.Show();
         Hide();
      }
   }
}
