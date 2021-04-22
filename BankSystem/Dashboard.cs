using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BankSystem
{
   public partial class Dashboard : Form
   {
      public Dashboard()
      {
         InitializeComponent();
      }

      SqlConnection con = new SqlConnection(@"Data Source=WOLF;Initial Catalog=BankSystem;Integrated Security=True");

      public void getRegisterRecords()
      {
         SqlCommand cmd = new SqlCommand("Select * from RegistrationDb", con);
         DataTable dt = new DataTable();

         con.Open();

         SqlDataReader sdr = cmd.ExecuteReader();
         dt.Load(sdr);
         con.Close();

         RegistrationDataGridView.DataSource = dt;
      }

      private void btnLogout_Click(object sender, System.EventArgs e)
      {
         Home home = new Home();
         home.Show();
         Hide();
      }

      private void Dashboard_Load(object sender, System.EventArgs e)
      {
         getRegisterRecords();
      }
   }
}
