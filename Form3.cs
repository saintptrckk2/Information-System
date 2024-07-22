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

namespace admin
{



    public partial class Form3 : Form
    {
        private string _LRN;
        private string _Firstname;
        private string _Lastname;
        private string _GradeLevel;
        private string _Section;
        private string _ContactNumber;
        private byte[] _Picture;

        public Form3(string LRN, string Firstname, string Lastname, string GradeLevel, string Section, string ContactNumber)
        {
            InitializeComponent();

            _LRN = LRN;
            _Firstname = Firstname;
            _Lastname = Lastname;
            _GradeLevel = GradeLevel;
            _Section = Section;
            _ContactNumber = ContactNumber;

            lrnTextBox.Text = LRN;
            firstNameTextBox.Text = Firstname;
            lastNameTextBox.Text = Lastname;
            gradeLevelTextBox.Text = GradeLevel;
            sectionTextBox.Text = Section;
            guardianTextBox.Text = ContactNumber;

            getPhoto();

        }

        private void lrnTextBox_TextChanged(object sender, EventArgs e)
        {

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

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string newLRN = lrnTextBox.Text;
            string newFirstname = firstNameTextBox.Text;
            string newLastname = lastNameTextBox.Text;
            string newGradeLevel = gradeLevelTextBox.Text;
            string newSection = sectionTextBox.Text;
            string newContactNumber = guardianTextBox.Text;

            updatePupilData(newLRN, newFirstname, newLastname, newGradeLevel, newSection, newContactNumber, _Picture);

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pupilPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pupilPictureBox.Image = Image.FromFile(openFileDialog.FileName);
                pupilPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    pupilPictureBox.Image.Save(memoryStream, pupilPictureBox.Image.RawFormat);
                    _Picture = memoryStream.ToArray();
                }
            }

            
        }

        private void getPhoto()
        {
            string connectionString = "Data Source=DESKTOP-AN3VUIS\\SQLEXPRESS;Initial Catalog=Baluarte;Integrated Security=SSPI;";
            string query = "SELECT Picture from Pupils WHERE LRN = @LRN";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LRN", _LRN);

                    var result = command.ExecuteScalar();
                    
                    if(result != DBNull.Value && result != null)
                    {
                        _Picture = (byte[])result;

                        using (MemoryStream memoryStream = new MemoryStream(_Picture))
                        {
                            pupilPictureBox.Image = Image.FromStream(memoryStream);
                            pupilPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }
                    else
                    {
                        pupilPictureBox.Image = null;
                    }
                    
                }
            }
        }

        private void updatePupilData(string newLRN, string newFirstname, string newLastname, string newGradeLevel, string newSection, string newContactNumber, byte[] _Picture)
        {
            string connectionString = "Data Source=DESKTOP-AN3VUIS\\SQLEXPRESS;Initial Catalog=Baluarte;Integrated Security=SSPI;";
            string query = "UPDATE Pupils SET LRN = @LRN, Firstname = @Firstname, Lastname = @Lastname,  GradeLevel = @GradeLevel, Section =@Section, ContactNumber = @ContactNumber, Picture = @Picture";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LRN", newLRN);
                    command.Parameters.AddWithValue("@Firstname", newFirstname);
                    command.Parameters.AddWithValue("@Lastname", newLastname);
                    command.Parameters.AddWithValue("@GradeLevel", newGradeLevel);
                    command.Parameters.AddWithValue("@Section", newSection);
                    command.Parameters.AddWithValue("@ContactNumber", newContactNumber);
                    command.Parameters.AddWithValue("@Picture", _Picture);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Updated Successfully!");
                }
            }
        }
    }
}
