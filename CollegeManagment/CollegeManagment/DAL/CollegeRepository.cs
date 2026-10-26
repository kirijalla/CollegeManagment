using CollegeManagment.Model;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
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

            adapter.InsertCommand.Parameters.Add("@ApplicatId",SqlDbType.Int,0,"ApplicatId");

            adapter.InsertCommand.Parameters.Add("@FirstName",SqlDbType.NVarChar,50,"FirstName");

            adapter.InsertCommand.Parameters.Add("@LastName",SqlDbType.NVarChar,50,"LastName");

            adapter.InsertCommand.Parameters.Add("@Email",SqlDbType.NVarChar,100,"Email");

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
            SqlConnection conn = new SqlConnection(_connectionString);

            string selectQuery = @"SELECT * FROM Applicants";
            SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, conn);

            string deleteQuery = @"DELETE FROM Applicants
                           WHERE ApplicatId = @ApplicatId";

            adapter.DeleteCommand = new SqlCommand(deleteQuery, conn);
            adapter.DeleteCommand.Parameters.Add("@ApplicatId",SqlDbType.Int,0,"ApplicatId");

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            DataRow[] rows = dt.Select("ApplicatId = " + Aid);

            if (rows.Length == 0)
            {
                throw new Exception("Applicant not found");
            }

            rows[0].Delete();

            adapter.Update(dt);
        }

        public List<AplicantsItem> APGetAll()
        {
            SqlConnection conn = new SqlConnection(_connectionString);

            string query = "SELECT * FROM dbo.Applicants";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            List<AplicantsItem> items = new List<AplicantsItem>();
            foreach (DataRow row in dt.Rows)
            {
                items.Add(APMapToItem(row));
            }

            return items;
        }

        public AplicantsItem APGetById(int id)
        {
            SqlConnection conn = new SqlConnection(_connectionString);

            string query = "SELECT * FROM Applicants WHERE ApplicatId = @id";

            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

            adapter.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                return APMapToItem(dt.Rows[0]);
            }
        }

        public void APUpdate(AplicantsItem item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            SqlConnection conn = new SqlConnection(_connectionString);

            string selectQuery = @"SELECT * FROM Applicants";

            SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, conn);

            string updateQuery = @"UPDATE Applicants
                           SET FirstName = @FirstName,
                               LastName = @LastName,
                               Email = @Email
                           WHERE ApplicatId = @ApplicatId";

            adapter.UpdateCommand = new SqlCommand(updateQuery, conn);

            adapter.UpdateCommand.Parameters.Add("@FirstName", SqlDbType.NVarChar, 50, "FirstName");
            adapter.UpdateCommand.Parameters.Add("@LastName", SqlDbType.NVarChar, 50, "LastName");
            adapter.UpdateCommand.Parameters.Add("@Email", SqlDbType.NVarChar, 100, "Email");
            adapter.UpdateCommand.Parameters.Add("@ApplicatId", SqlDbType.Int, 0, "ApplicatId");

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            DataRow[] rows = dt.Select("ApplicatId = " + item.ApplicatId);

            if (rows.Length == 0)
                throw new Exception("Applicant not found");

            DataRow existingRow = rows[0];

            existingRow["FirstName"] = item.FirstName;
            existingRow["LastName"] = item.LastName;
            existingRow["Email"] = item.Email;

            adapter.Update(dt);
        }
        // APPLICANT WEBINARS
        public void APWEBAdd(ApplicantsWebinarsItem item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            SqlConnection conn = new SqlConnection(_connectionString);

            string selectQuery = "SELECT * FROM ApplicantWebinars";

            SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, conn);

            string insertQuery = @"INSERT INTO ApplicantWebinars
                          (ApplicantId, WebinarCode, RegistrationDate)
                           VALUES
                          (@ApplicantId, @WebinarCode, @RegistrationDate)";

            adapter.InsertCommand = new SqlCommand(insertQuery, conn);

            adapter.InsertCommand.Parameters.Add("@ApplicantId", SqlDbType.Int, 0, "ApplicantId");
            adapter.InsertCommand.Parameters.Add("@WebinarCode", SqlDbType.NVarChar, 10, "WebinarCode");
            adapter.InsertCommand.Parameters.Add("@RegistrationDate", SqlDbType.DateTime, 0, "RegistrationDate");

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            DataRow row = dt.NewRow();

            row["ApplicantId"] = item.ApplicantId;
            row["WebinarCode"] = item.WebinarCode;
            row["RegistrationDate"] = item.RegistrationDate;

            dt.Rows.Add(row);

            adapter.Update(dt);
        }

        
        // WEBINARS
        public void WEBAdd(WebinarsItem item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            SqlConnection conn = new SqlConnection(_connectionString);

            string selectQuery = "SELECT * FROM Webinars";

            SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, conn);

            string insertQuery = @"INSERT INTO Webinars
                          (WebinarCode, WebinarName, TotalHour, StartingDate, EndingDate)
                           VALUES
                          (@WebinarCode, @WebinarName, @TotalHour, @StartingDate, @EndingDate)";

            adapter.InsertCommand = new SqlCommand(insertQuery, conn);

            adapter.InsertCommand.Parameters.Add("@WebinarCode", SqlDbType.NVarChar, 10, "WebinarCode");
            adapter.InsertCommand.Parameters.Add("@WebinarName", SqlDbType.NVarChar, 50, "WebinarName");
            adapter.InsertCommand.Parameters.Add("@TotalHour", SqlDbType.Decimal, 0, "TotalHour");
            adapter.InsertCommand.Parameters.Add("@StartingDate", SqlDbType.DateTime, 0, "StartingDate");
            adapter.InsertCommand.Parameters.Add("@EndingDate", SqlDbType.DateTime, 0, "EndingDate");

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            DataRow row = dt.NewRow();

            row["WebinarCode"] = item.WebinarCode;
            row["WebinarName"] = item.WebinarName;
            row["TotalHour"] = item.TotalHour;
            row["StartingDate"] = item.StartingDate;
            row["EndingDate"] = item.EndingDate;

            dt.Rows.Add(row);

            adapter.Update(dt);
        
        }

        public void WEBDelete(string WEBid)
        {
            SqlConnection conn = new SqlConnection(_connectionString);

            string selectQuery = @"SELECT * FROM Webinars";
            SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, conn);

            string deleteQuery = @"DELETE FROM Webinars
                           WHERE WebinarCode = @WebinarCode";

            adapter.DeleteCommand = new SqlCommand(deleteQuery, conn);
            adapter.DeleteCommand.Parameters.Add(
                "@WebinarCode",
                SqlDbType.NVarChar,
                10,
                "WebinarCode");

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            DataRow[] rows = dt.Select(
                "WebinarCode = '" + WEBid + "'");

            if (rows.Length == 0)
            {
                throw new Exception("Webinar not found");
            }

            rows[0].Delete();

            adapter.Update(dt);
        }

        public List<WebinarsItem> WEBGetAll()
        {
            SqlConnection conn = new SqlConnection(_connectionString);

            string query = "SELECT * FROM dbo.Webinars";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            List<WebinarsItem> items = new List<WebinarsItem>();
            foreach (DataRow row in dt.Rows)
            {
                items.Add(WEBMapToItem(row));
            }

            return items;
        }

        public WebinarsItem WEBGetById(string id)
        {
            SqlConnection conn = new SqlConnection(_connectionString);

            string query = "SELECT * FROM Webinars WHERE WebinarCode = @id";

            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

            adapter.SelectCommand.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                return WEBMapToItem(dt.Rows[0]);
            }
        }

        public void WEBUpdate(WebinarsItem item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            SqlConnection conn = new SqlConnection(_connectionString);

            string selectQuery = @"SELECT * FROM Webinars";

            SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, conn);

            string updateQuery = @"UPDATE Webinars
                           SET WebinarName = @WebinarName,
                               TotalHour = @TotalHour,
                               StartingDate = @StartingDate,
                               EndingDate = @EndingDate
                           WHERE WebinarCode = @WebinarCode";

            adapter.UpdateCommand = new SqlCommand(updateQuery, conn);

            adapter.UpdateCommand.Parameters.Add("@WebinarName", SqlDbType.NVarChar, 50, "WebinarName");
            adapter.UpdateCommand.Parameters.Add("@TotalHour", SqlDbType.Decimal, 0, "TotalHour");
            adapter.UpdateCommand.Parameters.Add("@StartingDate", SqlDbType.DateTime, 0, "StartingDate");
            adapter.UpdateCommand.Parameters.Add("@EndingDate", SqlDbType.DateTime, 0, "EndingDate");
            adapter.UpdateCommand.Parameters.Add("@WebinarCode", SqlDbType.NVarChar, 10, "WebinarCode");

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            DataRow[] rows =
                dt.Select("WebinarCode = '" + item.WebinarCode + "'");

            if (rows.Length == 0)
                throw new Exception("Webinar not found");

            DataRow existingRow = rows[0];

            existingRow["WebinarName"] = item.WebinarName;
            existingRow["TotalHour"] = item.TotalHour;
            existingRow["StartingDate"] = item.StartingDate;
            existingRow["EndingDate"] = item.EndingDate;

            adapter.Update(dt);
        }
    }
}
