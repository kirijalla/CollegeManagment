using CollegeManagment.DAL;
using CollegeManagment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagment.BLL
{
    
        public class CollegeManagementService
        {
            private readonly ICollegeRepository _repository;

            public CollegeManagementService()
            {
                _repository = new CollegeRepository();
            }

            // ================= APPLICANTS =================

            public List<AplicantsItem> GetAllApplicants()
            {
                return _repository.APGetAll();
            }

            public AplicantsItem GetApplicantById(int id)
            {
                return _repository.APGetById(id);
            }

            public void AddApplicant(AplicantsItem applicant)
            {
                ValidateApplicant(applicant);

                // if exists: check if another applicant already has this email
                foreach (AplicantsItem a in _repository.APGetAll())
                {
                    if (a.Email == applicant.Email)
                        throw new Exception("This applicant already exists.");
                }

                _repository.APAdd(applicant);
            }

            public void EditApplicant(AplicantsItem applicant)
            {
                if (applicant.ApplicatId <= 0) throw new Exception("Select an applicant first.");
                ValidateApplicant(applicant);
                _repository.APUpdate(applicant);
            }

            public void DeleteApplicant(int id)
            {
                if (id <= 0) throw new Exception("Select an applicant first.");
                _repository.APDelete(id);
            }

            private void ValidateApplicant(AplicantsItem applicant)
            {
                if (applicant == null) throw new Exception("Applicant is empty.");
                if (applicant.FirstName == "") throw new Exception("First name is required.");
                if (applicant.LastName == "") throw new Exception("Last name is required.");
                if (applicant.Email == "") throw new Exception("Email is required.");
            }

            // ================= WEBINARS =================

            public List<WebinarsItem> GetAllWebinars()
            {
                return _repository.WEBGetAll();
            }

            public WebinarsItem GetWebinarByCode(string code)
            {
                return _repository.WEBGetById(code);
            }

            public void AddWebinar(WebinarsItem webinar)
            {
                ValidateWebinar(webinar);

                // if exists: GetWebinarsByCode returns null when the code is NOT found
                if (_repository.WEBGetById(webinar.WebinarCode) != null)
                    throw new Exception("This webinar code already exists.");

                _repository.WEBAdd(webinar);
            }

            // Edit: change the webinar information
            public void EditWebinar(WebinarsItem webinar)
            {
                ValidateWebinar(webinar);
                _repository.WEBUpdate(webinar);
            }

            // Update: change only the starting and ending dates
            public void UpdateWebinarDates(string code, DateTime startingDate, DateTime endingDate)
            {
                WebinarsItem webinar = _repository.WEBGetById(code);
                if (webinar == null) throw new Exception("Select a webinar first.");

                webinar.StartingDate = startingDate;
                webinar.EndingDate = endingDate;

                ValidateWebinar(webinar);
                _repository.WEBUpdate(webinar);
            }

            public void DeleteWebinar(string code)
            {
                if (code == "") throw new Exception("Select a webinar first.");
                _repository.WEBDelete(code);
            }

            private void ValidateWebinar(WebinarsItem webinar)
            {
                if (webinar == null) throw new Exception("Webinar is empty.");
                if (webinar.WebinarCode == "") throw new Exception("Webinar code is required.");
                if (webinar.WebinarName == "") throw new Exception("Webinar name is required.");
                if (webinar.TotalHour <= 0) throw new Exception("Total hours must be greater than 0.");
                if (webinar.EndingDate < webinar.StartingDate)
                    throw new Exception("Ending date can't be before the starting date.");
            }

            // ================= REGISTRATION =================
            public List<ApplicantsWebinarsItem> GetAllRegistrations()
            {
                return _repository.APWEBGetAll();
            }
            public void Register(ApplicantsWebinarsItem registration)
            {
                if (registration == null) throw new Exception("Registration is empty.");

                // both must exist before registering
                if (_repository.APGetById(registration.ApplicantId) == null)
                    throw new Exception("Applicant not found.");
                if (_repository.WEBGetById(registration.WebinarCode) == null)
                    throw new Exception("Webinar not found.");

                registration.RegistrationDate = DateTime.Now;
                _repository.APWEBAdd(registration);
            }
        }
    }

