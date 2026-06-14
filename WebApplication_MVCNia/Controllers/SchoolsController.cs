using Microsoft.AspNetCore.Mvc;
using WebApplication_MVCNia.Contracts;
using WebApplication_MVCNia.Models.Entities;

namespace WebApplication_MVCNia.Controllers;

public class SchoolsController : Controller
{
    private readonly ISchoolsServices schoolsServices;

    public SchoolsController(ISchoolsServices schoolsServices)
    {
        this.schoolsServices = schoolsServices;
    }

    public async Task<IActionResult> Index()
    {
        IEnumerable<School> schools = await schoolsServices.ReadAllAsync();

        return View(schools);
    }

    public async Task<IActionResult> View(int id)
    {
        if (!ModelState.IsValid)
        {
            return NotFound();
        }

        School? school = await schoolsServices.ReadByIdAsync(id);

        return school is not null ? View(school) : NotFound();
    }
}
