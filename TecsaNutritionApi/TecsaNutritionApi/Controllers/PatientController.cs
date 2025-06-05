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
    public ActionResult<Patient> GetPatientBy(int id)
    {
        try
        {
            var patient = service.GetPatientById(id);
            return Ok(patient);
        }
        catch (Exception ex) 
        {
            return BadRequest(ex.Message);
        }
    }
}
