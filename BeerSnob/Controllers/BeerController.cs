using BeerSnob.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace BeerSnob.Controllers
{
    public class BeerController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            using (var foodContext = new BeerContext())
            {
                var beerListViewModel = new BeerListViewModel();
                beerListViewModel.Beers = foodContext.Beers.Select(f => new BeerViewModel
                {
                    BeerId = f.BeerId,
                    BeerName = f.BeerName,
                    WhereTried = f.WhereTried,
                    Country = f.Country,
                    PercentABV = f.PercentABV,
                    Rating = f.Rating,
                    Description = f.Description
                }).ToList();
                return View(beerListViewModel);
            }
        }


        public ActionResult Details(int? id)
        {
            using (var beerContext = new BeerContext())
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }

                var beerDetail = beerContext.Beers.SingleOrDefault(b => b.BeerId == id);

                var beerViewModel = new BeerViewModel {
                    BeerId = beerDetail.BeerId,
                    BeerName = beerDetail.BeerName,
                    WhereTried = beerDetail.WhereTried,
                    Country = beerDetail.Country,
                    PercentABV = beerDetail.PercentABV,
                    Rating = beerDetail.Rating,
                    Description = beerDetail.Description
                };

                return View(beerViewModel);
            }
        }

        [HttpGet]
        public ActionResult Create()
        {
            BeerViewModel beerViewModel = new BeerViewModel();
            return View("Create", beerViewModel);
        }

        // POST: Beer/Create
        [HttpPost]
        public ActionResult Create(Beer beer)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Beer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Beer/Edit/5
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

        // GET: Beer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Beer/Delete/5
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
