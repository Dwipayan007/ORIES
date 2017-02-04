using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ores.Models
{
    public class Upload_Project
    {
        public string Owner_Id { get; set; }
        public string Project_Name { get; set; }
        public string Project_Location { get; set; }
        public string Unit { get; set; }
        public List<string> Project_Images { get; set; }
    }
}