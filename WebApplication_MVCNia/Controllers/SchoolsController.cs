using Microsoft.AspNetCore.Mvc;
using WebApplication_MVCNia.Models.Entities;

namespace WebApplication_MVCNia.Controllers;

public class SchoolsController : Controller
{
    private readonly List<School> schools = new List<School>()
    {
         new School { Id = 1,  Name = "Greenwood Academy",        Director = "Margaret Collins",  FoundationDate = new DateOnly(1952, 9,  1),  StudentsQuantity = 842  },
         new School { Id = 2,  Name = "Riverside High School",     Director = "James Patel",       FoundationDate = new DateOnly(1967, 8,  15), StudentsQuantity = 1204 },
         new School { Id = 3,  Name = "Sunnydale Elementary",      Director = "Carla Nguyen",      FoundationDate = new DateOnly(1983, 2,  20), StudentsQuantity = 517  },
         new School { Id = 4,  Name = "Oakwood International",     Director = "Thomas Richter",    FoundationDate = new DateOnly(2001, 1,  10), StudentsQuantity = 730  },
         new School { Id = 5,  Name = "Maplecrest Middle School",  Director = "Sophia Andersen",   FoundationDate = new DateOnly(1975, 4,  3),  StudentsQuantity = 988  },
         new School { Id = 6,  Name = "Lincoln Primary School",    Director = "David Okafor",      FoundationDate = new DateOnly(1948, 11, 22), StudentsQuantity = 412  },
         new School { Id = 7,  Name = "Horizon STEM Academy",      Director = "Elena Voronova",    FoundationDate = new DateOnly(2010, 8,  28), StudentsQuantity = 623  },
         new School { Id = 8,  Name = "St. Catherine's College",   Director = "Patrick Brennan",   FoundationDate = new DateOnly(1901, 3,  15), StudentsQuantity = 1540 },
         new School { Id = 9,  Name = "Valley View School",        Director = "Linda Ferreira",    FoundationDate = new DateOnly(1990, 7,  7),  StudentsQuantity = 774  },
         new School { Id = 10, Name = "Crestwood Preparatory",     Director = "Nathan Burke",      FoundationDate = new DateOnly(1932, 5,  18), StudentsQuantity = 896  },
         new School { Id = 11, Name = "Westside Arts Academy",     Director = "Amara Diallo",      FoundationDate = new DateOnly(2005, 9,  5),  StudentsQuantity = 461  },
         new School { Id = 12, Name = "Northgate Grammar School",  Director = "Oliver Hartmann",   FoundationDate = new DateOnly(1889, 10, 30), StudentsQuantity = 1321 },
         new School { Id = 13, Name = "Eastbrook Learning Center", Director = "Yuki Tanaka",       FoundationDate = new DateOnly(2015, 1,  19), StudentsQuantity = 389  },
         new School { Id = 14, Name = "Silverpine High",           Director = "Rosa Mendes",       FoundationDate = new DateOnly(1961, 6,  12), StudentsQuantity = 1073 },
         new School { Id = 15, Name = "Fairfield Academy",         Director = "George Whitfield",  FoundationDate = new DateOnly(1978, 3,  25), StudentsQuantity = 658  },
         new School { Id = 16, Name = "Redwood Montessori",        Director = "Priya Iyer",        FoundationDate = new DateOnly(2008, 4,  14), StudentsQuantity = 295  },
         new School { Id = 17, Name = "Blue Hills Secondary",      Director = "Frank O'Brien",     FoundationDate = new DateOnly(1955, 8,  9),  StudentsQuantity = 910  },
    };

    public IActionResult Index()
    {
        return View(schools);
    }

    public IActionResult View(int id)
    {
        if (!ModelState.IsValid)
        {
            return NotFound();
        }

        School? school = schools.FirstOrDefault(x => x.Id == id);

        return school is not null ? View(school) : NotFound();
    }
}
