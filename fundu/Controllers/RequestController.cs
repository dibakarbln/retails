using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using fundu.Models;

namespace fundu.Controllers
{
    public class RequestController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: /Request/
        public ActionResult Index()
        {
            return View(db.PostModels.ToList());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "PostId,LocId,CatId,PostDesc,UID,FollowPostId,Status,budgetFrom,budgetTo,StartDate,EndDate,Comment")] PostModel postmodel)
        {
            //string itemId = Convert.ToInt64(formValue["ItemID"]);
            postmodel.CatId = Convert.ToInt16(Request["ddlLoc"]);

            Session["user"] = "dibakar";

            string user = Session["user"].ToString();

            //postmodel.budgetFrom=
            //postmodel.budgetTo=
            //postmodel.StartDate=
            //postmodel.EndDate=
            //postmodel.Comment=

            if (ModelState.IsValid)
            {
                db.PostModels.Add(postmodel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(postmodel);
        }

        // GET: /Request/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PostModel postmodel = db.PostModels.Find(id);
            if (postmodel == null)
            {
                return HttpNotFound();
            }
            return View(postmodel);
        }

        // GET: /Request/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Request/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="PostId,LocId,CatId,PostDesc,UID,FollowPostId,Status")] PostModel postmodel)
        {
            if (ModelState.IsValid)
            {
                db.PostModels.Add(postmodel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(postmodel);
        }

        // GET: /Request/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PostModel postmodel = db.PostModels.Find(id);
            if (postmodel == null)
            {
                return HttpNotFound();
            }
            return View(postmodel);
        }

        // POST: /Request/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="PostId,LocId,CatId,PostDesc,UID,FollowPostId,Status")] PostModel postmodel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(postmodel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(postmodel);
        }

        // GET: /Request/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PostModel postmodel = db.PostModels.Find(id);
            if (postmodel == null)
            {
                return HttpNotFound();
            }
            return View(postmodel);
        }

        // POST: /Request/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PostModel postmodel = db.PostModels.Find(id);
            db.PostModels.Remove(postmodel);
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
