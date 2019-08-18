using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Web;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace JobbyGarden.Extino
{
    public class Extension
    {
        public static readonly double MAxfileSize = 1;

        public static  IHostingEnvironment _env;

        public Extension(IHostingEnvironment env)
        {
            _env = env;
        }


        public static bool CheckImg(IFormFile _file,double _filesizMb)
        {

            return Convert.ToDouble(_file.Length / 1024 / 1024) <= _filesizMb
                 &&
                 (_file.ContentType == "image/jpg" ||
                 _file.ContentType == "image/png" ||
                 _file.ContentType == "image/jpeg" ||
                 _file.ContentType == "image/gif"


                 );

        }


        public static string SaveImg(IFormFile _file,string path)
        {
            if (_file != null)
            {
                
                string filesub = DateTime.Now.ToString("yyyy_MM-DD_mm_ss");
                string adds = "";

                string[] p = adds.Split("/");
                ////path = Path.Combine(_env.WebRootPath);
                foreach (var item in p)
                {
                    path = Path.Combine(path, item);
                }
                string filename = filesub + _file.FileName;
                var filePath = Path.Combine(path, filename );
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                     _file.CopyTo(stream);
                }
                return filename;
            }
            return "fieled";
        }

        public static void Deletimg(string _path, string _filename)
        {
            string imagePath = Path.Combine(_path,_filename);

            if (File.Exists(imagePath))
            {
                File.Delete(imagePath);
            }
        }


    }
}
