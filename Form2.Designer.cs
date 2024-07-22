namespace admin
{
    partial class Form2
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
            panel1 = new Panel();
            label1 = new Label();
            PupilTabControl = new TabControl();
            listTab = new TabPage();
            refreshBtn = new Button();
            goGenBtn = new Button();
            deleteBtn = new Button();
            editBtn = new Button();
            label2 = new Label();
            listGridView = new DataGridView();
            addNewBtn = new Button();
            searchTextBox = new TextBox();
            detailsTab = new TabPage();
            uploadBtn = new Button();
            cancelBtn = new Button();
            saveBtn = new Button();
            label9 = new Label();
            pupilPictureBox = new PictureBox();
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
            generateTab = new TabPage();
            cancelGenerateBtn = new Button();
            label10 = new Label();
            panel3 = new Panel();
            lrnLbl = new Label();
            lastNameLbl = new Label();
            firstNameLbl = new Label();
            saveCodeBtn = new Button();
            panel2 = new Panel();
            qrPictureBox = new PictureBox();
            generateBtn = new Button();
            panel1.SuspendLayout();
            PupilTabControl.SuspendLayout();
            listTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)listGridView).BeginInit();
            detailsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pupilPictureBox).BeginInit();
            generateTab.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)qrPictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1343, 62);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 20);
            label1.Name = "label1";
            label1.Size = new Size(80, 22);
            label1.TabIndex = 0;
            label1.Text = "PUPILS";
            // 
            // PupilTabControl
            // 
            PupilTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PupilTabControl.Controls.Add(listTab);
            PupilTabControl.Controls.Add(detailsTab);
            PupilTabControl.Controls.Add(generateTab);
            PupilTabControl.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PupilTabControl.Location = new Point(-2, 69);
            PupilTabControl.Name = "PupilTabControl";
            PupilTabControl.SelectedIndex = 0;
            PupilTabControl.Size = new Size(1343, 596);
            PupilTabControl.TabIndex = 1;
            // 
            // listTab
            // 
            listTab.BackColor = Color.White;
            listTab.Controls.Add(refreshBtn);
            listTab.Controls.Add(goGenBtn);
            listTab.Controls.Add(deleteBtn);
            listTab.Controls.Add(editBtn);
            listTab.Controls.Add(label2);
            listTab.Controls.Add(listGridView);
            listTab.Controls.Add(addNewBtn);
            listTab.Controls.Add(searchTextBox);
            listTab.Font = new Font("Arial", 12F, FontStyle.Bold);
            listTab.Location = new Point(4, 24);
            listTab.Name = "listTab";
            listTab.Padding = new Padding(3);
            listTab.Size = new Size(1335, 568);
            listTab.TabIndex = 0;
            listTab.Text = "Pupil Lists";
            // 
            // refreshBtn
            // 
            refreshBtn.Anchor = AnchorStyles.Right;
            refreshBtn.BackColor = Color.Transparent;
            refreshBtn.Font = new Font("Arial", 12F, FontStyle.Bold);
            refreshBtn.Location = new Point(1217, 304);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(107, 36);
            refreshBtn.TabIndex = 10;
            refreshBtn.Text = "Refresh";
            refreshBtn.UseVisualStyleBackColor = false;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // goGenBtn
            // 
            goGenBtn.Anchor = AnchorStyles.Right;
            goGenBtn.BackColor = Color.Transparent;
            goGenBtn.Font = new Font("Arial", 12F, FontStyle.Bold);
            goGenBtn.Location = new Point(1217, 256);
            goGenBtn.Name = "goGenBtn";
            goGenBtn.Size = new Size(107, 36);
            goGenBtn.TabIndex = 9;
            goGenBtn.Text = "Generate";
            goGenBtn.UseVisualStyleBackColor = false;
            goGenBtn.Click += goGenBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Anchor = AnchorStyles.Right;
            deleteBtn.BackColor = Color.Transparent;
            deleteBtn.Font = new Font("Arial", 12F, FontStyle.Bold);
            deleteBtn.Location = new Point(1217, 208);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(107, 36);
            deleteBtn.TabIndex = 8;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // editBtn
            // 
            editBtn.Anchor = AnchorStyles.Right;
            editBtn.BackColor = Color.Transparent;
            editBtn.Font = new Font("Arial", 12F, FontStyle.Bold);
            editBtn.Location = new Point(1217, 160);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(107, 36);
            editBtn.TabIndex = 7;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = false;
            editBtn.Click += editBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.Location = new Point(21, 10);
            label2.Name = "label2";
            label2.Size = new Size(106, 19);
            label2.TabIndex = 6;
            label2.Text = "Pupil Search";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // listGridView
            // 
            listGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listGridView.Location = new Point(23, 72);
            listGridView.Name = "listGridView";
            listGridView.Size = new Size(1186, 490);
            listGridView.TabIndex = 5;
            listGridView.CellContentClick += listGridView_CellContentClick;
            // 
            // addNewBtn
            // 
            addNewBtn.Anchor = AnchorStyles.Right;
            addNewBtn.BackColor = Color.Transparent;
            addNewBtn.Font = new Font("Arial", 12F, FontStyle.Bold);
            addNewBtn.Location = new Point(1216, 112);
            addNewBtn.Name = "addNewBtn";
            addNewBtn.Size = new Size(107, 36);
            addNewBtn.TabIndex = 2;
            addNewBtn.Text = "Add New";
            addNewBtn.UseVisualStyleBackColor = false;
            addNewBtn.Click += addNewBtn_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            searchTextBox.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchTextBox.Location = new Point(23, 37);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(1185, 29);
            searchTextBox.TabIndex = 0;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // detailsTab
            // 
            detailsTab.Controls.Add(uploadBtn);
            detailsTab.Controls.Add(cancelBtn);
            detailsTab.Controls.Add(saveBtn);
            detailsTab.Controls.Add(label9);
            detailsTab.Controls.Add(pupilPictureBox);
            detailsTab.Controls.Add(guardianTextBox);
            detailsTab.Controls.Add(label8);
            detailsTab.Controls.Add(label7);
            detailsTab.Controls.Add(sectionTextBox);
            detailsTab.Controls.Add(gradeLevelTextBox);
            detailsTab.Controls.Add(lastNameTextBox);
            detailsTab.Controls.Add(firstNameTextBox);
            detailsTab.Controls.Add(lrnTextBox);
            detailsTab.Controls.Add(label6);
            detailsTab.Controls.Add(label5);
            detailsTab.Controls.Add(label4);
            detailsTab.Controls.Add(label3);
            detailsTab.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            detailsTab.Location = new Point(4, 24);
            detailsTab.Name = "detailsTab";
            detailsTab.Padding = new Padding(3);
            detailsTab.Size = new Size(1335, 568);
            detailsTab.TabIndex = 1;
            detailsTab.Text = "Pupil Details";
            detailsTab.UseVisualStyleBackColor = true;
            // 
            // uploadBtn
            // 
            uploadBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uploadBtn.Location = new Point(824, 392);
            uploadBtn.Name = "uploadBtn";
            uploadBtn.Size = new Size(352, 48);
            uploadBtn.TabIndex = 16;
            uploadBtn.Text = "Upload Picture";
            uploadBtn.UseVisualStyleBackColor = true;
            uploadBtn.Click += uploadBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelBtn.Location = new Point(376, 392);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(176, 48);
            cancelBtn.TabIndex = 15;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveBtn.Location = new Point(176, 392);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(176, 48);
            saveBtn.TabIndex = 14;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(824, 40);
            label9.Name = "label9";
            label9.Size = new Size(65, 19);
            label9.TabIndex = 13;
            label9.Text = "Photo :";
            // 
            // pupilPictureBox
            // 
            pupilPictureBox.BackColor = Color.FromArgb(224, 224, 224);
            pupilPictureBox.Location = new Point(824, 64);
            pupilPictureBox.Name = "pupilPictureBox";
            pupilPictureBox.Size = new Size(352, 312);
            pupilPictureBox.TabIndex = 12;
            pupilPictureBox.TabStop = false;
            pupilPictureBox.Click += pupilPictureBox_Click;
            // 
            // guardianTextBox
            // 
            guardianTextBox.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guardianTextBox.Location = new Point(176, 320);
            guardianTextBox.Name = "guardianTextBox";
            guardianTextBox.Size = new Size(248, 26);
            guardianTextBox.TabIndex = 11;
            guardianTextBox.TextChanged += guardianTextBox_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(176, 288);
            label8.Name = "label8";
            label8.Size = new Size(231, 19);
            label8.TabIndex = 10;
            label8.Text = "Guardian's Contact Number :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(416, 200);
            label7.Name = "label7";
            label7.Size = new Size(77, 19);
            label7.TabIndex = 9;
            label7.Text = "Section :";
            // 
            // sectionTextBox
            // 
            sectionTextBox.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sectionTextBox.Location = new Point(416, 232);
            sectionTextBox.Name = "sectionTextBox";
            sectionTextBox.Size = new Size(176, 26);
            sectionTextBox.TabIndex = 8;
            sectionTextBox.TextChanged += sectionTextBox_TextChanged;
            // 
            // gradeLevelTextBox
            // 
            gradeLevelTextBox.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gradeLevelTextBox.Location = new Point(176, 232);
            gradeLevelTextBox.Name = "gradeLevelTextBox";
            gradeLevelTextBox.Size = new Size(176, 26);
            gradeLevelTextBox.TabIndex = 7;
            gradeLevelTextBox.TextChanged += gradeLevelTextBox_TextChanged;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lastNameTextBox.Location = new Point(416, 144);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(176, 26);
            lastNameTextBox.TabIndex = 6;
            lastNameTextBox.TextChanged += lastNameTextBox_TextChanged;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            firstNameTextBox.Location = new Point(176, 144);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(176, 26);
            firstNameTextBox.TabIndex = 5;
            firstNameTextBox.TextChanged += firstNameTextBox_TextChanged;
            // 
            // lrnTextBox
            // 
            lrnTextBox.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lrnTextBox.Location = new Point(176, 64);
            lrnTextBox.Name = "lrnTextBox";
            lrnTextBox.Size = new Size(248, 26);
            lrnTextBox.TabIndex = 4;
            lrnTextBox.TextChanged += lrnTextBox_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(176, 200);
            label6.Name = "label6";
            label6.Size = new Size(110, 19);
            label6.TabIndex = 3;
            label6.Text = "Grade Level :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(416, 112);
            label5.Name = "label5";
            label5.Size = new Size(94, 19);
            label5.TabIndex = 2;
            label5.Text = "Lastname :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(176, 120);
            label4.Name = "label4";
            label4.Size = new Size(95, 19);
            label4.TabIndex = 1;
            label4.Text = "Firstname :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(176, 40);
            label3.Name = "label3";
            label3.Size = new Size(96, 19);
            label3.TabIndex = 0;
            label3.Text = "Pupil LRN :";
            // 
            // generateTab
            // 
            generateTab.Controls.Add(cancelGenerateBtn);
            generateTab.Controls.Add(label10);
            generateTab.Controls.Add(panel3);
            generateTab.Controls.Add(lastNameLbl);
            generateTab.Controls.Add(firstNameLbl);
            generateTab.Controls.Add(saveCodeBtn);
            generateTab.Controls.Add(panel2);
            generateTab.Controls.Add(generateBtn);
            generateTab.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            generateTab.Location = new Point(4, 24);
            generateTab.Name = "generateTab";
            generateTab.Padding = new Padding(3);
            generateTab.Size = new Size(1335, 568);
            generateTab.TabIndex = 2;
            generateTab.Text = "Generate QR";
            generateTab.UseVisualStyleBackColor = true;
            // 
            // cancelGenerateBtn
            // 
            cancelGenerateBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelGenerateBtn.Location = new Point(128, 472);
            cancelGenerateBtn.Name = "cancelGenerateBtn";
            cancelGenerateBtn.Size = new Size(384, 48);
            cancelGenerateBtn.TabIndex = 24;
            cancelGenerateBtn.Text = "Cancel";
            cancelGenerateBtn.UseVisualStyleBackColor = true;
            cancelGenerateBtn.Click += cancelGenerateBtn_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(280, 72);
            label10.Name = "label10";
            label10.Size = new Size(89, 32);
            label10.TabIndex = 22;
            label10.Text = "LRN :";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(192, 255, 192);
            panel3.Controls.Add(lrnLbl);
            panel3.Location = new Point(136, 120);
            panel3.Name = "panel3";
            panel3.Size = new Size(384, 72);
            panel3.TabIndex = 1;
            // 
            // lrnLbl
            // 
            lrnLbl.Dock = DockStyle.Fill;
            lrnLbl.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lrnLbl.Location = new Point(0, 0);
            lrnLbl.Margin = new Padding(20);
            lrnLbl.Name = "lrnLbl";
            lrnLbl.Padding = new Padding(20, 10, 20, 10);
            lrnLbl.RightToLeft = RightToLeft.Yes;
            lrnLbl.Size = new Size(384, 72);
            lrnLbl.TabIndex = 21;
            lrnLbl.Text = "123123123";
            lrnLbl.TextAlign = ContentAlignment.MiddleCenter;
            lrnLbl.Click += lrnLbl_Click;
            // 
            // lastNameLbl
            // 
            lastNameLbl.AutoSize = true;
            lastNameLbl.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lastNameLbl.Location = new Point(344, 144);
            lastNameLbl.Name = "lastNameLbl";
            lastNameLbl.Size = new Size(148, 29);
            lastNameLbl.TabIndex = 23;
            lastNameLbl.Text = "Hello World";
            lastNameLbl.TextAlign = ContentAlignment.TopCenter;
            lastNameLbl.Visible = false;
            lastNameLbl.Click += lastNameLbl_Click;
            // 
            // firstNameLbl
            // 
            firstNameLbl.AutoSize = true;
            firstNameLbl.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            firstNameLbl.Location = new Point(184, 144);
            firstNameLbl.Name = "firstNameLbl";
            firstNameLbl.Size = new Size(148, 29);
            firstNameLbl.TabIndex = 22;
            firstNameLbl.Text = "Hello World";
            firstNameLbl.TextAlign = ContentAlignment.TopCenter;
            firstNameLbl.Visible = false;
            firstNameLbl.Click += firstNameLbl_Click;
            // 
            // saveCodeBtn
            // 
            saveCodeBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveCodeBtn.Location = new Point(128, 400);
            saveCodeBtn.Name = "saveCodeBtn";
            saveCodeBtn.Size = new Size(176, 48);
            saveCodeBtn.TabIndex = 20;
            saveCodeBtn.Text = "Save QR Code";
            saveCodeBtn.UseVisualStyleBackColor = true;
            saveCodeBtn.Click += saveCodeBtn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(qrPictureBox);
            panel2.Location = new Point(672, 32);
            panel2.Name = "panel2";
            panel2.Size = new Size(472, 496);
            panel2.TabIndex = 19;
            // 
            // qrPictureBox
            // 
            qrPictureBox.Location = new Point(40, 40);
            qrPictureBox.Name = "qrPictureBox";
            qrPictureBox.Size = new Size(392, 424);
            qrPictureBox.TabIndex = 18;
            qrPictureBox.TabStop = false;
            qrPictureBox.Click += qrPictureBox_Click;
            // 
            // generateBtn
            // 
            generateBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            generateBtn.Location = new Point(336, 400);
            generateBtn.Name = "generateBtn";
            generateBtn.Size = new Size(176, 48);
            generateBtn.TabIndex = 16;
            generateBtn.Text = "Gererate QR Code";
            generateBtn.UseVisualStyleBackColor = true;
            generateBtn.Click += generateBtn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1339, 667);
            Controls.Add(PupilTabControl);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pupil Information System";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            PupilTabControl.ResumeLayout(false);
            listTab.ResumeLayout(false);
            listTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)listGridView).EndInit();
            detailsTab.ResumeLayout(false);
            detailsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pupilPictureBox).EndInit();
            generateTab.ResumeLayout(false);
            generateTab.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)qrPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl PupilTabControl;
        private TabPage listTab;
        private TabPage detailsTab;
        private TextBox searchTextBox;
        private Button addNewBtn;
        private Label label2;
        private DataGridView listGridView;
        private Button deleteBtn;
        private Button editBtn;
        private TextBox lastNameTextBox;
        private TextBox firstNameTextBox;
        private TextBox lrnTextBox;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label7;
        private TextBox sectionTextBox;
        private TextBox gradeLevelTextBox;
        private Label label9;
        private PictureBox pupilPictureBox;
        private TextBox guardianTextBox;
        private Label label8;
        private Button cancelBtn;
        private Button saveBtn;
        private TabPage generateTab;
        private Button generateBtn;
        private Button saveCodeBtn;
        private Panel panel2;
        private PictureBox qrPictureBox;
        private Button goGenBtn;
        private Button uploadBtn;
        private Button refreshBtn;
        private Label lrnLbl;
        private Label lastNameLbl;
        private Label firstNameLbl;
        private Label label10;
        private Panel panel3;
        private Button cancelGenerateBtn;
    }
}