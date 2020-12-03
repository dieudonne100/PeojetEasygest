
namespace PeojetEasygest
{
    partial class Setting
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
            this.lblServer = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.btnSAVE = new Guna.UI.WinForms.GunaButton();
            this.lblServererror = new System.Windows.Forms.Label();
            this.lblDatabaseerror = new System.Windows.Forms.Label();
            this.lblUsererror = new System.Windows.Forms.Label();
            this.lblPassworderror = new System.Windows.Forms.Label();
            this.leftpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.lblPassworderror);
            this.leftpanel.Controls.Add(this.lblUsererror);
            this.leftpanel.Controls.Add(this.lblDatabaseerror);
            this.leftpanel.Controls.Add(this.lblServererror);
            this.leftpanel.Controls.Add(this.btnSAVE);
            this.leftpanel.Controls.Add(this.checkBox);
            this.leftpanel.Controls.Add(this.lblPassword);
            this.leftpanel.Controls.Add(this.txtPassword);
            this.leftpanel.Controls.Add(this.lblUser);
            this.leftpanel.Controls.Add(this.txtUser);
            this.leftpanel.Controls.Add(this.lblDatabase);
            this.leftpanel.Controls.Add(this.txtDatabase);
            this.leftpanel.Controls.Add(this.lblServer);
            this.leftpanel.Controls.Add(this.txtServer);
            this.leftpanel.Size = new System.Drawing.Size(250, 473);
            this.leftpanel.Controls.SetChildIndex(this.txtServer, 0);
            this.leftpanel.Controls.SetChildIndex(this.lblServer, 0);
            this.leftpanel.Controls.SetChildIndex(this.txtDatabase, 0);
            this.leftpanel.Controls.SetChildIndex(this.lblDatabase, 0);
            this.leftpanel.Controls.SetChildIndex(this.txtUser, 0);
            this.leftpanel.Controls.SetChildIndex(this.lblUser, 0);
            this.leftpanel.Controls.SetChildIndex(this.txtPassword, 0);
            this.leftpanel.Controls.SetChildIndex(this.lblPassword, 0);
            this.leftpanel.Controls.SetChildIndex(this.checkBox, 0);
            this.leftpanel.Controls.SetChildIndex(this.btnSAVE, 0);
            this.leftpanel.Controls.SetChildIndex(this.lblServererror, 0);
            this.leftpanel.Controls.SetChildIndex(this.lblDatabaseerror, 0);
            this.leftpanel.Controls.SetChildIndex(this.lblUsererror, 0);
            this.leftpanel.Controls.SetChildIndex(this.lblPassworderror, 0);
            // 
            // rigthpanel
            // 
            this.rigthpanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rigthpanel.ForeColor = System.Drawing.Color.White;
            this.rigthpanel.Size = new System.Drawing.Size(550, 473);
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServer.ForeColor = System.Drawing.Color.White;
            this.lblServer.Location = new System.Drawing.Point(12, 109);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(61, 25);
            this.lblServer.TabIndex = 2;
            this.lblServer.Text = "Server";
            // 
            // txtServer
            // 
            this.txtServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServer.Location = new System.Drawing.Point(12, 137);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(228, 29);
            this.txtServer.TabIndex = 3;
            this.txtServer.TextChanged += new System.EventHandler(this.txtServer_TextChanged);
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatabase.ForeColor = System.Drawing.Color.White;
            this.lblDatabase.Location = new System.Drawing.Point(12, 165);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(86, 25);
            this.lblDatabase.TabIndex = 4;
            this.lblDatabase.Text = "Database";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatabase.Location = new System.Drawing.Point(12, 193);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(228, 29);
            this.txtDatabase.TabIndex = 5;
            this.txtDatabase.TextChanged += new System.EventHandler(this.txtDatabase_TextChanged);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(12, 222);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(75, 25);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "User ID ";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(12, 250);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(228, 29);
            this.txtUser.TabIndex = 7;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(12, 279);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(87, 25);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(12, 307);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(228, 29);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox.ForeColor = System.Drawing.Color.White;
            this.checkBox.Location = new System.Drawing.Point(12, 356);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(180, 29);
            this.checkBox.TabIndex = 12;
            this.checkBox.Text = "Integrated Security";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // btnSAVE
            // 
            this.btnSAVE.AnimationHoverSpeed = 0.07F;
            this.btnSAVE.AnimationSpeed = 0.03F;
            this.btnSAVE.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(44)))), ((int)(((byte)(1)))));
            this.btnSAVE.BorderColor = System.Drawing.Color.White;
            this.btnSAVE.BorderSize = 2;
            this.btnSAVE.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSAVE.FocusedColor = System.Drawing.Color.Empty;
            this.btnSAVE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSAVE.ForeColor = System.Drawing.Color.White;
            this.btnSAVE.Image = null;
            this.btnSAVE.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSAVE.Location = new System.Drawing.Point(3, 402);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSAVE.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSAVE.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSAVE.OnHoverImage = null;
            this.btnSAVE.OnPressedColor = System.Drawing.Color.Black;
            this.btnSAVE.Size = new System.Drawing.Size(226, 48);
            this.btnSAVE.TabIndex = 13;
            this.btnSAVE.Text = "SAVE";
            this.btnSAVE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSAVE.Click += new System.EventHandler(this.btnSAVE_Click);
            // 
            // lblServererror
            // 
            this.lblServererror.AutoSize = true;
            this.lblServererror.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServererror.ForeColor = System.Drawing.Color.White;
            this.lblServererror.Location = new System.Drawing.Point(225, 115);
            this.lblServererror.Name = "lblServererror";
            this.lblServererror.Size = new System.Drawing.Size(15, 19);
            this.lblServererror.TabIndex = 14;
            this.lblServererror.Text = "*";
            // 
            // lblDatabaseerror
            // 
            this.lblDatabaseerror.AutoSize = true;
            this.lblDatabaseerror.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatabaseerror.ForeColor = System.Drawing.Color.White;
            this.lblDatabaseerror.Location = new System.Drawing.Point(225, 171);
            this.lblDatabaseerror.Name = "lblDatabaseerror";
            this.lblDatabaseerror.Size = new System.Drawing.Size(15, 19);
            this.lblDatabaseerror.TabIndex = 15;
            this.lblDatabaseerror.Text = "*";
            // 
            // lblUsererror
            // 
            this.lblUsererror.AutoSize = true;
            this.lblUsererror.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsererror.ForeColor = System.Drawing.Color.White;
            this.lblUsererror.Location = new System.Drawing.Point(225, 228);
            this.lblUsererror.Name = "lblUsererror";
            this.lblUsererror.Size = new System.Drawing.Size(15, 19);
            this.lblUsererror.TabIndex = 16;
            this.lblUsererror.Text = "*";
            // 
            // lblPassworderror
            // 
            this.lblPassworderror.AutoSize = true;
            this.lblPassworderror.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassworderror.ForeColor = System.Drawing.Color.White;
            this.lblPassworderror.Location = new System.Drawing.Point(225, 285);
            this.lblPassworderror.Name = "lblPassworderror";
            this.lblPassworderror.Size = new System.Drawing.Size(15, 19);
            this.lblPassworderror.TabIndex = 17;
            this.lblPassworderror.Text = "*";
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Name = "Setting";
            this.Text = "Setting";
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.TextBox txtServer;
        private Guna.UI.WinForms.GunaButton btnSAVE;
        private System.Windows.Forms.Label lblPassworderror;
        private System.Windows.Forms.Label lblUsererror;
        private System.Windows.Forms.Label lblDatabaseerror;
        private System.Windows.Forms.Label lblServererror;
    }
}