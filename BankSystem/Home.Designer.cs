
namespace BankSystem
{
   partial class Home
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
         this.btnLogin = new System.Windows.Forms.Button();
         this.btnExit = new System.Windows.Forms.Button();
         this.linklRegister = new System.Windows.Forms.LinkLabel();
         this.SuspendLayout();
         // 
         // btnLogin
         // 
         this.btnLogin.Location = new System.Drawing.Point(145, 274);
         this.btnLogin.Name = "btnLogin";
         this.btnLogin.Size = new System.Drawing.Size(176, 96);
         this.btnLogin.TabIndex = 0;
         this.btnLogin.Text = "Login";
         this.btnLogin.UseVisualStyleBackColor = true;
         this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
         // 
         // btnExit
         // 
         this.btnExit.Location = new System.Drawing.Point(494, 274);
         this.btnExit.Name = "btnExit";
         this.btnExit.Size = new System.Drawing.Size(181, 96);
         this.btnExit.TabIndex = 1;
         this.btnExit.Text = "Exit";
         this.btnExit.UseVisualStyleBackColor = true;
         this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
         // 
         // linklRegister
         // 
         this.linklRegister.AutoSize = true;
         this.linklRegister.Location = new System.Drawing.Point(328, 383);
         this.linklRegister.Name = "linklRegister";
         this.linklRegister.Size = new System.Drawing.Size(157, 13);
         this.linklRegister.TabIndex = 2;
         this.linklRegister.TabStop = true;
         this.linklRegister.Text = "Need an account? register here";
         this.linklRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklRegister_LinkClicked);
         // 
         // Home
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.linklRegister);
         this.Controls.Add(this.btnExit);
         this.Controls.Add(this.btnLogin);
         this.Name = "Home";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Form1";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnLogin;
      private System.Windows.Forms.Button btnExit;
      private System.Windows.Forms.LinkLabel linklRegister;
   }
}

