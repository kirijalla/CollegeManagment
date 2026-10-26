using CollegeManagment.BLL;
using CollegeManagment.Model;
using System;
using System.Windows.Forms;

namespace CollegeManagmentAryanPractice
{
    public partial class Form1 : Form
    {
        // the form only talks to the BLL
        private CollegeManagementService _service = new CollegeManagementService();

        private int selectedApplicantId = -1;      // -1 = no applicant selected
        private string selectedWebinarCode = "";   // "" = no webinar selected

        public Form1()
        {
            InitializeComponent();
            LoadApplicants();
            LoadWebinars();
            LoadRegistrations();
        }

        // ================= LOAD GRIDS =================

        private void LoadApplicants()
        {
            try
            {
                dataGridViewApplicant.DataSource = null;
                dataGridViewApplicant.DataSource = _service.GetAllApplicants();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading applicants: " + ex.Message);
            }
        }

        private void LoadWebinars()
        {
            try
            {
                dataGridViewWebinar.DataSource = null;
                dataGridViewWebinar.DataSource = _service.GetAllWebinars();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading webinars: " + ex.Message);
            }
        }
        private void LoadRegistrations()
        {
            try
            {
                dataGridViewRegistrationList.DataSource = null;
                dataGridViewRegistrationList.DataSource = _service.GetAllRegistrations();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading registrations: " + ex.Message);
            }
        }

        // ================= APPLICANT TAB =================

        private void buttonAddApplicants_Click(object sender, EventArgs e)
        {
            try
            {
                AplicantsItem applicant = new AplicantsItem();
                applicant.FirstName = textBoxFirstName.Text;
                applicant.LastName = textBoxLastName.Text;
                applicant.Email = textBoxEmail.Text;

                _service.AddApplicant(applicant);
                LoadApplicants();
                ClearApplicantBoxes();
                MessageBox.Show("Applicant added.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }







        private void buttonEdit_Click(object sender, EventArgs e)
        {
            
                try
                {
                    AplicantsItem applicant = new AplicantsItem();
                    applicant.ApplicatId = selectedApplicantId;   // which row to change
                    applicant.FirstName = textBoxFirstName.Text;
                    applicant.LastName = textBoxLastName.Text;
                    applicant.Email = textBoxEmail.Text;

                    _service.EditApplicant(applicant);
                    LoadApplicants();
                    ClearApplicantBoxes();
                    MessageBox.Show("Applicant updated.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {

            try
            {
                _service.DeleteApplicant(selectedApplicantId);
                LoadApplicants();
                ClearApplicantBoxes();
                MessageBox.Show("Applicant deleted.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        

        private void dataGridViewApplicant_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)   // -1 is the header row
            {
                DataGridViewRow row = dataGridViewApplicant.Rows[e.RowIndex];

                selectedApplicantId = Convert.ToInt32(row.Cells["ApplicantId"].Value);
                textBoxFirstName.Text = row.Cells["FirstName"].Value.ToString();
                textBoxLastName.Text = row.Cells["LastName"].Value.ToString();
                textBoxEmail.Text = row.Cells["Email"].Value.ToString();
            }
        }
        
           
        

        private void ClearApplicantBoxes()
        {
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxEmail.Clear();
            selectedApplicantId = -1;
        }

        // ================= WEBINAR TAB =================

        private void btnAddWebinar_Click(object sender, EventArgs e)
        {
            try
            {
                WebinarsItem webinar = new WebinarsItem();
                webinar.WebinarCode = textBoxWebinarCode.Text;
                webinar.WebinarName = textBoxWebinarName.Text;
                webinar.TotalHour = Convert.ToInt32(textBoxTotalHour.Text);
                webinar.StartingDate = dateTimePicker1.Value;
                webinar.EndingDate = dateTimePicker2.Value;

                _service.AddWebinar(webinar);
                LoadWebinars();
                ClearWebinarBoxes();
                MessageBox.Show("Webinar added.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Total hours must be a number.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddWebinar_Click_1(object sender, EventArgs e)
        {
            try
            {
                WebinarsItem webinar = new WebinarsItem();
                webinar.WebinarCode = selectedWebinarCode;   // the code identifies the row
                webinar.WebinarName = textBoxWebinarName.Text;
                webinar.TotalHour = Convert.ToInt32(textBoxTotalHour.Text);
                webinar.StartingDate = dateTimePicker1.Value;
                webinar.EndingDate = dateTimePicker2.Value;

                _service.EditWebinar(webinar);
                LoadWebinars();
                ClearWebinarBoxes();
                MessageBox.Show("Webinar updated.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Total hours must be a number.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        // Update = change only the dates
        private void buttonUpdateWebinar_Click(object sender, EventArgs e)
        {
            try
            {
                _service.UpdateWebinarDates(selectedWebinarCode, dateTimePicker1.Value, dateTimePicker2.Value);
                LoadWebinars();
                ClearWebinarBoxes();
                MessageBox.Show("Webinar dates updated.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDeleteWebinar_Click(object sender, EventArgs e)
        {
            try
            {
                _service.DeleteWebinar(selectedWebinarCode);
                LoadWebinars();
                ClearWebinarBoxes();
                MessageBox.Show("Webinar deleted.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewWebinar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewWebinar.Rows[e.RowIndex];

                selectedWebinarCode = row.Cells["WebinarCode"].Value.ToString();
                textBoxWebinarCode.Text = selectedWebinarCode;
                textBoxWebinarName.Text = row.Cells["WebinarName"].Value.ToString();
                textBoxTotalHour.Text = row.Cells["TotalHour"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["StartingDate"].Value);
                dateTimePicker2.Value = Convert.ToDateTime(row.Cells["EndingDate"].Value);
            }
        }
        
           
       
        
            
        

        private void ClearWebinarBoxes()
        {
            textBoxWebinarCode.Clear();
            textBoxWebinarName.Clear();
            textBoxTotalHour.Clear();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
            selectedWebinarCode = "";
        }

        // ================= REGISTRATION TAB =================

        private void buttonGetApplicantId_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxApplicantId.Text);
                AplicantsItem applicant = _service.GetApplicantById(id);

                if (applicant == null)
                {
                    MessageBox.Show("Applicant not found.");
                    return;
                }
                labelApplicantInfo.Text = "Name: " + applicant.FirstName + " " + applicant.LastName +
                        Environment.NewLine + "Email: " + applicant.Email;

                textBoxApplicantId.Text = applicant.FirstName;
                textBoxLastName.Text = applicant.LastName;
                textBoxEmail.Text = applicant.Email;
            }
            catch (FormatException)
            {
                MessageBox.Show("Applicant ID must be a number.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonGetWebinarInformation_Click(object sender, EventArgs e)
        {
            try
            {
               
                WebinarsItem webinar = _service.GetWebinarByCode(textBoxWebinar.Text);

                if (webinar == null)
                {
                    MessageBox.Show("Webinar not found.");
                    return;
                }
                label5.Text = "Name: " + webinar.WebinarName + Environment.NewLine +
                      "Hours: " + webinar.TotalHour + Environment.NewLine +
                      "From " + webinar.StartingDate.ToShortDateString() +
                      " to " + webinar.EndingDate.ToShortDateString();

                textBoxWebinarName.Text = webinar.WebinarName;
                textBoxTotalHour.Text = webinar.TotalHour.ToString();
                dateTimePicker1.Text = webinar.StartingDate.ToShortDateString();
                dateTimePicker2.Text = webinar.EndingDate.ToShortDateString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)   
        {
            try
            {
                ApplicantsWebinarsItem registration = new ApplicantsWebinarsItem();
                registration.ApplicantId = Convert.ToInt32(textBoxApplicantId.Text);
                registration.WebinarCode = textBoxWebinar.Text;

                _service.Register(registration);
                LoadRegistrations();
                MessageBox.Show("Applicant registered for the webinar.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Applicant ID must be a number.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}