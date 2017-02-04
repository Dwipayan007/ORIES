using Ores.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace Ores.Controllers
{
    public class uploadProjectController : ApiController
    {
        // GET: api/uploadProject
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/uploadProject/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/uploadProject
        public async Task<HttpResponseMessage> Post()
        {

            // const string StoragePath = "~/UploadedImage";
            Upload_Project upload = new Upload_Project();
            bool res = false;

            List<List<string>> imgData = new List<List<string>>();
            List<List<string>> formData = new List<List<string>>();
            List<string> _lstData = null;
            List<Dictionary<string, string>> di = new List<Dictionary<string, string>>();
            Dictionary<string, List<List<string>>> Imgs = new Dictionary<string, List<List<string>>>();
            Dictionary<string, string> myData = new Dictionary<string, string>();
            string StoragePath = HttpContext.Current.Server.MapPath("~/UploadedImage/");
            //string sp=HttpContext.Current.Server.MapPath(@"D:\Inetpub\vhosts\liveodia.co.in\devenv.liveodia.co.in\UploadedImage\");
            if (Request.Content.IsMimeMultipartContent())
            {
                try
                {
                    string fname = "";
                    var streamProvider = new MultipartFormDataStreamProvider(StoragePath);
                    await Request.Content.ReadAsMultipartAsync(streamProvider);
                    foreach (MultipartFileData fileData in streamProvider.FileData)
                    {
                        _lstData = new List<string>();
                        if (string.IsNullOrEmpty(fileData.Headers.ContentDisposition.FileName))
                        {
                            return Request.CreateResponse(HttpStatusCode.NotAcceptable, "This request is not properly formatted");
                        }
                        string fileName = fileData.Headers.ContentDisposition.FileName;

                        if (fileName.StartsWith("\"") && fileName.EndsWith("\""))
                        {
                            fileName = fileName.Trim('"');
                            fname = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + "_" + fileName;
                            _lstData.Add(fname);
                        }
                        if (fileName.Contains(@"/") || fileName.Contains(@"\"))
                        {
                            fname = Path.GetFileName(fileName);
                        }
                        string fpath = Path.Combine(StoragePath, fname);
                        File.Copy(fileData.LocalFileName, Path.Combine(StoragePath, fname));
                        imgData.Add(_lstData);
                        //compressFile(fpath);

                        //                        File.Copy(fileData.LocalFileName, Path.Combine(StoragePath, fname));
                        //File.Copy(fileData.LocalFileName, Path.Combine(sp, fname));
                        //                      compressFile(string fname);
                    }
                    foreach (var key in streamProvider.FormData.AllKeys)
                    {
                        foreach (var val in streamProvider.FormData.GetValues(key))
                        {
                            _lstData= new List<string>();
                            _lstData.Add(val);

                            // myData.Add(key, val);
                        }
                        formData.Add(_lstData);
                    }
                   

                    Imgs.Add("Imgs", imgData);
                    Imgs.Add("FormData", formData);
                    //di.Add(myData);
                    //myData.Add("img", upload);
                    //dbutility.SaveData(myData);
                }
                catch (Exception e)
                {
                    Request.CreateResponse(HttpStatusCode.NotAcceptable, "This request is not properly formatted");
                }

                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable, "This request is not properly formatted");
            }
        }

        // PUT: api/uploadProject/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/uploadProject/5
        public void Delete(int id)
        {
        }
    }
}
