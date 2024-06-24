using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAPI.Models;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<SinhVien> GetSV()
        {
            using (var context = new ApiContext())
            {
                //Get all 
                //return context.SinhViens.ToList();

                //Get sv by sccd
                return context.SinhViens.Where(auth => auth.SoCccd == "1312313").ToList();

                

                

            }
        }
        [HttpPost]
        public IEnumerable<SinhVien> AddSV()
        {
            using (var context = new ApiContext())
            {
                SinhVien sv = new SinhVien
                {
                    SoCccd = "197393925",
                    HoTen = "Hien",
                    DiaChi = "QT",
                    Email = "thuyhien15082002@gmail.com",
                    SoDt = "0147852369"
                };
                context.SinhViens.Add(sv);
                context.SaveChanges();
                return context.SinhViens;
            }
        }

    }
}
