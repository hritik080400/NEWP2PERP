using P2PLibray.GRN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace P2PERP.Controllers
{
    public class GRNController : Controller
    {
        BALGRN balGRN = new BALGRN();
        // GET: GRNP2P
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ReturnGoods()
        {
            return View();
        }

        [HttpGet]
        public async Task<JsonResult> getReturnGood()
        {
            SqlDataReader dr = await balGRN.GetReturnGoods();

            List<ReturnGoodsClass> ReturnGoodsList = new List<ReturnGoodsClass>();

            for (int i = 0; i < dr.FieldCount; i++)
            {
                System.Diagnostics.Debug.WriteLine("Column: " + dr.GetName(i));
            }

            if (dr.HasRows)
            {
                while (await dr.ReadAsync())
                {
                    ReturnGoodsClass ReturnGoods = new ReturnGoodsClass
                    {
                        GoodsReturnId = Convert.ToInt32(dr["GoodsReturnId"]),
                        GoodsReturnCode = dr["GoodsReturnCode"].ToString(),
                        FailedQCCode = dr["FailedQCCode"].ToString(),
                        StatusId = Convert.ToInt32(dr["StatusId"]),
                        TransporterName = dr["TransporterName"].ToString(),
                        TransportContactNo = dr["TransportContactNo"].ToString(),
                        VehicleTypeId = Convert.ToInt32(dr["VehicleTypeId"]),
                        VehicleNo = dr["VehicleNo"].ToString(),
                        AddedDate = Convert.ToDateTime(dr["AddedDate"]),
                        AddedBy = dr["AddedBy"].ToString()
                    };


                    ReturnGoodsList.Add(ReturnGoods);
                }
            }

            dr.Close(); 

            return Json(new { data = ReturnGoodsList }, JsonRequestBehavior.AllowGet);
        }

    }
}