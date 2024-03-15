using Microsoft.AspNetCore.Mvc;

namespace HMTF.Controllers
{
    public class KaryawanController : Controller
    {
        //    private readonly HTMFDbContext dbContext;

        //    public KaryawanController(HTMFDbContext dbContext)
        //    {
        //        this.dbContext = dbContext;
        //    }

        //    [Authorize]
        //    [HttpGet]
        //    public IActionResult Add()
        //    {
        //        return View();
        //    }

        //    [HttpPost]
        //    public async Task<IActionResult> Add(AddUserRequest addUserRequest)
        //    {
        //        var user = new User
        //        {
        //            Name = addUserRequest.Name,
        //            Departement = addUserRequest.Departement,
        //            CreatedBy = addUserRequest.CreatedBy,
        //            CreatedAt = DateTime.Now,
        //        };

        //        await dbContext.Users.AddAsync(user);
        //        await dbContext.SaveChangesAsync();

        //        return RedirectToAction("List", "Karyawan");
        //    }

        //    [HttpGet]
        //    public async Task<IActionResult> List()
        //    {
        //        var user = await dbContext.Users.ToListAsync();

        //        return View(user);
        //    }

        //    [HttpGet]
        //    public async Task<IActionResult> Edit(Guid id)
        //    {
        //        var user = await dbContext.Users.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);

        //        if (user == null)
        //        {
        //            return NotFound();
        //        }

        //        return View(user);
        //    }

        //    [HttpPost]
        //    public async Task<IActionResult> Edit(User editUserRequest)
        //    {
        //        var user = await dbContext.Users.FindAsync(editUserRequest.Id);

        //        if (user != null)
        //        {
        //            user.Name = editUserRequest.Name;
        //            user.Departement = editUserRequest.Departement;
        //            user.CreatedBy = editUserRequest.CreatedBy;
        //            user.CreatedAt = editUserRequest.CreatedAt;

        //            await dbContext.SaveChangesAsync();
        //        }

        //        return RedirectToAction("List", "Karyawan");
        //    }

        //    [HttpPost]
        //    public async Task<IActionResult> Delete(User userDelete)
        //    {
        //        var user = await dbContext.Users.AsNoTracking().FirstOrDefaultAsync(x => x.Id == userDelete.Id);

        //        if (user != null)
        //        {
        //            dbContext.Users.Remove(user);
        //            await dbContext.SaveChangesAsync();
        //        }
        //        return RedirectToAction("List", "Karyawan");
        //    }


        public IActionResult List()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
    }
}
