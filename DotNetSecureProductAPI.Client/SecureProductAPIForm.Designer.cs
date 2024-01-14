namespace DotNetSecureProductAPI.Client
{
    partial class SecureProductAPIForm
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
            label1 = new Label();
            label2 = new Label();
            txtNewUserConfirmPassword = new TextBox();
            label6 = new Label();
            btnCreateAccount = new Button();
            txtNewUserPassword = new TextBox();
            label5 = new Label();
            txtNewUserUsername = new TextBox();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            btnClearNewUser = new Button();
            label11 = new Label();
            btnCopy = new Button();
            label7 = new Label();
            txtJWBToken = new TextBox();
            button3 = new Button();
            btnLogin = new Button();
            txtLoginPassword = new TextBox();
            label8 = new Label();
            txtLoginUsername = new TextBox();
            label9 = new Label();
            label10 = new Label();
            dgProducts = new DataGridView();
            panel3 = new Panel();
            button1 = new Button();
            txtColour = new TextBox();
            label20 = new Label();
            label18 = new Label();
            button7 = new Button();
            label19 = new Label();
            label13 = new Label();
            button6 = new Button();
            label17 = new Label();
            label16 = new Label();
            button5 = new Button();
            label15 = new Label();
            label12 = new Label();
            txtTokenRequest = new TextBox();
            button4 = new Button();
            label14 = new Label();
            button8 = new Button();
            txtAPIAddress = new TextBox();
            label21 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgProducts).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 31);
            label1.Name = "label1";
            label1.Size = new Size(178, 30);
            label1.TabIndex = 0;
            label1.Text = "API Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(20, 462);
            label2.Name = "label2";
            label2.Size = new Size(220, 30);
            label2.TabIndex = 1;
            label2.Text = "Identity Management";
            // 
            // txtNewUserConfirmPassword
            // 
            txtNewUserConfirmPassword.Font = new Font("Segoe UI", 9.75F);
            txtNewUserConfirmPassword.Location = new Point(400, 77);
            txtNewUserConfirmPassword.Name = "txtNewUserConfirmPassword";
            txtNewUserConfirmPassword.PlaceholderText = "Confirm Password...";
            txtNewUserConfirmPassword.Size = new Size(178, 25);
            txtNewUserConfirmPassword.TabIndex = 7;
            txtNewUserConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(400, 53);
            label6.Name = "label6";
            label6.Size = new Size(137, 21);
            label6.TabIndex = 6;
            label6.Text = "Confirm Password";
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.BackColor = Color.LightGray;
            btnCreateAccount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateAccount.Location = new Point(594, 74);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(128, 29);
            btnCreateAccount.TabIndex = 5;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = true;
            btnCreateAccount.Click += button1_Click;
            // 
            // txtNewUserPassword
            // 
            txtNewUserPassword.Font = new Font("Segoe UI", 9.75F);
            txtNewUserPassword.Location = new Point(206, 77);
            txtNewUserPassword.Name = "txtNewUserPassword";
            txtNewUserPassword.PlaceholderText = "Password...";
            txtNewUserPassword.Size = new Size(178, 25);
            txtNewUserPassword.TabIndex = 4;
            txtNewUserPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(206, 53);
            label5.Name = "label5";
            label5.Size = new Size(76, 21);
            label5.TabIndex = 3;
            label5.Text = "Password";
            // 
            // txtNewUserUsername
            // 
            txtNewUserUsername.Font = new Font("Segoe UI", 9.75F);
            txtNewUserUsername.Location = new Point(12, 77);
            txtNewUserUsername.Name = "txtNewUserUsername";
            txtNewUserUsername.PlaceholderText = "Username...";
            txtNewUserUsername.Size = new Size(178, 25);
            txtNewUserUsername.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 53);
            label4.Name = "label4";
            label4.Size = new Size(133, 21);
            label4.TabIndex = 1;
            label4.Text = "Username \\ Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 17);
            label3.Name = "label3";
            label3.Size = new Size(144, 25);
            label3.TabIndex = 0;
            label3.Text = "Create Account";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(btnClearNewUser);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(txtNewUserConfirmPassword);
            panel2.Controls.Add(btnCopy);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(btnCreateAccount);
            panel2.Controls.Add(txtJWBToken);
            panel2.Controls.Add(txtNewUserPassword);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(txtNewUserUsername);
            panel2.Controls.Add(txtLoginPassword);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtLoginUsername);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Location = new Point(20, 499);
            panel2.Name = "panel2";
            panel2.Size = new Size(829, 408);
            panel2.TabIndex = 4;
            // 
            // btnClearNewUser
            // 
            btnClearNewUser.BackColor = Color.LightGray;
            btnClearNewUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClearNewUser.Location = new Point(733, 74);
            btnClearNewUser.Name = "btnClearNewUser";
            btnClearNewUser.Size = new Size(64, 29);
            btnClearNewUser.TabIndex = 14;
            btnClearNewUser.Text = "Clear";
            btnClearNewUser.UseVisualStyleBackColor = true;
            btnClearNewUser.Click += btnClearNewUser_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(68, 142);
            label11.Name = "label11";
            label11.Size = new Size(136, 17);
            label11.TabIndex = 13;
            label11.Text = "\\ Generate JWT Token";
            // 
            // btnCopy
            // 
            btnCopy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCopy.Location = new Point(737, 356);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(64, 29);
            btnCopy.TabIndex = 12;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(12, 238);
            label7.Name = "label7";
            label7.Size = new Size(154, 21);
            label7.TabIndex = 11;
            label7.Text = "JWT Token Response";
            // 
            // txtJWBToken
            // 
            txtJWBToken.Enabled = false;
            txtJWBToken.Location = new Point(12, 262);
            txtJWBToken.Multiline = true;
            txtJWBToken.Name = "txtJWBToken";
            txtJWBToken.Size = new Size(789, 82);
            txtJWBToken.TabIndex = 10;
            // 
            // button3
            // 
            button3.BackColor = Color.LightGray;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(475, 192);
            button3.Name = "button3";
            button3.Size = new Size(64, 29);
            button3.TabIndex = 9;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(398, 192);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(64, 29);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.Font = new Font("Segoe UI", 9.75F);
            txtLoginPassword.Location = new Point(206, 196);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.PlaceholderText = "Password...";
            txtLoginPassword.Size = new Size(178, 25);
            txtLoginPassword.TabIndex = 4;
            txtLoginPassword.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(206, 172);
            label8.Name = "label8";
            label8.Size = new Size(76, 21);
            label8.TabIndex = 3;
            label8.Text = "Password";
            // 
            // txtLoginUsername
            // 
            txtLoginUsername.Font = new Font("Segoe UI", 9.75F);
            txtLoginUsername.Location = new Point(12, 196);
            txtLoginUsername.Name = "txtLoginUsername";
            txtLoginUsername.PlaceholderText = "Username...";
            txtLoginUsername.Size = new Size(178, 25);
            txtLoginUsername.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(12, 172);
            label9.Name = "label9";
            label9.Size = new Size(133, 21);
            label9.TabIndex = 1;
            label9.Text = "Username \\ Email";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(12, 136);
            label10.Name = "label10";
            label10.Size = new Size(59, 25);
            label10.TabIndex = 0;
            label10.Text = "Login";
            // 
            // dgProducts
            // 
            dgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProducts.Location = new Point(534, 260);
            dgProducts.Name = "dgProducts";
            dgProducts.Size = new Size(315, 150);
            dgProducts.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(button1);
            panel3.Controls.Add(txtColour);
            panel3.Controls.Add(label20);
            panel3.Controls.Add(label18);
            panel3.Controls.Add(button7);
            panel3.Controls.Add(label19);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(label15);
            panel3.Location = new Point(20, 67);
            panel3.Name = "panel3";
            panel3.Size = new Size(498, 343);
            panel3.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(346, 277);
            button1.Name = "button1";
            button1.Size = new Size(64, 29);
            button1.TabIndex = 16;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // txtColour
            // 
            txtColour.Font = new Font("Segoe UI", 9.75F);
            txtColour.Location = new Point(12, 279);
            txtColour.Name = "txtColour";
            txtColour.PlaceholderText = "Colour...";
            txtColour.Size = new Size(178, 25);
            txtColour.TabIndex = 22;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.White;
            label20.Location = new Point(12, 255);
            label20.Name = "label20";
            label20.Size = new Size(57, 21);
            label20.TabIndex = 21;
            label20.Text = "Colour";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.White;
            label18.Location = new Point(187, 228);
            label18.Name = "label18";
            label18.Size = new Size(171, 17);
            label18.TabIndex = 20;
            label18.Text = "GET /api/products/bycolour";
            // 
            // button7
            // 
            button7.BackColor = Color.LightGray;
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(206, 277);
            button7.Name = "button7";
            button7.Size = new Size(128, 29);
            button7.TabIndex = 19;
            button7.Text = "Try Out";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.White;
            label19.Location = new Point(12, 222);
            label19.Name = "label19";
            label19.Size = new Size(175, 25);
            label19.TabIndex = 18;
            label19.Text = "Products By Colour";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(97, 122);
            label13.Name = "label13";
            label13.Size = new Size(115, 17);
            label13.TabIndex = 17;
            label13.Text = "GET /api/products";
            // 
            // button6
            // 
            button6.BackColor = Color.LightGray;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(12, 150);
            button6.Name = "button6";
            button6.Size = new Size(128, 29);
            button6.TabIndex = 16;
            button6.Text = "Try Out";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.White;
            label17.Location = new Point(12, 116);
            label17.Name = "label17";
            label17.Size = new Size(87, 25);
            label17.TabIndex = 15;
            label17.Text = "Products";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.White;
            label16.Location = new Point(141, 15);
            label16.Name = "label16";
            label16.Size = new Size(40, 17);
            label16.TabIndex = 14;
            label16.Text = "GET /";
            // 
            // button5
            // 
            button5.BackColor = Color.LightGray;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(12, 45);
            button5.Name = "button5";
            button5.Size = new Size(128, 29);
            button5.TabIndex = 5;
            button5.Text = "Try Out";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.White;
            label15.Location = new Point(12, 11);
            label15.Name = "label15";
            label15.Size = new Size(126, 25);
            label15.TabIndex = 0;
            label15.Text = "Health Check";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label12.ForeColor = Color.White;
            label12.Location = new Point(534, 67);
            label12.Name = "label12";
            label12.Size = new Size(176, 25);
            label12.TabIndex = 13;
            label12.Text = "JWT Token Request";
            // 
            // txtTokenRequest
            // 
            txtTokenRequest.Enabled = false;
            txtTokenRequest.Location = new Point(534, 100);
            txtTokenRequest.Multiline = true;
            txtTokenRequest.Name = "txtTokenRequest";
            txtTokenRequest.ScrollBars = ScrollBars.Vertical;
            txtTokenRequest.Size = new Size(315, 92);
            txtTokenRequest.TabIndex = 12;
            // 
            // button4
            // 
            button4.BackColor = Color.LightGray;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(715, 198);
            button4.Name = "button4";
            button4.Size = new Size(64, 29);
            button4.TabIndex = 14;
            button4.Text = "Paste";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label14.ForeColor = Color.White;
            label14.Location = new Point(534, 225);
            label14.Name = "label14";
            label14.Size = new Size(87, 25);
            label14.TabIndex = 15;
            label14.Text = "Products";
            // 
            // button8
            // 
            button8.BackColor = Color.LightGray;
            button8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.Location = new Point(785, 198);
            button8.Name = "button8";
            button8.Size = new Size(64, 29);
            button8.TabIndex = 16;
            button8.Text = "Clear";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // txtAPIAddress
            // 
            txtAPIAddress.BackColor = SystemColors.Info;
            txtAPIAddress.Font = new Font("Segoe UI", 9.75F);
            txtAPIAddress.Location = new Point(616, 12);
            txtAPIAddress.Name = "txtAPIAddress";
            txtAPIAddress.PlaceholderText = "API Address...";
            txtAPIAddress.Size = new Size(246, 25);
            txtAPIAddress.TabIndex = 23;
            txtAPIAddress.Text = "https://localhost:7138";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.Transparent;
            label21.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label21.ForeColor = Color.White;
            label21.Location = new Point(423, 12);
            label21.Name = "label21";
            label21.Size = new Size(187, 25);
            label21.TabIndex = 24;
            label21.Text = "Product API Address";
            // 
            // SecureProductAPIForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(869, 928);
            Controls.Add(label21);
            Controls.Add(txtAPIAddress);
            Controls.Add(button8);
            Controls.Add(label14);
            Controls.Add(button4);
            Controls.Add(label12);
            Controls.Add(txtTokenRequest);
            Controls.Add(panel3);
            Controls.Add(dgProducts);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SecureProductAPIForm";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Secure Product API";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgProducts).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private TextBox txtNewUserUsername;
        private Button btnCreateAccount;
        private TextBox txtNewUserPassword;
        private Label label5;
        private TextBox txtNewUserConfirmPassword;
        private Label label6;
        private Panel panel2;
        private Button btnLogin;
        private TextBox txtLoginPassword;
        private Label label8;
        private TextBox txtLoginUsername;
        private Label label9;
        private Label label10;
        private Button button3;
        private Label label7;
        private TextBox txtJWBToken;
        private Button btnCopy;
        private DataGridView dgProducts;
        private Label label11;
        private Panel panel3;
        private Button button5;
        private Label label15;
        private Label label12;
        private TextBox txtTokenRequest;
        private Button button4;
        private Label label14;
        private Label label16;
        private Label label13;
        private Button button6;
        private Label label17;
        private TextBox txtColour;
        private Label label20;
        private Label label18;
        private Button button7;
        private Label label19;
        private Button button1;
        private Button button8;
        private TextBox txtAPIAddress;
        private Label label21;
        private Button btnClearNewUser;
    }
}