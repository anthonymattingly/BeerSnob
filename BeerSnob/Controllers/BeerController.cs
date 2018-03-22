using BeerSnob.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace BeerSnob.Controllers
{
    public class BeerController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            using (var beerContext = new BeerContext())
            {
                var beerListViewModel = new BeerListViewModel();


                beerListViewModel.Beers = beerContext.Beers.Select(f => new BeerViewModel
                {
                    BeerId = f.BeerId,
                    BeerName = f.BeerName,
                    WhereTried = f.WhereTried,
                    WhenTried = f.WhenTried,
                    Country = f.Country,
                    Style = f.BeerStyle,
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
   
                var beerViewModel = new BeerViewModel
                {
                    BeerId = beerDetail.BeerId,
                    BeerName = beerDetail.BeerName,
                    WhereTried = beerDetail.WhereTried,
                    WhenTried = beerDetail.WhenTried,
                    Style = beerDetail.BeerStyle,
                    Country = beerDetail.Country,
                    PercentABV = beerDetail.PercentABV,
                    Rating = beerDetail.Rating,
                    Description = beerDetail.Description
                };

                return View(beerViewModel);
            }
        }



        //public ActionResult Details(int? id)
        //{
        //    using (var beerContext = new BeerContext())
        //    {
        //        if (id == null)
        //        {
        //            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //        }

        //        var beerDetail = beerContext.Beers.SingleOrDefault(b => b.BeerId == id);

        //        var beerViewModel = new BeerViewModel {
        //            BeerId = beerDetail.BeerId,
        //            BeerName = beerDetail.BeerName,
        //            WhereTried = beerDetail.WhereTried,
        //            WhenTried = beerDetail.WhenTried,
        //            Style = beerDetail.Style.StyleOfBeer,
        //            Country = beerDetail.Country,
        //            PercentABV = beerDetail.PercentABV,
        //            Rating = beerDetail.Rating,
        //            Description = beerDetail.Description
        //        };

        //        return View(beerViewModel);
        //    }
        //}

        [HttpGet]
        public ActionResult Create()
        {
            BeerViewModel beerViewModel = new BeerViewModel();

            using (var beerContext = new BeerContext())
            {
                beerViewModel.BeerStyles = beerContext.BeerStyles.Select(b => new BeerStyleViewModel
                {
                    BeerStyleId = b.BeerStyleId,
                    StyleOfBeer = b.StyleOfBeer
                }).ToList();
            }

            return View("Create", beerViewModel);
        }


        [HttpPost]
        public ActionResult Create(Beer beer)
        {
            if (ModelState.IsValid)
            {
                using (var beerContext = new BeerContext())
                {
                    
                    beerContext.Beers.Add(beer);
                    beerContext.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View(beer);
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            using(var beerContext = new BeerContext()) { 

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

                var beerViewModel = beerContext.Beers.Include(b => b.BeerStyle).SingleOrDefault(b => b.BeerId == id);
   
                if (beerViewModel == null)
                {
                    return HttpNotFound();
                }
                return View(beerViewModel);
            }
        }

        
        [HttpPost]
        public ActionResult Edit(BeerViewModel beerViewModel)
        {
            if (ModelState.IsValid)
            {
                using (var beerContext = new BeerContext())
                {

                    var beerToUpdate = beerContext.Beers.Include(b => b.BeerStyle).SingleOrDefault(b => b.BeerId == beerViewModel.BeerId);
                    //if(beerToUpdate != null)
                    //{
                        beerToUpdate.BeerName = beerViewModel.BeerName;
                        beerToUpdate.WhereTried = beerViewModel.WhereTried;
                        beerToUpdate.WhenTried = beerViewModel.WhenTried;
                        beerToUpdate.BeerStyleId = beerViewModel.BeerStyleId;
                        beerToUpdate.Country = beerViewModel.Country;
                        beerToUpdate.PercentABV = beerViewModel.PercentABV;
                        beerToUpdate.Rating = beerViewModel.Rating;
                        beerToUpdate.Description = beerViewModel.Description;
                        beerContext.SaveChanges();
                        return RedirectToAction("Index");
                    //}
                   
                }
            }
            return new HttpNotFoundResult();
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            using (var beerContext = new BeerContext())
            {

                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }

                var beerViewModel = beerContext.Beers.SingleOrDefault(b => b.BeerId == id);

                if (beerViewModel == null)
                {
                    return HttpNotFound();
                }
                return View(beerViewModel);
            }
        }

      
        [HttpPost]
        public ActionResult Delete(int id)
        {
            using (var beerContext = new BeerContext())
            {
                var beerToDelete = beerContext.Beers.SingleOrDefault(b => b.BeerId == id);

                if (beerToDelete != null)
                {
                    beerContext.Beers.Remove(beerToDelete);
                    beerContext.SaveChanges();
                }

                return RedirectToAction("Index");
            }
        }
    }
}
