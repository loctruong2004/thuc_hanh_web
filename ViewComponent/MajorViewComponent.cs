using Microsoft.AspNetCore.Mvc;
using Thuc_Hanh_Web.Data;
using Thuc_Hanh_Web.Models;

namespace Thuc_Hanh_Web.ViewComponents
{
    public class MajorViewComponent:ViewComponent

    {
        SchoolContext db;
        List<Major> majors;
        public MajorViewComponent(SchoolContext _context) {
            db = _context;
            majors = db.Majors.ToList();
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("RenderMajor", majors);
        }
    }
}
