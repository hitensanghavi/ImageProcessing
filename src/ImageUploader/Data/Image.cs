using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ImageUploader.Data
{
    /// <summary>
    /// This is the Image data entity. Used to store data in DocumentDB. Stores information about the file and various URLs.
    /// 
    /// Partition Key is userId
    /// F
    /// </summary>
    public class ImageEntity : TableEntity
    {

        public ImageEntity(string userId, string fileName)
        {
            this.PartitionKey = userId;
            this.RowKey = fileName;
            this.UserID = userId;
            this.FileName = fileName;
        }

        
        [Required]
        public int ID { get; set; }

        //GUID can be added here
        [Required]
        public string UserID { get; set; }

        //Name of the file 
        [Required]
        public string FileName { get; set; }

        //Address for the original file
        [Required]
        public string OriginalFileURL { get; set; }

        // Address for thumbnail image.
        public string ThumbnailURL { get; set; }

        // Address for Medium size image. 
        public string MediumFileURL { get; set; }

        // Address for Large size image. 
        public string LargeFileURL { get; set; }

        // Address for Medium size image. 
        public DateTime UploadDate { get; set; }

        // Address for Medium size image. 
        public DateTime UpdateDate { get; set; }

        
    }
}
