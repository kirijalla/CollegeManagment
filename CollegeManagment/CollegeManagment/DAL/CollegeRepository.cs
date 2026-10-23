using CollegeManagment.Model;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CollegeManagment.DAL
{
    internal class CollegeRepository : ICollegeRepository
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["WhisDB"].ConnectionString;
        private AplicantsItem APMapToItem(DataRow row)
        {
            AplicantsItem item = new AplicantsItem();
            item.ApplicatId = Convert.ToInt32(row["ApplicatId"]);
            item.FirstName = row["FirstName"].ToString();
            item.LastName = row["LastName"].ToString();
            item.Email = row["Email"].ToString();

            return item;
        }
        private WebinarsItem WEBMapToItem(DataRow row)
        {
            WebinarsItem item = new WebinarsItem();
            item.WebinarCode = row["WebinarCode"].ToString();
            item.WebinarName = row["WebinarName"].ToString();
            item.TotalHour = Convert.ToDecimal(row["TotalHour"]);
            item.StartingDate = Convert.ToDateTime(row["StartingDate"]);
            item.EndingDate = Convert.ToDateTime(row["EndingDate"]);

            return item;
        }

        //APPLICANTS
        public void APAdd(AplicantsItem item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            SqlConnection conn = new SqlConnection(_connectionString);

            string selectQuery = @"SELECT * FROM Applicants";

            SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, conn);

            string insertQuery = @"INSERT INTO Applicants
                          (ApplicatId, FirstName, LastName, Email)
                           VALUES
                          (@ApplicatId, @FirstName, @LastName, @Email)";

            adapter.InsertCommand = new SqlCommand(insertQuery, conn);

            adapter.InsertCommand.Parameters.Add(
                "@ApplicatId",
                SqlDbType.Int,
                0,
                "ApplicatId");

            adapter.InsertCommand.Parameters.Add(
                "@FirstName",
                SqlDbType.NVarChar,
                50,
                "FirstName");

            adapter.InsertCommand.Parameters.Add(
                "@LastName",
                SqlDbType.NVarChar,
                50,
                "LastName");

            adapter.InsertCommand.Parameters.Add(
                "@Email",
                SqlDbType.NVarChar,
                100,
                "Email");

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            DataRow row = dt.NewRow();

            row["ApplicatId"] = item.ApplicatId;
            row["FirstName"] = item.FirstName;
            row["LastName"] = item.LastName;
            row["Email"] = item.Email;

            dt.Rows.Add(row);

            adapter.Update(dt);
        }

        public void APDelete(int Aid)
        {
            throw new NotImplementedException();
        }

        public List<AplicantsItem> APGetAll()
        {
            throw new NotImplementedException();
        }

        public AplicantsItem APGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void APUpdate(AplicantsItem item)
        {
            throw new NotImplementedException();
        }
        // APPLICANT WEBINARS
        public void APWEBAdd(ApplicantsWebinarsItem item)
        {
            throw new NotImplementedException();
        }
        // WEBINARS
        public void WEBAdd(WebinarsItem item)
        {
            throw new NotImplementedException();
        }

        public void WEBDelete(int id)
        {
            throw new NotImplementedException();
        }

        public List<WebinarsItem> WEBGetAll()
        {
            throw new NotImplementedException();
        }

        public WebinarsItem WEBGetById(string id)
        {
            throw new NotImplementedException();
        }

        public void WEBUpdate(WebinarsItem item)
        {
            throw new NotImplementedException();
        }
    }
}
