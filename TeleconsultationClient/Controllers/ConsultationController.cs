using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TeleconsultationClient.Controllers
{
    public class ConsultationController : Controller
    {
        // GET: Consultation
        string conString = "Data Source=CHECKUPSSERVER;Initial Catalog =ZidiDb; User Id=zidiadmin;Password=L90ns!@123";
        public static string DbConn = "Data Source=CHECKUPSSERVER;Initial Catalog =ZidiDb; User Id=zidiadmin;Password=L90ns!@123";

        public ActionResult Index()
        {
            return View();
        }
        public JsonResult BookAppointment(ConsultationModel consul)
        {
            var responseMessage = new ResponseMessage();
            string insertQry = "Insert into () values()";
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand command = new SqlCommand(insertQry, con);
            int numResult = command.ExecuteNonQuery();
            con.Close();
            if (numResult > 0)
            {
                responseMessage.Status = "200";
                responseMessage.Message = "success";
                return Json(responseMessage, JsonRequestBehavior.AllowGet);
            }
            else
            {
                responseMessage.Status = "500";
                responseMessage.Message = "Something went wrong";
                return Json(responseMessage, JsonRequestBehavior.AllowGet);
            }

        }
    }

    public class ConsultationModel
    {
        public string FirstName { get; set; }
    }
}