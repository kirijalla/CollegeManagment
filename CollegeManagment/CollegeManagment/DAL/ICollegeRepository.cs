using CollegeManagment.Model;
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
    internal interface ICollegeRepository
    {
        // APLICANTS
        List<AplicantsItem> APGetAll();
        AplicantsItem APGetById(int id);
        void APAdd(AplicantsItem item);
        void APUpdate(AplicantsItem item);
        void APDelete(int Aid);

        // WEBINAR
        List<WebinarsItem> WEBGetAll();
        WebinarsItem WEBGetById(string id);
        void WEBAdd(WebinarsItem item);
        void WEBUpdate(WebinarsItem item);
        void WEBDelete(string id);

        // APLICANTWEBINARS
        void APWEBAdd(ApplicantsWebinarsItem item);
    }
}
