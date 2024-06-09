using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebApp.UI.Data;
using WebApp.UI.Data.Entities;

namespace WebApp.UI.Controllers
{
    public class StudentController : Controller
    {
        // GET: Product
        [HttpGet]
        //Product/Index
        public ActionResult Index()
        {
            //Sadece readonly işlerde ,sadece datayı çekip gösterme işlemlerinde mutlaka "AsNoTracking()" eklenmeli
            EducationDbContext dbContext = new EducationDbContext();
            List<Student> students = dbContext.Students.Include("Group").AsNoTracking().ToList();
            return View(students);
        }

        //Student/Detail
        [HttpGet]
        public ActionResult Detail(int id)
        {
            EducationDbContext dbContext = new EducationDbContext();
            Student student = dbContext.Students
                                               .Include("Group")
                                               .AsNoTracking()
                                               .Where(s => s.StudentId == id)
                                               .FirstOrDefault();

            return View(student);
        }

        [HttpGet]
        public ActionResult Add()
        {
            EducationDbContext dbContext = new EducationDbContext();
            ViewBag.Groups = dbContext.Groups.AsNoTracking().ToList();
            return View();
        }


        [HttpPost]
        public ActionResult Add(Student student)
        {
            EducationDbContext dbContext = new EducationDbContext();
            dbContext.Students.Add(student);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        //public class Test
        //{
        //    public List<Student> students { get; set; }
        //    public List<Group> groups { get; set; }
        //}
    }
}
//Bir sayfayı Layout'a bağlarken,ilişkilendirirken  2 yol var 
//1)layout kısmını boş bırakmak ,Layout kısmını boş bırakınca viewstart dosyasında elirtilen layout baz alınır
//2)Layout kısmını yazmak,hangilayout'a bağlı olduğunu belirtmek