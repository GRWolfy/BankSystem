
namespace BankSystem
{
   partial class Dashboard
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.RegistrationDataGridView = new System.Windows.Forms.DataGridView();
         this.btnLogout = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.RegistrationDataGridView)).BeginInit();
         this.SuspendLayout();
         // 
         // RegistrationDataGridView
         // 
         this.RegistrationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.RegistrationDataGridView.Location = new System.Drawing.Point(100, 164);
         this.RegistrationDataGridView.Name = "RegistrationDataGridView";
         this.RegistrationDataGridView.Size = new System.Drawing.Size(586, 197);
         this.RegistrationDataGridView.TabIndex = 0;
         // 
         // btnLogout
         // 
         this.btnLogout.Location = new System.Drawing.Point(697, 13);
         this.btnLogout.Name = "btnLogout";
         this.btnLogout.Size = new System.Drawing.Size(75, 23);
         this.btnLogout.TabIndex = 1;
         this.btnLogout.Text = "Logout";
         this.btnLogout.UseVisualStyleBackColor = true;
         this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
         // 
         // Dashboard
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.btnLogout);
         this.Controls.Add(this.RegistrationDataGridView);
         this.Name = "Dashboard";
         this.Text = "Form1";
         ((System.ComponentModel.ISupportInitialize)(this.RegistrationDataGridView)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.DataGridView RegistrationDataGridView;
      private System.Windows.Forms.Button btnLogout;
   }
}