namespace admin
{
    partial class Form3
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
            cancelBtn = new Button();
            saveBtn = new Button();
            guardianTextBox = new TextBox();
            label8 = new Label();
            label7 = new Label();
            sectionTextBox = new TextBox();
            gradeLevelTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            lrnTextBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            uploadBtn = new Button();
            label9 = new Label();
            pupilPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pupilPictureBox).BeginInit();
            SuspendLayout();
            // 
            // cancelBtn
            // 
            cancelBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelBtn.Location = new Point(216, 408);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(176, 48);
            cancelBtn.TabIndex = 29;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveBtn.Location = new Point(16, 408);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(176, 48);
            saveBtn.TabIndex = 28;
            saveBtn.Text = "Save Changes";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // guardianTextBox
            // 
            guardianTextBox.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guardianTextBox.Location = new Point(16, 336);
            guardianTextBox.Name = "guardianTextBox";
            guardianTextBox.Size = new Size(248, 26);
            guardianTextBox.TabIndex = 27;
            guardianTextBox.TextChanged += guardianTextBox_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(16, 304);
            label8.Name = "label8";
            label8.Size = new Size(231, 19);
            label8.TabIndex = 26;
            label8.Text = "Guardian's Contact Number :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(256, 216);
            label7.Name = "label7";
            label7.Size = new Size(77, 19);
            label7.TabIndex = 25;
            label7.Text = "Section :";
            // 
            // sectionTextBox
            // 
            sectionTextBox.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sectionTextBox.Location = new Point(256, 248);
            sectionTextBox.Name = "sectionTextBox";
            sectionTextBox.Size = new Size(176, 26);
            sectionTextBox.TabIndex = 24;
            sectionTextBox.TextChanged += sectionTextBox_TextChanged;
            // 
            // gradeLevelTextBox
            // 
            gradeLevelTextBox.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gradeLevelTextBox.Location = new Point(16, 248);
            gradeLevelTextBox.Name = "gradeLevelTextBox";
            gradeLevelTextBox.Size = new Size(176, 26);
            gradeLevelTextBox.TabIndex = 23;
            gradeLevelTextBox.TextChanged += gradeLevelTextBox_TextChanged;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lastNameTextBox.Location = new Point(256, 160);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(176, 26);
            lastNameTextBox.TabIndex = 22;
            lastNameTextBox.TextChanged += lastNameTextBox_TextChanged;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            firstNameTextBox.Location = new Point(16, 160);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(176, 26);
            firstNameTextBox.TabIndex = 21;
            firstNameTextBox.TextChanged += firstNameTextBox_TextChanged;
            // 
            // lrnTextBox
            // 
            lrnTextBox.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lrnTextBox.Location = new Point(16, 80);
            lrnTextBox.Name = "lrnTextBox";
            lrnTextBox.Size = new Size(248, 26);
            lrnTextBox.TabIndex = 20;
            lrnTextBox.TextChanged += lrnTextBox_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(16, 216);
            label6.Name = "label6";
            label6.Size = new Size(110, 19);
            label6.TabIndex = 19;
            label6.Text = "Grade Level :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(256, 128);
            label5.Name = "label5";
            label5.Size = new Size(94, 19);
            label5.TabIndex = 18;
            label5.Text = "Lastname :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 136);
            label4.Name = "label4";
            label4.Size = new Size(95, 19);
            label4.TabIndex = 17;
            label4.Text = "Firstname :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 56);
            label3.Name = "label3";
            label3.Size = new Size(96, 19);
            label3.TabIndex = 16;
            label3.Text = "Pupil LRN :";
            // 
            // uploadBtn
            // 
            uploadBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uploadBtn.Location = new Point(488, 408);
            uploadBtn.Name = "uploadBtn";
            uploadBtn.Size = new Size(352, 48);
            uploadBtn.TabIndex = 32;
            uploadBtn.Text = "Update Picture";
            uploadBtn.UseVisualStyleBackColor = true;
            uploadBtn.Click += uploadBtn_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(488, 56);
            label9.Name = "label9";
            label9.Size = new Size(65, 19);
            label9.TabIndex = 31;
            label9.Text = "Photo :";
            // 
            // pupilPictureBox
            // 
            pupilPictureBox.BackColor = Color.FromArgb(224, 224, 224);
            pupilPictureBox.Location = new Point(488, 80);
            pupilPictureBox.Name = "pupilPictureBox";
            pupilPictureBox.Size = new Size(352, 312);
            pupilPictureBox.TabIndex = 30;
            pupilPictureBox.TabStop = false;
            pupilPictureBox.Click += pupilPictureBox_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 482);
            Controls.Add(uploadBtn);
            Controls.Add(label9);
            Controls.Add(pupilPictureBox);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            Controls.Add(guardianTextBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(sectionTextBox);
            Controls.Add(gradeLevelTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(lrnTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "Form3";
            Text = "Update Pupil";
            ((System.ComponentModel.ISupportInitialize)pupilPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelBtn;
        private Button saveBtn;
        private TextBox guardianTextBox;
        private Label label8;
        private Label label7;
        private TextBox sectionTextBox;
        private TextBox gradeLevelTextBox;
        private TextBox lastNameTextBox;
        private TextBox firstNameTextBox;
        private TextBox lrnTextBox;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button uploadBtn;
        private Label label9;
        private PictureBox pupilPictureBox;
    }
}