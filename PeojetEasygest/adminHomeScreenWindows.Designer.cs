
namespace PeojetEasygest
{
    partial class adminHomeScreenWindows
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnfoodmenu = new System.Windows.Forms.Button();
            this.btnTables = new System.Windows.Forms.Button();
            this.btnorders = new System.Windows.Forms.Button();
            this.btnfloors = new System.Windows.Forms.Button();
            this.btncategories = new System.Windows.Forms.Button();
            this.btncustomers = new System.Windows.Forms.Button();
            this.btnusers = new System.Windows.Forms.Button();
            this.btnroles = new System.Windows.Forms.Button();
            this.rigthpanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Size = new System.Drawing.Size(250, 450);
            this.leftpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.leftpanel_Paint);
            // 
            // rigthpanel
            // 
            this.rigthpanel.Controls.Add(this.tableLayoutPanel1);
            this.rigthpanel.Size = new System.Drawing.Size(671, 450);
            this.rigthpanel.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnfoodmenu, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnTables, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnorders, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnfloors, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btncategories, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btncustomers, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnusers, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnroles, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(671, 400);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnfoodmenu
            // 
            this.btnfoodmenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnfoodmenu.FlatAppearance.BorderSize = 3;
            this.btnfoodmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfoodmenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfoodmenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(44)))), ((int)(((byte)(1)))));
            this.btnfoodmenu.Location = new System.Drawing.Point(504, 103);
            this.btnfoodmenu.Name = "btnfoodmenu";
            this.btnfoodmenu.Size = new System.Drawing.Size(164, 94);
            this.btnfoodmenu.TabIndex = 7;
            this.btnfoodmenu.Text = "FOODMENU";
            this.btnfoodmenu.UseVisualStyleBackColor = true;
            this.btnfoodmenu.Click += new System.EventHandler(this.btnfoodmenu_Click);
            // 
            // btnTables
            // 
            this.btnTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTables.FlatAppearance.BorderSize = 3;
            this.btnTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTables.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTables.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(44)))), ((int)(((byte)(1)))));
            this.btnTables.Location = new System.Drawing.Point(337, 103);
            this.btnTables.Name = "btnTables";
            this.btnTables.Size = new System.Drawing.Size(161, 94);
            this.btnTables.TabIndex = 6;
            this.btnTables.Text = "TABLES";
            this.btnTables.UseVisualStyleBackColor = true;
            this.btnTables.Click += new System.EventHandler(this.btnTables_Click);
            // 
            // btnorders
            // 
            this.btnorders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnorders.FlatAppearance.BorderSize = 3;
            this.btnorders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnorders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(44)))), ((int)(((byte)(1)))));
            this.btnorders.Location = new System.Drawing.Point(170, 103);
            this.btnorders.Name = "btnorders";
            this.btnorders.Size = new System.Drawing.Size(161, 94);
            this.btnorders.TabIndex = 5;
            this.btnorders.Text = "ODERS";
            this.btnorders.UseVisualStyleBackColor = true;
            this.btnorders.Click += new System.EventHandler(this.btnorders_Click);
            // 
            // btnfloors
            // 
            this.btnfloors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnfloors.FlatAppearance.BorderSize = 3;
            this.btnfloors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfloors.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfloors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(44)))), ((int)(((byte)(1)))));
            this.btnfloors.Location = new System.Drawing.Point(3, 103);
            this.btnfloors.Name = "btnfloors";
            this.btnfloors.Size = new System.Drawing.Size(161, 94);
            this.btnfloors.TabIndex = 4;
            this.btnfloors.Text = "FLOORS";
            this.btnfloors.UseVisualStyleBackColor = true;
            this.btnfloors.Click += new System.EventHandler(this.btnfloors_Click);
            // 
            // btncategories
            // 
            this.btncategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btncategories.FlatAppearance.BorderSize = 3;
            this.btncategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncategories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncategories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(44)))), ((int)(((byte)(1)))));
            this.btncategories.Location = new System.Drawing.Point(504, 3);
            this.btncategories.Name = "btncategories";
            this.btncategories.Size = new System.Drawing.Size(164, 94);
            this.btncategories.TabIndex = 3;
            this.btncategories.Text = "FOOD CATEGORIES";
            this.btncategories.UseVisualStyleBackColor = true;
            this.btncategories.Click += new System.EventHandler(this.btncategories_Click);
            // 
            // btncustomers
            // 
            this.btncustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btncustomers.FlatAppearance.BorderSize = 3;
            this.btncustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncustomers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(44)))), ((int)(((byte)(1)))));
            this.btncustomers.Location = new System.Drawing.Point(337, 3);
            this.btncustomers.Name = "btncustomers";
            this.btncustomers.Size = new System.Drawing.Size(161, 94);
            this.btncustomers.TabIndex = 2;
            this.btncustomers.Text = "CUSTOMERS";
            this.btncustomers.UseVisualStyleBackColor = true;
            this.btncustomers.Click += new System.EventHandler(this.btncustomers_Click);
            // 
            // btnusers
            // 
            this.btnusers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnusers.FlatAppearance.BorderSize = 3;
            this.btnusers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnusers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnusers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(44)))), ((int)(((byte)(1)))));
            this.btnusers.Location = new System.Drawing.Point(170, 3);
            this.btnusers.Name = "btnusers";
            this.btnusers.Size = new System.Drawing.Size(161, 94);
            this.btnusers.TabIndex = 1;
            this.btnusers.Text = "USERS";
            this.btnusers.UseVisualStyleBackColor = true;
            this.btnusers.Click += new System.EventHandler(this.btnusers_Click);
            // 
            // btnroles
            // 
            this.btnroles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnroles.FlatAppearance.BorderSize = 3;
            this.btnroles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnroles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnroles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(44)))), ((int)(((byte)(1)))));
            this.btnroles.Location = new System.Drawing.Point(3, 3);
            this.btnroles.Name = "btnroles";
            this.btnroles.Size = new System.Drawing.Size(161, 94);
            this.btnroles.TabIndex = 0;
            this.btnroles.Text = "ROLES";
            this.btnroles.UseVisualStyleBackColor = true;
            this.btnroles.Click += new System.EventHandler(this.btnroles_Click);
            // 
            // adminHomeScreenWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 450);
            this.Name = "adminHomeScreenWindows";
            this.Text = "Home Screen";
            this.rigthpanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnfoodmenu;
        private System.Windows.Forms.Button btnTables;
        private System.Windows.Forms.Button btnorders;
        private System.Windows.Forms.Button btnfloors;
        private System.Windows.Forms.Button btncategories;
        private System.Windows.Forms.Button btncustomers;
        private System.Windows.Forms.Button btnusers;
        private System.Windows.Forms.Button btnroles;
    }
}