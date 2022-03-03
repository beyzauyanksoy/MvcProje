using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class StatisticsController : Controller
    {
        // GET: Statistics

        Context context = new Context();

        public ActionResult Index()
        {
            //Toplam Kategori Sayısı
            var result1 = context.Categories.Count().ToString();
            ViewBag.result1 = result1;
            //Yazılım Kategorisine Ait Başlık Sayısı
            ViewBag.result2 = context.Headings.Count(c => c.CategoryID == 2);


            var result3 = (from c in context.Writers select c.WriterName.ToLower().IndexOf("a")).Count().ToString();
            ViewBag.result3 = result3;

            var result4 = context.Categories.Where(x => x.CategoryID == context.Headings.GroupBy(c => c.CategoryID).OrderByDescending(c => c.Count()).Select(c => c.Key).FirstOrDefault()).Select(x => x.CategoryName).FirstOrDefault();
            ViewBag.result4 = result4;
            //toplam yazar sayısı
            var result5 = context.Writers.Count().ToString();
            ViewBag.result5 = result5;
            //en fazla yazı yazan yazar
            //Aktif Başlık Sayısı
            //en fazla yazı yazan yazar
            var result6 = context.Writers.Where(x => x.WriterID == context.Contents.GroupBy(c => c.WriterID).OrderByDescending(c => c.Count()).Select(c => c.Key).FirstOrDefault()).Select(x => x.WriterName).FirstOrDefault();
            ViewBag.result6 = result6;

            return View();
        }
    }
}