
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
         this.button1 = new System.Windows.Forms.Button();
         this.button2 = new System.Windows.Forms.Button();
         this.button3 = new System.Windows.Forms.Button();
         this.button4 = new System.Windows.Forms.Button();
         this.button5 = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.RegistrationDataGridView)).BeginInit();
         this.SuspendLayout();
         // 
         // RegistrationDataGridView
         // 
         this.RegistrationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.RegistrationDataGridView.Location = new System.Drawing.Point(114, 207);
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
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(27, 13);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(86, 49);
         this.button1.TabIndex = 2;
         this.button1.Text = "Balance Inquiry";
         this.button1.UseVisualStyleBackColor = true;
         // 
         // button2
         // 
         this.button2.Location = new System.Drawing.Point(144, 13);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(86, 49);
         this.button2.TabIndex = 3;
         this.button2.Text = "Withdraw";
         this.button2.UseVisualStyleBackColor = true;
         // 
         // button3
         // 
         this.button3.Location = new System.Drawing.Point(265, 13);
         this.button3.Name = "button3";
         this.button3.Size = new System.Drawing.Size(86, 49);
         this.button3.TabIndex = 4;
         this.button3.Text = "Deposit";
         this.button3.UseVisualStyleBackColor = true;
         // 
         // button4
         // 
         this.button4.Location = new System.Drawing.Point(379, 13);
         this.button4.Name = "button4";
         this.button4.Size = new System.Drawing.Size(86, 49);
         this.button4.TabIndex = 5;
         this.button4.Text = "Loan";
         this.button4.UseVisualStyleBackColor = true;
         // 
         // button5
         // 
         this.button5.Location = new System.Drawing.Point(496, 13);
         this.button5.Name = "button5";
         this.button5.Size = new System.Drawing.Size(86, 49);
         this.button5.TabIndex = 6;
         this.button5.Text = "Money Transfer";
         this.button5.UseVisualStyleBackColor = true;
         // 
         // Dashboard
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.button5);
         this.Controls.Add(this.button4);
         this.Controls.Add(this.button3);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.btnLogout);
         this.Controls.Add(this.RegistrationDataGridView);
         this.Name = "Dashboard";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Dashboard";
         this.Load += new System.EventHandler(this.Dashboard_Load);
         ((System.ComponentModel.ISupportInitialize)(this.RegistrationDataGridView)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.DataGridView RegistrationDataGridView;
      private System.Windows.Forms.Button btnLogout;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.Button button3;
      private System.Windows.Forms.Button button4;
      private System.Windows.Forms.Button button5;
   }
}