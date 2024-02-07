using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ControleAcesso.Models;

namespace ControleAcesso.Controllers
{
    public class AcessoController : Controller
    {
        private DEVMEDIAEntities db = new DEVMEDIAEntities();

        // GET: Acesso
        public ActionResult Index()
        {
            return View(db.ACESSOes.ToList());
        }

        // GET: Acesso/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ACESSO aCESSO = db.ACESSOes.Find(id);
            if (aCESSO == null)
            {
                return HttpNotFound();
            }
            return View(aCESSO);
        }

        // GET: Acesso/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Acesso/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_LOGIN,EMAIL,SENHA,ATIVO,PERFIL,NOME,SOBRENOME")] ACESSO aCESSO)
        {
            if (ModelState.IsValid)
            {
                db.ACESSOes.Add(aCESSO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aCESSO);
        }

        // GET: Acesso/Edit/5
        [Authorize(Roles = "Administrador")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ACESSO aCESSO = db.ACESSOes.Find(id);
            if (aCESSO == null)
            {
                return HttpNotFound();
            }
            return View(aCESSO);
        }

        // POST: Acesso/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_LOGIN,EMAIL,SENHA,ATIVO,PERFIL,NOME,SOBRENOME")] ACESSO aCESSO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aCESSO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aCESSO);
        }

        // GET: Acesso/Delete/5
        [Authorize(Roles = "Administrador")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ACESSO aCESSO = db.ACESSOes.Find(id);
            if (aCESSO == null)
            {
                return HttpNotFound();
            }
            return View(aCESSO);
        }

        // POST: Acesso/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ACESSO aCESSO = db.ACESSOes.Find(id);
            db.ACESSOes.Remove(aCESSO);
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
