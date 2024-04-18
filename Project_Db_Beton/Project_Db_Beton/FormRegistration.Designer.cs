namespace Project_Db_Beton
{
    partial class FormRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistration));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxFManager = new System.Windows.Forms.TextBox();
            this.textBoxIManager = new System.Windows.Forms.TextBox();
            this.textBoxOManager = new System.Windows.Forms.TextBox();
            this.textBoxLManager = new System.Windows.Forms.TextBox();
            this.textBoxPManager = new System.Windows.Forms.TextBox();
            this.buttonReg = new System.Windows.Forms.Button();
            this.buttonRegCancel = new System.Windows.Forms.Button();
            this.labelRegF = new System.Windows.Forms.Label();
            this.labelRegI = new System.Windows.Forms.Label();
            this.labelRegO = new System.Windows.Forms.Label();
            this.labelRegLogin = new System.Windows.Forms.Label();
            this.labelRegPassword = new System.Windows.Forms.Label();
            this.textBoxIdManager = new System.Windows.Forms.TextBox();
            this.labelIdReg = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.labelIdReg);
            this.panel1.Controls.Add(this.textBoxIdManager);
            this.panel1.Controls.Add(this.labelRegPassword);
            this.panel1.Controls.Add(this.labelRegLogin);
            this.panel1.Controls.Add(this.labelRegO);
            this.panel1.Controls.Add(this.labelRegI);
            this.panel1.Controls.Add(this.labelRegF);
            this.panel1.Controls.Add(this.buttonRegCancel);
            this.panel1.Controls.Add(this.buttonReg);
            this.panel1.Controls.Add(this.textBoxPManager);
            this.panel1.Controls.Add(this.textBoxLManager);
            this.panel1.Controls.Add(this.textBoxOManager);
            this.panel1.Controls.Add(this.textBoxIManager);
            this.panel1.Controls.Add(this.textBoxFManager);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 261);
            this.panel1.TabIndex = 0;
            // 
            // textBoxFManager
            // 
            this.textBoxFManager.Location = new System.Drawing.Point(89, 32);
            this.textBoxFManager.Name = "textBoxFManager";
            this.textBoxFManager.Size = new System.Drawing.Size(100, 20);
            this.textBoxFManager.TabIndex = 0;
            // 
            // textBoxIManager
            // 
            this.textBoxIManager.Location = new System.Drawing.Point(89, 58);
            this.textBoxIManager.Name = "textBoxIManager";
            this.textBoxIManager.Size = new System.Drawing.Size(100, 20);
            this.textBoxIManager.TabIndex = 1;
            // 
            // textBoxOManager
            // 
            this.textBoxOManager.Location = new System.Drawing.Point(89, 84);
            this.textBoxOManager.Name = "textBoxOManager";
            this.textBoxOManager.Size = new System.Drawing.Size(100, 20);
            this.textBoxOManager.TabIndex = 2;
            // 
            // textBoxLManager
            // 
            this.textBoxLManager.Location = new System.Drawing.Point(89, 110);
            this.textBoxLManager.Name = "textBoxLManager";
            this.textBoxLManager.Size = new System.Drawing.Size(100, 20);
            this.textBoxLManager.TabIndex = 3;
            // 
            // textBoxPManager
            // 
            this.textBoxPManager.Location = new System.Drawing.Point(89, 136);
            this.textBoxPManager.Name = "textBoxPManager";
            this.textBoxPManager.Size = new System.Drawing.Size(100, 20);
            this.textBoxPManager.TabIndex = 4;
            // 
            // buttonReg
            // 
            this.buttonReg.Location = new System.Drawing.Point(77, 162);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(127, 35);
            this.buttonReg.TabIndex = 5;
            this.buttonReg.Text = "Зарегистрироваться";
            this.buttonReg.UseVisualStyleBackColor = true;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // buttonRegCancel
            // 
            this.buttonRegCancel.Location = new System.Drawing.Point(77, 203);
            this.buttonRegCancel.Name = "buttonRegCancel";
            this.buttonRegCancel.Size = new System.Drawing.Size(127, 33);
            this.buttonRegCancel.TabIndex = 6;
            this.buttonRegCancel.Text = "Отмена";
            this.buttonRegCancel.UseVisualStyleBackColor = true;
            this.buttonRegCancel.Click += new System.EventHandler(this.buttonRegCancel_Click);
            // 
            // labelRegF
            // 
            this.labelRegF.AutoSize = true;
            this.labelRegF.Location = new System.Drawing.Point(5, 35);
            this.labelRegF.Name = "labelRegF";
            this.labelRegF.Size = new System.Drawing.Size(56, 13);
            this.labelRegF.TabIndex = 7;
            this.labelRegF.Text = "Фамилия";
            // 
            // labelRegI
            // 
            this.labelRegI.AutoSize = true;
            this.labelRegI.Location = new System.Drawing.Point(5, 63);
            this.labelRegI.Name = "labelRegI";
            this.labelRegI.Size = new System.Drawing.Size(29, 13);
            this.labelRegI.TabIndex = 8;
            this.labelRegI.Text = "Имя";
            // 
            // labelRegO
            // 
            this.labelRegO.AutoSize = true;
            this.labelRegO.Location = new System.Drawing.Point(5, 89);
            this.labelRegO.Name = "labelRegO";
            this.labelRegO.Size = new System.Drawing.Size(54, 13);
            this.labelRegO.TabIndex = 9;
            this.labelRegO.Text = "Отчество";
            // 
            // labelRegLogin
            // 
            this.labelRegLogin.AutoSize = true;
            this.labelRegLogin.Location = new System.Drawing.Point(5, 116);
            this.labelRegLogin.Name = "labelRegLogin";
            this.labelRegLogin.Size = new System.Drawing.Size(38, 13);
            this.labelRegLogin.TabIndex = 10;
            this.labelRegLogin.Text = "Логин";
            // 
            // labelRegPassword
            // 
            this.labelRegPassword.AutoSize = true;
            this.labelRegPassword.Location = new System.Drawing.Point(5, 141);
            this.labelRegPassword.Name = "labelRegPassword";
            this.labelRegPassword.Size = new System.Drawing.Size(45, 13);
            this.labelRegPassword.TabIndex = 11;
            this.labelRegPassword.Text = "Пароль";
            // 
            // textBoxIdManager
            // 
            this.textBoxIdManager.Location = new System.Drawing.Point(89, 6);
            this.textBoxIdManager.Name = "textBoxIdManager";
            this.textBoxIdManager.Size = new System.Drawing.Size(20, 20);
            this.textBoxIdManager.TabIndex = 12;
            // 
            // labelIdReg
            // 
            this.labelIdReg.AutoSize = true;
            this.labelIdReg.Location = new System.Drawing.Point(5, 9);
            this.labelIdReg.Name = "labelIdReg";
            this.labelIdReg.Size = new System.Drawing.Size(81, 13);
            this.labelIdReg.TabIndex = 13;
            this.labelIdReg.Text = "Идентфикатор";
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelIdReg;
        private System.Windows.Forms.TextBox textBoxIdManager;
        private System.Windows.Forms.Label labelRegPassword;
        private System.Windows.Forms.Label labelRegLogin;
        private System.Windows.Forms.Label labelRegO;
        private System.Windows.Forms.Label labelRegI;
        private System.Windows.Forms.Label labelRegF;
        private System.Windows.Forms.Button buttonRegCancel;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.TextBox textBoxPManager;
        private System.Windows.Forms.TextBox textBoxLManager;
        private System.Windows.Forms.TextBox textBoxOManager;
        private System.Windows.Forms.TextBox textBoxIManager;
        private System.Windows.Forms.TextBox textBoxFManager;
    }
}