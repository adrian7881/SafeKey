namespace Password_Manager
{
    partial class Logg_inn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logg_inn));
            this.lblEnter_password = new System.Windows.Forms.Label();
            this.txtPassord_inn_logg = new System.Windows.Forms.TextBox();
            this.btnLogginn = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.txtSkriv_brukernavn = new System.Windows.Forms.TextBox();
            this.lblBrukernavn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnter_password
            // 
            this.lblEnter_password.AutoSize = true;
            this.lblEnter_password.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnter_password.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblEnter_password.Location = new System.Drawing.Point(115, 198);
            this.lblEnter_password.Name = "lblEnter_password";
            this.lblEnter_password.Size = new System.Drawing.Size(168, 30);
            this.lblEnter_password.TabIndex = 0;
            this.lblEnter_password.Text = "Enter Password:";
            this.lblEnter_password.Click += new System.EventHandler(this.lblEnter_password_Click);
            // 
            // txtPassord_inn_logg
            // 
            this.txtPassord_inn_logg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.txtPassord_inn_logg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassord_inn_logg.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassord_inn_logg.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtPassord_inn_logg.Location = new System.Drawing.Point(289, 199);
            this.txtPassord_inn_logg.MinimumSize = new System.Drawing.Size(0, 30);
            this.txtPassord_inn_logg.Multiline = true;
            this.txtPassord_inn_logg.Name = "txtPassord_inn_logg";
            this.txtPassord_inn_logg.Size = new System.Drawing.Size(245, 30);
            this.txtPassord_inn_logg.TabIndex = 1;
            this.txtPassord_inn_logg.TextChanged += new System.EventHandler(this.txtPassord_inn_logg_TextChanged);
            // 
            // btnLogginn
            // 
            this.btnLogginn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnLogginn.FlatAppearance.BorderSize = 0;
            this.btnLogginn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogginn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogginn.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogginn.Location = new System.Drawing.Point(120, 261);
            this.btnLogginn.Name = "btnLogginn";
            this.btnLogginn.Size = new System.Drawing.Size(414, 65);
            this.btnLogginn.TabIndex = 2;
            this.btnLogginn.Text = "Login";
            this.btnLogginn.UseVisualStyleBackColor = false;
            this.btnLogginn.Click += new System.EventHandler(this.btnLogginn_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(183, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(301, 117);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 3;
            this.picLogo.TabStop = false;
            // 
            // txtSkriv_brukernavn
            // 
            this.txtSkriv_brukernavn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.txtSkriv_brukernavn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSkriv_brukernavn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSkriv_brukernavn.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtSkriv_brukernavn.Location = new System.Drawing.Point(289, 157);
            this.txtSkriv_brukernavn.MinimumSize = new System.Drawing.Size(0, 30);
            this.txtSkriv_brukernavn.Multiline = true;
            this.txtSkriv_brukernavn.Name = "txtSkriv_brukernavn";
            this.txtSkriv_brukernavn.Size = new System.Drawing.Size(245, 30);
            this.txtSkriv_brukernavn.TabIndex = 5;
            // 
            // lblBrukernavn
            // 
            this.lblBrukernavn.AutoSize = true;
            this.lblBrukernavn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrukernavn.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblBrukernavn.Location = new System.Drawing.Point(115, 156);
            this.lblBrukernavn.Name = "lblBrukernavn";
            this.lblBrukernavn.Size = new System.Drawing.Size(116, 30);
            this.lblBrukernavn.TabIndex = 4;
            this.lblBrukernavn.Text = "Username:";
            // 
            // Logg_inn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(638, 351);
            this.Controls.Add(this.txtSkriv_brukernavn);
            this.Controls.Add(this.lblBrukernavn);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnLogginn);
            this.Controls.Add(this.txtPassord_inn_logg);
            this.Controls.Add(this.lblEnter_password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Logg_inn";
            this.Text = "Log in";
            this.Load += new System.EventHandler(this.Logg_inn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnter_password;
        private System.Windows.Forms.TextBox txtPassord_inn_logg;
        private System.Windows.Forms.Button btnLogginn;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TextBox txtSkriv_brukernavn;
        private System.Windows.Forms.Label lblBrukernavn;
    }
}

