using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Niagara_Hospice.Models;
using System.IO;
using System.Data.SqlClient;


namespace Niagara_Hospice.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contacts()
        {
            ViewBag.Message = "Your contacts page.";

            return View();
        }

        public ActionResult Announcements()
        {
            ViewBag.Message = "Announcements page.";

            return View();
        }

        public ActionResult Meetings()
        {
            ViewBag.Message = "Meetings page.";

            return View();
        }
        // GET: Home
        public ActionResult Resources()
        {
            var fileList = from f in db.FileStores
                           select new FileStoreViewModel
                           {
                               ID = f.ID,
                               FileName = f.FileName,
                               MimeType = f.MimeType,
                               FileDescription = f.FileDescription
                           };
                return View(fileList.ToList());
        }

        // POST: Home/Delete/5
        [HttpPost, ActionName("Resources")]
        public ActionResult ResourcesUpload(string fileDescription)
        {
            string mimeType = Request.Files[0].ContentType;
            string fileName = Path.GetFileName(Request.Files[0].FileName);
            int fileLength = Request.Files[0].ContentLength;
            if (!(fileName == "" || fileLength == 0))
            {
                Stream fileStream = Request.Files[0].InputStream;
                byte[] fileData = new byte[fileLength];
                fileStream.Read(fileData, 0, fileLength);

                FileStore newFile = new FileStore
                {
                    FileContent = fileData,
                    MimeType = mimeType,
                    FileName = fileName,
                    FileDescription = fileDescription
                };

                db.FileStores.Add(newFile);
                db.SaveChanges();
            }

            return RedirectToAction("Resources");

        }
        public FileContentResult Download(int id)
        {
            var theFile = db.FileStores.Where(f => f.ID == id).SingleOrDefault();
            return File(theFile.FileContent, theFile.MimeType, theFile.FileName);
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FileStoreViewModel filetoDelete = (from f in db.FileStores
                                               where f.ID == id
                                               select new FileStoreViewModel
                                               {
                                                   ID = f.ID,
                                                   FileName = f.FileName,
                                                   MimeType = f.MimeType,
                                                   FileDescription = f.FileDescription
                                               }).SingleOrDefault();
            if (filetoDelete == null)
            {
                return HttpNotFound();
            }
            return View(filetoDelete);
        }

        // POST: Home/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FileStore fileStore = db.FileStores.Find(id);
            db.FileStores.Remove(fileStore);
            db.SaveChanges();
            return RedirectToAction("Resources");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }


        public ActionResult Schedules()
        {
            ViewBag.Message = "Meetings page.";

            return View();
        }
    }
}