using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Data;

namespace api.Controllers;

[ApiController]
[Route("[controller]")]
public class SimpleGetAPIController : ControllerBase
{
    private readonly IConfiguration _configuration;

    public SimpleGetAPIController(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    [HttpGet("GetCustomerData")]
    public IActionResult GetCustomerData()
    {
        try
        {
            var connectionString = _configuration.GetConnectionString("DefaultConnection");
            var db = new dboGetCompanyData(connectionString);
            DataTable dt = db.GetAllCustomerData();
            string json = JsonConvert.SerializeObject(dt);
            return Ok(json);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"API åeÕ`: {ex.Message}");
        }
    }

    [HttpPost("UpdateCustomerData")]
    public IActionResult UpdateCustomerData([FromBody] JsonDataTable json)
    {
        try
        {
            var dt = JsonConvert.DeserializeObject<DataTable>(json.dtModified);
            var connectionString = _configuration.GetConnectionString("DefaultConnection");
            var db = new dboGetCompanyData(connectionString);
            int rows = db.UpdateCustomerData(dt);
            return Ok(rows);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"API ¸üÐÂåeÕ`: {ex.Message}");
        }
    }
}
}

