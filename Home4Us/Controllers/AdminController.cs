using Home4Us.Models;
using Home4Us_Models_BL.BSL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Home4Us.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        //    var model = new OrdersDetails(new AdminService().GetAllOrders());
        //    return View(model);
        //}

        // GET: Admin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        [HttpPost]
        public ActionResult Create(PropertyView model)
        {
                if(ModelState.IsValid)
                {
                    int dId = AdminService.AddDetails(model.Details.Price, model.Details.SpaceM2,
                        model.Details.MoreDetails, model.Details.RoomsId, model.Property.ID);
                    int aId = AdminService.AddAddress(model.Address.City, model.Address.Street,
                       model.Address.Block, model.Address.Apartment);
                    AdminService.AddProperty(model.Property.Name, aId, dId);
                }
            return View("Index");
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
