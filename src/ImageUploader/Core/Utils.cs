using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ImageUploader.Core
{

    public enum AzureTableOperationEnum
    {
        Insert,
        Upsert,
        Delete,
        Replace,
        Merge
    }

    public partial class Utils
    {
        public static void LoadStream(Stream ms, string text)
        {
            StreamWriter writer = new StreamWriter(ms);
            writer.Write(text);
            writer.Flush();
            ms.Position = 0;
        }

        public static T FromJson<T>(string json)
        {
            if (string.IsNullOrEmpty(json))
                return default(T);

            return JsonConvert.DeserializeObject<T>(json);
        }

        

    }
}
