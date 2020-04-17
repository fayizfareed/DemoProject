using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;

namespace DemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetDataController : ControllerBase
    {
        private string constring = @"Data Source=FAYIZFAREED;Initial Catalog=Demo;User ID=sa;Password=cool_nothing";
        //private string constring = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Demo;Integrated Security=True";
        [HttpGet]
        public string Get()
        {
            SqlConnection cnn = new SqlConnection(constring);
            string sql = "select count(rxj.status) as [Number Of Status], rxj.status as [Status],rxr.name as [RoomType]  from rx_job rxj inner join rx_roomtype rxr on rxj.roomtypeid = rxr.id group by rxj.status, rxr.name";

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
            string json = JsonConvert.SerializeObject(ds, Formatting.Indented);
            return json;
        }
    }
}
