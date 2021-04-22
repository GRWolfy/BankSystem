
namespace BankSystem
{
   partial class Login
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
         this.txtLoginUsername = new System.Windows.Forms.TextBox();
         this.txtLoginPassword = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.linklRegister = new System.Windows.Forms.LinkLabel();
         this.btnBack = new System.Windows.Forms.Button();
         this.btnLoginOK = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // txtLoginUsername
         // 
         this.txtLoginUsername.Location = new System.Drawing.Point(342, 226);
         this.txtLoginUsername.Name = "txtLoginUsername";
         this.txtLoginUsername.Size = new System.Drawing.Size(209, 20);
         this.txtLoginUsername.TabIndex = 0;
         // 
         // txtLoginPassword
         // 
         this.txtLoginPassword.Location = new System.Drawing.Point(342, 300);
         this.txtLoginPassword.Name = "txtLoginPassword";
         this.txtLoginPassword.Size = new System.Drawing.Size(209, 20);
         this.txtLoginPassword.TabIndex = 1;
         this.txtLoginPassword.UseSystemPasswordChar = true;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(223, 226);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(100, 24);
         this.label1.TabIndex = 2;
         this.label1.Text = "username:";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(223, 296);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(87, 24);
         this.label2.TabIndex = 3;
         this.label2.Text = "pasword:";
         // 
         // linklRegister
         // 
         this.linklRegister.AutoSize = true;
         this.linklRegister.Location = new System.Drawing.Point(305, 348);
         this.linklRegister.Name = "linklRegister";
         this.linklRegister.Size = new System.Drawing.Size(157, 13);
         this.linklRegister.TabIndex = 4;
         this.linklRegister.TabStop = true;
         this.linklRegister.Text = "Need an account? register here";
         this.linklRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklRegister_LinkClicked);
         // 
         // btnBack
         // 
         this.btnBack.Location = new System.Drawing.Point(12, 12);
         this.btnBack.Name = "btnBack";
         this.btnBack.Size = new System.Drawing.Size(75, 23);
         this.btnBack.TabIndex = 5;
         this.btnBack.Text = "Back";
         this.btnBack.UseVisualStyleBackColor = true;
         this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
         // 
         // btnLoginOK
         // 
         this.btnLoginOK.Location = new System.Drawing.Point(602, 226);
         this.btnLoginOK.Name = "btnLoginOK";
         this.btnLoginOK.Size = new System.Drawing.Size(149, 94);
         this.btnLoginOK.TabIndex = 6;
         this.btnLoginOK.Text = "Login";
         this.btnLoginOK.UseVisualStyleBackColor = true;
         this.btnLoginOK.Click += new System.EventHandler(this.btnLoginOK_Click);
         // 
         // Login
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.btnLoginOK);
         this.Controls.Add(this.btnBack);
         this.Controls.Add(this.linklRegister);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.txtLoginPassword);
         this.Controls.Add(this.txtLoginUsername);
         this.Name = "Login";
         this.Text = "Login";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox txtLoginUsername;
      private System.Windows.Forms.TextBox txtLoginPassword;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.LinkLabel linklRegister;
      private System.Windows.Forms.Button btnBack;
      private System.Windows.Forms.Button btnLoginOK;
   }
}