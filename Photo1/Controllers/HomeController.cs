using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Photo1.Models;

namespace Photo1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPhotoRepository _photoRepository;

        public HomeController(IPhotoRepository photoRepository)
        {
            _photoRepository = photoRepository;
        }

        public IActionResult Index()
        {
            var photos = _photoRepository.GetAllPhotos().OrderBy(p => p.Title);
            return View(photos);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Gallery()
        {
            var photos = _photoRepository.GetAllPhotos().OrderBy(p => p.Title);
            return View(photos);
        }

        public IActionResult ViewDetails(int Id)
        {
            var photo = _photoRepository.GetPhotoById(Id);
            if (photo == null)
                return NotFound();
            return View(photo);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
