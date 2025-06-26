using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using SDP_EntityModels;
using System;
using System.Collections.Generic;

namespace SDP_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InboundRecordController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public InboundRecordController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        private string GetConnectionString()
        {
            return _configuration.GetConnectionString("DefaultConnection");
        }

        [HttpGet("GetAll")]
        public IActionResult GetAllInboundRecords()
        {
            var list = new List<InboundRecordModel>();

            try
            {
                using var conn = new MySqlConnection(GetConnectionString());
                conn.Open();

                string sql = "SELECT * FROM inboundrecord";

                using var cmd = new MySqlCommand(sql, conn);
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new InboundRecordModel
                    {
                        InboundRecordID = Convert.ToInt32(reader["InboundRecordID"]),
                        ProductID = Convert.ToInt32(reader["ProductID"]),
                        Quantity = Convert.ToInt32(reader["Quantity"]),
                        InboundDate = Convert.ToDateTime(reader["InboundDate"]),
                        SupplierID = Convert.ToInt32(reader["SupplierID"])
                    });
                }

                return Ok(list);
            }
            catch (Exception ex)
            {
 
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost("Add")]
        public IActionResult AddInboundRecord([FromBody] InboundRecordModel model)
        {
            if (model == null) return BadRequest("Invalid data.");

            try
            {
                using var conn = new MySqlConnection(GetConnectionString());
                conn.Open();

                string sql = @"INSERT INTO inboundrecord (ProductID, Quantity, InboundDate, SupplierID)
                               VALUES (@ProductID, @Quantity, @InboundDate, @SupplierID)";

                using var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ProductID", model.ProductID);
                cmd.Parameters.AddWithValue("@Quantity", model.Quantity);
                cmd.Parameters.AddWithValue("@InboundDate", model.InboundDate);
                cmd.Parameters.AddWithValue("@SupplierID", model.SupplierID);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0) return Ok("Insert success");
                else return BadRequest("Insert failed");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPut("Update")]
        public IActionResult UpdateInboundRecord([FromBody] InboundRecordModel model)
        {
            if (model == null || model.InboundRecordID <= 0) return BadRequest("Invalid data.");

            try
            {
                using var conn = new MySqlConnection(GetConnectionString());
                conn.Open();

                string sql = @"UPDATE inboundrecord
                               SET ProductID = @ProductID, Quantity = @Quantity, InboundDate = @InboundDate, SupplierID = @SupplierID
                               WHERE InboundRecordID = @InboundRecordID";

                using var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ProductID", model.ProductID);
                cmd.Parameters.AddWithValue("@Quantity", model.Quantity);
                cmd.Parameters.AddWithValue("@InboundDate", model.InboundDate);
                cmd.Parameters.AddWithValue("@SupplierID", model.SupplierID);
                cmd.Parameters.AddWithValue("@InboundRecordID", model.InboundRecordID);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0) return Ok("Update success");
                else return BadRequest("Update failed");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpDelete("Delete/{id}")]
        public IActionResult DeleteInboundRecord(int id)
        {
            if (id <= 0) return BadRequest("Invalid ID.");

            try
            {
                using var conn = new MySqlConnection(GetConnectionString());
                conn.Open();

                string sql = "DELETE FROM inboundrecord WHERE InboundRecordID = @InboundRecordID";

                using var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@InboundRecordID", id);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0) return Ok("Delete success");
                else return BadRequest("Delete failed");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }



    public class InboundRecordModel
    {
        public int InboundRecordID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public DateTime InboundDate { get; set; }
        public int SupplierID { get; set; }
    }
}