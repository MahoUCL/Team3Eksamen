using HundeRally.WebUI.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace HundeRally.WebUI.Domain.Controllers
{
    public class ImagesController : Controller
    {
        private readonly ImageService _imageService;

        public ImagesController(ImageService imageService)
        {
            _imageService = imageService;
        }

        public IActionResult Index()
        {
            var imageNames = _imageService.GetImageNames();
            return View(imageNames);
        }
    }

}
