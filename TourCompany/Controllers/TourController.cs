using Microsoft.AspNetCore.Mvc;
using Models.Models;
using Models.ViewModel;
using TourCompany.Servises;
using System.Web;

namespace TourCompany.Controllers
{
    public class TourController : Controller
    {
        private readonly ITourService _tourService;

        public TourController(ITourService tourService)
        {
            _tourService = tourService;
        }

        [HttpGet("/Tours")]
        public IActionResult Index()
        {
            var tours = _tourService.GetAllToursAsync().Result;
            return View(tours);
        }

        [HttpGet("/Tour/{id}")]
        public IActionResult TourDetails([FromRoute] int id)
        {
            var tour = _tourService.GetTourByIdAsync(id).Result;
            return View(tour);
        }

        [HttpGet("/Tour")]
        public IActionResult Create()
        {
            return View(new Tour());
        }
        [HttpGet("/Tour/Edit/{id}")]
        public async Task<IActionResult> Edit([FromRoute] int id)
        {
            var tour = _tourService.GetTourByIdAsync(id).Result;
            return View(tour);
        }

        [HttpPost("/Tour")]
        public async Task<IActionResult> Create(TourAddViewModel model) 
        {
            
            
            await _tourService.AddTourAsync(model);
            return RedirectToAction("Index");
        }

        [HttpPost("/Tour/Edit/{id}")]
        public async Task<IActionResult> Edit(Tour model)
        {
            await _tourService.UpdateTourAsync(model);
            return RedirectToAction("Index");
        }
    }
}
