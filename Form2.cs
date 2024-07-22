using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace admin
{
    public partial class Form2 : Form
    {
        private Bitmap qrCodeImage;
       

        public Form2()
        {
            InitializeComponent();
            LoadDataGridView(searchTextBox.Text);
        }

       
      

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadDataGridView(searchTextBox.Text);

        }

        private void addNewBtn_Click(object sender, EventArgs e)
        {
            PupilTabControl.SelectedIndex = 1;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            GoToUpdateForm();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult decision = MessageBox.Show("are you sureyou want to delete?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (decision == DialogResult.Yes)
            {
                if (listGridView.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in listGridView.SelectedRows)
                    {
                        if (row.Cells["LRN"] != null && row.Cells["LRN"].Value != null)
                        {
                            int LRN = Convert.ToInt32(row.Cells["LRN"].Value);
                            DeleteSelectedRow(LRN);
                        }
                        listGridView.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("Select pupil to delete");
            }
        }
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadDataGridView(searchTextBox.Text);
        }

        private void lrnTextBox_TextChanged(object sender, EventArgs e)
        {
            lrnTextBox.MaxLength = 9;
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void gradeLevelTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sectionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void guardianTextBox_TextChanged(object sender, EventArgs e)
        {
            guardianTextBox.MaxLength = 11;
        }
        private void lrnGenerateTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void generateBtn_Click(object sender, EventArgs e)
        {
            
            string data = lrnLbl.Text;

            generateQR(data);
        }

        private void saveCodeBtn_Click(object sender, EventArgs e)
        {
            saveQR();
        }

        private void qrPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void pupilPictureBox_Click(object sender, EventArgs e)
        {

        }
        private void listGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void uploadBtn_Click(object sender, EventArgs e)
        {
            UploadImage();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            createStudent();
            LoadDataGridView(searchTextBox.Text);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            lrnTextBox.Text = string.Empty;
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            gradeLevelTextBox.Text = string.Empty;
            sectionTextBox.Text = string.Empty;
            guardianTextBox.Text = string.Empty;
            pupilPictureBox.Image = null;

        }
        private void goGenBtn_Click(object sender, EventArgs e)
        {
            
            if (listGridView.SelectedRows.Count > 0)
            {
                int selectedRowIndex = listGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = listGridView.Rows[selectedRowIndex];

                string LRN = Convert.ToString(selectedRow.Cells["LRN"].Value);
                string Firstname = Convert.ToString(selectedRow.Cells["Firstname"].Value);
                string Lastname = Convert.ToString(selectedRow.Cells["Lastname"].Value);

                GenerateQRCode(LRN, Firstname, Lastname);
                PupilTabControl.SelectedIndex = 2;
            }






        }
        //QR Code Generator
        private void generateQR(string data)
        {
            if (!string.IsNullOrEmpty(data))
            {
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(12);

                qrPictureBox.Image = qrCodeImage;

            }
            else
            {
                MessageBox.Show
                    (
                    "Please Enter a student ID.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );

            }
        }

        //Save QR Method
        private void saveQR()
        {
            if (qrPictureBox.Image != null)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PNG Image|*.png";
                    saveFileDialog.Title = "Save QR Code";
                    saveFileDialog.FileName = lastNameLbl.Text + ", " + firstNameLbl.Text + " QR.png";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        qrPictureBox.Image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                        MessageBox.Show("QR Code saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        firstNameLbl.Text = string.Empty;
                        lastNameLbl.Text = string.Empty;
                        lrnLbl.Text = string.Empty;

                        PupilTabControl.SelectedIndex = 0;
                    }
                }
            }
            else
            {
                MessageBox.Show("No QR Code to save. Please generate one first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Create Student Method
        private void createStudent()
        {
            string connectionString = "Data Source=DESKTOP-AN3VUIS\\SQLEXPRESS;Initial Catalog=Baluarte;Integrated Security=SSPI;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    int convertedGradeLevel = Convert.ToInt32(gradeLevelTextBox.Text);
                    //Upload Pupil Details Query
                    string query = "INSERT INTO Pupils (LRN, Firstname, Lastname, GradeLevel, Section, ContactNumber, Picture) VALUES (@LRN, @FirstName, @Lastname, @GradeLevel, @Section, @ContactNumber, @Picture)";
                    SqlCommand command = new SqlCommand(query, connection);
                    if (convertedGradeLevel > 0 && convertedGradeLevel < 7)
                    {
                        Convert.ToString(gradeLevelTextBox.Text);
                        command.Parameters.AddWithValue("@LRN", lrnTextBox.Text);
                        command.Parameters.AddWithValue("@Firstname", firstNameTextBox.Text);
                        command.Parameters.AddWithValue("@Lastname", lastNameTextBox.Text);
                        command.Parameters.AddWithValue("@GradeLevel", gradeLevelTextBox.Text);
                        command.Parameters.AddWithValue("@Section", sectionTextBox.Text);
                        command.Parameters.AddWithValue("@ContactNumber", guardianTextBox.Text);
                        byte[] imagesBytes = null;
                        if (!string.IsNullOrEmpty(pupilPictureBox.ImageLocation))
                        {
                            imagesBytes = File.ReadAllBytes(pupilPictureBox.ImageLocation);
                        }
                        else if (pupilPictureBox.Image != null)
                        {
                            using (MemoryStream memoryStream = new MemoryStream())
                            {
                                pupilPictureBox.Image.Save(memoryStream, pupilPictureBox.Image.RawFormat); imagesBytes = memoryStream.ToArray();
                            }
                        }
                        command.Parameters.AddWithValue("@Picture", (object)imagesBytes ?? DBNull.Value);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Pupil Successfully Created!");

                        lrnTextBox.Text = string.Empty;
                        firstNameTextBox.Text = string.Empty;
                        lastNameTextBox.Text = string.Empty;
                        gradeLevelTextBox.Text = string.Empty;
                        sectionTextBox.Text = string.Empty;
                        guardianTextBox.Text = string.Empty;
                        pupilPictureBox.Image = null;

                        PupilTabControl.SelectedIndex = 0;

                    }
                    else
                    {
                        MessageBox.Show("Invalid Grade Level");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please Complete all fields to add new pupil", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Upload Picture From File Method
        private void UploadImage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pupilPictureBox.Image = Image.FromFile(openFileDialog.FileName);
                pupilPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        //load DataGridView
        private void LoadDataGridView(string searchText)
        {
            string connectionString = "Data Source=DESKTOP-AN3VUIS\\SQLEXPRESS;Initial Catalog=Baluarte;Integrated Security=SSPI;";
            string query = "SELECT LRN, Firstname, Lastname, GradeLevel, Section, ContactNumber FROM Pupils";

            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    foreach (DataColumn col in dataTable.Columns)
                    {
                        Console.WriteLine($"{col.ColumnName}: {col.DataType}");
                    }

                    if (!string.IsNullOrEmpty(searchText))
                    {
                        string filter = string.Format("Firstname LIKE '%{0}%' OR Lastname LIKE '%{0}%' OR GradeLevel LIKE '%{0}%' OR Section LIKE '%{0}%' OR ContactNumber LIKE '%{0}%'", searchText);
                        dataTable.DefaultView.RowFilter = filter;
                    }

                    listGridView.DataSource = dataTable;
                    listGridView.Columns["LRN"].HeaderText = "LRNs";
                    listGridView.Columns["Firstname"].HeaderText = "First names";
                    listGridView.Columns["Lastname"].HeaderText = "Last names";
                    listGridView.Columns["GradeLevel"].HeaderText = "Grade Level";
                    listGridView.Columns["Section"].HeaderText = "Sections";
                    listGridView.Columns["ContactNumber"].HeaderText = "Contact Numbers";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteSelectedRow(int LRN)
        {
            string connectionString = "Data Source=DESKTOP-AN3VUIS\\SQLEXPRESS;Initial Catalog=Baluarte;Integrated Security=SSPI;";
            string query = "DELETE FROM Pupils WHERE LRN = @LRN";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@LRN", LRN);
                command.ExecuteNonQuery();
            }

        }

        private void GoToUpdateForm()
        {
            if (listGridView.SelectedCells.Count > 0)
            {
                int selectedRowIndex = listGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = listGridView.Rows[selectedRowIndex];

                string LRN = Convert.ToString(selectedRow.Cells["LRN"].Value);
                string Firstname = Convert.ToString(selectedRow.Cells["Firstname"].Value);
                string Lastname = Convert.ToString(selectedRow.Cells["Lastname"].Value);
                string GradeLevel = Convert.ToString(selectedRow.Cells["GradeLevel"].Value);
                string Section = Convert.ToString(selectedRow.Cells["Section"].Value);
                string ContactNumber = Convert.ToString(selectedRow.Cells["ContactNumber"].Value);

                Form3 form3 = new Form3(LRN, Firstname, Lastname, GradeLevel, Section, ContactNumber);
                form3.ShowDialog();
            }

        }

        private void GenerateQRCode(string LRN, string Firstname, string Lastname)
        {
            lrnLbl.Text = LRN;
            firstNameLbl.Text = Firstname;
            lastNameLbl.Text = Lastname;

        }

        private void lrnLbl_Click(object sender, EventArgs e)
        {

        }

        private void firstNameLbl_Click(object sender, EventArgs e)
        {

        }

        private void lastNameLbl_Click(object sender, EventArgs e)
        {

        }

        private void cancelGenerateBtn_Click(object sender, EventArgs e)
        {
            qrPictureBox.Image = null;
            lrnLbl.Text = string.Empty;
            firstNameLbl.Text = string.Empty;
            lastNameLbl.Text = string.Empty;

            PupilTabControl.SelectedIndex = 0;
        }

       
       
    }
}
