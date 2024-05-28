namespace HundeRally.WebUI.Domain.Services
{
    public class ImageService
    {
        private readonly IWebHostEnvironment _env;

        public ImageService(IWebHostEnvironment env)
        {
            _env = env;
        }

        public IEnumerable<string> GetImageNames()
        {
            var imagesPath = Path.Combine(_env.WebRootPath, "images");
            return Directory.EnumerateFiles(imagesPath, "*.png")
                            .Select(Path.GetFileName);
        }
    }

}
