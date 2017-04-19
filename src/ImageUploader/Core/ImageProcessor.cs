using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace ImageUploader.Core
{
    public class ImageProcessor
    {
        /// <summary>
        /// Validates the file information.
        /// Size of the file - Maximum size of the file is configuable, default set to 1MB.
        /// Type of file- images  various extensions - PNG, JPEG, TIFF, BMP and GIF.
        /// Image file name characters - can only have char, space, -, ., @, _, (, )
        /// File name uniqueness - Whether a file with same name and user exists - If file with same name and user exists respond with the filename with number suffix.
        /// </summary>
        /// <param name="image">File to be validated</param>
        /// <returns>Multiple Exceptions for errors </returns>
        public void Validate(Object image) {
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// Converts original File to Thumbnail size and .PNG format
        /// </summary>
        /// <param name="originalFile">Original File to convert</param>
        /// <param name="height">height of Thumbnail</param>
        /// <param name="width">width of Thumbnail</param>
        /// <returns>The converted file</returns>
        public Image ConvertToThumbnail(Object originalFile, int height, int width)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Converts original File to Medium size and .PNG format
        /// </summary>
        /// <param name="originalFile">Original File to convert</param>
        /// <param name="height">height of Medium size image</param>
        /// <param name="width">width of Medium size image</param>
        /// <returns>The converted file</returns>
        public Image ConvertToMediumSize(Object originalFile, int height, int width)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Convert original image file to Large Size and .PNG format
        /// </summary>
        /// <param name="originalFile">Original File to convert</param>
        /// <param name="height">height of Medium size image</param>
        /// <param name="width">width of Medium size image</param>
        /// <returns>The converted file</returns>
        public Image ConvertToLargeSize(Object originalFile, int height, int width)
        {
            throw new NotImplementedException();

        }

    }

    public class FileTooLargeException: Exception
    {
        public FileTooLargeException(int fileSize): base($"File Too Large - {fileSize}")
        {
            
        }
    }
}
