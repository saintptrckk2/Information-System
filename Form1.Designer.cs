namespace admin
{
    partial class loginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            userTextBox = new TextBox();
            pwTextBox = new TextBox();
            showBtn = new Button();
            loginBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(22, 24);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 199);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F);
            label1.Location = new Point(342, 24);
            label1.Name = "label1";
            label1.Size = new Size(90, 18);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F);
            label2.Location = new Point(345, 104);
            label2.Name = "label2";
            label2.Size = new Size(87, 18);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // userTextBox
            // 
            userTextBox.Font = new Font("Arial Rounded MT Bold", 12F);
            userTextBox.Location = new Point(289, 45);
            userTextBox.Margin = new Padding(3, 4, 3, 4);
            userTextBox.Multiline = true;
            userTextBox.Name = "userTextBox";
            userTextBox.Size = new Size(212, 34);
            userTextBox.TabIndex = 3;
            userTextBox.TextAlign = HorizontalAlignment.Center;
            userTextBox.TextChanged += userTextBox_TextChanged;
            // 
            // pwTextBox
            // 
            pwTextBox.Font = new Font("Arial Rounded MT Bold", 12F);
            pwTextBox.Location = new Point(289, 125);
            pwTextBox.Margin = new Padding(3, 4, 3, 4);
            pwTextBox.Multiline = true;
            pwTextBox.Name = "pwTextBox";
            pwTextBox.PasswordChar = '•';
            pwTextBox.Size = new Size(212, 34);
            pwTextBox.TabIndex = 4;
            pwTextBox.TextAlign = HorizontalAlignment.Center;
            pwTextBox.TextChanged += pwTextBox_TextChanged;
            // 
            // showBtn
            // 
            showBtn.Font = new Font("Arial Rounded MT Bold", 12F);
            showBtn.Location = new Point(289, 181);
            showBtn.Margin = new Padding(3, 4, 3, 4);
            showBtn.Name = "showBtn";
            showBtn.Size = new Size(99, 41);
            showBtn.TabIndex = 5;
            showBtn.Text = "Show";
            showBtn.UseVisualStyleBackColor = true;
            showBtn.Click += showBtn_Click;
            // 
            // loginBtn
            // 
            loginBtn.Font = new Font("Arial Rounded MT Bold", 12F);
            loginBtn.Location = new Point(404, 181);
            loginBtn.Margin = new Padding(3, 4, 3, 4);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(97, 41);
            loginBtn.TabIndex = 6;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(525, 244);
            Controls.Add(loginBtn);
            Controls.Add(showBtn);
            Controls.Add(pwTextBox);
            Controls.Add(userTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "loginForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox userTextBox;
        private TextBox pwTextBox;
        private Button showBtn;
        private Button loginBtn;
    }
}
