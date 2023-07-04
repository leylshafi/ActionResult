using Microsoft.AspNetCore.Mvc;

namespace ActionResult.Controllers
{
    //FileResult
    public class FileController : Controller
    {
        [Route("File")]
        public VirtualFileResult Index()
        {
            return File("/sample.pdf","application/pdf");
        }
    }
}
