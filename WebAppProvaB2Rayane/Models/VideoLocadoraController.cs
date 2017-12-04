using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace WebAppProvaB2Rayane.Models
{
    public class VideoLocadoraController : Controller
    {
        private VideoContext db = new VideoContext();

        // GET: VideoLocadora
        public ActionResult Index()
        {
            return View(db.VideoLocadoras.ToList());
        }

        // GET: VideoLocadora/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VideoLocadora videoLocadora = db.VideoLocadoras.Find(id);
            if (videoLocadora == null)
            {
                return HttpNotFound();
            }
            return View(videoLocadora);
        }

        // GET: VideoLocadora/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VideoLocadora/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Titulo,Descricao,Categoria")] VideoLocadora videoLocadora)
        {
            if (ModelState.IsValid)
            {
                db.VideoLocadoras.Add(videoLocadora);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(videoLocadora);
        }

        // GET: VideoLocadora/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VideoLocadora videoLocadora = db.VideoLocadoras.Find(id);
            if (videoLocadora == null)
            {
                return HttpNotFound();
            }
            return View(videoLocadora);
        }

        // POST: VideoLocadora/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Titulo,Descricao,Categoria")] VideoLocadora videoLocadora)
        {
            if (ModelState.IsValid)
            {
                db.Entry(videoLocadora).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(videoLocadora);
        }

        // GET: VideoLocadora/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VideoLocadora videoLocadora = db.VideoLocadoras.Find(id);
            if (videoLocadora == null)
            {
                return HttpNotFound();
            }
            return View(videoLocadora);
        }

        // POST: VideoLocadora/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VideoLocadora videoLocadora = db.VideoLocadoras.Find(id);
            db.VideoLocadoras.Remove(videoLocadora);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
