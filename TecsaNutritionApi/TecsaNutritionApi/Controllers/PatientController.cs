using Microsoft.AspNetCore.Mvc;
using TecsaNutrition.Application.Repository;
using TecsaNutrition.Application.Services;
using TecsaNutrition.Models;

namespace TecsaNutritionApi.Controllers;

[ApiController]
[Route("[controller]")]
public class PatientController : ControllerBase
{
    private ILogger<PatientController> logger;
    private IPatientService service;

    public PatientController(
        ILogger<PatientController> logger,
        IPatientService service)
    {
        this.logger = logger;
        this.service = service;
    }

    // TODO: Create Resource
    [HttpGet(nameof(GetPatientBy))]
    public async Task<ActionResult<Patient>> GetPatientBy(int id)
    {
        try
        {
            var patient = await service.GetPatientById(id);
            return Ok(patient);
        }
        catch (Exception ex) 
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost(nameof(CreatePatient))]
    public async Task<ActionResult<Patient>> CreatePatient([FromBody]Patient patient)
    {
        var operationResult = await service.CreatePatient(patient);
        if (!operationResult.IsSuccess)
        {
            return BadRequest(operationResult.Message);
        }
        return Ok(patient);
    }
}
