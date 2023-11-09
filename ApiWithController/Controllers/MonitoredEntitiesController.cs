using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiWithController.Controllers;

[ApiController]
public class MonitoredEntitiesController : ControllerBase {

    private readonly IDbmsService m_DbmsService;
    private readonly IHostService m_HostService;
    
    public MonitoredEntitiesController(IDbmsService dbmsService, IHostService hostService)
    {
        m_DbmsService = dbmsService;
        m_HostService = hostService;
    }

    [HttpGet("/Dbms/{dbmsId}")]
    public IActionResult Get(string dbmsId)
    {
        return Ok(m_DbmsService.GetById(dbmsId).ToDto());
    }

    [HttpPost("/Dbms")]
    [Authorize]
    public IActionResult Post([FromBody]DbmsDto dto)
    {
        m_DbmsService.Add(dto.ToDomain());
        return Ok();
    }

    [HttpGet("/Dbms/Host/{hostId}")]
    public IActionResult GetHost(string hostId)
    {
        return Ok(m_HostService.GetById(hostId).ToDto());
    }
}