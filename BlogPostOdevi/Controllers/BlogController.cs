using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BlogPostOdevi.Controllers
{
    public class BlogController : Controller
    {
        private readonly IWebHostEnvironment webHostEnvironment;

        public BlogController(IWebHostEnvironment webHostEnvironment)
        {
            this.webHostEnvironment = webHostEnvironment;
        }

        BlogManager blogManager = new BlogManager(new EfBlogRepository());


        public IActionResult Index()
        {
            //List<Blog> list = blogManager.ListAll();
            //return View(list);
            return View();
        }

        public IActionResult Create()
        {

            return View();
        }

        //[HttpPost]
        //public IActionResult Create(Blog blog)
        //{
        //    blogManager.Create(blog);
        //    return RedirectToAction("Index");   
        //}

        [HttpPost]
        public IActionResult Create(Blog blog, IFormFile file)
        {
            blog.BlogImage = "";
            if (file != null)
            {
            //resim upload işlemi
            string wwwrootPath = webHostEnvironment.WebRootPath;
            string fileName = Path.GetFileNameWithoutExtension(file.FileName);
            string extension = Path.GetExtension(file.FileName);

            string yeniDosyaAdi = fileName + DateTime.Now.ToString("yymmss") + extension;

            string path = Path.Combine(wwwrootPath + "/images/blog/", yeniDosyaAdi);

            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(fileStream);
            }

            blog.BlogImage = yeniDosyaAdi;
            blogManager.Create(blog);
            }
          

          

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            Blog blog = blogManager.Get(id);
            return View(blog);
        }

        [HttpPost]
        public IActionResult Edit(Blog blog, IFormFile? file)
        {
            if (file != null)
            {
                //resim upload işlemi
                string wwwrootPath = webHostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(file.FileName);
                string extension = Path.GetExtension(file.FileName);

                string yeniDosyaAdi = fileName + DateTime.Now.ToString("yymmss") + extension;

                string path = Path.Combine(wwwrootPath + "/images/blog/", yeniDosyaAdi);

                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }

                blog.BlogImage = yeniDosyaAdi;
                blogManager.Update(blog);
            }
            return RedirectToAction(nameof(Index));
        }


        public IActionResult Delete(int id)
        {
            Blog blog = blogManager.Get(id);
            return View(blog);
        }

        [HttpPost]
        public IActionResult Delete(Blog blog)
        {
            blogManager.Delete(blog);
            return RedirectToAction(nameof(Index));
        }

    }
}
