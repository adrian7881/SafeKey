namespace PasswordAddAccount
{
    partial class form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form3));
            this.lblTitle = new System.Windows.Forms.Label();
            this.BtnPasteAccountName = new System.Windows.Forms.Button();
            this.btnClearAccountName = new System.Windows.Forms.Button();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnClearEmail = new System.Windows.Forms.Button();
            this.btnPasteEmail = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnClearUsername = new System.Windows.Forms.Button();
            this.btnPasteUsername = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnPastePassword = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(226, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(243, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add a new account";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // BtnPasteAccountName
            // 
            this.BtnPasteAccountName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.BtnPasteAccountName.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.BtnPasteAccountName.FlatAppearance.BorderSize = 0;
            this.BtnPasteAccountName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPasteAccountName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPasteAccountName.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnPasteAccountName.Location = new System.Drawing.Point(460, 91);
            this.BtnPasteAccountName.Name = "BtnPasteAccountName";
            this.BtnPasteAccountName.Size = new System.Drawing.Size(87, 36);
            this.BtnPasteAccountName.TabIndex = 2;
            this.BtnPasteAccountName.TabStop = false;
            this.BtnPasteAccountName.Text = "Paste";
            this.BtnPasteAccountName.UseVisualStyleBackColor = false;
            this.BtnPasteAccountName.Click += new System.EventHandler(this.BtnPasteAccountName_Click);
            // 
            // btnClearAccountName
            // 
            this.btnClearAccountName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnClearAccountName.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnClearAccountName.FlatAppearance.BorderSize = 0;
            this.btnClearAccountName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAccountName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAccountName.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClearAccountName.Location = new System.Drawing.Point(552, 91);
            this.btnClearAccountName.Name = "btnClearAccountName";
            this.btnClearAccountName.Size = new System.Drawing.Size(87, 36);
            this.btnClearAccountName.TabIndex = 4;
            this.btnClearAccountName.TabStop = false;
            this.btnClearAccountName.Text = "Clear";
            this.btnClearAccountName.UseVisualStyleBackColor = false;
            this.btnClearAccountName.Click += new System.EventHandler(this.btnClearAccountName_Click);
            // 
            // txtAccountName
            // 
            this.txtAccountName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAccountName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtAccountName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.txtAccountName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAccountName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountName.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtAccountName.Location = new System.Drawing.Point(190, 91);
            this.txtAccountName.MaximumSize = new System.Drawing.Size(263, 36);
            this.txtAccountName.MinimumSize = new System.Drawing.Size(263, 36);
            this.txtAccountName.Multiline = true;
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(263, 36);
            this.txtAccountName.TabIndex = 5;
            this.txtAccountName.TextChanged += new System.EventHandler(this.txtAccountName_GotFocus);
            // 
            // txtEmail
            // 
            this.txtEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtEmail.Location = new System.Drawing.Point(190, 133);
            this.txtEmail.MaximumSize = new System.Drawing.Size(263, 28);
            this.txtEmail.MinimumSize = new System.Drawing.Size(263, 36);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(263, 36);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // btnClearEmail
            // 
            this.btnClearEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnClearEmail.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnClearEmail.FlatAppearance.BorderSize = 0;
            this.btnClearEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearEmail.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearEmail.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClearEmail.Location = new System.Drawing.Point(552, 133);
            this.btnClearEmail.Name = "btnClearEmail";
            this.btnClearEmail.Size = new System.Drawing.Size(87, 36);
            this.btnClearEmail.TabIndex = 8;
            this.btnClearEmail.TabStop = false;
            this.btnClearEmail.Text = "Clear";
            this.btnClearEmail.UseVisualStyleBackColor = false;
            this.btnClearEmail.Click += new System.EventHandler(this.btnClearEmail_Click);
            // 
            // btnPasteEmail
            // 
            this.btnPasteEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnPasteEmail.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnPasteEmail.FlatAppearance.BorderSize = 0;
            this.btnPasteEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasteEmail.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasteEmail.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPasteEmail.Location = new System.Drawing.Point(460, 133);
            this.btnPasteEmail.Name = "btnPasteEmail";
            this.btnPasteEmail.Size = new System.Drawing.Size(87, 36);
            this.btnPasteEmail.TabIndex = 7;
            this.btnPasteEmail.TabStop = false;
            this.btnPasteEmail.Text = "Paste";
            this.btnPasteEmail.UseVisualStyleBackColor = false;
            this.btnPasteEmail.Click += new System.EventHandler(this.btnPasteEmail_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtUsername.Location = new System.Drawing.Point(190, 175);
            this.txtUsername.MaximumSize = new System.Drawing.Size(263, 28);
            this.txtUsername.MinimumSize = new System.Drawing.Size(263, 36);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(263, 36);
            this.txtUsername.TabIndex = 13;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // btnClearUsername
            // 
            this.btnClearUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnClearUsername.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnClearUsername.FlatAppearance.BorderSize = 0;
            this.btnClearUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearUsername.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearUsername.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClearUsername.Location = new System.Drawing.Point(552, 175);
            this.btnClearUsername.Name = "btnClearUsername";
            this.btnClearUsername.Size = new System.Drawing.Size(87, 36);
            this.btnClearUsername.TabIndex = 12;
            this.btnClearUsername.TabStop = false;
            this.btnClearUsername.Text = "Clear";
            this.btnClearUsername.UseVisualStyleBackColor = false;
            this.btnClearUsername.Click += new System.EventHandler(this.btnClearUsername_Click);
            // 
            // btnPasteUsername
            // 
            this.btnPasteUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnPasteUsername.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnPasteUsername.FlatAppearance.BorderSize = 0;
            this.btnPasteUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasteUsername.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasteUsername.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPasteUsername.Location = new System.Drawing.Point(460, 175);
            this.btnPasteUsername.Name = "btnPasteUsername";
            this.btnPasteUsername.Size = new System.Drawing.Size(87, 36);
            this.btnPasteUsername.TabIndex = 11;
            this.btnPasteUsername.TabStop = false;
            this.btnPasteUsername.Text = "Paste";
            this.btnPasteUsername.UseVisualStyleBackColor = false;
            this.btnPasteUsername.Click += new System.EventHandler(this.btnPasteUsername_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtPassword.Location = new System.Drawing.Point(190, 217);
            this.txtPassword.MaximumSize = new System.Drawing.Size(263, 36);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(263, 36);
            this.txtPassword.TabIndex = 17;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // btnPastePassword
            // 
            this.btnPastePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnPastePassword.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnPastePassword.FlatAppearance.BorderSize = 0;
            this.btnPastePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPastePassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPastePassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPastePassword.Location = new System.Drawing.Point(502, 217);
            this.btnPastePassword.Name = "btnPastePassword";
            this.btnPastePassword.Size = new System.Drawing.Size(137, 36);
            this.btnPastePassword.TabIndex = 15;
            this.btnPastePassword.TabStop = false;
            this.btnPastePassword.Text = "Generate";
            this.btnPastePassword.UseVisualStyleBackColor = false;
            this.btnPastePassword.Click += new System.EventHandler(this.btnPastePassword_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtInfo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInfo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtInfo.Location = new System.Drawing.Point(190, 259);
            this.txtInfo.Margin = new System.Windows.Forms.Padding(0);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(449, 98);
            this.txtInfo.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.btnShow);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnCreateAccount);
            this.panel1.Controls.Add(this.btnHide);
            this.panel1.Location = new System.Drawing.Point(179, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 349);
            this.panel1.TabIndex = 22;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClose.Location = new System.Drawing.Point(281, 282);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(179, 58);
            this.btnClose.TabIndex = 24;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnCreateAccount.Enabled = false;
            this.btnCreateAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnCreateAccount.FlatAppearance.BorderSize = 0;
            this.btnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAccount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAccount.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCreateAccount.Location = new System.Drawing.Point(11, 282);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(263, 58);
            this.btnCreateAccount.TabIndex = 23;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnHide.BackgroundImage = global::PasswordAddAccount.Properties.Resources.Untitled__1_;
            this.btnHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnHide.Location = new System.Drawing.Point(281, 135);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(36, 36);
            this.btnHide.TabIndex = 25;
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblAccountName.Location = new System.Drawing.Point(21, 94);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(152, 30);
            this.lblAccountName.TabIndex = 1;
            this.lblAccountName.Text = "Account Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblEmail.Location = new System.Drawing.Point(21, 136);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(63, 30);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUsername.Location = new System.Drawing.Point(21, 178);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(106, 30);
            this.lblUsername.TabIndex = 10;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPassword.Location = new System.Drawing.Point(21, 220);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(99, 30);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "Password";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblInfo.Location = new System.Drawing.Point(21, 262);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(102, 30);
            this.lblInfo.TabIndex = 18;
            this.lblInfo.Text = "Extra Info";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnShow.BackgroundImage = global::PasswordAddAccount.Properties.Resources.show_final;
            this.btnShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnShow.Location = new System.Drawing.Point(281, 135);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(36, 36);
            this.btnShow.TabIndex = 23;
            this.btnShow.TabStop = false;
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(668, 455);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnPastePassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnClearUsername);
            this.Controls.Add(this.btnPasteUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnClearEmail);
            this.Controls.Add(this.btnPasteEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtAccountName);
            this.Controls.Add(this.btnClearAccountName);
            this.Controls.Add(this.BtnPasteAccountName);
            this.Controls.Add(this.lblAccountName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form3";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "New Account";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button BtnPasteAccountName;
        private System.Windows.Forms.Button btnClearAccountName;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnClearEmail;
        private System.Windows.Forms.Button btnPasteEmail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnClearUsername;
        private System.Windows.Forms.Button btnPasteUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnPastePassword;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnHide;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Button btnShow;
    }
}

