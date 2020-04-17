using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DemoProject.Models;
using System.Data.SqlClient;
using System.Data;

namespace DemoProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private string constring = @"Data Source=FAYIZFAREED;Initial Catalog=Demo;User ID=sa;Password=cool_nothing";
        //private string constring = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Demo;Integrated Security=True";
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            DataSet ds = getjob();
            return View(ds.Tables[0]);
        }
        private DataSet getjob()
        {
            SqlConnection cnn = new SqlConnection(constring);
            string sql = "select rxj.id as [Job ID],rxj.name as [Name],rxj.floor as [Floor],rxj.status as [Status],rxr.name as [Room Type],rxj.id  from rx_job rxj inner join rx_roomtype rxr on rxj.roomtypeid = rxr.id";

            DataSet ds = new DataSet();
            try
            {
                cnn.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql, cnn);
                dap.Fill(ds);
                cnn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
        public IActionResult Update(string id)
        {
            MakeComplete(id);
            DataSet ds = getjob();
            return View(ds.Tables[0]);
        }
        private void MakeComplete(string id)
        {
            SqlConnection conn = new SqlConnection(constring);
            try
            {
                conn.Open(); 
                DataSet ds = new DataSet();
                string sql = "select * from rx_job where id ='" + id + "' and (status = 'In Progress' or status = 'Delayed')";
                SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
                dap.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    string updateQuery = "update rx_job set Status = 'Completed' where id = '" + id + "'";
                    SqlCommand com = new SqlCommand(updateQuery, conn);
                    int result = com.ExecuteNonQuery();
                } 
                conn.Close();
            }
            catch (Exception ex4)
            {
            }
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
