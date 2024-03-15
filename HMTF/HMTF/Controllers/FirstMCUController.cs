using HMTF.Data;
using HMTF.Models;
using HMTF.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HMTF.Controllers
{
    public class FirstMCUController : Controller
    {
        private readonly HTMFDbContext _dbContext;

        public FirstMCUController(HTMFDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public IActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Upload(AddFirstMCU addFirstMCU)
        {
            var firstMCU = new FirstMCU
            {
                FilePath = addFirstMCU.FilePath,
                IdTransaction = addFirstMCU.IdTransaction,
                NIK = addFirstMCU.NIK,
                Name = addFirstMCU.Name,
                Department = addFirstMCU.Department,
                CreatedBy = addFirstMCU.CreatedBy,
                CreatedAt = DateTime.Now
            };

            await _dbContext.FirstMcus.AddAsync(firstMCU);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index", "FirstMCU");
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var firstMcus = await _dbContext.FirstMcus.ToListAsync();

            return View(firstMcus);
        }
    }
}
