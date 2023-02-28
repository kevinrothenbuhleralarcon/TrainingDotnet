using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rest_API.Data;

namespace Rest_API.Controllers;

[ApiController]
[Route("/api/[controller]")] // The controller tells that we will use the controller name as the route (in this case employees)
public class EmployeesController : Controller
{
    private readonly RestApiDbContext _restApiDbContext;

    public EmployeesController(RestApiDbContext restApiDbContext)
    {
        _restApiDbContext = restApiDbContext;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAllEmployees()
    {
        var employees = await _restApiDbContext.Employees.ToListAsync();
        return Ok(employees);
    }
}