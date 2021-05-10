
namespace CourseProj
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.createAccountLabel = new System.Windows.Forms.Label();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.userNameField = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.createAccountLabel);
            this.panel1.Controls.Add(this.passwordField);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.userNameField);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 503);
            this.panel1.TabIndex = 0;
            // 
            // createAccountLabel
            // 
            this.createAccountLabel.AutoSize = true;
            this.createAccountLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createAccountLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createAccountLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.createAccountLabel.Location = new System.Drawing.Point(382, 419);
            this.createAccountLabel.Name = "createAccountLabel";
            this.createAccountLabel.Size = new System.Drawing.Size(190, 22);
            this.createAccountLabel.TabIndex = 4;
            this.createAccountLabel.Text = "Создать аккаунт →";
            this.createAccountLabel.Click += new System.EventHandler(this.createAccountLabel_Click);
            this.createAccountLabel.MouseEnter += new System.EventHandler(this.userNameField_Leave);
            this.createAccountLabel.MouseLeave += new System.EventHandler(this.createAccountLabel_MouseLeave);
            // 
            // passwordField
            // 
            this.passwordField.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(177)))), ((int)(((byte)(194)))));
            this.passwordField.Location = new System.Drawing.Point(309, 244);
            this.passwordField.Margin = new System.Windows.Forms.Padding(6);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(337, 48);
            this.passwordField.TabIndex = 2;
            this.passwordField.Text = "Пароль";
            this.passwordField.Enter += new System.EventHandler(this.passwordField_Enter);
            this.passwordField.Leave += new System.EventHandler(this.passwordField_Leave);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.AliceBlue;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginButton.ForeColor = System.Drawing.Color.Black;
            this.loginButton.Location = new System.Drawing.Point(309, 332);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(337, 67);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Войти";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.Login_Click);
            // 
            // userNameField
            // 
            this.userNameField.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(177)))), ((int)(((byte)(194)))));
            this.userNameField.Location = new System.Drawing.Point(309, 96);
            this.userNameField.Margin = new System.Windows.Forms.Padding(6);
            this.userNameField.Name = "userNameField";
            this.userNameField.Size = new System.Drawing.Size(337, 48);
            this.userNameField.TabIndex = 1;
            this.userNameField.Text = "Логин";
            this.userNameField.Enter += new System.EventHandler(this.userNameField_Enter);
            this.userNameField.Leave += new System.EventHandler(this.userNameField_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CourseProj.Properties.Resources.iconfinder_8_4698577;
            this.pictureBox2.Location = new System.Drawing.Point(200, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CourseProj.Properties.Resources.iconfinder_22_4698593;
            this.pictureBox1.Location = new System.Drawing.Point(200, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 503);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ну как там с деньгами?";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox userNameField;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Label createAccountLabel;
    }
}