namespace Hotel_Reservation_System
{
    partial class FormFrontPage
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
            this.components = new System.ComponentModel.Container();
            this.panelFrontMain = new System.Windows.Forms.Panel();
            this.panelLogIn = new System.Windows.Forms.Panel();
            this.buttonExitApplication = new System.Windows.Forms.Button();
            this.groupBoxEmployee = new System.Windows.Forms.GroupBox();
            this.buttonEmployeeEnter = new System.Windows.Forms.Button();
            this.textBoxEmpPass = new System.Windows.Forms.TextBox();
            this.textBoxEmpName = new System.Windows.Forms.TextBox();
            this.labelEmpPass = new System.Windows.Forms.Label();
            this.labelEmpName = new System.Windows.Forms.Label();
            this.labelLogIn = new System.Windows.Forms.Label();
            this.groupBoxAdmin = new System.Windows.Forms.GroupBox();
            this.buttonAdminEnter = new System.Windows.Forms.Button();
            this.textBoxAdminPass = new System.Windows.Forms.TextBox();
            this.textBoxAdminName = new System.Windows.Forms.TextBox();
            this.labelAdminPass = new System.Windows.Forms.Label();
            this.labelAdminName = new System.Windows.Forms.Label();
            this.panelFrontImage = new System.Windows.Forms.Panel();
            this.labelHeadLine = new System.Windows.Forms.Label();
            this.labelFrontTime = new System.Windows.Forms.Label();
            this.timerFront = new System.Windows.Forms.Timer(this.components);
            this.panelFrontMain.SuspendLayout();
            this.panelLogIn.SuspendLayout();
            this.groupBoxEmployee.SuspendLayout();
            this.groupBoxAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFrontMain
            // 
            this.panelFrontMain.BackColor = System.Drawing.Color.FloralWhite;
            this.panelFrontMain.Controls.Add(this.panelLogIn);
            this.panelFrontMain.Controls.Add(this.panelFrontImage);
            this.panelFrontMain.Controls.Add(this.labelHeadLine);
            this.panelFrontMain.Location = new System.Drawing.Point(-1, 3);
            this.panelFrontMain.Name = "panelFrontMain";
            this.panelFrontMain.Size = new System.Drawing.Size(1352, 705);
            this.panelFrontMain.TabIndex = 0;
            // 
            // panelLogIn
            // 
            this.panelLogIn.BackColor = System.Drawing.Color.FloralWhite;
            this.panelLogIn.Controls.Add(this.labelFrontTime);
            this.panelLogIn.Controls.Add(this.buttonExitApplication);
            this.panelLogIn.Controls.Add(this.groupBoxEmployee);
            this.panelLogIn.Controls.Add(this.labelLogIn);
            this.panelLogIn.Controls.Add(this.groupBoxAdmin);
            this.panelLogIn.Location = new System.Drawing.Point(620, 3);
            this.panelLogIn.Name = "panelLogIn";
            this.panelLogIn.Size = new System.Drawing.Size(717, 699);
            this.panelLogIn.TabIndex = 2;
            // 
            // buttonExitApplication
            // 
            this.buttonExitApplication.BackColor = System.Drawing.Color.Lavender;
            this.buttonExitApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExitApplication.Location = new System.Drawing.Point(556, 628);
            this.buttonExitApplication.Name = "buttonExitApplication";
            this.buttonExitApplication.Size = new System.Drawing.Size(126, 50);
            this.buttonExitApplication.TabIndex = 5;
            this.buttonExitApplication.Text = "Exit Aplication";
            this.buttonExitApplication.UseVisualStyleBackColor = false;
            this.buttonExitApplication.Click += new System.EventHandler(this.buttonExitApplication_Click);
            // 
            // groupBoxEmployee
            // 
            this.groupBoxEmployee.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBoxEmployee.Controls.Add(this.buttonEmployeeEnter);
            this.groupBoxEmployee.Controls.Add(this.textBoxEmpPass);
            this.groupBoxEmployee.Controls.Add(this.textBoxEmpName);
            this.groupBoxEmployee.Controls.Add(this.labelEmpPass);
            this.groupBoxEmployee.Controls.Add(this.labelEmpName);
            this.groupBoxEmployee.Font = new System.Drawing.Font("Siyam Rupali", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEmployee.Location = new System.Drawing.Point(22, 344);
            this.groupBoxEmployee.Name = "groupBoxEmployee";
            this.groupBoxEmployee.Size = new System.Drawing.Size(660, 278);
            this.groupBoxEmployee.TabIndex = 2;
            this.groupBoxEmployee.TabStop = false;
            this.groupBoxEmployee.Text = "Employee Log In: ";
            // 
            // buttonEmployeeEnter
            // 
            this.buttonEmployeeEnter.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonEmployeeEnter.Location = new System.Drawing.Point(213, 183);
            this.buttonEmployeeEnter.Name = "buttonEmployeeEnter";
            this.buttonEmployeeEnter.Size = new System.Drawing.Size(218, 50);
            this.buttonEmployeeEnter.TabIndex = 4;
            this.buttonEmployeeEnter.Text = "Log In";
            this.buttonEmployeeEnter.UseVisualStyleBackColor = false;
            this.buttonEmployeeEnter.Click += new System.EventHandler(this.EmployeeEnter_Click);
            // 
            // textBoxEmpPass
            // 
            this.textBoxEmpPass.Location = new System.Drawing.Point(181, 115);
            this.textBoxEmpPass.Name = "textBoxEmpPass";
            this.textBoxEmpPass.Size = new System.Drawing.Size(271, 29);
            this.textBoxEmpPass.TabIndex = 3;
            // 
            // textBoxEmpName
            // 
            this.textBoxEmpName.Location = new System.Drawing.Point(181, 47);
            this.textBoxEmpName.Name = "textBoxEmpName";
            this.textBoxEmpName.Size = new System.Drawing.Size(271, 29);
            this.textBoxEmpName.TabIndex = 2;
            // 
            // labelEmpPass
            // 
            this.labelEmpPass.AutoSize = true;
            this.labelEmpPass.Location = new System.Drawing.Point(38, 118);
            this.labelEmpPass.Name = "labelEmpPass";
            this.labelEmpPass.Size = new System.Drawing.Size(77, 21);
            this.labelEmpPass.TabIndex = 1;
            this.labelEmpPass.Text = "Password: ";
            // 
            // labelEmpName
            // 
            this.labelEmpName.AutoSize = true;
            this.labelEmpName.Location = new System.Drawing.Point(38, 50);
            this.labelEmpName.Name = "labelEmpName";
            this.labelEmpName.Size = new System.Drawing.Size(54, 21);
            this.labelEmpName.TabIndex = 0;
            this.labelEmpName.Text = "Name: ";
            // 
            // labelLogIn
            // 
            this.labelLogIn.AutoSize = true;
            this.labelLogIn.BackColor = System.Drawing.Color.FloralWhite;
            this.labelLogIn.Font = new System.Drawing.Font("Siyam Rupali", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogIn.Location = new System.Drawing.Point(19, 22);
            this.labelLogIn.Name = "labelLogIn";
            this.labelLogIn.Size = new System.Drawing.Size(75, 31);
            this.labelLogIn.TabIndex = 1;
            this.labelLogIn.Text = "Log In";
            // 
            // groupBoxAdmin
            // 
            this.groupBoxAdmin.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBoxAdmin.Controls.Add(this.buttonAdminEnter);
            this.groupBoxAdmin.Controls.Add(this.textBoxAdminPass);
            this.groupBoxAdmin.Controls.Add(this.textBoxAdminName);
            this.groupBoxAdmin.Controls.Add(this.labelAdminPass);
            this.groupBoxAdmin.Controls.Add(this.labelAdminName);
            this.groupBoxAdmin.Font = new System.Drawing.Font("Siyam Rupali", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAdmin.Location = new System.Drawing.Point(22, 73);
            this.groupBoxAdmin.Name = "groupBoxAdmin";
            this.groupBoxAdmin.Size = new System.Drawing.Size(660, 252);
            this.groupBoxAdmin.TabIndex = 0;
            this.groupBoxAdmin.TabStop = false;
            this.groupBoxAdmin.Text = "Admin Log In: ";
            // 
            // buttonAdminEnter
            // 
            this.buttonAdminEnter.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonAdminEnter.Font = new System.Drawing.Font("Siyam Rupali", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdminEnter.Location = new System.Drawing.Point(213, 161);
            this.buttonAdminEnter.Name = "buttonAdminEnter";
            this.buttonAdminEnter.Size = new System.Drawing.Size(218, 47);
            this.buttonAdminEnter.TabIndex = 4;
            this.buttonAdminEnter.Text = "Log In";
            this.buttonAdminEnter.UseVisualStyleBackColor = false;
            this.buttonAdminEnter.Click += new System.EventHandler(this.buttonAdminEnter_Click);
            // 
            // textBoxAdminPass
            // 
            this.textBoxAdminPass.Location = new System.Drawing.Point(181, 104);
            this.textBoxAdminPass.Name = "textBoxAdminPass";
            this.textBoxAdminPass.Size = new System.Drawing.Size(271, 29);
            this.textBoxAdminPass.TabIndex = 3;
            // 
            // textBoxAdminName
            // 
            this.textBoxAdminName.Location = new System.Drawing.Point(181, 44);
            this.textBoxAdminName.Name = "textBoxAdminName";
            this.textBoxAdminName.Size = new System.Drawing.Size(271, 29);
            this.textBoxAdminName.TabIndex = 2;
            // 
            // labelAdminPass
            // 
            this.labelAdminPass.AutoSize = true;
            this.labelAdminPass.Location = new System.Drawing.Point(38, 107);
            this.labelAdminPass.Name = "labelAdminPass";
            this.labelAdminPass.Size = new System.Drawing.Size(77, 21);
            this.labelAdminPass.TabIndex = 1;
            this.labelAdminPass.Text = "Password: ";
            // 
            // labelAdminName
            // 
            this.labelAdminName.AutoSize = true;
            this.labelAdminName.Location = new System.Drawing.Point(38, 47);
            this.labelAdminName.Name = "labelAdminName";
            this.labelAdminName.Size = new System.Drawing.Size(59, 21);
            this.labelAdminName.TabIndex = 0;
            this.labelAdminName.Text = "Name:  ";
            // 
            // panelFrontImage
            // 
            this.panelFrontImage.BackgroundImage = global::Hotel_Reservation_System.Properties.Resources._1319837830_253769553_1_Pictures_of__Hotel_Management_Software_Program;
            this.panelFrontImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelFrontImage.Location = new System.Drawing.Point(59, 167);
            this.panelFrontImage.Name = "panelFrontImage";
            this.panelFrontImage.Size = new System.Drawing.Size(519, 458);
            this.panelFrontImage.TabIndex = 1;
            // 
            // labelHeadLine
            // 
            this.labelHeadLine.AutoSize = true;
            this.labelHeadLine.Font = new System.Drawing.Font("Perpetua Titling MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeadLine.Location = new System.Drawing.Point(110, 53);
            this.labelHeadLine.Name = "labelHeadLine";
            this.labelHeadLine.Size = new System.Drawing.Size(442, 88);
            this.labelHeadLine.TabIndex = 0;
            this.labelHeadLine.Text = "Hotel Reservation\r\n          System";
            // 
            // labelFrontTime
            // 
            this.labelFrontTime.AutoSize = true;
            this.labelFrontTime.BackColor = System.Drawing.Color.FloralWhite;
            this.labelFrontTime.Font = new System.Drawing.Font("Siyam Rupali", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrontTime.Location = new System.Drawing.Point(378, 22);
            this.labelFrontTime.Name = "labelFrontTime";
            this.labelFrontTime.Size = new System.Drawing.Size(69, 31);
            this.labelFrontTime.TabIndex = 6;
            this.labelFrontTime.Text = "Time:";
            // 
            // timerFront
            // 
            this.timerFront.Tick += new System.EventHandler(this.timerFront_Tick);
            // 
            // FormFrontPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 704);
            this.Controls.Add(this.panelFrontMain);
            this.Name = "FormFrontPage";
            this.Text = "Front Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFrontPage_FormClosing);
            this.panelFrontMain.ResumeLayout(false);
            this.panelFrontMain.PerformLayout();
            this.panelLogIn.ResumeLayout(false);
            this.panelLogIn.PerformLayout();
            this.groupBoxEmployee.ResumeLayout(false);
            this.groupBoxEmployee.PerformLayout();
            this.groupBoxAdmin.ResumeLayout(false);
            this.groupBoxAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFrontMain;
        private System.Windows.Forms.Panel panelFrontImage;
        private System.Windows.Forms.Label labelHeadLine;
        private System.Windows.Forms.Panel panelLogIn;
        private System.Windows.Forms.Label labelLogIn;
        private System.Windows.Forms.GroupBox groupBoxAdmin;
        private System.Windows.Forms.Button buttonAdminEnter;
        private System.Windows.Forms.TextBox textBoxAdminPass;
        private System.Windows.Forms.TextBox textBoxAdminName;
        private System.Windows.Forms.Label labelAdminPass;
        private System.Windows.Forms.Label labelAdminName;
        private System.Windows.Forms.GroupBox groupBoxEmployee;
        private System.Windows.Forms.Button buttonEmployeeEnter;
        private System.Windows.Forms.TextBox textBoxEmpPass;
        private System.Windows.Forms.TextBox textBoxEmpName;
        private System.Windows.Forms.Label labelEmpPass;
        private System.Windows.Forms.Label labelEmpName;
        private System.Windows.Forms.Button buttonExitApplication;
        private System.Windows.Forms.Label labelFrontTime;
        private System.Windows.Forms.Timer timerFront;
    }
}

