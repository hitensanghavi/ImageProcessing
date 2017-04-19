using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ImageUploader.Core;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ImageUploader.Controllers
{
    /// <summary>
    /// Use this Controller to handle the request for Image upload
    /// 
    /// 
    /// </summary>
    public class ImageUploadController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {

            return View();
        }

        /// <summary>
        /// Called when Image upload is requested.
        /// </summary>
        /// <param name="file"> Image file</param>
        /// <returns></returns>
        [HttpPost, Route("api/[Controller]")]
        public IActionResult PostImage([FromBody] Object file)
        {
            try
            {
                // Validate()
                // call  ConvertToThumbnail, Size is configurable outside of code, and passed to this method.
                // call  ConvertToMediumSize, Size is configurable outside of code, and passed to this method.
                // call ConvertToLargeSize, Size is configurable outside of code, and passed to this method.
                // store files/blobs
                // store to tableEntity 



            }
            catch (FileTooLargeException fx)
            {
                
            }
            throw new NotImplementedException();
        }
    }
}

