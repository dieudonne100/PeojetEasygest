
namespace PeojetEasygest
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.lblUsrename = new System.Windows.Forms.Label();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.gunaTextBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.btnLogin = new Guna.UI.WinForms.GunaButton();
            this.leftpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.btnLogin);
            this.leftpanel.Controls.Add(this.lblPassword);
            this.leftpanel.Controls.Add(this.gunaTextBox2);
            this.leftpanel.Controls.Add(this.gunaTextBox1);
            this.leftpanel.Controls.Add(this.lblUsrename);
            this.leftpanel.Size = new System.Drawing.Size(293, 450);
            this.leftpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.leftpanel_Paint);
            this.leftpanel.Controls.SetChildIndex(this.lblUsrename, 0);
            this.leftpanel.Controls.SetChildIndex(this.gunaTextBox1, 0);
            this.leftpanel.Controls.SetChildIndex(this.gunaTextBox2, 0);
            this.leftpanel.Controls.SetChildIndex(this.lblPassword, 0);
            this.leftpanel.Controls.SetChildIndex(this.btnLogin, 0);
            // 
            // rigthpanel
            // 
            this.rigthpanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rigthpanel.BackgroundImage")));
            this.rigthpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rigthpanel.Location = new System.Drawing.Point(293, 0);
            this.rigthpanel.Size = new System.Drawing.Size(507, 450);
            // 
            // lblUsrename
            // 
            this.lblUsrename.AutoSize = true;
            this.lblUsrename.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsrename.ForeColor = System.Drawing.Color.White;
            this.lblUsrename.Location = new System.Drawing.Point(3, 153);
            this.lblUsrename.Name = "lblUsrename";
            this.lblUsrename.Size = new System.Drawing.Size(104, 28);
            this.lblUsrename.TabIndex = 2;
            this.lblUsrename.Text = "User name";
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox1.Location = new System.Drawing.Point(6, 184);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.SelectedText = "";
            this.gunaTextBox1.Size = new System.Drawing.Size(261, 37);
            this.gunaTextBox1.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(3, 239);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(93, 28);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox2.Location = new System.Drawing.Point(6, 270);
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.PasswordChar = '●';
            this.gunaTextBox2.SelectedText = "";
            this.gunaTextBox2.Size = new System.Drawing.Size(261, 37);
            this.gunaTextBox2.TabIndex = 5;
            this.gunaTextBox2.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.AnimationHoverSpeed = 0.07F;
            this.btnLogin.AnimationSpeed = 0.03F;
            this.btnLogin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(44)))), ((int)(((byte)(1)))));
            this.btnLogin.BorderColor = System.Drawing.Color.White;
            this.btnLogin.BorderSize = 2;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogin.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Image = null;
            this.btnLogin.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLogin.Location = new System.Drawing.Point(8, 330);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLogin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogin.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogin.OnHoverImage = null;
            this.btnLogin.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogin.Size = new System.Drawing.Size(255, 48);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "LoginScreen";
            this.Text = "Login";
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnLogin;
        private System.Windows.Forms.Label lblPassword;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox2;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
        private System.Windows.Forms.Label lblUsrename;
    }
}